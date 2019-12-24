using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using Lab5_library;

namespace Laboratorka_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<string> list = new List<string>();
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.Filter = "текстовые файлы|*.txt";
            if (fd.ShowDialog() == DialogResult.OK)
            {
                Stopwatch t = new Stopwatch();
                t.Start();
                string text = File.ReadAllText(fd.FileName);
                char[] separators = new char[] { ' ', '.', ',', '!', '?', '/', '\t', '\n' };
                string[] textArray = text.Split(separators);
                foreach (string strTemp in textArray)
                {
                    string str = strTemp.Trim();
                    if (!list.Contains(str)) list.Add(str);
                }
                t.Stop();
                this.Time_of_loading.Text = t.Elapsed.ToString();
                this.count_of_words.Text = list.Count.ToString();
            }
            else
            {
                MessageBox.Show("Необходимо выбрать файл!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string word = this.Field_for_input.Text.Trim();
            if (!string.IsNullOrWhiteSpace(word) && list.Count > 0)
            {
                string wordUpper = word.ToUpper();
                List<string> tempList = new List<string>();
                Stopwatch t = new Stopwatch();
                t.Start();

                foreach (string str in list)
                {
                    if (str.ToUpper().Contains(wordUpper))
                    {
                        tempList.Add(str);
                    }
                }
                t.Stop();

                if (tempList.Count == 0)
                {
                    this.exp_search_time.Text = "Слово не найдено!";
                }
                else
                {
                    this.exp_search_time.Text = t.Elapsed.ToString();
                }

                this.listBox1.BeginUpdate();
                this.listBox1.Items.Clear();
                foreach (string str in tempList)
                {
                    this.listBox1.Items.Add(str);
                }
                this.listBox1.EndUpdate();
            }
            else
            {
                MessageBox.Show("Введите файл и слово для поиска!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string word = this.Field_for_input.Text.Trim();
            if (!string.IsNullOrWhiteSpace(word) && list.Count > 0)
            {
                int maxDist;
                if (!int.TryParse(this.text_dist.Text.Trim(), out maxDist))
                {
                    MessageBox.Show("Необходимо указать максимальное расстояние");
                    return;
                }

                if (maxDist < 1 || maxDist > 5)
                {
                    MessageBox.Show("Максимальное расстояние должно быть в диапазоне от 1 до 5");
                    return;
                }

                int ThreadCount;
                if (!int.TryParse(this.count_of_stream.Text.Trim(), out ThreadCount))
                {
                    MessageBox.Show("Необходимо указать количество потоков");
                    return;
                }

                Stopwatch timer = new Stopwatch();
                timer.Start();

                //Результирующий список  
                List<ParallelSearchResult> Result = new List<ParallelSearchResult>();

                //Деление списка на фрагменты для параллельного запуска в потоках
                List<MinMax> arrayDivList = SubArrays.DivideSubArrays(0, list.Count, ThreadCount);
                int count = arrayDivList.Count;

                //Количество потоков соответствует количеству фрагментов массива
                Task<List<ParallelSearchResult>>[] tasks = new Task<List<ParallelSearchResult>>[count];

                //Запуск потоков
                for (int i = 0; i < count; i++)
                {
                    //Создание временного списка, чтобы потоки не работали параллельно с одной коллекцией
                    List<string> tempTaskList = list.GetRange(arrayDivList[i].Min, arrayDivList[i].Max - arrayDivList[i].Min);

                    tasks[i] = new Task<List<ParallelSearchResult>>(
                        //Метод, который будет выполняться в потоке
                        ArrayThreadTask,
                        //Параметры потока 
                        new ParallelSearchThreadParam()
                        {
                            tempList = tempTaskList,
                            maxDist = maxDist,
                            ThreadNum = i,
                            wordPattern = word
                        });

                    //Запуск потока
                    tasks[i].Start();
                }
                Task.WaitAll(tasks);

                //Объединение результатов
                for (int i = 0; i < count; i++)
                {
                    Result.AddRange(tasks[i].Result);
                }

                //Обновление списка результатов
                this.listBox1.BeginUpdate();
                this.listBox1.Items.Clear();
                foreach (var x in Result)
                {
                    string temp = x.word + "(расстояние=" + x.dist.ToString() + " поток=" + x.ThreadNum.ToString() + ")";
                    this.listBox1.Items.Add(temp);
                }
                this.listBox1.EndUpdate();

                timer.Stop();

                //Время поиска
                this.Time_of_searching.Text = timer.Elapsed.ToString();

                //Вычисленное количество потоков
                this.my_count_of_steam.Text = count.ToString();
            }
            else
            {
                MessageBox.Show("Необходимо выбрать файл и ввести слово для поиска");
            }
        }

        public static List<ParallelSearchResult> ArrayThreadTask(object paramObj)
        {
            ParallelSearchThreadParam param = (ParallelSearchThreadParam)paramObj;

            string wordUpper = param.wordPattern.Trim().ToUpper();

            //Результаты поиска в одном потоке
            List<ParallelSearchResult> Result = new List<ParallelSearchResult>();

            //Перебор всех слов во временном списке данного потока 
            foreach (string str in param.tempList)
            {
                //Вычисление расстояния Дамерау-Левенштейна
                int dist = Manager.Distance(str.ToUpper(), wordUpper);
                //Если расстояние меньше порогового, то слово добавляется в результат
                if (dist <= param.maxDist)
                {
                    ParallelSearchResult temp = new ParallelSearchResult()
                    {
                        word = str,
                        dist = dist,
                        ThreadNum = param.ThreadNum
                    };
                    Result.Add(temp);
                }
            }
            return Result;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string TempReportFileName = "Report_" + DateTime.Now.ToString("dd_MM_yyyy_hhmmss");

            //Диалог сохранения файла отчета
            SaveFileDialog fd = new SaveFileDialog();
            fd.FileName = TempReportFileName;
            fd.Filter = "Text files|*.txt|HTML Reports|*.html;";

            if (fd.ShowDialog() == DialogResult.OK)
            {
                string ReportFileName = fd.FileName;
                if (Path.GetExtension(fd.FileName) == ".txt")
                {
                    StreamWriter sw = new StreamWriter(fd.FileName);
                    sw.WriteLine("Отчет: " + ReportFileName);
                    sw.WriteLine("Время чтения из файла: " + this.Time_of_loading.Text);
                    sw.WriteLine("Количество уникальных слов в файле: " + this.count_of_words.Text);
                    sw.WriteLine("Слово для поиска: " + this.Field_for_input.Text);
                    sw.WriteLine("Максимальное расстояние для нечеткого поиска: " + this.text_dist.Text);
                    sw.WriteLine("Время четкого поиска: " + this.exp_search_time.Text);
                    sw.WriteLine("Время нечеткого поиска: " + this.Time_of_searching.Text);
                    sw.WriteLine("Результаты поиска: ");
                    foreach (var x in this.listBox1.Items)
                    {
                        sw.WriteLine(x.ToString());
                    }
                    sw.Close();
                }
                else
                {
                    StringBuilder b = new StringBuilder();
                    b.AppendLine("<html>");

                    b.AppendLine("<head>");
                    b.AppendLine("<meta http-equiv='Content-Type' content='text/html; charset=UTF-8'/>");
                    b.AppendLine("<title>" + "Отчет: " + ReportFileName + "</title>");
                    b.AppendLine("</head>");

                    b.AppendLine("<body>");

                    b.AppendLine("<h1>" + "Отчет: " + ReportFileName + "</h1>");
                    b.AppendLine("<table border='1'>");

                    b.AppendLine("<tr>");
                    b.AppendLine("<td>Время чтения из файла</td>");
                    b.AppendLine("<td>" + this.Time_of_loading.Text + "</td>");
                    b.AppendLine("</tr>");

                    b.AppendLine("<tr>");
                    b.AppendLine("<td>Количество уникальных слов в файле</td>");
                    b.AppendLine("<td>" + this.count_of_words.Text + "</td>");
                    b.AppendLine("</tr>");

                    b.AppendLine("<tr>");
                    b.AppendLine("<td>Слово для поиска</td>");
                    b.AppendLine("<td>" + this.Field_for_input.Text + "</td>");
                    b.AppendLine("</tr>");

                    b.AppendLine("<tr>");
                    b.AppendLine("<td>Максимальное расстояние для нечеткого поиска</td>");
                    b.AppendLine("<td>" + this.text_dist.Text + "</td>");
                    b.AppendLine("</tr>");

                    b.AppendLine("<tr>");
                    b.AppendLine("<td>Время четкого поиска</td>");
                    b.AppendLine("<td>" + this.exp_search_time.Text + "</td>");
                    b.AppendLine("</tr>");

                    b.AppendLine("<tr>");
                    b.AppendLine("<td>Время нечеткого поиска</td>");
                    b.AppendLine("<td>" + this.Time_of_searching.Text + "</td>");
                    b.AppendLine("</tr>");

                    b.AppendLine("<tr valign='top'>");
                    b.AppendLine("<td>Результаты поиска</td>");
                    b.AppendLine("<td>");
                    b.AppendLine("<ul>");

                    foreach (var x in this.listBox1.Items)
                    {
                        b.AppendLine("<li>" + x.ToString() + "</li>");
                    }

                    b.AppendLine("</ul>");
                    b.AppendLine("</td>");
                    b.AppendLine("</tr>");

                    b.AppendLine("</table>");

                    b.AppendLine("</body>");
                    b.AppendLine("</html>");

                    //Сохранение файла
                    File.AppendAllText(ReportFileName, b.ToString());
                }
                MessageBox.Show("Отчет успешно сформирован. Файл: " + ReportFileName);
            }
        }
    }

}
