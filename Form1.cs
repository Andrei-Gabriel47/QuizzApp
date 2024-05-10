using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizzApp
{
    public class GlobalVariable
    {
        public  static String NumberofQuestions { get; set; }
       public static String categoryName { get; set; }
    }

    public partial class homeForm : Form
    {
        public homeForm()
        {
            InitializeComponent();
            conn = new OleDbConnection();
            String conectionString = " Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Andre\\source\\repos\\QuizzApp\\QuizzApp\\QuizzDB.accdb;Persist Security Info=False;";
            conn.ConnectionString = conectionString;
        }
        OleDbConnection conn;
        OleDbDataReader reader;
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                OleDbCommand command = new OleDbCommand();
                conn.Open();
                command.Connection = conn;
                command.CommandText = "Select CategoryName from Category";
                reader = command.ExecuteReader();
                DataTable dataTable = new DataTable();
                dataTable.Load(reader);                
                for (int i = 0; i < dataTable.Rows.Count - 1; i++)
                    cmbCategory.Items.Add(dataTable.Rows[i][0].ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(" " + ex);
            }
        }
        private void btnAddQuestion_Click(object sender, EventArgs e)
        {
            addChildForm(new AddQuestionForm());
        }
        private void btnStartQuizz_Click(object sender, EventArgs e)
        {
            GlobalVariable.NumberofQuestions = txtNumberOfQuestions.Text;
            GlobalVariable.categoryName = cmbCategory.SelectedItem.ToString();
            if (GlobalVariable.NumberofQuestions == "" || GlobalVariable.categoryName == "") MessageBox.Show("Complete the category and number of questions!");
            else addChildForm(new QuizzTestForm());
        }
        Form activeForm = null;
        private void addChildForm(Form childForm)
        {
            if (activeForm != null) activeForm = null;
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnlGeneral.Controls.Add(childForm);
            childForm.BringToFront();
            childForm.Show();
        }
    }
}
