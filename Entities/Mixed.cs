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
        public string[] RandomMixed;
        public void GeneratingMixedValues(int number)
        {
            
            string[] letters = { "A","B","C","D","E","F","G","H","I",
                                "J","K","L","M","N","O","P","Q","R","S",
                                "T","U","V","X","Z","W","Y"};
            string[] randomLetters = new string[number];
            string[] numbers = new string[number];

            string[] numbersAndLetters = new string[number * 2];

            var random = new Random();

            for (int i = 0; i < number; i++)
            {
                numbers[i] = Convert.ToString(random.Next(101));
                var index = random.Next(letters.Length);
                randomLetters[i] = letters[index];
            }

            randomLetters.CopyTo(numbersAndLetters, 0);
            numbers.CopyTo(numbersAndLetters, randomLetters.Length);

            RandomMixed = new string[number];
            for (int i = 0; i < number; i++)
            {
                var index = random.Next(numbersAndLetters.Length);
                RandomMixed[i] = numbersAndLetters[index];
            }
        }
    }
}
