using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeJson.Entities
{
    public class Number
    {
        public static int[] GeneratingRandomNumbers(int quantity)
        {
            int[] RandomNumbers = new int[quantity];
            var rand = new Random();

            for (int i = 0; i < quantity; i++)
                RandomNumbers[i] = rand.Next(101);

            return RandomNumbers;
        }
    }
}
