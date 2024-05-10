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
    public partial class AddQuestionForm : Form
    {
        public AddQuestionForm()
        {
            InitializeComponent();
            conn = new OleDbConnection();
            String conectionString = " Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Andre\\source\\repos\\QuizzApp\\QuizzApp\\QuizzDB.accdb;Persist Security Info=False;";
            conn.ConnectionString = conectionString;
        }
        OleDbConnection conn;
        OleDbDataReader reader;
        private void btnAddNewQuestion_Click(object sender, EventArgs e)
        {
            if(txtAnswer1.Text == "" || txtAnswer2.Text=="" || txtAnswer3.Text == "" || txtAnswer4.Text == "" || txtCategory.Text=="" ||txtQuestion.Text=="") 
            {
                MessageBox.Show("Complete all the boxes!");
            }
            else
            {
                try
                {
                    //verify if the category exists already
                    OleDbCommand command = new OleDbCommand();
                    conn.Open();
                    command.Connection = conn;
                    command.CommandText = "Select CategoryName from Category";
                    reader = command.ExecuteReader();
                    DataTable dataTable = new DataTable();
                    dataTable.Load(reader);
                    conn.Close();
                    bool categoryType = false;
                    for(int i=0;i<dataTable.Rows.Count;i++)
                    {
                        if (dataTable.Rows[i][0].ToString()==txtCategory.Text) { categoryType = true; break; }
                    }
                    if (categoryType == false)
                    {
                        OleDbCommand cmd = new OleDbCommand();
                        conn.Open();
                        cmd.Connection = conn;
                        cmd.CommandText = "Insert into Category(CategoryName) Values(@CategoryName)";
                        cmd.Parameters.AddWithValue("@CategoryName",txtCategory.Text);
                        cmd.ExecuteNonQuery();
                        conn.Close();
                    }
                    else
                    {
                        OleDbCommand cmdCategoryId = new OleDbCommand();
                        conn.Open();
                        cmdCategoryId.Connection = conn;
                        cmdCategoryId.CommandText = "Select Id from Category where CategoryName=@CategoryName";
                        cmdCategoryId.Parameters.AddWithValue("@CategoryName", txtCategory.Text);
                        reader= cmdCategoryId.ExecuteReader();
                        DataTable data = new DataTable();
                        data.Load(reader);
                        int catId =int.Parse( data.Rows[0][0].ToString());
                        conn.Close() ;

                        //insert Question
                        OleDbCommand cmdInsertQ= new OleDbCommand();
                        conn.Open();
                        cmdInsertQ.Connection = conn;
                        cmdInsertQ.CommandText = "Insert into Questions(CategoryId,QuestionText) Values(@CategoryId,@QuestionText)";
                        cmdInsertQ.Parameters.AddWithValue("@CategoryId", catId);
                        cmdInsertQ.Parameters.AddWithValue("@QuestionText", txtQuestion.Text);
                        cmdInsertQ.ExecuteNonQuery() ;
                        conn.Close();

                        OleDbCommand cmdQuestionId = new OleDbCommand();
                        conn.Open();
                        cmdQuestionId.Connection = conn;
                        cmdQuestionId.CommandText = "Select ID from Questions where QuestionText=@QuestionText";
                        cmdQuestionId.Parameters.AddWithValue("@QuestionText",txtQuestion.Text);
                        reader = cmdQuestionId.ExecuteReader();
                        DataTable dataC = new DataTable();
                        dataC.Load(reader);
                        int questionId = int.Parse(dataC.Rows[0][0].ToString());
                        conn.Close();
                        //insert answers
                        OleDbCommand cmdInsertAnsw1 = new OleDbCommand();
                        conn.Open();
                        cmdInsertAnsw1.Connection = conn;
                        cmdInsertAnsw1.CommandText = "Insert into Answers(QuestionId,AnswerText,isCorrect) Values(@QuestionId,@Answertext,@isCorrect)";
                        cmdInsertAnsw1.Parameters.AddWithValue("@QuestionId", questionId);
                        cmdInsertAnsw1.Parameters.AddWithValue("@Answertext", txtAnswer1.Text);
                       cmdInsertAnsw1.Parameters.AddWithValue("@isCorrect", rdbAnswer1.Checked);
                        cmdInsertAnsw1.ExecuteNonQuery();
                        conn.Close();

                        OleDbCommand cmdInsertAnsw2 = new OleDbCommand();
                        conn.Open();
                        cmdInsertAnsw2.Connection = conn;
                        cmdInsertAnsw2.CommandText = "Insert into Answers(QuestionId,AnswerText,isCorrect) Values(@QuestionId,@Answertext,@isCorrect)";
                        cmdInsertAnsw2.Parameters.AddWithValue("@QuestionId", questionId);
                        cmdInsertAnsw2.Parameters.AddWithValue("@Answertext", txtAnswer2.Text);
                        cmdInsertAnsw2.Parameters.AddWithValue("@isCorrect", rdbAnswer2.Checked);
                        cmdInsertAnsw2.ExecuteNonQuery();
                        conn.Close();

                        OleDbCommand cmdInsertAnsw3 = new OleDbCommand();
                        conn.Open();
                        cmdInsertAnsw3.Connection = conn;
                        cmdInsertAnsw3.CommandText = "Insert into Answers(QuestionId,AnswerText,isCorrect) Values(@QuestionId,@Answertext,@isCorrect)";
                        cmdInsertAnsw3.Parameters.AddWithValue("@QuestionId", questionId);
                        cmdInsertAnsw3.Parameters.AddWithValue("@Answertext", txtAnswer3.Text);
                        cmdInsertAnsw3.Parameters.AddWithValue("@isCorrect", rdbAnswer3.Checked);
                        cmdInsertAnsw3.ExecuteNonQuery();
                        conn.Close();

                        OleDbCommand cmdInsertAnsw4= new OleDbCommand();
                        conn.Open();
                        cmdInsertAnsw4.Connection = conn;
                        cmdInsertAnsw4.CommandText = "Insert into Answers(QuestionId,AnswerText,isCorrect) Values(@QuestionId,@Answertext,@isCorrect)";
                        cmdInsertAnsw4.Parameters.AddWithValue("@QuestionId", questionId);
                        cmdInsertAnsw4.Parameters.AddWithValue("@Answertext", txtAnswer4.Text);
                        cmdInsertAnsw4.Parameters.AddWithValue("@isCorrect", rdbAnswer4.Checked);
                        cmdInsertAnsw4.ExecuteNonQuery();
                        conn.Close();
                        MessageBox.Show("Question succefuly added!");
                    }
                }
                catch (Exception ex) 
                {
                    MessageBox.Show(" "+ ex);
                }
             }
        }
    }
}
