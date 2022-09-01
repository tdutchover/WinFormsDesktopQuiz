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
        }
        private void questionGrid_DoubleClick(object sender, EventArgs e)
        {
            var questionId = (int)questionGrid.CurrentRow.Cells[0].Value;
            DisplayAnswers(questionId);
            answerGrid.DataSource = _quizRespository.FindAnswersGlob(questionId);
        }
        private void DisplayAnswers(int questionId)
        {
            StringBuilder sb = new StringBuilder();

            List<string> answerList = _quizRespository.FindAnswersAsStringList(questionId);
            foreach (var answer in answerList)
            {
                sb.AppendLine(answer);
            }

            txtSqlResults.Clear();
            txtSqlResults.Text = sb.ToString();
        }
        // TODO Delete old
        // Prototype to display _questions and answers from DB
        //private void DisplayQuestionAndAnswersInTextBox()
        //{
        //    StringBuilder sb = new StringBuilder();
        //    var qaResult = _quizRespository.GetAllQuestionAnswerRecords();

        //    foreach (var qa in qaResult)
        //    {
        //        sb.AppendLine($"QuestionId: {qa.QuestionId}, Question.Description: {qa.Question.Description}, AnswerId: {qa.AnswerId}, Answer.Description: {qa.Answer.Description}\n");
        //    }

        //    txtSqlResults.Clear();
        //    txtSqlResults.Text = sb.ToString();
        //}
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
