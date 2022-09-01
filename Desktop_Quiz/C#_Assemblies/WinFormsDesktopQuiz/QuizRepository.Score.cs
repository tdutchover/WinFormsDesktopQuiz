using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsDesktopQuiz
{
    public partial class QuizRepository : IScoreCRUD, IScoreDTO
    {
        public void AddScoreRecord(Score score)
        {
            entities.Scores.Add(score);
            entities.SaveChanges();
        }

        public ICollection<ScoreDTO> GetAllScoreDTORecords()
        {
            List<ScoreDTO> scoreDTOList = new List<ScoreDTO>();
            foreach (Score score in GetAllScoreRecords())
            {

                scoreDTOList.Add(new ScoreDTO(score.CallSign, score.CorrectAnswerCount));
            }

            return scoreDTOList;
        }

        public ICollection<Score> GetAllScoreRecords()
        {
            return entities.Scores.ToList();
        }
    }

    // ScoreDTO is for displaing to the user. ScoreDTO exludes record ID score.ScoreId because that's for 
    public class ScoreDTO
    {
        public string CallSign { get; }
        public int CorrectAnswerCount { get; }
        public ScoreDTO(string callSign, int correctAnswerCount)
        {
            CallSign = callSign;
            CorrectAnswerCount = correctAnswerCount;
        }
    }
    public interface IScoreDTO
    {
        ICollection<ScoreDTO> GetAllScoreDTORecords();
    }
}
