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
    public partial class OutForm : Form
    {
        FactoryData data;
        public OutForm(FactoryData data1)
        {
            InitializeComponent();
            data = data1;
            foreach (KeyValuePair<int, WorkersData> d in data)
            {
                string s = "";
                s += $"Информация по цеху №{d.Key}:\n";
                s += $"    Нужно Квартир: {d.Value.IsNeedAmount()}\n";
                s += $"    Приоритетный рабочий: {d.Value.FindPriority().Name} ({d.Value.FindPriority().Year})";

                listBox1.Items.Add(s);
            }
        }

        private void OutForm_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SaveAs_Button_Click(object sender, EventArgs e)
        {

        }
    }
}
