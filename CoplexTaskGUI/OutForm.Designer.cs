namespace WindowsFormsApp
{
    partial class OutForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OutForm));
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SaveAs_Button = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(851, 292);
            this.listBox1.TabIndex = 0;
            // 
            // SaveAs_Button
            // 
            this.SaveAs_Button.Location = new System.Drawing.Point(733, 310);
            this.SaveAs_Button.Name = "SaveAs_Button";
            this.SaveAs_Button.Size = new System.Drawing.Size(130, 50);
            this.SaveAs_Button.TabIndex = 6;
            this.SaveAs_Button.Text = "Сохранить как...";
            this.SaveAs_Button.UseVisualStyleBackColor = true;
            this.SaveAs_Button.Click += new System.EventHandler(this.SaveAs_Button_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileName = "Result";
            this.saveFileDialog1.Filter = "(*.txt)|*.txt|Все файлы (*.*)|*.*\"";
            // 
            // OutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 369);
            this.Controls.Add(this.SaveAs_Button);
            this.Controls.Add(this.listBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "OutForm";
            this.Text = "OutForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button SaveAs_Button;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}