using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizzApp
{
    public partial class QuizzTestForm : Form
    {
       
        public QuizzTestForm()
        {
            InitializeComponent();
            conn = new OleDbConnection();
            String conectionString = " Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Andre\\source\\repos\\QuizzApp\\QuizzApp\\QuizzDB.accdb;Persist Security Info=False;";
            conn.ConnectionString = conectionString;            
        }
        OleDbConnection conn;
        OleDbDataReader readerQ,readerA;
        double CorrectAnswers;
        int[] questionsIds;
        String[] isCorrect;
        int k = 0;
        int quesitonsShowed;

        private void btnAnswer1_Click(object sender, EventArgs e)
        {
            if (isCorrect[0] == "True")
            {
                btnAnswer1.BackColor = Color.Green;
                int count = VerifyAnswer();
                if(count==0) CorrectAnswers++;
                else if(count==1) CorrectAnswers+=0.5;
                lblCorrectAnswers.Text=CorrectAnswers.ToString();

            }
            else btnAnswer1.BackColor= Color.Red;
        }

        private void btnAnswer2_Click(object sender, EventArgs e)
        {
            if (isCorrect[1] == "True")
            {
                btnAnswer2.BackColor = Color.Green;
                int count = VerifyAnswer();
                if (count == 0) CorrectAnswers++;
                else if (count == 1) CorrectAnswers += 0.5;
                lblCorrectAnswers.Text = CorrectAnswers.ToString();
            }
            else btnAnswer2.BackColor = Color.Red;
        }

        private void btnAnswer3_Click(object sender, EventArgs e)
        {
            if (isCorrect[2] == "True")
            {
                btnAnswer3.BackColor = Color.Green;
                int count = VerifyAnswer();
                if (count == 0) CorrectAnswers++;
                else if (count == 1) CorrectAnswers += 0.5;
                lblCorrectAnswers.Text = CorrectAnswers.ToString();
            }
            else btnAnswer3.BackColor = Color.Red;
        }

        private void btnAnswer4_Click(object sender, EventArgs e)
        {
            if (isCorrect[3] == "True")
            {
                btnAnswer4.BackColor = Color.Green;
                int count = VerifyAnswer();
                if (count == 0) CorrectAnswers++;
                else if (count == 1) CorrectAnswers += 0.5;
                lblCorrectAnswers.Text = CorrectAnswers.ToString();
            }
            else btnAnswer4.BackColor = Color.Red;
        }
        private int VerifyAnswer()
        {
            int wrongAns = 0;
            if(btnAnswer1.BackColor == Color.Red ) wrongAns++;
            if (btnAnswer2.BackColor == Color.Red) wrongAns++;
            if(btnAnswer3.BackColor == Color.Red)wrongAns++;
            if( btnAnswer4.BackColor == Color.Red)wrongAns++;
            return wrongAns;
        }

        private void btnNextQuestion_Click(object sender, EventArgs e)
        {
            if (quesitonsShowed < int.Parse(GlobalVariable.NumberofQuestions))
            {
                btnAnswer1.BackColor = Color.MediumTurquoise;
                btnAnswer2.BackColor = Color.MediumTurquoise;
                btnAnswer3.BackColor = Color.MediumTurquoise;
                btnAnswer4.BackColor = Color.MediumTurquoise;
                lblCategory.Text = GlobalVariable.categoryName;

                //obtain question
                OleDbCommand command = new OleDbCommand();
                command.Connection = conn;
                conn.Open();
                command.CommandText = "Select * from Questions inner join Category on Questions.CategoryId=Category.ID where CategoryName=@CategoryName";
                command.Parameters.AddWithValue("@CategoryName", GlobalVariable.categoryName);
                readerQ = command.ExecuteReader();
                DataTable dataTable = new DataTable();
                dataTable.Load(readerQ);
                conn.Close();
                Random random = new Random();
                int[] qId = new int[int.Parse(dataTable.Rows.Count.ToString())];
                int i = 0;
                while (i < dataTable.Rows.Count)
                {
                    qId[i] = int.Parse(dataTable.Rows[i]["Questions.Id"].ToString());
                    i++;
                }
                if (k < dataTable.Rows.Count - 1)
                {
                    int nextQ = random.Next(0, dataTable.Rows.Count);
                    bool alreadyShowed = true;
                    while (alreadyShowed)
                    {
                        alreadyShowed = false;
                        for (int j = 0; j < questionsIds.Length; j++)
                            if (questionsIds[j] == qId[nextQ] ) alreadyShowed = true;
                        if (alreadyShowed) nextQ = random.Next(dataTable.Rows.Count);
                    }
                    txtQuestion.Text = dataTable.Rows[nextQ]["QuestionText"].ToString();
                    int quesitonId = int.Parse(dataTable.Rows[nextQ]["Questions.Id"].ToString());
                    k++;
                    questionsIds[k] = quesitonId;
                    OleDbCommand cmd = new OleDbCommand();
                    cmd.Connection = conn;
                    conn.Open();
                    cmd.CommandText = "Select * from Answers inner join Questions on Answers.QuestionId=Questions.Id where Questions.Id=@QuestionId";
                    cmd.Parameters.AddWithValue("@QuestionId", quesitonId);
                    readerA = cmd.ExecuteReader();
                    DataTable datableAnswers = new DataTable();
                    datableAnswers.Load(readerA);
                    btnAnswer1.Text = datableAnswers.Rows[0]["AnswerText"].ToString();
                    btnAnswer2.Text = datableAnswers.Rows[1]["AnswerText"].ToString();
                    btnAnswer3.Text = datableAnswers.Rows[2]["AnswerText"].ToString();
                    btnAnswer4.Text = datableAnswers.Rows[3]["AnswerText"].ToString();
                    isCorrect = new String[] { datableAnswers.Rows[0]["isCorrect"].ToString(), datableAnswers.Rows[1]["isCorrect"].ToString(), datableAnswers.Rows[2]["isCorrect"].ToString(), datableAnswers.Rows[3]["isCorrect"].ToString() };
                    conn.Close();
                }
                else
                {
                    MessageBox.Show("No more questions available!");
                }
                quesitonsShowed++;
            }
            else
            {
                MessageBox.Show("You answerd at  " + lblCorrectAnswers.Text + "/" + GlobalVariable.NumberofQuestions);
                this.Dispose();
            }
        }

        private void QuizzTestForm_Load(object sender, EventArgs e)
        {
            quesitonsShowed = 1;
            int numbQuestions=int.Parse( GlobalVariable.NumberofQuestions);
            String category = GlobalVariable.categoryName;
            CorrectAnswers = 0;
            lblCorrectAnswers.Text=CorrectAnswers.ToString();
            try
            {
                lblCategory.Text = category;
                //obtain question
                OleDbCommand command = new OleDbCommand();
                command.Connection= conn;
                conn.Open();
                command.CommandText = "Select * from Questions inner join Category on Questions.CategoryId=Category.ID where CategoryName=@CategoryName";
                command.Parameters.AddWithValue("@CategoryName", category);
                readerQ = command.ExecuteReader();
                DataTable dataTable = new DataTable();
                dataTable.Load(readerQ);
                txtQuestion.Text = dataTable.Rows[0]["QuestionText"].ToString();
                conn.Close();
                int quesitonId = int.Parse(dataTable.Rows[0]["Questions.Id"].ToString());
                //obtain asnwers
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection= conn;
                conn.Open();
                cmd.CommandText = "Select * from Answers inner join Questions on Answers.QuestionId=Questions.Id where Questions.Id=@QuestionId";
                cmd.Parameters.AddWithValue("@QuestionId", quesitonId);
                readerA = cmd.ExecuteReader();
                questionsIds = new int[numbQuestions];
                questionsIds[0] = quesitonId;
                DataTable datableAnswers = new DataTable();
                datableAnswers.Load(readerA);
                btnAnswer1.Text = datableAnswers.Rows[0]["AnswerText"].ToString();
                btnAnswer2.Text = datableAnswers.Rows[1]["AnswerText"].ToString();
                btnAnswer3.Text = datableAnswers.Rows[2]["AnswerText"].ToString();
                btnAnswer4.Text = datableAnswers.Rows[3]["AnswerText"].ToString();

                 isCorrect = new String[]{ datableAnswers.Rows[0]["isCorrect"].ToString(), datableAnswers.Rows[1]["isCorrect"].ToString(), datableAnswers.Rows[2]["isCorrect"].ToString(), datableAnswers.Rows[3]["isCorrect"].ToString() };
                
                conn.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(" " + ex);
            }
        }
    }
}
