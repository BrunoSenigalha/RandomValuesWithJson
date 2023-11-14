using ChallengeJson.Entities;
using Newtonsoft.Json;

Number numbers = new Number();

Console.WriteLine("Enter a quantity of random values for Numbers: ");
int quantity = Convert.ToInt32(Console.ReadLine());

numbers.GeneratingRandomNumbers(quantity);

string serializedNumbers = JsonConvert.SerializeObject(numbers);

Console.WriteLine(serializedNumbers);

Letter letters = new Letter();
letters.GeneratingRandomLetters(quantity);
string serializedLetters = JsonConvert.SerializeObject(letters);

Console.WriteLine(serializedLetters);

Mixed mixed = new Mixed();
mixed.GeneratingMixedValues(quantity);

string serializedMixed = JsonConvert.SerializeObject(mixed);
Console.WriteLine(serializedMixed);
//try
//{
//    using (StreamWriter sw = new StreamWriter("C:\\Users\\Daiane Dias\\Desktop\\C#\\Desafios\\PastaJson\\Log.json"))
//    {
//        sw.WriteLine(serializedNumbers.ToString());
//    }

//}
//catch (IOException e)
//{
//    Console.WriteLine("An error occurred: ", e);
//}


