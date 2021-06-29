using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1.Client.Services
{
    public static class HighScoreSVC
    {
        private static List<int> iHighScores = new List<int>();

        public static void AddScore(int iScore)
        {
            iHighScores.Add(iScore);
        }

        public static String GetScores()
        {
            String sReturnMe = "";
            foreach (int iScore in iHighScores)
            {
                sReturnMe += iScore.ToString() + " ";
            }
            return sReturnMe.Trim();
        }
    }
}
