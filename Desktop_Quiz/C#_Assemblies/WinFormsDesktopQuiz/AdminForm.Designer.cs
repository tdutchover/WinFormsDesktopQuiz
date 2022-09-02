namespace WinFormsDesktopQuiz
{
    partial class AdminForm
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
            this.questionGrid = new System.Windows.Forms.DataGridView();
            this.answerGrid = new System.Windows.Forms.DataGridView();
            this.btnGoToLeaderBoard = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblQuestions = new System.Windows.Forms.Label();
            this.lblAnswers = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.questionGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.answerGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // questionGrid
            // 
            this.questionGrid.AllowUserToAddRows = false;
            this.questionGrid.AllowUserToDeleteRows = false;
            this.questionGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.questionGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.questionGrid.Location = new System.Drawing.Point(69, 189);
            this.questionGrid.Name = "questionGrid";
            this.questionGrid.ReadOnly = true;
            this.questionGrid.Size = new System.Drawing.Size(1085, 194);
            this.questionGrid.TabIndex = 3;
            this.questionGrid.DoubleClick += new System.EventHandler(this.questionGrid_DoubleClick);
            // 
            // answerGrid
            // 
            this.answerGrid.AllowUserToAddRows = false;
            this.answerGrid.AllowUserToDeleteRows = false;
            this.answerGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.answerGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.answerGrid.Location = new System.Drawing.Point(69, 486);
            this.answerGrid.Name = "answerGrid";
            this.answerGrid.ReadOnly = true;
            this.answerGrid.Size = new System.Drawing.Size(1085, 109);
            this.answerGrid.TabIndex = 5;
            // 
            // btnGoToLeaderBoard
            // 
            this.btnGoToLeaderBoard.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGoToLeaderBoard.Location = new System.Drawing.Point(564, 638);
            this.btnGoToLeaderBoard.Name = "btnGoToLeaderBoard";
            this.btnGoToLeaderBoard.Size = new System.Drawing.Size(137, 55);
            this.btnGoToLeaderBoard.TabIndex = 8;
            this.btnGoToLeaderBoard.Text = "Leaderboard";
            this.btnGoToLeaderBoard.UseVisualStyleBackColor = true;
            this.btnGoToLeaderBoard.Click += new System.EventHandler(this.btnGoToLeaderBoard_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(419, 89);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(325, 29);
            this.lblTitle.TabIndex = 10;
            this.lblTitle.Text = "View Questions and Answers";
            // 
            // lblQuestions
            // 
            this.lblQuestions.AutoSize = true;
            this.lblQuestions.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestions.Location = new System.Drawing.Point(65, 159);
            this.lblQuestions.Name = "lblQuestions";
            this.lblQuestions.Size = new System.Drawing.Size(91, 22);
            this.lblQuestions.TabIndex = 11;
            this.lblQuestions.Text = "Questions";
            // 
            // lblAnswers
            // 
            this.lblAnswers.AutoSize = true;
            this.lblAnswers.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnswers.Location = new System.Drawing.Point(65, 456);
            this.lblAnswers.Name = "lblAnswers";
            this.lblAnswers.Size = new System.Drawing.Size(79, 22);
            this.lblAnswers.TabIndex = 12;
            this.lblAnswers.Text = "Answers";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 37);
            this.label1.TabIndex = 13;
            this.label1.Text = "Learning Center";
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 730);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblAnswers);
            this.Controls.Add(this.lblQuestions);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnGoToLeaderBoard);
            this.Controls.Add(this.answerGrid);
            this.Controls.Add(this.questionGrid);
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Learning Center - View Questions and Answers";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdminForm_FormClosing);
            this.Load += new System.EventHandler(this.Admin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.questionGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.answerGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView questionGrid;
        private System.Windows.Forms.DataGridView answerGrid;
        private System.Windows.Forms.Button btnGoToLeaderBoard;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblQuestions;
        private System.Windows.Forms.Label lblAnswers;
        private System.Windows.Forms.Label label1;
    }
}