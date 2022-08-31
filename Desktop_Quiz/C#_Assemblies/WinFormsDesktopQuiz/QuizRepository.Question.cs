using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsDesktopQuiz
{
    public partial class QuizRepository : IQuestionCRUD
    {
        public Question FindQuestion(int questionId)
        {
            throw new NotImplementedException();
        }
        public ICollection<Question> GetAllQuestionRecords()
        {
            return entities.Questions.ToList();
        }
    }
}
