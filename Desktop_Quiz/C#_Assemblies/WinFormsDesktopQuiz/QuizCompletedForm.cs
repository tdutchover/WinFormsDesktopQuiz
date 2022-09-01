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
    public partial class QuizCompletedForm : Form
    {
        private Form1 _landingPageForm;
        private QuizRepository _quizRespository;
        private int _correctAnswerCount;
        public QuizCompletedForm(Form1 landingPageForm, QuizRepository quizRespository, int correctAnswerCount)
        {
            InitializeComponent();
            _landingPageForm = landingPageForm;
            _quizRespository = quizRespository;
            _correctAnswerCount = correctAnswerCount;
        }
        private void QuizCompletedForm_Load(object sender, EventArgs e)
        {
            lblScoreStatus.Text = $"{_correctAnswerCount} correct answers";
        }
        private void QuizCompletedForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Score score = new Score();
            score.CorrectAnswerCount = _correctAnswerCount;

            if (txtCallSign.Text.Length > 0)
            {
                score.CallSign = txtCallSign.Text;
            }

            _quizRespository.AddScoreRecord(score);

            // We navigate back to the landing page during the closing event because there are several ways to close the form
            // and we must handle any way of closing this quiz session by navigating back to the landing page.
            NavigationUtils.NavigateToLandingPage(this._landingPageForm, this);
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            // We no longer need this form. We can count on the FormClosing handler saves the score to the database
            this.Close();
        }
    }
}
