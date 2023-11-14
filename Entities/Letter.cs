
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

            for (int i = 0; i < quantity; i++)
            {
                var index = random.Next(letters.Length);
                RandomLetters[i] = letters[index];
            }

            return RandomLetters;
        }
    }
}
