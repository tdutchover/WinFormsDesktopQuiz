using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsDesktopQuiz
{
    public interface IScoreCRUD
    {
        ICollection<Score> GetAllScoreRecords();
        void AddScoreRecord(Score score);
        //void DeleteScoreRecord(Score score);
        //void UpdateScoreRecord(Score score);
    }
    public interface IQuestionCRUD
    {
        Question FindQuestion(int questionId);
        ICollection<Question> GetAllQuestionRecords();
        //void AddQuestionRecord(Question question);
        //void DeleteQuestionRecord(Question question);
        //void UpdateQuestionRecord(int questionId, Question question);
    }

    public interface IAnswerCRUD
    {
        Answer FindAnswer(int answerId);
        ICollection<Answer> GetAllAnswerRecords();
        //void AddAnswerRecord(Answer answer);
        //void DeleteAnswerRecord(Answer answer);
        //void UpdateAnswerRecord(int answerId, Answer answer);
    }

    public interface IQuestionAnswerCRUD
    {
        List<string> FindAnswersAsStringList(int questionId);
        QuestionAnswer FindAnswer(int questionAnswerId);
        ICollection<QuestionAnswer> GetAllQuestionAnswerRecords();
        //void AddQuestionAnswerRecord(QuestionAnswer questionAnswer);
        //void DeleteAnswerRecord(QuestionAnswer questionAnswer);
        //void UpdateAnswerRecord(int questionAnswerId, QuestionAnswer questionAnswer);
    }
}
