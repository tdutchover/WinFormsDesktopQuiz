using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsDesktopQuiz
{
    public class AnswerDTO
    {
        public string AnswerDescription { get; set; }
        public bool IsCorrectAnswer { get; set; }
        //private Answer answer;
        //private bool _correctAnswer;
        //Answer Answer { get { return answer; } }
        //bool CorrectAnswer { get { return _correctAnswer; } }
        //public AnswerDTO(Answer answer, bool _correctAnswer)
        //{
        //    this.answer = answer;
        //    this._correctAnswer = _correctAnswer;
        //}
    }
    public partial class QuizRepository : IQuestionAnswerCRUD
    {
        public List<Answer> FindAnswers(int questionId, out Answer correctAnswer)
        {
            correctAnswer = null;

            var result = from ans in entities.Answers
                         join qa in entities.QuestionAnswers on ans equals qa.Answer
                         join q in entities.Questions on qa.Question equals q
                         where qa.QuestionId == questionId
                         select new { candidateAnswer = ans, correctAnswer = qa.CorrectAnswer };

            List<Answer> answerList = new List<Answer>();
            foreach(var resultItem in result)
            {
                answerList.Add(resultItem.candidateAnswer);

                if (resultItem.correctAnswer)
                {
                    correctAnswer = resultItem.candidateAnswer;
                }
            }

            if (correctAnswer == null)
            {
                // This should never occur
                throw new Exception("Correct answer not found");
            }

            return answerList;
        }

        // This is for easy display on a grid
        public List<AnswerDTO> FindDTOAnswersForQuestion(int questionId)
        {
            var result = from ans in entities.Answers
                         join qa in entities.QuestionAnswers on ans equals qa.Answer
                         join q in entities.Questions on qa.Question equals q
                         where qa.QuestionId == questionId
                         select new AnswerDTO()
                         {
                             AnswerDescription = ans.Description,
                             IsCorrectAnswer = qa.CorrectAnswer
                         };

            return result.ToList();
        }

        // TODO Delete old
        //public ICollection<T> FindAnswersWithCorrectAnswer(int questionId)
        //{
        //    var result = from ans in entities.Answers
        //                 join qa in entities.QuestionAnswers on ans equals qa.Answer
        //                 join q in entities.Questions on qa.Question equals q
        //                 where qa.QuestionId == questionId
        //                 select new { candidateAnswer = ans, _correctAnswer = qa.CorrectAnswer };

        //    return result.ToList();

        //    //List<Answer> answerList = new List<Answer>();
        //    //foreach (var resultItem in result)
        //    //{
        //    //    answerList.Add(resultItem.candidateAnswer);

        //    //    if (resultItem._correctAnswer)
        //    //    {
        //    //        _correctAnswer = resultItem.candidateAnswer;
        //    //    }

        //    //}

        //    //if (_correctAnswer == null)
        //    //{
        //    //    throw new Exception("Correct answer not found");
        //    //}

        //    //return answerList;
        //}

        public List<string> FindAnswersAsStringList(int questionId)
        {
            var result = from ans in entities.Answers
                         join qa in entities.QuestionAnswers on ans equals qa.Answer
                         join q in entities.Questions on qa.Question equals q
                         where qa.QuestionId == questionId
                         select new { answerDesc = ans.Description };

            List<string> answerList = new List<string>();
            foreach (var answer in result)
            {
                answerList.Add(answer.answerDesc);
            }

            return answerList;
        }
        public ICollection<QuestionAnswer> GetAllQuestionAnswerRecords()
        {
            return entities.QuestionAnswers.ToHashSet();
        }
        QuestionAnswer IQuestionAnswerCRUD.FindAnswer(int questionAnswerId)
        {
            throw new NotImplementedException();
        }
    }
}
