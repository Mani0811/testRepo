using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;

namespace src.Olympics
{
    public class ScoreBoard
    {
        private Dictionary<string, Dictionary<string, int>> _olympicScores;

        public ScoreBoard(Dictionary<string, Dictionary<string, int>> olympicScores)
        {
            this._olympicScores = olympicScores;
        }

        public List<string> RankCountries()
        {
            Dictionary<string,int> output= new Dictionary<string,int>();
            foreach (var score in _olympicScores)
            {
                var totalCount = 0;
                foreach (var count in score.Value)
                {
                    totalCount += count.Value;
                }
               output.Add(score.Key,totalCount);
            }
           return output.OrderByDescending(i => i.Value).Select(c=>c.Key).ToList();
            
       
        }
    }
}
