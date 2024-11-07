using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.SymbolStore;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Serialization;

namespace LearnTeach
{
    public partial class TestForm : Form
    {
        int question_count, correct_answers, wrong_answers, correct_answers_number, selected_response;
        string[] array;
        
        System.IO.StreamReader read;

        After after = new After();

        public TestForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            if (SaveStats.testNumber == 1)
            {
                this.Text = "Тест №1: \"Общие сведения\"";
                start(@"\test.txt");
            }
            else if (SaveStats.testNumber == 2)
            {
                this.Text = "Тест №2: \"Классы и объекты\"";
                start(@"\test2.txt");
            }
            else if (SaveStats.testNumber == 3)
            {
                this.Text = "Тест №3: \"Empty\"";
                start(@"\test3.txt");
            }
            else if (SaveStats.testNumber == 4)
            {
                this.Text = "Главный тест по всем разделам";
                start(@"\testMain.txt");
            }
        }

        void start(string filename)
        {
            var encoding = System.Text.Encoding.GetEncoding(65001);

            try
            {
                read = new System.IO.StreamReader(System.IO.Directory.GetCurrentDirectory() + $"{filename}", encoding);

                question_count = 0;
                correct_answers = 0;
                wrong_answers = 0;

                array = new String[10];
            }
            catch (Exception) 
            {
                MessageBox.Show("Error 404");
            }
            question();

        }

        void question()
        {
            label2.Text = read.ReadLine();
            label1.Text = read.ReadLine();

            radioButton1.Text = read.ReadLine();
            radioButton2.Text = read.ReadLine();
            radioButton3.Text = read.ReadLine();
            radioButton4.Text = read.ReadLine();

            correct_answers_number = int.Parse(read.ReadLine());

            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;

            buttonSelect.Enabled = false;

            question_count++;

            if (read.EndOfStream == true) buttonSelect.Text = "Завершить";
        }

        void Status_switch(object sender, EventArgs e)
        {
            buttonSelect.Enabled = true;
            buttonSelect.Focus();
            RadioButton switcher = (RadioButton)sender;
            var tmp = switcher.Name;
            
            selected_response = int.Parse(tmp.Substring(11));
        }

        private void TestForm_Load(object sender, EventArgs e)
        {
            buttonBack.Text = "Назад";
            buttonSelect.Text = "Ответить";

            radioButton1.CheckedChanged += new EventHandler(Status_switch);
            radioButton2.CheckedChanged += new EventHandler(Status_switch);
            radioButton3.CheckedChanged += new EventHandler(Status_switch);
            radioButton4.CheckedChanged += new EventHandler(Status_switch);
        }

        private void TestForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void buttonSelect_Click(object sender, EventArgs e)
        {
            if (selected_response == correct_answers_number) 
                correct_answers++;

            if (selected_response != correct_answers_number)
            {
                wrong_answers++;

                array[wrong_answers] = label2.Text + ". " + label1.Text + "\n";
            }

            if (buttonSelect.Text == "Перезапуск")
            {
                buttonSelect.Text = "Ответить";

                label2.Visible = true;

                radioButton1.Visible = true;
                radioButton2.Visible = true;
                radioButton3.Visible = true;
                radioButton4.Visible = true;
                
                if (SaveStats.testNumber == 1)
                {
                    start(@"\test.txt");
                }
                if (SaveStats.testNumber == 2)
                {
                    start(@"\test2.txt");
                }
                if (SaveStats.testNumber == 3)
                {
                    start(@"\test3.txt");
                }
                if (SaveStats.testNumber == 4)
                {
                    start(@"\testMain.txt");
                }



                return;
            }

            if (buttonSelect.Text == "Завершить")
            {
                read.Close();

                radioButton1.Visible = false;
                radioButton2.Visible = false;
                radioButton3.Visible = false;
                radioButton4.Visible = false;

                label2.Visible = false;
                label1.Text = String.Format("Тестирование завершено. \n" + 
                    "Правильных ответов: {0} из {1}.\n" + 
                    "Набранные баллы: {2:F2}.", correct_answers,
                    question_count, (correct_answers * 5.0F) / question_count);

                buttonSelect.Text = "Перезапуск";

                var Str = "Список ошибок " +
                          ":\n\n";
                for (int i = 1; i <= wrong_answers; i++)
                    Str += array[i] + "\n";

                if (SaveStats.testNumber == 1)
                {
                    SaveStats.correctAnswers1 = correct_answers;
                    SaveStats.questionCount1 = question_count;
                }
                if (SaveStats.testNumber == 2)
                {
                    SaveStats.correctAnswers2 = correct_answers;
                    SaveStats.questionCount2 = question_count;
                }
                if (SaveStats.testNumber == 3)
                {
                    SaveStats.correctAnswers3 = correct_answers;
                    SaveStats.questionCount3 = question_count;
                }
                if (SaveStats.testNumber == 4)
                {
                    SaveStats.correctAnswers4 = correct_answers;
                    SaveStats.questionCount4 = question_count;
                }

                if (wrong_answers != 0) 
                { 
                    MessageBox.Show(Str, "Тестирование завершено.");
                }
                if (correct_answers == question_count)
                {
                    if (SaveStats.testNumber == 1)
                    {
                        if (SaveStats.testComplete1 == 0)
                            SaveStats.progress += 10;

                        SaveStats.testComplete1 = 1;
                        after.EditXML();
                    }

                    if (SaveStats.testNumber == 2)
                    {
                        if (SaveStats.testComplete2 == 0)
                            SaveStats.progress += 10;

                        SaveStats.testComplete2 = 1;
                        after.EditXML();
                    }

                    if (SaveStats.testNumber == 3)
                    {
                        if (SaveStats.testComplete3 == 0)
                            SaveStats.progress += 10;

                        SaveStats.testComplete3 = 1;
                        after.EditXML();
                    }
                    
                    if (SaveStats.testNumber == 4)
                    {
                        if (SaveStats.testComplete4 == 0)
                            SaveStats.progress += 16;

                        SaveStats.testComplete4 = 1;
                        after.EditXML();
                    }
                } 
            }
            if (buttonSelect.Text == "Ответить")
                question();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            SaveStats.testNumber = 5;
            this.Hide();
            MainForm mf = new MainForm();
            mf.ShowDialog();
        }
    }
}