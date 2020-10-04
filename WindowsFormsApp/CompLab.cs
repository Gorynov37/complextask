using System;
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
        FactoryData data;
        public CompLabForm1()
        {
            InitializeComponent();
            data = new FactoryData();
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            data.RandomInit(Convert.ToInt32(numeric_n.Value) , Convert.ToInt32(numeric_m.Value));
            data.WriteTxt();

            foreach (KeyValuePair<int, WorkersData> d in data)
            {
                foreach (KeyValuePair<string, Worker> p in d.Value)
                {
                    GeneratedListBox1.Items.Add($"{p.Value.Name}         {p.Value.Number}         {p.Value.Year}         {p.Value.IsNeed} ");
                }
            }

        }


        private void DataProcessingButton_Click(object sender, EventArgs e)
        {
            OutForm outForm = new OutForm(data);
            outForm.Show();
        }

        private void domain_n_SelectedItemChanged(object sender, EventArgs e) { }
        private void GeneratedListBox1_SelectedIndexChanged(object sender, EventArgs e) { }
        private void label5_Click(object sender, EventArgs e) { }

        private void button1_Click(object sender, EventArgs e)
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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
