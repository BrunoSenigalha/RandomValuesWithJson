using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeJson.Entities
{
    public class Mixed
    {
        public static string[] GeneratingMixedValues(int number)
        {
            Random random = new Random();

            string[] letters = { "A","B","C","D","E","F","G","H","I",
                                "J","K","L","M","N","O","P","Q","R","S",
                                "T","U","V","X","Z","W","Y"};

            string[] RandomMixed = new string[number];

            for (int i = 0; i < number; i++)
            {
                var index = random.Next(letters.Length);

                RandomMixed[i] = random.Next(2) == 0 ? Convert
                    .ToString(random.Next(101)) : letters[index];
            }

            return RandomMixed;
        }
    }
}
