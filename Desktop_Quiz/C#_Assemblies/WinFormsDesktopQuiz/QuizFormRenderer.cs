using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsDesktopQuiz
{
    public class QuizFormRenderer
    {
        Button btnNext;
        Label lblQuizStatus;
        Label lblScoreStatus;
        Label lblQuestion;
        Label lblCorrectAnswer;
        Label lblWrongAnswer;
        Label lblResponseToSelectedAnswer;
        List<RadioButton> allRadioButtons;
        Button btnSubmitAnswer;
        private int totalQuestionCount;
        public QuizFormRenderer(Label lblQuizStatus, Label lblScoreStatus, Label lblQuestion, Button btnNext,
                                Button btnSubmitAnswer, Label lblCorrectAnswer, Label lblWrongAnswer,
                                Label lblResponseToSelectedAnswer,
                                List<RadioButton> allRadioButtons, int totalQuestionCount)
        {
            this.lblQuizStatus = lblQuizStatus;
            this.lblScoreStatus = lblScoreStatus;
            this.lblQuestion = lblQuestion;
            this.btnNext = btnNext;
            this.btnSubmitAnswer = btnSubmitAnswer;
            this.lblCorrectAnswer = lblCorrectAnswer;
            this.lblWrongAnswer = lblWrongAnswer;
            this.lblResponseToSelectedAnswer = lblResponseToSelectedAnswer;
            this.allRadioButtons = allRadioButtons;
            this.totalQuestionCount = totalQuestionCount;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="questionIndex">Zero based Index that identifies</param>
        /// <param name="question"></param>
        /// <param name="answers"></param>
        public void ShowQuestionPageContent(int questionIndex, Question question, Answer correctAnswer,
                                            Dictionary<RadioButton, Answer> radioBtnAnswerMap, int correctAnswersSoFar)
        {
            // We don't want focus on the answer controls so the user has to explictely select an answer.
            // That's because the answer is considered submitted and final right when the user selects it.
            // We want to avoid the user mistakenly selecting an answer.
            lblQuestion.Focus();

            DisplayCommonContent(radioBtnAnswerMap, questionIndex, this.totalQuestionCount, question, correctAnswersSoFar);

            if (questionIndex <= this.totalQuestionCount - 2)
            {
                // Navigate to next (non-final) question
                DisplayQuestionPage(questionIndex);
            }
            else if (questionIndex == this.totalQuestionCount - 1)
            {
                // Navigate to final question
                DisplayLastQuestionPage(questionIndex);
            }
        }
        public void DisplayCorrectChoiceUI(RadioButton selectedRadioButton, int correctAnswersSoFar, int totalQuestionCount)
        {
            // Display UI for correct choice of answer
            DisplayResponseToAnswerChoice((colorForCorrectAnswer) =>
            {
                DisplayResponseToCorrectAnswerChoice(correctAnswersSoFar, totalQuestionCount, selectedRadioButton, colorForCorrectAnswer);
            });
        }
        public void DisplayWrongChoiceUI(RadioButton correctAnswerRadioBtn, RadioButton selectedRadioButton)
        {
            // Display UI for wrong choice of answer
            DisplayResponseToAnswerChoice((colorForCorrectAnswer) =>
            {
                DisplayResponseToWrongAnswerChoice(selectedRadioButton, correctAnswerRadioBtn, colorForCorrectAnswer);
            });
        }
        /// <summary>
        /// This method displays the user interface corresponding to a correct or incorrect choice of answer made by the user taking the quiz.
        /// The body of this method contains common code for both correct and incorrect choice of answer.
        /// </summary>
        /// <param name="correctAnswersSoFar">Indicates the 1-based count of correct answers so far that a user has made in the quiz.</param>
        /// <param name="displayResponseToUserChoiceOfAnswer">This delegate encapsulates the difference in UI code that must occur for a correct or incorrect user choice of answer.</param>
        private void DisplayResponseToAnswerChoice(Action<Color> displayResponseToUserChoiceOfAnswer)
        {
            btnSubmitAnswer.Visible = false;
            HideAllRadioButtons();

            // The correct answer must display as green
            Color colorForCorrectAnswer = Color.Green;

            displayResponseToUserChoiceOfAnswer(colorForCorrectAnswer);

            lblResponseToSelectedAnswer.Visible = true;
        }
        private void DisplayResponseToCorrectAnswerChoice(int correctAnswersSoFar, int totalQuestionCount,
                                                          RadioButton selectedRadioButton, Color colorForCorrectAnswer)
        {
            ShowScore(correctAnswersSoFar, totalQuestionCount);

            // We want only the selected correct answer to show in the same location as the chosen radio button

            // The selected radio button represents the correct answer.

            lblCorrectAnswer.ForeColor = colorForCorrectAnswer;

            SetLabelLocationToRadioButtonTextLocation(lblCorrectAnswer, selectedRadioButton);

            lblCorrectAnswer.Text = selectedRadioButton.Text;
            lblCorrectAnswer.Visible = true;

            lblResponseToSelectedAnswer.ForeColor = colorForCorrectAnswer;
            lblResponseToSelectedAnswer.Text = TextResources.RESPONSE_TO_CORRECT_ANSWER_CHOICE;
        }
        private void DisplayResponseToWrongAnswerChoice(RadioButton selectedRadioButton, RadioButton correctAnswerRadioBtn, Color colorForCorrectAnswer)
        {
            Color colorForWrongAnswer = Color.Red;
            // The selected radio button represents the wrong answer
            lblWrongAnswer.ForeColor = colorForWrongAnswer;
            SetLabelLocationToRadioButtonTextLocation(lblWrongAnswer, selectedRadioButton);

            lblWrongAnswer.Text = selectedRadioButton.Text;
            lblWrongAnswer.Visible = true;

            lblCorrectAnswer.ForeColor = colorForCorrectAnswer;
            SetLabelLocationToRadioButtonTextLocation(lblCorrectAnswer, correctAnswerRadioBtn);
            lblCorrectAnswer.Text = correctAnswerRadioBtn.Text;
            lblCorrectAnswer.Visible = true;

            lblResponseToSelectedAnswer.ForeColor = colorForWrongAnswer;
            lblResponseToSelectedAnswer.Text = TextResources.RESPONSE_TO_WRONG_ANSWER_CHOICE;
        }
        /// <summary>
        /// Move to the specified label so that its text location exactly matches the text location of the specified radio button.
        /// </summary>
        /// <param name="lbl">Need Label so we can set its location</param>
        /// <param name="rb">Need RadioButton to get its location</param>
        private static void SetLabelLocationToRadioButtonTextLocation(Label lbl, RadioButton rb)
        {
            // These offsets are hardcoded for the resolution of my particular screen.
            // So it's unlikely to match other resolutions.
            int xOffsetToTextOnRadioButton = 16;
            int yOffsetToTextOnRadioButton = 2;

            lbl.Location = new Point(rb.Location.X + xOffsetToTextOnRadioButton, rb.Location.Y + yOffsetToTextOnRadioButton);
        }
        private void HideAllRadioButtons()
        {
            foreach (var radioBtn in this.allRadioButtons)
            {
                radioBtn.Visible = false;
            }
        }
        private void ResetAllRadioButtons()
        {
            // Radio Button Bug workaround. The first radio button shows as checked
            // unless we first check it before we uncheck below.
            allRadioButtons[0].Checked = true;
            allRadioButtons.ForEach(radioBtn =>
            {
                radioBtn.Checked = false;

                // Ensure the proper initial color because some radio button text color will
                // change when user selects the correct or incorrect answer.
                radioBtn.ForeColor = Color.Black;
            });
        }
        private void DisplayCommonContent(Dictionary<RadioButton, Answer> radioBtnAnswerMap, int currentQuestionIndex, int totalQuestionCount,
                                          Question question, int correctAnswersSoFar)
        {
            HideAllRadioButtons();
            ResetAllRadioButtons();

            ShowQuizProgress(currentQuestionIndex, totalQuestionCount);
            ShowScore(correctAnswersSoFar, totalQuestionCount);

            DisplayQuestionDescription(question);
            DisplayAnswerDescriptions(radioBtnAnswerMap);
        }
        private void DisplayQuestionDescription(Question question)
        {
            lblQuestion.Text = question.Description;
        }
        private void DisplayAnswerDescriptions(Dictionary<RadioButton, Answer> radioBtnAnswerMap)
        {
            foreach (var keyValuePair in radioBtnAnswerMap)
            {
                RadioButton radioButton = keyValuePair.Key;
                Answer answer = keyValuePair.Value;

                radioButton.Text = answer.Description;
                radioButton.Visible = true;
            }
        }
        private void DisplayQuestionPage(int questionNumber)
        {
            // Display content for current question

            btnNext.Text = TextResources.QUIZ_PAGE_NAVIGATION_BUTTON_NEXT_PAGE;
        }
        private void DisplayLastQuestionPage(int questionNumber)
        {
            btnNext.Text = TextResources.QUIZ_PAGE_NAVIGATION_BUTTON_FINISH_QUIZ;
        }
        private void ShowQuizProgress(int currentQuestionIndex, int totalQuestionCount)
        {
            int questionNumber = currentQuestionIndex + 1;
            lblQuizStatus.Text = $"Question {questionNumber} of {totalQuestionCount}";
        }
        private void ShowScore(int correctAnswersSoFar, int totalQuestionCount)
        {
            lblScoreStatus.Text = $"{correctAnswersSoFar} of {totalQuestionCount} Correct Answers";
        }
    }
}
