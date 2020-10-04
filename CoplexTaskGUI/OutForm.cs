using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DataLib;

namespace WindowsFormsApp
{
    //      Окно вывода результата обработки данных
    public partial class OutForm : Form
    {
        private FactoryData data;

        //      Конструктор окна вывода
        // Инициализирует окно вывода 
        // и выводит в него результаты обработки данных
        public OutForm(FactoryData data1)
        {
            InitializeComponent();
            data = data1;
            foreach (KeyValuePair<int, WorkersData> d in data)
            {
                string s = "";
                s += $"Информация по цеху №{d.Key}: ";
                s += $"    Нужно Квартир: {d.Value.IsNeedAmount()} ";
                s += $"    Приоритетный рабочий: {d.Value.FindPriority().Name} ({d.Value.FindPriority().Year})";

                listBox1.Items.Add(s);
            }
        }

        //      Нажатие на кнопку "Сохранить как..."
        // Открывает диалоговое окно сохранения, записывает в выбранный файл(txt)
        // результаты обработки данных с помощью метода WriteResultTxt
        private void SaveAs_Button_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filename = saveFileDialog1.FileName;
                data.WriteResultTxt(filename);
                MessageBox.Show(
                    "Файл сохранен",
                    "",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }
    }
}
