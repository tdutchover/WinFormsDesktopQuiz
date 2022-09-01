using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsDesktopQuiz
{
    public class QuestionDTO
    {
        public string Description { get; }
        public QuestionDTO(string description)
        {
            Description = description;
        }
    }
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

        public List<QuestionDTO> GetAllDTOQuestionRecords()
        {
            List<QuestionDTO> questionDTOs = new List<QuestionDTO>();

            foreach (Question q in GetAllQuestionRecords())
            {
                questionDTOs.Add(new QuestionDTO(q.Description));
            }

            return questionDTOs;
        }
    }
}
