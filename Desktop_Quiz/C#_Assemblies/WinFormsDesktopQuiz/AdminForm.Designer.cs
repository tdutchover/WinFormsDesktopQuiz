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
            this.txtSqlResults = new System.Windows.Forms.TextBox();
            this.answerGrid = new System.Windows.Forms.DataGridView();
            this.btnGoToLeaderBoard = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.questionGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.answerGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // questionGrid
            // 
            this.questionGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.questionGrid.Location = new System.Drawing.Point(25, 25);
            this.questionGrid.Name = "questionGrid";
            this.questionGrid.Size = new System.Drawing.Size(1085, 176);
            this.questionGrid.TabIndex = 3;
            this.questionGrid.DoubleClick += new System.EventHandler(this.questionGrid_DoubleClick);
            // 
            // txtSqlResults
            // 
            this.txtSqlResults.Location = new System.Drawing.Point(25, 218);
            this.txtSqlResults.Multiline = true;
            this.txtSqlResults.Name = "txtSqlResults";
            this.txtSqlResults.Size = new System.Drawing.Size(1135, 139);
            this.txtSqlResults.TabIndex = 4;
            // 
            // answerGrid
            // 
            this.answerGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.answerGrid.Location = new System.Drawing.Point(25, 364);
            this.answerGrid.Name = "answerGrid";
            this.answerGrid.Size = new System.Drawing.Size(1085, 123);
            this.answerGrid.TabIndex = 5;
            // 
            // btnGoToLeaderBoard
            // 
            this.btnGoToLeaderBoard.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGoToLeaderBoard.Location = new System.Drawing.Point(475, 634);
            this.btnGoToLeaderBoard.Name = "btnGoToLeaderBoard";
            this.btnGoToLeaderBoard.Size = new System.Drawing.Size(137, 55);
            this.btnGoToLeaderBoard.TabIndex = 8;
            this.btnGoToLeaderBoard.Text = "Leaderboard";
            this.btnGoToLeaderBoard.UseVisualStyleBackColor = true;
            this.btnGoToLeaderBoard.Click += new System.EventHandler(this.btnGoToLeaderBoard_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1364, 730);
            this.Controls.Add(this.btnGoToLeaderBoard);
            this.Controls.Add(this.answerGrid);
            this.Controls.Add(this.txtSqlResults);
            this.Controls.Add(this.questionGrid);
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdminForm_FormClosing);
            this.Load += new System.EventHandler(this.Admin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.questionGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.answerGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView questionGrid;
        private System.Windows.Forms.TextBox txtSqlResults;
        private System.Windows.Forms.DataGridView answerGrid;
        private System.Windows.Forms.Button btnGoToLeaderBoard;
    }
}