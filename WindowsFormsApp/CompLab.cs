using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataLib;

namespace WindowsFormsApp
{
    public partial class CompLabForm1 : Form
    {
        FactoryData data = new FactoryData();
        bool inited = false;
        public CompLabForm1()
        {
            InitializeComponent();
        }
        private void RandomInitButton_Click(object sender, EventArgs e)
        {
            if (inited)
            {
                MessageBox.Show(
                    "Вы уже ввели данные другим способом.",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
            }
            else
            {
                data.RandomInit(Convert.ToInt32(numeric_n.Value), Convert.ToInt32(numeric_m.Value));

                foreach (KeyValuePair<int, WorkersData> d in data)
                {
                    foreach (KeyValuePair<string, Worker> p in d.Value)
                    {
                        GeneratedListBox1.Items.Add($"{p.Value.Name}         {p.Value.Number}         {p.Value.Year}         {p.Value.IsNeed} ");
                    }
                }
                inited = true;
            }

        }


        private void DataProcessingButton_Click(object sender, EventArgs e)
        {
            OutForm outForm = new OutForm(data);
            outForm.Show();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            try
            {
                data.AddPerson(Convert.ToInt32(NumText.Text), SurnameText.Text, Convert.ToInt32(numericYear.Value), Convert.ToBoolean(Need.Text));
                GeneratedListBox1.Items.Add($"{SurnameText.Text}         {NumText.Text}         {numericYear.Value}         {Need.Text} ");
            }
            catch (System.ArgumentException)
            {
                MessageBox.Show(
                    "Этот человек уже есть в списке.\n" +
                    "Введите другую фамилию.",
                    "Ошибка", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Error);
            }
            
        }

        private void OpenFile_Button_Click(object sender, EventArgs e)
        {
            if (inited)
            {
                MessageBox.Show(
                    "Вы уже ввели данные другим способом.",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
            }
            else
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    Stream fileStream = openFileDialog1.OpenFile();
                    data.ReadTxt(fileStream);

                    foreach (KeyValuePair<int, WorkersData> d in data)
                    {
                        foreach (KeyValuePair<string, Worker> p in d.Value)
                        {
                            GeneratedListBox1.Items.Add($"{p.Value.Name}         {p.Value.Number}         {p.Value.Year}         {p.Value.IsNeed} ");
                        }
                    }
                    fileStream.Close();
                    inited = true;
                }
            }
        }

        private void SaveAsButton_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filename = saveFileDialog1.FileName;
                data.WriteTxt(filename);
                MessageBox.Show(
                    "Файл сохранен",
                    "",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }
    }
}
