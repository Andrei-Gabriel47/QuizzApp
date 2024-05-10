namespace QuizzApp
{
    partial class homeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.btnStartQuizz = new System.Windows.Forms.Button();
            this.btnAddQuestion = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNumberOfQuestions = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlGeneral = new System.Windows.Forms.Panel();
            this.pnlGeneral.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(118, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quizz Time";
            // 
            // cmbCategory
            // 
            this.cmbCategory.BackColor = System.Drawing.SystemColors.HotTrack;
            this.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(112, 153);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(184, 33);
            this.cmbCategory.TabIndex = 1;
            // 
            // btnStartQuizz
            // 
            this.btnStartQuizz.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnStartQuizz.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartQuizz.Location = new System.Drawing.Point(32, 352);
            this.btnStartQuizz.Name = "btnStartQuizz";
            this.btnStartQuizz.Size = new System.Drawing.Size(139, 78);
            this.btnStartQuizz.TabIndex = 2;
            this.btnStartQuizz.Text = "Start Quizz";
            this.btnStartQuizz.UseVisualStyleBackColor = false;
            this.btnStartQuizz.Click += new System.EventHandler(this.btnStartQuizz_Click);
            // 
            // btnAddQuestion
            // 
            this.btnAddQuestion.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnAddQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddQuestion.Location = new System.Drawing.Point(225, 352);
            this.btnAddQuestion.Name = "btnAddQuestion";
            this.btnAddQuestion.Size = new System.Drawing.Size(153, 78);
            this.btnAddQuestion.TabIndex = 3;
            this.btnAddQuestion.Text = "Add Question";
            this.btnAddQuestion.UseVisualStyleBackColor = false;
            this.btnAddQuestion.Click += new System.EventHandler(this.btnAddQuestion_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 248);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(294, 32);
            this.label2.TabIndex = 4;
            this.label2.Text = "Number of questions";
            // 
            // txtNumberOfQuestions
            // 
            this.txtNumberOfQuestions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumberOfQuestions.Location = new System.Drawing.Point(331, 251);
            this.txtNumberOfQuestions.Name = "txtNumberOfQuestions";
            this.txtNumberOfQuestions.Size = new System.Drawing.Size(82, 30);
            this.txtNumberOfQuestions.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(450, 575);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(448, 493);
            this.panel1.TabIndex = 6;
            // 
            // pnlGeneral
            // 
            this.pnlGeneral.BackColor = System.Drawing.Color.Turquoise;
            this.pnlGeneral.Controls.Add(this.label1);
            this.pnlGeneral.Controls.Add(this.cmbCategory);
            this.pnlGeneral.Controls.Add(this.txtNumberOfQuestions);
            this.pnlGeneral.Controls.Add(this.btnStartQuizz);
            this.pnlGeneral.Controls.Add(this.label2);
            this.pnlGeneral.Controls.Add(this.btnAddQuestion);
            this.pnlGeneral.Location = new System.Drawing.Point(5, 3);
            this.pnlGeneral.Name = "pnlGeneral";
            this.pnlGeneral.Size = new System.Drawing.Size(435, 530);
            this.pnlGeneral.TabIndex = 7;
            // 
            // homeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(446, 539);
            this.Controls.Add(this.pnlGeneral);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "homeForm";
            this.Text = "Quizz App( .Net )";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlGeneral.ResumeLayout(false);
            this.pnlGeneral.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Button btnStartQuizz;
        private System.Windows.Forms.Button btnAddQuestion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNumberOfQuestions;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlGeneral;
    }
}

