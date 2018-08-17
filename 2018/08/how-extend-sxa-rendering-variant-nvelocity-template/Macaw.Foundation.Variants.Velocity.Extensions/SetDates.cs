//Author: Barend Emmerzaal
//b.emmerzaal@gmail.com
//linkedin.com/in/barendemmerzaal
//twitter.com/barendemmerzaal
//This is just an example project to get you started. You can use it anyway you like but any damage caused by using this is your own.
//The author of this solution is not responsible for anything in any way.

using System;

namespace Macaw.Foundation.Variants.NVelocityExtensions
{
    public class SetDates
    {
        public static string GetTodayDate()
        {
            string TodayDate = DateTime.Today.ToString("MM/dd/yyyy");
            return TodayDate;
        }
        public static string GetYesterdayDate()
        {
            string YesterDate = DateTime.Today.AddDays(-1).ToString("MM/dd/yyyy");
            return YesterDate;
        }
        public static string GetTomorrowDate()
        {
            string TomorrowDate = DateTime.Today.AddDays(1).ToString("MM/dd/yyyy");
            return TomorrowDate;
        }
    }
}
