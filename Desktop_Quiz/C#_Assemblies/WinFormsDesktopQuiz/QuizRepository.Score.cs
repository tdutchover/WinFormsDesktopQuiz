using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsDesktopQuiz
{
    public partial class QuizRepository : IScoreCRUD
    {
        public void AddScoreRecord(Score score)
        {
            entities.Scores.Add(score);
            entities.SaveChanges();
        }
        public ICollection<Score> GetAllScoreRecords()
        {
            return entities.Scores.ToList();
        }
    }
}
