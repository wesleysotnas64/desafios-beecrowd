using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace iniciante.challenges
{
    public class Challenge1052 : BaseChallenge
    {
        public override void Execute()
        {
            Dictionary<int, string> months = new Dictionary<int, string>()
            {
                {1, "January"},
                {2, "February"},
                {3, "March"},
                {4, "April"},
                {5, "May"},
                {6, "June"},
                {7, "July"},
                {8, "August"},
                {9, "September"},
                {10, "October"},
                {11, "November"},
                {12, "December"}
            };

            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(months[number]);
        }
    }
}