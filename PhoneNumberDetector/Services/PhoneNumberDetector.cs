using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace PhoneNumberDetector.Services
{
    public class PhoneNumberDetector : IPhoneNumberDetector
    {
        private static readonly List<String> PhoneNumberPatterns = new List<String>
        {
            // Regex to match with different Phone Number Patterns

            @"\b\d{10}\b", // 10-digit numbers
            @"(\d{10})", // 10-digit numbers
            @"\b\d{3}[-.\s]\d{3}[-.\s]\d{4}\b",
            @"\+?\d{1,3}?[-.\s]?\(?\d{1,4}?\)?[-.\s]?\d{1,4}[-.\s]?\d{1,9}\b", // all in one
            @"\(?\d{2,3}\)?\s?\d{3,4}[-.\s]?\d{4}\b",
            @"(\d{3}-\d{3}-\d{4})", // 10-digit numbers with dashes
            @"(\+\d{1,2}-\d{3}-\d{3}-\d{4})", // Numbers with country codes
            @"(\(\d{3}\) \d{3}-\d{4})", // Numbers with parentheses for area codes
            @"(\d{3} \d{3} \d{4})", // Numbers with spaces as separators
            @"(\+\d{1,2}\d{10})", // Numbers with country codes
            @"(\(\d{3}\) \d{3} \d{4})", // Numbers with parentheses for area codes

        };

        public List<string> DetectPhoneNumbers(string input)
        {
            var detectedNumbers = new List<string>();

            foreach (var pattern in PhoneNumberPatterns)
            {
                var matches = Regex.Matches(input, pattern, RegexOptions.IgnoreCase);

                foreach (Match match in matches.Cast<Match>())
                {
                    detectedNumbers.Add(match.Value);
                }
            }

            return detectedNumbers;
        }
    }
}
