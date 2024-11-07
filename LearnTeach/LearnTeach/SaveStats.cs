using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Windows.Forms;

namespace LearnTeach
{
    public static class SaveStats
    {
        public static int progress, progressTest1, progressTest2, progressTest3, progressTest4, testNumber, testComplete1, testComplete2, testComplete3, testComplete4, testCompleted = 100, questionCount1, questionCount2, questionCount3, questionCount4, correctAnswers1, correctAnswers2, correctAnswers3, correctAnswers4, checkProgress;
        public static string login, password;
        public static int[,] treeview = new int[3, 6];
        public static bool IsChangingTreeView = false;
    }
    public class After
    {
        public void EditXML()
        {
            string filePath = "Users.xml";

            string loginToUpdate = SaveStats.login;
            string passwordToUpdate = SaveStats.password;

            int newProgressValue = SaveStats.progress;

            XmlDocument xmlDoc = new XmlDocument();

            xmlDoc.Load(filePath);

            XmlNodeList userNodes = xmlDoc.SelectNodes("/Users/User");

            foreach (XmlNode userNode in userNodes)
            {
                XmlNode loginNode = userNode.SelectSingleNode("Login");
                XmlNode passwordNode = userNode.SelectSingleNode("Password");
                string login = loginNode.InnerText;
                string password = passwordNode.InnerText;

                if (login == loginToUpdate && password == passwordToUpdate)
                {
                    XmlNode progressNode = userNode.SelectSingleNode("Progress");
                    progressNode.InnerText = newProgressValue.ToString();

                    XmlNode testCompleteNode1 = userNode.SelectSingleNode("testComplete1");
                    testCompleteNode1.InnerText = SaveStats.testComplete1.ToString();
                    XmlNode testCompleteNode2 = userNode.SelectSingleNode("testComplete2");
                    testCompleteNode2.InnerText = SaveStats.testComplete2.ToString();
                    XmlNode testCompleteNode3 = userNode.SelectSingleNode("testComplete3");
                    testCompleteNode3.InnerText = SaveStats.testComplete3.ToString();
                    XmlNode testCompleteNode4 = userNode.SelectSingleNode("testComplete4");
                    testCompleteNode4.InnerText = SaveStats.testComplete4.ToString();

                    XmlNode correctAnswersNode1 = userNode.SelectSingleNode("correctAnswers1");
                    correctAnswersNode1.InnerText = SaveStats.correctAnswers1.ToString();
                    XmlNode correctAnswersNode2 = userNode.SelectSingleNode("correctAnswers2");
                    correctAnswersNode2.InnerText = SaveStats.correctAnswers2.ToString();
                    XmlNode correctAnswersNode3 = userNode.SelectSingleNode("correctAnswers3");
                    correctAnswersNode3.InnerText = SaveStats.correctAnswers3.ToString();
                    XmlNode correctAnswersNode4 = userNode.SelectSingleNode("correctAnswers4");
                    correctAnswersNode4.InnerText = SaveStats.correctAnswers4.ToString();

                    XmlNode questionCountNode1 = userNode.SelectSingleNode("questionCount1");
                    questionCountNode1.InnerText = SaveStats.questionCount1.ToString();
                    XmlNode questionCountNode2 = userNode.SelectSingleNode("questionCount2");
                    questionCountNode2.InnerText = SaveStats.questionCount2.ToString();
                    XmlNode questionCountNode3 = userNode.SelectSingleNode("questionCount3");
                    questionCountNode3.InnerText = SaveStats.questionCount3.ToString();
                    XmlNode questionCountNode4 = userNode.SelectSingleNode("questionCount4");
                    questionCountNode4.InnerText = SaveStats.questionCount4.ToString();

                    XmlNode progressTestNode1 = userNode.SelectSingleNode("progressTest1");
                    progressTestNode1.InnerText = SaveStats.progressTest1.ToString();
                    XmlNode progressTestNode2 = userNode.SelectSingleNode("progressTest2");
                    progressTestNode2.InnerText = SaveStats.progressTest2.ToString();
                    XmlNode progressTestNode3 = userNode.SelectSingleNode("progressTest3");
                    progressTestNode3.InnerText = SaveStats.progressTest3.ToString();
                    XmlNode progressTestNode4 = userNode.SelectSingleNode("progressTest4");
                    progressTestNode4.InnerText = SaveStats.progressTest4.ToString();


                    for (int i = 0; i < 3; i++)
                    {
                        for (int j = 0; j < 6; j++)
                        {
                            XmlNode treeViewNode = userNode.SelectSingleNode("treeView" + (i * 6 + j + 1));
                            treeViewNode.InnerText = SaveStats.treeview[i, j].ToString();
                        }
                    }
                }
            }
            xmlDoc.Save(filePath);
        }
    }
}