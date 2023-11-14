using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeJson.Solutions
{
    public class JsonGenerator
    {
        public string[] Letters { get; set; }
        public int[] Numbers { get; set; }
        public string[] Mixed { get; set; }

        public JsonGenerator(string[] letters, int[] numbers, string[] mixed)
        {
            Letters = letters;
            Numbers = numbers;
            Mixed = mixed;
        }
    }
}
