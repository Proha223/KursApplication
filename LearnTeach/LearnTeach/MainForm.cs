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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Serialization;
using System.Xml;

namespace LearnTeach
{
    public partial class MainForm : Form
    {
        string txt0 = File.ReadAllText(@"..\Узел0.txt");
        string txt1 = File.ReadAllText(@"..\Узел1.txt");
        string txt2 = File.ReadAllText(@"..\Узел2.txt");
        string txt3 = File.ReadAllText(@"..\Узел3.txt");
        string txt4 = File.ReadAllText(@"..\Узел4.txt");
        string txt5 = File.ReadAllText(@"..\Узел5.txt");
        string txt6 = File.ReadAllText(@"..\Узел6.txt");
        string txt7 = File.ReadAllText(@"..\Узел7.txt");
        string txt8 = File.ReadAllText(@"..\Узел8.txt");
        string txt9 = File.ReadAllText(@"..\Узел9.txt");
        string txt10 = File.ReadAllText(@"..\Узел10.txt");
        string txt11 = File.ReadAllText(@"..\Узел11.txt");
        string txt12 = File.ReadAllText(@"..\Узел12.txt");
        string txt13 = File.ReadAllText(@"..\Узел13.txt");
        string txt14 = File.ReadAllText(@"..\Узел14.txt");
        string txt15 = File.ReadAllText(@"..\Узел15.txt");
        string txt16 = File.ReadAllText(@"..\Узел16.txt");
        string txt17 = File.ReadAllText(@"..\Узел17.txt");

        After after = new After();

        public MainForm()
        {
            InitializeComponent();

            TestResult();
            refreshBar();
            MyProgressBar();
            labelBar.Text = SaveStats.progress + "%";
            CheckStats();

            this.Text = "Информационно-обучающая система C#";

            if (SaveStats.testNumber == 5)
            {
                tabControl1.SelectedIndex = 1;
            }

            this.MinimumSize = new Size(1920, 1050);
            this.MaximumSize = new Size(1920, 1050);

            foreach (TreeNode node in MainTreeView.Nodes)
            {
                SetVisibleNode(node);
            }

            SelectNodeByName(MainTreeView, "Общие сведения");

            progressBar1.Minimum = 0;
            progressBar1.Maximum = 100;
        }

        void TestResult()
        {
            if (SaveStats.correctAnswers1 >= 1)
            {
                SaveStats.progressTest1 = (int)((SaveStats.correctAnswers1 / (float)SaveStats.questionCount1) * 100);
            }
            
            if (SaveStats.correctAnswers2 >= 1)
            {
                SaveStats.progressTest2 = (int)((SaveStats.correctAnswers2 / (float)SaveStats.questionCount2) * 100);
            }

            if (SaveStats.correctAnswers3 >= 1)
            {
                SaveStats.progressTest3 = (int)((SaveStats.correctAnswers3 / (float)SaveStats.questionCount3) * 100);
            }

            if (SaveStats.correctAnswers4 >= 1)
            {
                SaveStats.progressTest4 = (int)((SaveStats.correctAnswers4 / (float)SaveStats.questionCount4) * 100);
            }
        }

        void refreshBar()
        {
            progressBar1.Value = SaveStats.progress;
        }

        void CheckStats()
        {
            if (SaveStats.progress >= 18)
                buttonTest1.Enabled = true;

            if (SaveStats.progress >= 36)
                 buttonTest2.Enabled = true;

            if (SaveStats.progress >= 54)
                buttonTest3.Enabled = true;

            if (SaveStats.progress >= 86)
                buttonMainTest.Enabled = true;

            if (SaveStats.progress < 18 || SaveStats.testComplete1 == 1)
                buttonTest1.Enabled = false;

            if (SaveStats.progress < 36 || SaveStats.testComplete2 == 1)
                buttonTest2.Enabled = false;

            if (SaveStats.progress < 54 || SaveStats.testComplete3 == 1)
                buttonTest3.Enabled = false;

            if (SaveStats.progress < 84 || SaveStats.testComplete4 == 1)
                buttonMainTest.Enabled = false;
        }

        private void MyProgressBar()
        {
            if (SaveStats.checkProgress == 1)
            {
                if (SaveStats.progress == progressBar1.Maximum)
                {
                    MessageBox.Show($"Поздравляю, {SaveStats.login}!\nВы прошли курс \"Способы создания классов в C#\"", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                SaveStats.checkProgress = 0;
            }

        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm lf = new LoginForm();
            lf.ShowDialog();
        }

        private void ClearTextButton_Click(object sender, EventArgs e)
        {
            TextBox.Clear();
        }

        void TreeSet()
        {
            SaveStats.IsChangingTreeView = false;
            for (int i = 0; i < MainTreeView.Nodes.Count; i++)
            {
                TreeNode rootNode = MainTreeView.Nodes[i];
                rootNode.Checked = SaveStats.treeview[i, 0] == 1;

                for (int j = 0; j < rootNode.Nodes.Count; j++)
                {
                    TreeNode childNode = rootNode.Nodes[j];
                    childNode.Checked = SaveStats.treeview[i, j + 1] == 1;
                }
            }
            SaveStats.IsChangingTreeView = true;
        }

        void CheckTestResult()
        {
            if (SaveStats.testComplete1 == 0)
            {
                textBox1.Text = $"Ваш результат теста №1 = {SaveStats.progressTest1} %\r\nПравильно {SaveStats.correctAnswers1} из {SaveStats.questionCount1} вопросов\r\nТест не пройден! \r\n(Прогресс начисляется после правильного прохождения теста)";
            }
            else
            {
                textBox1.Text = $"Ваш результат теста №1 = {SaveStats.testCompleted} %\r\nПравильно {SaveStats.correctAnswers1} из {SaveStats.questionCount1} вопросов\r\nТест пройден!\r\nПоздравляю, {SaveStats.login}!";
            }
            if (SaveStats.testComplete2 == 0)
            {
                textBox2.Text = $"Ваш результат теста №2 = {SaveStats.progressTest2} %\r\nПравильно {SaveStats.correctAnswers2} из {SaveStats.questionCount2} вопросов\r\nТест не пройден! \r\n(Прогресс начисляется после правильного прохождения теста)";
            }
            else
            {
                textBox2.Text = $"Ваш результат теста №2 = {SaveStats.testCompleted} %\r\nПравильно {SaveStats.correctAnswers2} из {SaveStats.questionCount2} вопросов\r\nТест пройден!\r\nПоздравляю, {SaveStats.login}!";
            }
            if (SaveStats.testComplete3 == 0)
            {
                textBox3.Text = $"Ваш результат теста №3 = {SaveStats.progressTest3} %\r\nПравильно {SaveStats.correctAnswers3} из {SaveStats.questionCount3} вопросов\r\nТест не пройден! \r\n(Прогресс начисляется после правильного прохождения теста)";
            }
            else
            {
                textBox3.Text = $"Ваш результат теста №3 = {SaveStats.testCompleted} %\r\nПравильно {SaveStats.correctAnswers3} из {SaveStats.questionCount3} вопросов\r\nТест пройден!\r\nПоздравляю, {SaveStats.login}!";
            }
            if (SaveStats.testComplete4 == 0)
            {
                textBox4.Text = $"\r\nВаш результат главного теста = {SaveStats.progressTest4} %\r\nПравильно {SaveStats.correctAnswers4} из {SaveStats.questionCount4} вопросов\r\nТест не пройден! \r\n(Прогресс начисляется после правильного прохождения теста)";
            }
            else
            {
                textBox4.Text = $"\r\nВаш результат главного теста = {SaveStats.testCompleted} %\r\nПравильно {SaveStats.correctAnswers4} из {SaveStats.questionCount4} вопросов\r\nТест пройден!\r\nПоздравляю, {SaveStats.login}!";
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            this.WindowState = FormWindowState.Maximized;
            SaveStats.IsChangingTreeView = false;
            TreeSet();
            CheckStats();
            CheckTestResult();
        }

        private void SetVisibleNode(TreeNode node)
        {
            if (node != null)
            {
                node.Expand();

                if (node.Parent != null)
                {
                    SetVisibleNode(node.Parent);
                }
            }
        }
        
        public void SelectNodeByName(System.Windows.Forms.TreeView treeView, string nameNode)
        {
            foreach (TreeNode item in MainTreeView.Nodes)
            {
                if (item.Text == nameNode)
                {
                    MainTreeView.SelectedNode = item;
                }
            }
        }

        private void MainTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode node = e.Node;
            if (node == null)
            {
                return;
            }
            
            if (e.Node.Text == "Общие сведения")
                TextBox.Text = node.Text + ":" + Environment.NewLine + txt0;

            else if (e.Node.Text == "Типы ссылок")
                TextBox.Text = node.Text + ":" + Environment.NewLine + txt1;

            else if (e.Node.Text == "Объявление классов")
                TextBox.Text = node.Text + ":" + Environment.NewLine + txt2;

            else if (e.Node.Text == "Создание объектов")
                TextBox.Text = node.Text + ":" + Environment.NewLine + txt3;

            else if (e.Node.Text == "Конструкторы и инициализация")
                TextBox.Text = node.Text + ":" + Environment.NewLine + txt4;

            else if (e.Node.Text == "Наследование классов")
                TextBox.Text = node.Text + ":" + Environment.NewLine + txt5;

            else if (e.Node.Text == "Классы и объекты")
                TextBox.Text = node.Text + ":" + Environment.NewLine + txt6;

            else if (e.Node.Text == "Поля и методы класса")
                TextBox.Text = node.Text + ":" + Environment.NewLine + txt7;

            else if (e.Node.Text == "Создание объекта класса")
                TextBox.Text = node.Text + ":" + Environment.NewLine + txt8;

            else if (e.Node.Text == "Конструктор по умолчанию")
                TextBox.Text = node.Text + ":" + Environment.NewLine + txt9;

            else if (e.Node.Text == "Обращение к функциональности класса")
                TextBox.Text = node.Text + ":" + Environment.NewLine + txt10;

            else if (e.Node.Text == "Добавление класса")
                TextBox.Text = node.Text + ":" + Environment.NewLine + txt11;

            else if (e.Node.Text == "Дополнительный материал")
                TextBox.Text = node.Text + ":" + Environment.NewLine + txt12;

            else if (e.Node.Text == "Поля класса")
                TextBox.Text = node.Text + ":" + Environment.NewLine + txt13;

            else if (e.Node.Text == "Конструкторы")
                TextBox.Text = node.Text + ":" + Environment.NewLine + txt14;

            else if (e.Node.Text == "Инициализаторы объектов")
                TextBox.Text = node.Text + ":" + Environment.NewLine + txt15;

            else if (e.Node.Text == "Собственные структуры")
                TextBox.Text = node.Text + ":" + Environment.NewLine + txt16;

            else if (e.Node.Text == "Итог")
                TextBox.Text = node.Text + ":" + Environment.NewLine + txt17;
        }

        private void MainTreeView_AfterCheck(object sender, TreeViewEventArgs e)
        {
            if (SaveStats.IsChangingTreeView == true)
            {
                if (e.Node.Checked)
                {
                    SaveStats.progress += 3;
                    refreshBar();
                    labelBar.Text = SaveStats.progress + " %";
                    CheckStats();
                }
                else
                {
                    SaveStats.progress -= 3;
                    refreshBar();
                    after.EditXML();
                    labelBar.Text = SaveStats.progress + " %";
                    CheckStats();
                }
            }
            TreeNode node = e.Node;
            int rootIndex = node.Parent == null ? node.Index : node.Parent.Index;
            int childIndex = node.Parent == null ? -1 : node.Index;

            if (node.Parent == null)
            {
                if (rootIndex >= 0 && rootIndex < 3)
                {
                    SaveStats.treeview[rootIndex, 0] = node.Checked ? 1 : 0;
                }
            }
            else
            {
                if (rootIndex >= 0 && rootIndex < 3 && childIndex >= 0 && childIndex < 6)
                {
                    SaveStats.treeview[rootIndex, childIndex + 1] = node.Checked ? 1 : 0; 
                }
            }
            after.EditXML();
        }

        private void buttonTest1_Click(object sender, EventArgs e) 
        {
            SaveStats.testNumber = 1;
            this.Hide();
            TestForm tf = new TestForm();
            tf.ShowDialog();
        }

        private void buttonTest2_Click(object sender, EventArgs e)
        {
            SaveStats.testNumber = 2;
            this.Hide();
            TestForm tf = new TestForm();
            tf.ShowDialog();
        }

        private void buttonTest3_Click(object sender, EventArgs e)
        {
            SaveStats.testNumber = 3;
            this.Hide();
            TestForm tf = new TestForm();
            tf.ShowDialog();
        }

        private void buttonMainTest_Click(object sender, EventArgs e)
        {
            SaveStats.checkProgress = 1;
            SaveStats.testNumber = 4;
            this.Hide();
            TestForm tf = new TestForm();
            tf.ShowDialog();
        }
    }
}