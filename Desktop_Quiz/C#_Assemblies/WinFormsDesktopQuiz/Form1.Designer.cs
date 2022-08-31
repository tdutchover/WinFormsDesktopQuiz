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
            this.btnStartQuiz = new System.Windows.Forms.Button();
            this.txtSqlResults = new System.Windows.Forms.TextBox();
            this.questionGrid = new System.Windows.Forms.DataGridView();
            this.answerGrid = new System.Windows.Forms.DataGridView();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAdmin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.questionGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.answerGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStartQuiz
            // 
            this.btnStartQuiz.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartQuiz.Location = new System.Drawing.Point(526, 647);
            this.btnStartQuiz.Name = "btnStartQuiz";
            this.btnStartQuiz.Size = new System.Drawing.Size(137, 55);
            this.btnStartQuiz.TabIndex = 0;
            this.btnStartQuiz.Text = "Start Quiz";
            this.btnStartQuiz.UseVisualStyleBackColor = true;
            this.btnStartQuiz.Click += new System.EventHandler(this.btnStartQuiz_Click);
            // 
            // txtSqlResults
            // 
            this.txtSqlResults.Location = new System.Drawing.Point(0, 251);
            this.txtSqlResults.Multiline = true;
            this.txtSqlResults.Name = "txtSqlResults";
            this.txtSqlResults.Size = new System.Drawing.Size(1135, 172);
            this.txtSqlResults.TabIndex = 1;
            // 
            // questionGrid
            // 
            this.questionGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.questionGrid.Location = new System.Drawing.Point(0, 0);
            this.questionGrid.Name = "questionGrid";
            this.questionGrid.Size = new System.Drawing.Size(1085, 245);
            this.questionGrid.TabIndex = 2;
            this.questionGrid.DoubleClick += new System.EventHandler(this.questionGrid_DoubleClick);
            // 
            // answerGrid
            // 
            this.answerGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.answerGrid.Location = new System.Drawing.Point(0, 439);
            this.answerGrid.Name = "answerGrid";
            this.answerGrid.Size = new System.Drawing.Size(1085, 168);
            this.answerGrid.TabIndex = 4;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(28, 647);
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
            this.btnAdmin.Location = new System.Drawing.Point(267, 647);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(137, 55);
            this.btnAdmin.TabIndex = 7;
            this.btnAdmin.Text = "Admin";
            this.btnAdmin.UseVisualStyleBackColor = true;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1364, 730);
            this.Controls.Add(this.btnAdmin);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.answerGrid);
            this.Controls.Add(this.questionGrid);
            this.Controls.Add(this.txtSqlResults);
            this.Controls.Add(this.btnStartQuiz);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.questionGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.answerGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStartQuiz;
        private System.Windows.Forms.TextBox txtSqlResults;
        private System.Windows.Forms.DataGridView questionGrid;
        private System.Windows.Forms.DataGridView answerGrid;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnAdmin;
    }
}

