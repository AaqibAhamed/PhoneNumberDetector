using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneNumberDetector.Services
{
    public class OutputFormatter : IOutputFormatter
    {
        public void DisplayDetectedNumbers(List<string> phoneNumbers)
        {
            if (phoneNumbers.Count == 0)
            {
                Console.WriteLine("No phone numbers detected yet");
                return;
            }

            Console.WriteLine("List of Detected Phone Numbers:");

            foreach (var number in phoneNumbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}
