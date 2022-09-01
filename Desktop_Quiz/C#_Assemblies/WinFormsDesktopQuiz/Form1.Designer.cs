namespace WinFormsDesktopQuiz
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.btnStartQuiz = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.leaderBoardGrid = new System.Windows.Forms.DataGridView();
            this.lblQuizStatus = new System.Windows.Forms.Label();
            this.form1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.leaderBoardGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStartQuiz
            // 
            this.btnStartQuiz.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartQuiz.Location = new System.Drawing.Point(1042, 638);
            this.btnStartQuiz.Name = "btnStartQuiz";
            this.btnStartQuiz.Size = new System.Drawing.Size(137, 55);
            this.btnStartQuiz.TabIndex = 0;
            this.btnStartQuiz.Text = "Start Quiz";
            this.btnStartQuiz.UseVisualStyleBackColor = true;
            this.btnStartQuiz.Click += new System.EventHandler(this.btnStartQuiz_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(65, 638);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(137, 55);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnAdmin
            // 
            this.btnAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdmin.Location = new System.Drawing.Point(564, 638);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(137, 55);
            this.btnAdmin.TabIndex = 7;
            this.btnAdmin.Text = "View Content";
            this.btnAdmin.UseVisualStyleBackColor = true;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // leaderBoardGrid
            // 
            this.leaderBoardGrid.AllowUserToAddRows = false;
            this.leaderBoardGrid.AllowUserToDeleteRows = false;
            this.leaderBoardGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.leaderBoardGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.leaderBoardGrid.Location = new System.Drawing.Point(65, 116);
            this.leaderBoardGrid.MultiSelect = false;
            this.leaderBoardGrid.Name = "leaderBoardGrid";
            this.leaderBoardGrid.ReadOnly = true;
            this.leaderBoardGrid.Size = new System.Drawing.Size(1114, 339);
            this.leaderBoardGrid.TabIndex = 8;
            // 
            // lblQuizStatus
            // 
            this.lblQuizStatus.AutoSize = true;
            this.lblQuizStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuizStatus.Location = new System.Drawing.Point(464, 37);
            this.lblQuizStatus.Name = "lblQuizStatus";
            this.lblQuizStatus.Size = new System.Drawing.Size(199, 37);
            this.lblQuizStatus.TabIndex = 9;
            this.lblQuizStatus.Text = "Leaderboard";
            // 
            // form1BindingSource
            // 
            this.form1BindingSource.DataSource = typeof(WinFormsDesktopQuiz.Form1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1364, 730);
            this.Controls.Add(this.lblQuizStatus);
            this.Controls.Add(this.leaderBoardGrid);
            this.Controls.Add(this.btnAdmin);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnStartQuiz);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Practice Quiz";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.leaderBoardGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStartQuiz;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.BindingSource form1BindingSource;
        private System.Windows.Forms.DataGridView leaderBoardGrid;
        private System.Windows.Forms.Label lblQuizStatus;
    }
}

