using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.Xml;

namespace LearnTeach
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen;

            this.PasswordTextBox.AutoSize = false;
            this.PasswordTextBox.Size = new Size(319, 64);
            this.LoginTextBox.AutoSize = false;
            this.LoginTextBox.Size = new Size(319, 64);
            
            LoginTextBox.Text = "";
            PasswordTextBox.Text = "";
            LoginTextBox.MaxLength = 15;
            PasswordTextBox.MaxLength = 20;
        }

        
        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CloseButton_MouseEnter(object sender, EventArgs e)
        {
            CloseButton.ForeColor = Color.YellowGreen;
        }

        private void CloseButton_MouseLeave(object sender, EventArgs e)
        {
            CloseButton.ForeColor = Color.White;
        }

        Point lastPoint;
        private void MainPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void MainPanel_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void Text_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void Text_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void ClearButton_MouseLeave(object sender, EventArgs e)
        {
            ClearButton.BringToFront();
        }

        private void ClearButton_MouseDown(object sender, MouseEventArgs e)
        {
            ClearButton2.BringToFront();
            LoginTextBox.Text = "";
            PasswordTextBox.Text = "";
            LoginTextBox.Select();
        }

        private void HideButton_MouseDown(object sender, MouseEventArgs e)
        {
            ShowButton.BringToFront();
            UnlockPass.BringToFront();
            PasswordTextBox.UseSystemPasswordChar = false;
        }

        private void ShowButton_MouseDown(object sender, MouseEventArgs e)
        {
            HideButton.BringToFront();
            LockPass.BringToFront();
            PasswordTextBox.UseSystemPasswordChar = true;
        }

        private void EnterButton_Click(object sender, EventArgs e)
        {
            DataXML();
            CheckLoginAndPassword();
        }

        public void DataXML()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("Users.xml");

            XmlNodeList users = doc.GetElementsByTagName("User");

            foreach (XmlNode userNode in users)
            {
                string login = userNode.SelectSingleNode("Login").InnerText;
                string password = userNode.SelectSingleNode("Password").InnerText;

                if (login == LoginTextBox.Text && password == PasswordTextBox.Text)
                {
                    SaveStats.progress = int.Parse(userNode.SelectSingleNode("Progress").InnerText);
                    for (int i = 1; i <= 4; i++)
                    {
                        int value = int.Parse(userNode.SelectSingleNode($"testComplete{i}").InnerText);
                        switch (i)
                        {
                            case 1:
                                SaveStats.testComplete1 = value;
                                break;
                            case 2:
                                SaveStats.testComplete2 = value;
                                break;
                            case 3:
                                SaveStats.testComplete3 = value;
                                break;
                            case 4:
                                SaveStats.testComplete4 = value;
                                break;
                        }
                    }
                    for (int i = 1; i <= 4; i++)
                    {
                        int value = int.Parse(userNode.SelectSingleNode($"correctAnswers{i}").InnerText);
                        switch (i)
                        {
                            case 1:
                                SaveStats.correctAnswers1 = value;
                                break;
                            case 2:
                                SaveStats.correctAnswers2 = value;
                                break;
                            case 3:
                                SaveStats.correctAnswers3 = value;
                                break;
                            case 4:
                                SaveStats.correctAnswers4 = value;
                                break;
                        }
                    }
                    for (int i = 1; i <= 4; i++)
                    {
                        int value = int.Parse(userNode.SelectSingleNode($"questionCount{i}").InnerText);
                        switch (i)
                        {
                            case 1:
                                SaveStats.questionCount1 = value;
                                break;
                            case 2:
                                SaveStats.questionCount2 = value;
                                break;
                            case 3:
                                SaveStats.questionCount3 = value;
                                break;
                            case 4:
                                SaveStats.questionCount4 = value;
                                break;
                        }
                    }
                    for (int i = 1; i <= 4; i++)
                    {
                        int value = int.Parse(userNode.SelectSingleNode($"progressTest{i}").InnerText);
                        switch (i)
                        {
                            case 1:
                                SaveStats.progressTest1 = value;
                                break;
                            case 2:
                                SaveStats.progressTest2 = value;
                                break;
                            case 3:
                                SaveStats.progressTest3 = value;
                                break;
                            case 4:
                                SaveStats.progressTest4 = value;
                                break;
                        }
                    }
                    for (int i = 0; i < 3; i++)
                    {
                        for (int j = 0; j < 6; j++)
                        {
                            SaveStats.treeview[i, j] = int.Parse(userNode.SelectSingleNode("treeView" + (i * 6 + j + 1)).InnerText);
                        }
                    }

                    break;
                }
            }
        }

        public void CheckLoginAndPassword()
        {
            SaveStats.login = LoginTextBox.Text.Trim();
            SaveStats.password = PasswordTextBox.Text.Trim();

            XmlDocument doc = new XmlDocument();
            doc.Load("Users.xml");

            XmlNodeList users = doc.SelectNodes("Users/User");

            bool found = false;
            foreach (XmlNode user in users)
            {
                string xmlLogin = user.SelectSingleNode("Login").InnerText;
                string xmlPassword = user.SelectSingleNode("Password").InnerText;

                if (SaveStats.login == xmlLogin && SaveStats.password == xmlPassword)
                {
                    found = true;
                    break;
                }
                
            }

            if (found)
            {
                this.Hide();
                MainForm mf = new MainForm();
                MessageBox.Show("Вы успешно вошли!", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mf.ShowDialog();
            }
            else if (SaveStats.login.Length == 0 || SaveStats.password.Length == 0)
            {
                MessageBox.Show("Пустое поле логина или пароля!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (SaveStats.login.Length < 4 || SaveStats.password.Length < 4)
            {
                MessageBox.Show("Слишком короткая длина логина или пароля!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}