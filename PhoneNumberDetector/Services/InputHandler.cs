using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneNumberDetector.Services
{
    public class InputHandler : IInputHandler
    {
        public string GetInput()
        {
            Console.WriteLine("Enter your input:");
            return Console.ReadLine() ?? string.Empty;
        }
    }
}
