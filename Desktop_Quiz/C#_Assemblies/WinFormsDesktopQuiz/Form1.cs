using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsDesktopQuiz
{
    public partial class Form1 : Form
    {
        private QuizRepository quizRespository;
        private QuizForm _quizForm;
        private AdminForm _adminForm;
        private NavigatedFrom navigatedFrom = NavigatedFrom.ApplicationStartup;

        public Form1()
        {
            InitializeComponent();
            quizRespository = new QuizRepository();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            DisplayLeaderboardContent();
            DataGridViewColumn columnScoreId = leaderBoardGrid.Columns[0];
            columnScoreId.Visible = false;

            DataGridViewColumn columnCallSign = leaderBoardGrid.Columns[1];
            columnCallSign.Width = 500;
            columnCallSign.HeaderText = "Call Sign";

            DataGridViewColumn columnQuizScore = leaderBoardGrid.Columns[2];
            columnQuizScore.Width = 500;
            columnQuizScore.HeaderText = "Quiz Score";

        }
        private void btnStartQuiz_Click(object sender, EventArgs e)
        {
            //DisplayQuestionAndAnswersInTextBox();     // TODO: Move prototype to admin page

            // When control returns to this landing page, we'll know it returned
            // from a quiz session.
            navigatedFrom = NavigatedFrom.QuizFormSession;

            _quizForm = new QuizForm(this, this.quizRespository);
            _quizForm.Show();
            this.Hide();
        }
        private void Form1_Activated(object sender, EventArgs e)
        {
            DisplayLeaderboardContent();

            if (NavigatedFrom.QuizFormSession == navigatedFrom)
            {
                Debug.Assert(_quizForm != null);

                // Close the form because we will recreate it if the user wants another quiz.
                _quizForm.Close();

                //TODO: Delete obsolete
                //MessageBox.Show($"You have {this._quizForm.CorrectAnswers} correct answers");
            }
            else if (NavigatedFrom.AdminFormSession == navigatedFrom)
            {
                Debug.Assert(_adminForm != null);

                // Close the admin form because we will recreate it if the user wants to vist the admin page again.
                _adminForm.Close();
            }

            // Control of the user interface is returned to the landing page
            navigatedFrom = NavigatedFrom.ApplicationStartup;
        }
        private void DisplayLeaderboardContent()
        {
            List<Score> scoresSorted = quizRespository.GetAllScoreRecords()
              .OrderByDescending(scoreRecord => scoreRecord.CorrectAnswerCount)
              .ToList();

            // Excess scores cannot be displayed on the leaderboard. So remove the lower scores.
            //int maxLeaderboardItemsAllowed = 3;
            //if (scoresSorted.Count > maxLeaderboardItemsAllowed)
            //{
            //    int numberOfItemsToRemove = scoresSorted.Count - maxLeaderboardItemsAllowed;
            //    scoresSorted.RemoveRange(maxLeaderboardItemsAllowed - 1, numberOfItemsToRemove);
            //}

            leaderBoardGrid.DataSource = scoresSorted;

            // TODO Delete old. This was writing the leadboard content to a label.
            //StringBuilder sb = new StringBuilder();
            //foreach (Score score in scoresSorted)
            //{
            //    string leaderBoardLine = $"Call Sign: {score.CallSign}\t\tQuiz Score: {score.CorrectAnswerCount}";
            //    sb.AppendLine(leaderBoardLine);
            //}

            //txtLeaderBoard.Text = sb.ToString();
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // TODO: Confirm - I believe this will close all windows. So we don't have to explicitely close them. Test to confirm.
            Application.Exit();

            // The quizForm is the only one we can probably close because we prevent closing 
            //if (_quizForm != null)
            //{
            //    // TODO: Should log if we reach here.
            //    // If this resource exists at this time, then it's a bug in the code. But let's clean up the resource anyway.
            //    _quizForm.Close();
            //}
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Force the FormClosing event to occur, which in turn exits the application and closes all windows.
            this.Close();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            _adminForm = new AdminForm(this, this.quizRespository);
            navigatedFrom = NavigatedFrom.AdminFormSession;
            _adminForm.Show();
            this.Hide();
        }
    }
}
