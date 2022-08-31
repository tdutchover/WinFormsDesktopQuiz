namespace WinFormsDesktopQuiz
{
    partial class QuizForm
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
            this.lblQuizStatus = new System.Windows.Forms.Label();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.radioBtn_AnswerCandidate1 = new System.Windows.Forms.RadioButton();
            this.groupBoxAnswers = new System.Windows.Forms.GroupBox();
            this.lblWrongAnswer = new System.Windows.Forms.Label();
            this.radioBtn_AnswerCandidate4 = new System.Windows.Forms.RadioButton();
            this.lblCorrectAnswer = new System.Windows.Forms.Label();
            this.radioBtn_AnswerCandidate3 = new System.Windows.Forms.RadioButton();
            this.radioBtn_AnswerCandidate2 = new System.Windows.Forms.RadioButton();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnAbort = new System.Windows.Forms.Button();
            this.lblScoreStatus = new System.Windows.Forms.Label();
            this.btnSubmitAnswer = new System.Windows.Forms.Button();
            this.lblResponseToSelectedAnswer = new System.Windows.Forms.Label();
            this.groupBoxAnswers.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblQuizStatus
            // 
            this.lblQuizStatus.AutoSize = true;
            this.lblQuizStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuizStatus.Location = new System.Drawing.Point(42, 23);
            this.lblQuizStatus.Name = "lblQuizStatus";
            this.lblQuizStatus.Size = new System.Drawing.Size(132, 22);
            this.lblQuizStatus.TabIndex = 0;
            this.lblQuizStatus.Text = "Question # of #";
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion.Location = new System.Drawing.Point(271, 23);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(167, 22);
            this.lblQuestion.TabIndex = 1;
            this.lblQuestion.Text = "Question goes here";
            // 
            // radioBtn_AnswerCandidate1
            // 
            this.radioBtn_AnswerCandidate1.AutoSize = true;
            this.radioBtn_AnswerCandidate1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtn_AnswerCandidate1.Location = new System.Drawing.Point(43, 44);
            this.radioBtn_AnswerCandidate1.Name = "radioBtn_AnswerCandidate1";
            this.radioBtn_AnswerCandidate1.Size = new System.Drawing.Size(157, 22);
            this.radioBtn_AnswerCandidate1.TabIndex = 2;
            this.radioBtn_AnswerCandidate1.TabStop = true;
            this.radioBtn_AnswerCandidate1.Text = "Candidate Answer 1";
            this.radioBtn_AnswerCandidate1.UseVisualStyleBackColor = true;
            this.radioBtn_AnswerCandidate1.Click += new System.EventHandler(this.radioBtn_AnswerCandidate1_Click);
            // 
            // groupBoxAnswers
            // 
            this.groupBoxAnswers.Controls.Add(this.lblWrongAnswer);
            this.groupBoxAnswers.Controls.Add(this.radioBtn_AnswerCandidate4);
            this.groupBoxAnswers.Controls.Add(this.lblCorrectAnswer);
            this.groupBoxAnswers.Controls.Add(this.radioBtn_AnswerCandidate3);
            this.groupBoxAnswers.Controls.Add(this.radioBtn_AnswerCandidate2);
            this.groupBoxAnswers.Controls.Add(this.radioBtn_AnswerCandidate1);
            this.groupBoxAnswers.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxAnswers.Location = new System.Drawing.Point(275, 121);
            this.groupBoxAnswers.Name = "groupBoxAnswers";
            this.groupBoxAnswers.Size = new System.Drawing.Size(855, 357);
            this.groupBoxAnswers.TabIndex = 3;
            this.groupBoxAnswers.TabStop = false;
            this.groupBoxAnswers.Text = "Choose Answer";
            // 
            // lblWrongAnswer
            // 
            this.lblWrongAnswer.AutoSize = true;
            this.lblWrongAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWrongAnswer.Location = new System.Drawing.Point(577, 252);
            this.lblWrongAnswer.Name = "lblWrongAnswer";
            this.lblWrongAnswer.Size = new System.Drawing.Size(151, 18);
            this.lblWrongAnswer.TabIndex = 10;
            this.lblWrongAnswer.Text = "Incorrect Answer Text";
            // 
            // radioBtn_AnswerCandidate4
            // 
            this.radioBtn_AnswerCandidate4.AutoSize = true;
            this.radioBtn_AnswerCandidate4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtn_AnswerCandidate4.Location = new System.Drawing.Point(43, 267);
            this.radioBtn_AnswerCandidate4.Name = "radioBtn_AnswerCandidate4";
            this.radioBtn_AnswerCandidate4.Size = new System.Drawing.Size(157, 22);
            this.radioBtn_AnswerCandidate4.TabIndex = 5;
            this.radioBtn_AnswerCandidate4.TabStop = true;
            this.radioBtn_AnswerCandidate4.Text = "Candidate Answer 4";
            this.radioBtn_AnswerCandidate4.UseVisualStyleBackColor = true;
            this.radioBtn_AnswerCandidate4.Click += new System.EventHandler(this.radioBtn_AnswerCandidate4_Click);
            // 
            // lblCorrectAnswer
            // 
            this.lblCorrectAnswer.AutoSize = true;
            this.lblCorrectAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorrectAnswer.Location = new System.Drawing.Point(577, 175);
            this.lblCorrectAnswer.Name = "lblCorrectAnswer";
            this.lblCorrectAnswer.Size = new System.Drawing.Size(143, 18);
            this.lblCorrectAnswer.TabIndex = 9;
            this.lblCorrectAnswer.Text = "Correct Answer Text";
            // 
            // radioBtn_AnswerCandidate3
            // 
            this.radioBtn_AnswerCandidate3.AutoSize = true;
            this.radioBtn_AnswerCandidate3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtn_AnswerCandidate3.Location = new System.Drawing.Point(43, 189);
            this.radioBtn_AnswerCandidate3.Name = "radioBtn_AnswerCandidate3";
            this.radioBtn_AnswerCandidate3.Size = new System.Drawing.Size(157, 22);
            this.radioBtn_AnswerCandidate3.TabIndex = 4;
            this.radioBtn_AnswerCandidate3.TabStop = true;
            this.radioBtn_AnswerCandidate3.Text = "Candidate Answer 3";
            this.radioBtn_AnswerCandidate3.UseVisualStyleBackColor = true;
            this.radioBtn_AnswerCandidate3.Click += new System.EventHandler(this.radioBtn_AnswerCandidate3_Click);
            // 
            // radioBtn_AnswerCandidate2
            // 
            this.radioBtn_AnswerCandidate2.AutoSize = true;
            this.radioBtn_AnswerCandidate2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtn_AnswerCandidate2.Location = new System.Drawing.Point(43, 115);
            this.radioBtn_AnswerCandidate2.Name = "radioBtn_AnswerCandidate2";
            this.radioBtn_AnswerCandidate2.Size = new System.Drawing.Size(157, 22);
            this.radioBtn_AnswerCandidate2.TabIndex = 3;
            this.radioBtn_AnswerCandidate2.TabStop = true;
            this.radioBtn_AnswerCandidate2.Text = "Candidate Answer 2";
            this.radioBtn_AnswerCandidate2.UseVisualStyleBackColor = true;
            this.radioBtn_AnswerCandidate2.Click += new System.EventHandler(this.radioBtn_AnswerCandidate2_Click);
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(1115, 638);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(137, 55);
            this.btnNext.TabIndex = 4;
            this.btnNext.Text = "Next Question";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnAbort
            // 
            this.btnAbort.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbort.Location = new System.Drawing.Point(46, 638);
            this.btnAbort.Name = "btnAbort";
            this.btnAbort.Size = new System.Drawing.Size(137, 55);
            this.btnAbort.TabIndex = 5;
            this.btnAbort.Text = "Abort Quiz";
            this.btnAbort.UseVisualStyleBackColor = true;
            this.btnAbort.Click += new System.EventHandler(this.btnAbort_Click);
            // 
            // lblScoreStatus
            // 
            this.lblScoreStatus.AutoSize = true;
            this.lblScoreStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScoreStatus.Location = new System.Drawing.Point(42, 73);
            this.lblScoreStatus.Name = "lblScoreStatus";
            this.lblScoreStatus.Size = new System.Drawing.Size(158, 22);
            this.lblScoreStatus.TabIndex = 6;
            this.lblScoreStatus.Text = "# Correct Answers";
            // 
            // btnSubmitAnswer
            // 
            this.btnSubmitAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmitAnswer.Location = new System.Drawing.Point(539, 638);
            this.btnSubmitAnswer.Name = "btnSubmitAnswer";
            this.btnSubmitAnswer.Size = new System.Drawing.Size(146, 55);
            this.btnSubmitAnswer.TabIndex = 7;
            this.btnSubmitAnswer.Text = "Submit Answer";
            this.btnSubmitAnswer.UseVisualStyleBackColor = true;
            this.btnSubmitAnswer.Click += new System.EventHandler(this.btnSubmitAnswer_Click);
            // 
            // lblResponseToSelectedAnswer
            // 
            this.lblResponseToSelectedAnswer.AutoSize = true;
            this.lblResponseToSelectedAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResponseToSelectedAnswer.Location = new System.Drawing.Point(271, 511);
            this.lblResponseToSelectedAnswer.Name = "lblResponseToSelectedAnswer";
            this.lblResponseToSelectedAnswer.Size = new System.Drawing.Size(250, 22);
            this.lblResponseToSelectedAnswer.TabIndex = 8;
            this.lblResponseToSelectedAnswer.Text = "Response to answer selection";
            // 
            // QuizForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1364, 730);
            this.Controls.Add(this.lblResponseToSelectedAnswer);
            this.Controls.Add(this.btnSubmitAnswer);
            this.Controls.Add(this.lblScoreStatus);
            this.Controls.Add(this.btnAbort);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.groupBoxAnswers);
            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.lblQuizStatus);
            this.Name = "QuizForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quiz In Progress";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.QuizForm_FormClosing);
            this.Load += new System.EventHandler(this.QuizForm_Load);
            this.groupBoxAnswers.ResumeLayout(false);
            this.groupBoxAnswers.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQuizStatus;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.RadioButton radioBtn_AnswerCandidate1;
        private System.Windows.Forms.GroupBox groupBoxAnswers;
        private System.Windows.Forms.RadioButton radioBtn_AnswerCandidate4;
        private System.Windows.Forms.RadioButton radioBtn_AnswerCandidate3;
        private System.Windows.Forms.RadioButton radioBtn_AnswerCandidate2;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnAbort;
        private System.Windows.Forms.Label lblScoreStatus;
        private System.Windows.Forms.Button btnSubmitAnswer;
        private System.Windows.Forms.Label lblResponseToSelectedAnswer;
        private System.Windows.Forms.Label lblCorrectAnswer;
        private System.Windows.Forms.Label lblWrongAnswer;
    }
}