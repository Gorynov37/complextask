using System;
using System.IO;
using System.Collections.Generic;
using System.Windows.Forms;
using DataLib;

namespace WindowsFormsApp
{
    //      Основное окно программы
    public partial class CompLabForm1 : Form
    {
        private FactoryData data = new FactoryData();       //Создаём пустой объект для хранения данных

        private bool inited = false;                        //Хранит данные о том, использован ли 
                                                            //один из методов ввода данных(Генерация/Ввод из файла)

        //  Стандартный конструктор
        public CompLabForm1()
        {
            InitializeComponent();
        }

        //  Нажатие на кнопку "Сгенерировать"
        //Генерирует случайные данные и выводит их в окно
        private void RandomInitButton_Click(object sender, EventArgs e)
        {
            if (inited)     //Если до этого генерировали/вводили из файла данные, отказать в генерации.
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
                //  Заполняем data случайнми данными
                data.RandomInit(Convert.ToInt32(numeric_n.Value),   //Кол-во рабочих
                                Convert.ToInt32(numeric_m.Value));  //Кол-во цехов

                //  Выводим в окно все данные из data
                foreach (KeyValuePair<int, WorkersData> d in data)  
                {
                    foreach (KeyValuePair<string, Worker> p in d.Value)
                    {
                        GeneratedListBox1.Items.Add($"{p.Value.Name}         " +
                                                    $"{p.Value.Number}         " +
                                                    $"{p.Value.Year}         " +
                                                    $"{p.Value.IsNeed}");
                    }
                }
                inited = true;
            }

        }

        //  Нажатие на кнопку "Добавить"
        //Реализует ручное добавление данный по одному рабочему
        private void AddButton_Click(object sender, EventArgs e)
        {
            if((data.ContainsKey(Convert.ToInt32(NumText.Text)))  &&
               (data[Convert.ToInt32(NumText.Text)].ContainsKey(SurnameText.Text)))
            {
                MessageBox.Show(
                    "Этот человек уже есть в списке.\n" +
                    "Введите другую фамилию.",
                    "Ошибка", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Error);
            }
            else
            {
                data.AddPerson(Convert.ToInt32(NumText.Text), 
                               SurnameText.Text, 
                               Convert.ToInt32(numericYear.Value), 
                               Convert.ToBoolean(Need.Text));

                GeneratedListBox1.Items.Add($"{SurnameText.Text}         " +
                                            $"{NumText.Text}         " +
                                            $"{numericYear.Value}         " +
                                            $"{Need.Text}");
            }
        }
        
        //  Нажатие на кнопку "Загрузить из файла"
        //Считывает данные из файла txt и выводит их в окно
        private void OpenFile_Button_Click(object sender, EventArgs e)
        {
            if (inited)     //Если до этого генерировали/вводили из файла данные, отказать в вводе.
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
                    //  Открываем файл с помощью диалогового окна и считываем его в data
                    Stream fileStream = openFileDialog1.OpenFile();
                    data.ReadTxt(fileStream);

                    //  Выводим в окно все данные из data в окно
                    foreach (KeyValuePair<int, WorkersData> d in data)
                    {
                        foreach (KeyValuePair<string, Worker> p in d.Value)
                        {
                            GeneratedListBox1.Items.Add($"{p.Value.Name}         " +
                                                        $"{p.Value.Number}         " +
                                                        $"{p.Value.Year}         " +
                                                        $"{p.Value.IsNeed}");
                        }
                    }
                    fileStream.Close();
                    inited = true;
                }
            }
        }

        //  Нажатие на кнопку "Сохранить как..."
        //Сохраняет все данные в файл, указанный с помощью диалогового окна
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

        //  Нажатие на кнопку "ОБРАБОТАТЬ ДАННЫЕ"
        //Открывает новое окно, в которое выводит результаты обработки данных
        private void DataProcessingButton_Click(object sender, EventArgs e)
        {
            OutForm outForm = new OutForm(data);
            outForm.Show();
        }

        //  Нажатие на кнопку "Очистить"
        //Удаляет все ранее введённые данные
        private void ClearButton_Click(object sender, EventArgs e)
        {
            GeneratedListBox1.Items.Clear();
            data.Clear();
            inited = false;
        }
    }
}
