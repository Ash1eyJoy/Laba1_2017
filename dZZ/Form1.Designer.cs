namespace Laboratorka_5
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.Time_of_loading = new System.Windows.Forms.TextBox();
            this.Field_for_input = new System.Windows.Forms.TextBox();
            this.exp_search_time = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.text_dist = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.count_of_words = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.count_of_stream = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Label8 = new System.Windows.Forms.Label();
            this.Time_of_searching = new System.Windows.Forms.TextBox();
            this.my_count_of_steam = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(10, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 34);
            this.button1.TabIndex = 0;
            this.button1.Text = "Выбрать файл";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(10, 118);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(510, 44);
            this.button2.TabIndex = 1;
            this.button2.Text = "Четкий поиск";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(6, 391);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(514, 164);
            this.listBox1.TabIndex = 2;
            // 
            // Time_of_loading
            // 
            this.Time_of_loading.Location = new System.Drawing.Point(419, 15);
            this.Time_of_loading.Name = "Time_of_loading";
            this.Time_of_loading.Size = new System.Drawing.Size(100, 26);
            this.Time_of_loading.TabIndex = 3;
            // 
            // Field_for_input
            // 
            this.Field_for_input.Location = new System.Drawing.Point(184, 86);
            this.Field_for_input.Name = "Field_for_input";
            this.Field_for_input.Size = new System.Drawing.Size(335, 26);
            this.Field_for_input.TabIndex = 4;
            // 
            // exp_search_time
            // 
            this.exp_search_time.Location = new System.Drawing.Point(196, 182);
            this.exp_search_time.Name = "exp_search_time";
            this.exp_search_time.Size = new System.Drawing.Size(324, 26);
            this.exp_search_time.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(181, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Время чтения из файла:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Слово для поиска:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Время четкого поиска:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 269);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(390, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Максимальное расстояние для нечеткого поиска:";
            // 
            // text_dist
            // 
            this.text_dist.Location = new System.Drawing.Point(400, 266);
            this.text_dist.Name = "text_dist";
            this.text_dist.Size = new System.Drawing.Size(123, 26);
            this.text_dist.TabIndex = 10;
            this.text_dist.Text = "3";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(181, 50);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(236, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Количество уникальных слов:";
            // 
            // count_of_words
            // 
            this.count_of_words.Location = new System.Drawing.Point(419, 46);
            this.count_of_words.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.count_of_words.Name = "count_of_words";
            this.count_of_words.Size = new System.Drawing.Size(100, 26);
            this.count_of_words.TabIndex = 12;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(8, 216);
            this.button3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(514, 45);
            this.button3.TabIndex = 13;
            this.button3.Text = "Нечеткий поиск";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // count_of_stream
            // 
            this.count_of_stream.Location = new System.Drawing.Point(400, 297);
            this.count_of_stream.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.count_of_stream.Name = "count_of_stream";
            this.count_of_stream.Size = new System.Drawing.Size(123, 26);
            this.count_of_stream.TabIndex = 14;
            this.count_of_stream.Text = "10";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 303);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(170, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Количество потоков:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 360);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(170, 20);
            this.label7.TabIndex = 16;
            this.label7.Text = "Количество потоков:";
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Location = new System.Drawing.Point(5, 332);
            this.Label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(200, 20);
            this.Label8.TabIndex = 17;
            this.Label8.Text = "Время нечеткого поиска:";
            // 
            // Time_of_searching
            // 
            this.Time_of_searching.Location = new System.Drawing.Point(399, 326);
            this.Time_of_searching.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Time_of_searching.Name = "Time_of_searching";
            this.Time_of_searching.Size = new System.Drawing.Size(123, 26);
            this.Time_of_searching.TabIndex = 18;
            // 
            // my_count_of_steam
            // 
            this.my_count_of_steam.Location = new System.Drawing.Point(399, 360);
            this.my_count_of_steam.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.my_count_of_steam.Name = "my_count_of_steam";
            this.my_count_of_steam.Size = new System.Drawing.Size(123, 26);
            this.my_count_of_steam.TabIndex = 19;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(9, 560);
            this.button4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(513, 40);
            this.button4.TabIndex = 20;
            this.button4.Text = "Создать отчет";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 611);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.my_count_of_steam);
            this.Controls.Add(this.Time_of_searching);
            this.Controls.Add(this.Label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.count_of_stream);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.count_of_words);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.text_dist);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exp_search_time);
            this.Controls.Add(this.Field_for_input);
            this.Controls.Add(this.Time_of_loading);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox Time_of_loading;
        private System.Windows.Forms.TextBox Field_for_input;
        private System.Windows.Forms.TextBox exp_search_time;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox text_dist;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox count_of_words;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox count_of_stream;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label Label8;
        private System.Windows.Forms.TextBox Time_of_searching;
        private System.Windows.Forms.TextBox my_count_of_steam;
        private System.Windows.Forms.Button button4;
    }
}

