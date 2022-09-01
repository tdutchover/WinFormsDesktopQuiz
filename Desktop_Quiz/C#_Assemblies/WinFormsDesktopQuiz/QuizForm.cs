using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsDesktopQuiz
{
    internal partial class QuizForm : Form
    {
        private Form1 _landingPageForm;
        private QuizRepository _quizRespository;

        private int correctAnswersSoFar;
        public int CorrectAnswers { get { return correctAnswersSoFar; } }


        private ICollection<Question> _questions;

        private List<RadioButton> _allRadioButtons;

        private Answer _correctAnswer;
        private Dictionary<RadioButton, Answer> _radioBtnAnswerMap;

        private RadioButton _selectedRadioButton;

        private int _currentQuestionIndex;
        private int _totalQuestionCount;
        private QuizFormRenderer _quizFormRenderer;
        public QuizForm(Form1 parentForm, QuizRepository quizRespository)
        {
            InitializeComponent();
            this._landingPageForm = parentForm;
            this._quizRespository = quizRespository;

            correctAnswersSoFar = 0;
        }
        private void QuizForm_Load(object sender, EventArgs e)
        {
            //TODO: Load _questions and oldAnswers
            _questions = _quizRespository.GetAllQuestionRecords();

            if (_questions.Count == 0)
            {
                // TODO: Have the landing page send the _questions. There should never be a need to check zero
                //         _questions by the time we're in the quiz.
                //       Should display a message to the user to explain the problem.
                NavigationUtils.NavigateToLandingPage(this._landingPageForm, this);
            }

            btnSubmitAnswer.Visible = false;

            _totalQuestionCount = _questions.Count;     //TODO: Perhaps generalize from the records queried from the DB

            //TODO: Consider dynamically creating radio buttons. Or at least ensure that there can never be more oldAnswers than radio button.
            //      For now, we assume there's always for candidate oldAnswers so we match up exactly with the number of radio buttons.
            this._allRadioButtons = new List<RadioButton>()
            {
                radioBtn_AnswerCandidate1,
                radioBtn_AnswerCandidate2,
                radioBtn_AnswerCandidate3,
                radioBtn_AnswerCandidate4
            };

            this._quizFormRenderer = new QuizFormRenderer(lblQuizStatus, lblScoreStatus, lblQuestion, btnNext,
                                                         btnSubmitAnswer, lblCorrectAnswer, lblWrongAnswer,
                                                         lblResponseToSelectedAnswer,
                                                         _allRadioButtons, this._totalQuestionCount);
            // Show first nextQuestion
            int firstQuestionIndex = 0;
            this._currentQuestionIndex = firstQuestionIndex;
            Question question = GetQuestion(questionIndex: this._currentQuestionIndex);

            this._radioBtnAnswerMap = InitializeQuestionAnswerMetadata(question, out _correctAnswer, this._allRadioButtons);
            ShowPageContent(question, this._quizFormRenderer, this._radioBtnAnswerMap, this.correctAnswersSoFar);
        }
        private void ShowPageContent(Question question, QuizFormRenderer quizFormRenderer,
                                     Dictionary<RadioButton, Answer> radioBtnAnswerMap, int correctAnswersSoFar)
        {
            // The response must only display after the user selects an answer.
            lblResponseToSelectedAnswer.Visible = false;

            // The response to a user answer choice must be hidden before the user makes a choice.
            // We don't bother to clear the text on these because the text is correctly set when the user choose an answer.
            lblWrongAnswer.Visible = false;
            lblCorrectAnswer.Visible = false;

            quizFormRenderer.ShowQuestionPageContent(this._currentQuestionIndex, question, _correctAnswer, radioBtnAnswerMap, correctAnswersSoFar);
        }
        private Dictionary<RadioButton, Answer> InitializeQuestionAnswerMetadata(Question question, out Answer correctAnswer, List<RadioButton> allRadioButtons)
        {
            List<Answer> answers = FindAnswersNew(question, out correctAnswer);

            Debug.Assert(answers.Count <= allRadioButtons.Count);

            Dictionary<RadioButton, Answer> btnAnswerDict = new Dictionary<RadioButton, Answer>();

            // Populate map
            for (int i = 0; i < answers.Count && i < allRadioButtons.Count; i++)
            {
                btnAnswerDict.Add(allRadioButtons[i], answers[i]);
            }

            return btnAnswerDict;
        }
        private void btnAbort_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            // TODO: In lieu of asserts, consider to provide a type that limits to valid nextQuestion numbers via param questionNumber
            Debug.Assert(_currentQuestionIndex >= 0);

            if (this._currentQuestionIndex < this._totalQuestionCount - 1)
            {
                // Show next nextQuestion
                Question nextQuestion = GetQuestion(questionIndex: ++this._currentQuestionIndex);
                this._radioBtnAnswerMap = InitializeQuestionAnswerMetadata(nextQuestion, out _correctAnswer, this._allRadioButtons);
                ShowPageContent(nextQuestion, this._quizFormRenderer, this._radioBtnAnswerMap, this.correctAnswersSoFar);
            }
            else if (this._currentQuestionIndex == this._totalQuestionCount - 1)
            {
                // Submitting Quiz
                QuizCompletedForm quizCompletedForm = new QuizCompletedForm(this._landingPageForm, this._quizRespository, correctAnswersSoFar);
                NavigationUtils.NavigateToForm(quizCompletedForm, this);

                // Don't invoke this.Close() here because that will execute the FormClosing handler, which will navigate to the landing page
                // instead of QuizCompletedForm above. Instead, we let the landing page close this form.
            }
        }
        private Question GetQuestion(int questionIndex)
        {
            Debug.Assert(questionIndex <= this._totalQuestionCount - 1);
            return _questions.ElementAt(questionIndex);
        }
        private List<Answer> FindAnswersNew(Question question, out Answer correctAnswer)
        {
            List<Answer> answers = _quizRespository.FindAnswers(question.QuestionId, out correctAnswer);

            // TODO: Delete test code

            //StringBuilder sb = new StringBuilder();

            //foreach(Answer answer in oldAnswers)
            //{
            //    if (answer == _correctAnswer)
            //    {
            //        sb.AppendLine($"Correct Answer: TRUE, AnswerId: {answer.AnswerId}, Answer-Description: {answer.Description}");
            //    }
            //    else
            //    {
            //        sb.AppendLine($"AnswerId: {answer.AnswerId}, Answer-Description: {answer.Description}");
            //    }
            //}
            //MessageBox.Show(sb.ToString());
            return answers;
        }
        private void QuizForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //TODO: We don't want the landing page to attempt to display a new quiz result.
            //      So we either need a way to tell the parent landing page that the quiz was aborted.
            //      Or do nothing, because the landing page will depend only on the database to make any updates
            //      to its Leader Board status.

            // We navigate back to the landing page during the closing event because there are several ways to close the form
            // and we must handle any way of closing this quiz session by navigating back to the landing page.
            NavigationUtils.NavigateToLandingPage(this._landingPageForm, this);
        }
        private void radioBtn_AnswerCandidate1_Click(object sender, EventArgs e)
        {
            btnSubmitAnswer.Visible = true;
            _selectedRadioButton = radioBtn_AnswerCandidate1;
        }
        private void radioBtn_AnswerCandidate2_Click(object sender, EventArgs e)
        {
            btnSubmitAnswer.Visible = true;
            _selectedRadioButton = radioBtn_AnswerCandidate2;
        }
        private void radioBtn_AnswerCandidate3_Click(object sender, EventArgs e)
        {
            btnSubmitAnswer.Visible = true;
            _selectedRadioButton = radioBtn_AnswerCandidate3;
        }
        private void radioBtn_AnswerCandidate4_Click(object sender, EventArgs e)
        {
            btnSubmitAnswer.Visible = true;
            _selectedRadioButton = radioBtn_AnswerCandidate4;
        }
        private void btnSubmitAnswer_Click(object sender, EventArgs e)
        {
            Debug.Assert(_radioBtnAnswerMap.ContainsKey(_selectedRadioButton));
            Answer selectedAnswer = _radioBtnAnswerMap[_selectedRadioButton];

            if (selectedAnswer == this._correctAnswer)
            {
                this.correctAnswersSoFar++;  // Keep track of the number of correct answer choices made by the user

                // Display UI for correct choice of answer
                _quizFormRenderer.DisplayCorrectChoiceUI(_selectedRadioButton, this.correctAnswersSoFar, this._totalQuestionCount);
 
                // TODO Delete old
                //_quizFormRenderer.DisplayResponseToAnswerChoice((colorForCorrectAnswer) =>
                //{
                //    QuizFormRenderer.DisplayResponseToCorrectAnswerChoice(lblCorrectAnswer, lblResponseToSelectedAnswer,
                //                                                          _selectedRadioButton, colorForCorrectAnswer);
                //});
            }
            else
            {
                // Display UI for wrong choice of answer
                var correctAnswerRadioBtn = _radioBtnAnswerMap.FirstOrDefault(x => x.Value == _correctAnswer).Key;
                _quizFormRenderer.DisplayWrongChoiceUI(correctAnswerRadioBtn, _selectedRadioButton);

                // TODO Delete old
                //_quizFormRenderer.DisplayResponseToAnswerChoice((colorForCorrectAnswer) =>
                //{
                //    var correctAnswerRadioBtn = _radioBtnAnswerMap.FirstOrDefault(x => x.Value == _correctAnswer).Key;
                //    QuizFormRenderer.DisplayResponseToWrongAnswerChoice(lblWrongAnswer, lblCorrectAnswer, lblResponseToSelectedAnswer,
                //                                                        _selectedRadioButton, correctAnswerRadioBtn, colorForCorrectAnswer);
                //});
            }
        }
    }
}