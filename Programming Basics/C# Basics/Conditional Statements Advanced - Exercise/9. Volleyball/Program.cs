using System;

namespace _9._Volleyball
{
    class Program
    {
        static void Main(string[] args)
        {
            const int YearWeekends = 48;

            // leap" (високосна година) или "normal" (невисокосна).
            string yearType = Console.ReadLine();
            // брой празници в годината (които не са събота и неделя).
            int holidays = int.Parse(Console.ReadLine());
            // брой уикенди, в които Влади си пътува до родния град.
            int homeTownWeekends = int.Parse(Console.ReadLine());
            int weekendsInSofia = YearWeekends - homeTownWeekends;

            double satGamesInSofia = weekendsInSofia * 3.0 / 4.0;
            double sunGamesInHomeTown = homeTownWeekends;
            double holidayGamesInSofia = holidays * 2.0 / 3.0;

            double totalGames = satGamesInSofia + sunGamesInHomeTown + holidayGamesInSofia;
            if (yearType == "leap")
            {
                totalGames += totalGames * 0.15;
            }
            Console.WriteLine(Math.Floor(totalGames));
        }
    }
}
