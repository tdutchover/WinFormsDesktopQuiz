using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsDesktopQuiz
{
    public partial class QuizRepository : IAnswerCRUD
    {
        public Answer FindAnswer(int answerId)
        {
            throw new NotImplementedException();
        }
        public ICollection<Answer> GetAllAnswerRecords()
        {
            throw new NotImplementedException();
        }
    }
}
