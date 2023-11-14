using ChallengeJson.Entities;
using ChallengeJson.Solutions;
using Newtonsoft.Json;

Console.WriteLine("Enter a quantity of random values for Numbers: ");
int quantity = Convert.ToInt32(Console.ReadLine());

JsonGenerator jsonGenerator = new JsonGenerator(Letter.GeneratingRandomLetters(quantity), 
                                                Number.GeneratingRandomNumbers(quantity),
                                                 Mixed.GeneratingMixedValues(quantity));

string serialized = JsonConvert.SerializeObject(jsonGenerator, Formatting.Indented);
Console.WriteLine(serialized);

try
{
    using (StreamWriter sw = new StreamWriter("C:\\Users\\Daiane Dias\\Desktop\\C#\\Desafios\\PastaJson\\Log.txt"))
    {
        sw.WriteLine(serialized.ToString());
    }

}
catch (IOException e)
{
    Console.WriteLine("An error occurred: ", e);
}


