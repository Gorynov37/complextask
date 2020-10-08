namespace WindowsFormsApp
{
    partial class CompLabForm1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CompLabForm1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Generate_Button = new System.Windows.Forms.Button();
            this.OpenFile_Button = new System.Windows.Forms.Button();
            this.GeneratedListBox1 = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.DataProcessingButton = new System.Windows.Forms.Button();
            this.SurnameText = new System.Windows.Forms.TextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.Need = new System.Windows.Forms.ComboBox();
            this.numericYear = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.NumText = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numeric_m = new System.Windows.Forms.NumericUpDown();
            this.numeric_n = new System.Windows.Forms.NumericUpDown();
            this.SaveAsButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.ClearButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericYear)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_m)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_n)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Количество цехов: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Количество людей: ";
            // 
            // Generate_Button
            // 
            this.Generate_Button.Location = new System.Drawing.Point(285, 26);
            this.Generate_Button.Name = "Generate_Button";
            this.Generate_Button.Size = new System.Drawing.Size(130, 50);
            this.Generate_Button.TabIndex = 4;
            this.Generate_Button.Text = "Сгенерировать";
            this.Generate_Button.UseVisualStyleBackColor = true;
            this.Generate_Button.Click += new System.EventHandler(this.RandomInitButton_Click);
            // 
            // OpenFile_Button
            // 
            this.OpenFile_Button.Location = new System.Drawing.Point(465, 38);
            this.OpenFile_Button.Name = "OpenFile_Button";
            this.OpenFile_Button.Size = new System.Drawing.Size(130, 50);
            this.OpenFile_Button.TabIndex = 5;
            this.OpenFile_Button.Text = "Загрузить из файла";
            this.OpenFile_Button.UseVisualStyleBackColor = true;
            this.OpenFile_Button.Click += new System.EventHandler(this.OpenFile_Button_Click);
            // 
            // GeneratedListBox1
            // 
            this.GeneratedListBox1.FormattingEnabled = true;
            this.GeneratedListBox1.ItemHeight = 16;
            this.GeneratedListBox1.Location = new System.Drawing.Point(15, 261);
            this.GeneratedListBox1.Name = "GeneratedListBox1";
            this.GeneratedListBox1.Size = new System.Drawing.Size(580, 212);
            this.GeneratedListBox1.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 241);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(474, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Даннные (Фамилия, Цех, Год рождения, Нуждаемость в жилплощади)";
            // 
            // DataProcessingButton
            // 
            this.DataProcessingButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.DataProcessingButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DataProcessingButton.Location = new System.Drawing.Point(151, 479);
            this.DataProcessingButton.Name = "DataProcessingButton";
            this.DataProcessingButton.Size = new System.Drawing.Size(308, 76);
            this.DataProcessingButton.TabIndex = 9;
            this.DataProcessingButton.Text = "ОБРАБОТАТЬ ДАННЫЕ";
            this.DataProcessingButton.UseVisualStyleBackColor = true;
            this.DataProcessingButton.Click += new System.EventHandler(this.DataProcessingButton_Click);
            // 
            // SurnameText
            // 
            this.SurnameText.Location = new System.Drawing.Point(15, 168);
            this.SurnameText.Name = "SurnameText";
            this.SurnameText.Size = new System.Drawing.Size(258, 22);
            this.SurnameText.TabIndex = 10;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(15, 196);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(580, 23);
            this.AddButton.TabIndex = 14;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // Need
            // 
            this.Need.FormattingEnabled = true;
            this.Need.Items.AddRange(new object[] {
            "True",
            "False"});
            this.Need.Location = new System.Drawing.Point(470, 166);
            this.Need.Name = "Need";
            this.Need.Size = new System.Drawing.Size(125, 24);
            this.Need.TabIndex = 15;
            // 
            // numericYear
            // 
            this.numericYear.Location = new System.Drawing.Point(365, 167);
            this.numericYear.Maximum = new decimal(new int[] {
            2002,
            0,
            0,
            0});
            this.numericYear.Minimum = new decimal(new int[] {
            1940,
            0,
            0,
            0});
            this.numericYear.Name = "numericYear";
            this.numericYear.Size = new System.Drawing.Size(99, 22);
            this.numericYear.TabIndex = 17;
            this.numericYear.Value = new decimal(new int[] {
            1940,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 17);
            this.label4.TabIndex = 18;
            this.label4.Text = "Фамилия:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(279, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 17);
            this.label5.TabIndex = 19;
            this.label5.Text = "Цех:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(362, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 17);
            this.label6.TabIndex = 20;
            this.label6.Text = "Год:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(470, 148);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 17);
            this.label7.TabIndex = 21;
            this.label7.Text = "Нуждаемость:";
            // 
            // NumText
            // 
            this.NumText.Location = new System.Drawing.Point(279, 168);
            this.NumText.Name = "NumText";
            this.NumText.Size = new System.Drawing.Size(79, 22);
            this.NumText.TabIndex = 22;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numeric_m);
            this.groupBox1.Controls.Add(this.numeric_n);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Generate_Button);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(425, 94);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Случайная генерация";
            // 
            // numeric_m
            // 
            this.numeric_m.Location = new System.Drawing.Point(159, 54);
            this.numeric_m.Maximum = new decimal(new int[] {
            320000,
            0,
            0,
            0});
            this.numeric_m.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numeric_m.Name = "numeric_m";
            this.numeric_m.Size = new System.Drawing.Size(102, 22);
            this.numeric_m.TabIndex = 26;
            this.numeric_m.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // numeric_n
            // 
            this.numeric_n.Location = new System.Drawing.Point(159, 26);
            this.numeric_n.Maximum = new decimal(new int[] {
            320000,
            0,
            0,
            0});
            this.numeric_n.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numeric_n.Name = "numeric_n";
            this.numeric_n.Size = new System.Drawing.Size(102, 22);
            this.numeric_n.TabIndex = 25;
            this.numeric_n.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // SaveAsButton
            // 
            this.SaveAsButton.Location = new System.Drawing.Point(465, 479);
            this.SaveAsButton.Name = "SaveAsButton";
            this.SaveAsButton.Size = new System.Drawing.Size(130, 76);
            this.SaveAsButton.TabIndex = 24;
            this.SaveAsButton.Text = "Сохранить как...";
            this.SaveAsButton.UseVisualStyleBackColor = true;
            this.SaveAsButton.Click += new System.EventHandler(this.SaveAsButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "(*.txt)|*.txt|Все файлы (*.*)|*.*\"";
            this.openFileDialog1.InitialDirectory = "\"c:\\\\\"";
            this.openFileDialog1.RestoreDirectory = true;
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileName = "List";
            this.saveFileDialog1.Filter = "(*.txt)|*.txt|Все файлы (*.*)|*.*\"";
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(15, 479);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(130, 76);
            this.ClearButton.TabIndex = 25;
            this.ClearButton.Text = "Очистить";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // CompLabForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 567);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.SaveAsButton);
            this.Controls.Add(this.OpenFile_Button);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.NumText);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numericYear);
            this.Controls.Add(this.Need);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.SurnameText);
            this.Controls.Add(this.DataProcessingButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.GeneratedListBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CompLabForm1";
            this.Text = "CompLab";
            ((System.ComponentModel.ISupportInitialize)(this.numericYear)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_m)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_n)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Generate_Button;
        private System.Windows.Forms.Button OpenFile_Button;
        private System.Windows.Forms.ListBox GeneratedListBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button DataProcessingButton;
        private System.Windows.Forms.TextBox SurnameText;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.ComboBox Need;
        private System.Windows.Forms.NumericUpDown numericYear;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox NumText;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button SaveAsButton;
        private System.Windows.Forms.NumericUpDown numeric_m;
        private System.Windows.Forms.NumericUpDown numeric_n;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button ClearButton;
    }
}

