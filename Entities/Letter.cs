using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeJson.Entities
{
    public class Letter
    {
        
        public static string[] GeneratingRandomLetters(int quantity)
        {
            string[] RandomLetters = new string[quantity];

            string[] letters = { "A","B","C","D","E","F","G","H","I",
                                "J","K","L","M","N","O","P","Q","R","S",
                                "T","U","V","X","Z","W","Y"};
            var random = new Random();
            //var chars = "ABCDEFGHIJKLMNOPQRSTUVXZ";
            //var random = new Random();
            //var result = new string(
            //    Enumerable.Repeat(chars, quantity)
            //              .Select(s => s[random.Next(s.Length)])
            //              .ToArray());
            for (int i = 0; i < quantity; i++)
            {
                var index = random.Next(letters.Length);
                RandomLetters[i] = letters[index];
            }

           return RandomLetters;
        }
    }
}
