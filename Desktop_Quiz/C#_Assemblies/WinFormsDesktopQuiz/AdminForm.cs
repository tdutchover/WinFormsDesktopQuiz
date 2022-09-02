using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsDesktopQuiz
{
    public partial class AdminForm : Form
    {
        private Form1 _parentForm;
        private QuizRepository _quizRespository;
        public AdminForm(Form1 parentForm, QuizRepository quizRespository)
        {
            InitializeComponent();
            this._parentForm = parentForm;
            this._quizRespository = quizRespository;
        }
        private void Admin_Load(object sender, EventArgs e)
        {
            var questions = _quizRespository.GetAllQuestionRecords();
            questionGrid.DataSource = questions;
            AdjustQuestionGridUserInterface();
            DisplayAnswersGridContent();
        }
        private void questionGrid_DoubleClick(object sender, EventArgs e)
        {
            DisplayAnswersGridContent();
            //DisplayAnswers(questionId);   //TODO Delete test code. Don't need to display answers in text box
        }
        private void DisplayAnswersGridContent()
        {
            var questionId = (int)questionGrid.CurrentRow.Cells[0].Value;
            answerGrid.DataSource = _quizRespository.FindDTOAnswersForQuestion(questionId);
            AdjustAnswerGridUI();
            answerGrid.ClearSelection();
        }

        /// <summary>
        /// Only invoke this after first populating the grid so the column UI can be changed
        /// </summary>
        private void AdjustQuestionGridUserInterface()
        {
            // Rename the "QuestionId" column header because we don't want that database column name.
            int questionIdColumnIndex = 0;
            DataGridViewColumn questionIdColumn = questionGrid.Columns[questionIdColumnIndex];
            questionIdColumn.HeaderText = "Question Id";

            // We don't rename the "Description" column header text because we like it as is.

            // Hide the 3rd column that data field Question.QuestionAnswers would cause to display.
            // The columns are 0-based.
            int questionAnswerColumnIndex = 2;
            DataGridViewColumn questionAnswerColumn = questionGrid.Columns[questionAnswerColumnIndex];
            questionAnswerColumn.Visible = false;
        }
        private void AdjustAnswerGridUI()
        {
            // Rename the "QuestionId" column header because we don't want that database column name.
            int answerDescriptionColumnIndex = 0;
            DataGridViewColumn answerDescriptionColumn = answerGrid.Columns[answerDescriptionColumnIndex];
            answerDescriptionColumn.HeaderText = "Answer Description";

            // We don't rename the "Description" column header text because we like it as is.

            // Hide the 3rd column that data field Question.QuestionAnswers would cause to display.
            // The columns are 0-based.
            int isCorrectAnswerColumnIndex = 1;
            DataGridViewColumn isCorrectAnswerColumn = answerGrid.Columns[isCorrectAnswerColumnIndex];
            isCorrectAnswerColumn.HeaderText = "Correct Answer is Checked";
        }
        private void AdminForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // This is a child form that I can't close the app from without causing problems.
            // So only allow navigation back to the parent landing page when a user attempts to close
            // this form in any way. Some ways the user can attempt to close this form are:
            //    1. ALT+F4
            //    2. the Close menu item.
            //    2. the x on the upper right of the window.
            // All will cause this event which we use to navigate back to the parent landing page.
            NavigationUtils.NavigateToLandingPage(this._parentForm, this);
        }
        private void btnGoToLeaderBoard_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
