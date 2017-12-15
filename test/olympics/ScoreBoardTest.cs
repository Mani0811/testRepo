using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using src.Olympics;

namespace test.Olympics
{
    [TestClass]
    public class ScoreBoardTest
    {
        [TestMethod]
        public void ShouldReturnCountryRankingBasedOnMedals()
        {
            var _olympicScores = new Dictionary<string, Dictionary<string, int>>();
            var _medals1 = new Dictionary<string, int>();
            _medals1.Add("Gold", 3);
            _medals1.Add("Silver", 0);
            _medals1.Add("Bronze", 2);
            _olympicScores.Add("Australia", _medals1);

            var _medals2 = new Dictionary<string, int>();
            _medals2.Add("Gold", 0);
            _medals2.Add("Silver", 1);
            _medals2.Add("Bronze", 2);
            _olympicScores.Add("Bangladesh", _medals2);

            var _medals3 = new Dictionary<string, int>();
            _medals3.Add("Gold", 0);
            _medals3.Add("Silver", 1);
            _medals3.Add("Bronze", 3);
            _olympicScores.Add("Greenland", _medals3);

            var _medals4 = new Dictionary<string, int>();
            _medals4.Add("Gold", 3);
            _medals4.Add("Silver", 1);
            _medals4.Add("Bronze", 2);
            _olympicScores.Add("India", _medals4);


            ScoreBoard scoreboard = new ScoreBoard(_olympicScores);
            List<String> expectedCountryList = new List<string> { "India", "Australia", "Greenland", "Bangladesh" };

            List<String> countryList = scoreboard.RankCountries();

            CollectionAssert.AreEqual(expectedCountryList, countryList);
        }

        [TestMethod]
        public void ShouldReturnCountryRankingWhenMedalEntriesAreBlank()
        {
            var _olympicScores = new Dictionary<string, Dictionary<string, int>>();
            var _medals1 = new Dictionary<string, int>();
            _medals1.Add("Gold", 3);
            _medals1.Add("Silver", 1);
            _medals1.Add("Bronze", 2);
            _olympicScores.Add("Australia", _medals1);

            var _medals2 = new Dictionary<string, int>();
            _medals2.Add("Gold", 1);
            _medals2.Add("Silver", 0);
            _medals2.Add("Bronze", 2);
            _olympicScores.Add("Bangladesh", _medals2);

            var _medals4 = new Dictionary<string, int>();
            _medals4.Add("Gold", 3);
            _medals4.Add("Bronze", 2);
            _olympicScores.Add("India", _medals4);

            ScoreBoard scoreboard = new ScoreBoard(_olympicScores);
            List<String> expectedCountryList = new List<string> { "Australia", "India", "Bangladesh" };

            List<String> countryList = scoreboard.RankCountries();

            CollectionAssert.AreEqual(expectedCountryList, countryList);
        }

        [TestMethod]
        public void ShouldRankCountryBasedOnOrderInListIfEqual()
        {
            var _olympicScores = new Dictionary<string, Dictionary<string, int>>();
            var _medals1 = new Dictionary<string, int>();
            _medals1.Add("Gold", 0);
            _medals1.Add("Silver", 1);
            _medals1.Add("Bronze", 2);
            _olympicScores.Add("Bangladesh", _medals1);

            var _medals2 = new Dictionary<string, int>();
            _medals2.Add("Gold", 3);
            _medals2.Add("Silver", 0);
            _medals2.Add("Bronze", 2);
            _olympicScores.Add("Australia", _medals2);

            var _medals4 = new Dictionary<string, int>();
            _medals4.Add("Gold", 3);
            _medals4.Add("Silver", 0);
            _medals4.Add("Bronze", 2);
            _olympicScores.Add("India", _medals4);

            ScoreBoard scoreboard = new ScoreBoard(_olympicScores);
            List<String> expectedCountryList = new List<string> { "Australia", "India", "Bangladesh" };

            List<String> countryList = scoreboard.RankCountries();

            CollectionAssert.AreEqual(expectedCountryList, countryList);
        }
    }
}
