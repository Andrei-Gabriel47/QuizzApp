namespace QuizzApp
{
    partial class AddQuestionForm
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
            this.txtQuestion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCategory = new System.Windows.Forms.TextBox();
            this.rdbAnswer1 = new System.Windows.Forms.RadioButton();
            this.rdbAnswer2 = new System.Windows.Forms.RadioButton();
            this.rdbAnswer3 = new System.Windows.Forms.RadioButton();
            this.rdbAnswer4 = new System.Windows.Forms.RadioButton();
            this.txtAnswer1 = new System.Windows.Forms.TextBox();
            this.txtAnswer2 = new System.Windows.Forms.TextBox();
            this.txtAnswer3 = new System.Windows.Forms.TextBox();
            this.txtAnswer4 = new System.Windows.Forms.TextBox();
            this.btnAddNewQuestion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtQuestion
            // 
            this.txtQuestion.BackColor = System.Drawing.Color.Teal;
            this.txtQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuestion.Location = new System.Drawing.Point(45, 67);
            this.txtQuestion.Multiline = true;
            this.txtQuestion.Name = "txtQuestion";
            this.txtQuestion.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtQuestion.Size = new System.Drawing.Size(332, 114);
            this.txtQuestion.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = "Category :";
            // 
            // txtCategory
            // 
            this.txtCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCategory.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtCategory.Location = new System.Drawing.Point(181, 18);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtCategory.Size = new System.Drawing.Size(196, 30);
            this.txtCategory.TabIndex = 13;
            // 
            // rdbAnswer1
            // 
            this.rdbAnswer1.AutoSize = true;
            this.rdbAnswer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbAnswer1.Location = new System.Drawing.Point(24, 223);
            this.rdbAnswer1.Name = "rdbAnswer1";
            this.rdbAnswer1.Size = new System.Drawing.Size(95, 24);
            this.rdbAnswer1.TabIndex = 14;
            this.rdbAnswer1.TabStop = true;
            this.rdbAnswer1.Text = "Answer1";
            this.rdbAnswer1.UseVisualStyleBackColor = true;
            // 
            // rdbAnswer2
            // 
            this.rdbAnswer2.AutoSize = true;
            this.rdbAnswer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbAnswer2.Location = new System.Drawing.Point(24, 285);
            this.rdbAnswer2.Name = "rdbAnswer2";
            this.rdbAnswer2.Size = new System.Drawing.Size(95, 24);
            this.rdbAnswer2.TabIndex = 15;
            this.rdbAnswer2.TabStop = true;
            this.rdbAnswer2.Text = "Answer2";
            this.rdbAnswer2.UseVisualStyleBackColor = true;
            // 
            // rdbAnswer3
            // 
            this.rdbAnswer3.AutoSize = true;
            this.rdbAnswer3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbAnswer3.Location = new System.Drawing.Point(24, 347);
            this.rdbAnswer3.Name = "rdbAnswer3";
            this.rdbAnswer3.Size = new System.Drawing.Size(95, 24);
            this.rdbAnswer3.TabIndex = 16;
            this.rdbAnswer3.TabStop = true;
            this.rdbAnswer3.Text = "Answer3";
            this.rdbAnswer3.UseVisualStyleBackColor = true;
            // 
            // rdbAnswer4
            // 
            this.rdbAnswer4.AutoSize = true;
            this.rdbAnswer4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbAnswer4.Location = new System.Drawing.Point(24, 407);
            this.rdbAnswer4.Name = "rdbAnswer4";
            this.rdbAnswer4.Size = new System.Drawing.Size(95, 24);
            this.rdbAnswer4.TabIndex = 17;
            this.rdbAnswer4.TabStop = true;
            this.rdbAnswer4.Text = "Answer4";
            this.rdbAnswer4.UseVisualStyleBackColor = true;
            // 
            // txtAnswer1
            // 
            this.txtAnswer1.BackColor = System.Drawing.Color.Teal;
            this.txtAnswer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnswer1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtAnswer1.Location = new System.Drawing.Point(148, 223);
            this.txtAnswer1.Name = "txtAnswer1";
            this.txtAnswer1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtAnswer1.Size = new System.Drawing.Size(257, 30);
            this.txtAnswer1.TabIndex = 18;
            // 
            // txtAnswer2
            // 
            this.txtAnswer2.BackColor = System.Drawing.Color.Teal;
            this.txtAnswer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnswer2.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtAnswer2.Location = new System.Drawing.Point(148, 285);
            this.txtAnswer2.Name = "txtAnswer2";
            this.txtAnswer2.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtAnswer2.Size = new System.Drawing.Size(257, 30);
            this.txtAnswer2.TabIndex = 19;
            // 
            // txtAnswer3
            // 
            this.txtAnswer3.BackColor = System.Drawing.Color.Teal;
            this.txtAnswer3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnswer3.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtAnswer3.Location = new System.Drawing.Point(148, 342);
            this.txtAnswer3.Name = "txtAnswer3";
            this.txtAnswer3.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtAnswer3.Size = new System.Drawing.Size(257, 30);
            this.txtAnswer3.TabIndex = 20;
            // 
            // txtAnswer4
            // 
            this.txtAnswer4.BackColor = System.Drawing.Color.Teal;
            this.txtAnswer4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnswer4.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtAnswer4.Location = new System.Drawing.Point(148, 401);
            this.txtAnswer4.Name = "txtAnswer4";
            this.txtAnswer4.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtAnswer4.Size = new System.Drawing.Size(257, 30);
            this.txtAnswer4.TabIndex = 21;
            // 
            // btnAddNewQuestion
            // 
            this.btnAddNewQuestion.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnAddNewQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewQuestion.Location = new System.Drawing.Point(43, 453);
            this.btnAddNewQuestion.Name = "btnAddNewQuestion";
            this.btnAddNewQuestion.Size = new System.Drawing.Size(334, 38);
            this.btnAddNewQuestion.TabIndex = 22;
            this.btnAddNewQuestion.Text = "Add Question";
            this.btnAddNewQuestion.UseVisualStyleBackColor = false;
            this.btnAddNewQuestion.Click += new System.EventHandler(this.btnAddNewQuestion_Click);
            // 
            // AddQuestionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(432, 503);
            this.Controls.Add(this.btnAddNewQuestion);
            this.Controls.Add(this.txtAnswer4);
            this.Controls.Add(this.txtAnswer3);
            this.Controls.Add(this.txtAnswer2);
            this.Controls.Add(this.txtAnswer1);
            this.Controls.Add(this.rdbAnswer4);
            this.Controls.Add(this.rdbAnswer3);
            this.Controls.Add(this.rdbAnswer2);
            this.Controls.Add(this.rdbAnswer1);
            this.Controls.Add(this.txtCategory);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtQuestion);
            this.Name = "AddQuestionForm";
            this.Text = "AddQuestionForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtQuestion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCategory;
        private System.Windows.Forms.RadioButton rdbAnswer1;
        private System.Windows.Forms.RadioButton rdbAnswer2;
        private System.Windows.Forms.RadioButton rdbAnswer3;
        private System.Windows.Forms.RadioButton rdbAnswer4;
        private System.Windows.Forms.TextBox txtAnswer1;
        private System.Windows.Forms.TextBox txtAnswer2;
        private System.Windows.Forms.TextBox txtAnswer3;
        private System.Windows.Forms.TextBox txtAnswer4;
        private System.Windows.Forms.Button btnAddNewQuestion;
    }
}