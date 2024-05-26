using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneNumberDetector.Services
{
    public class FileInputHandler : IInputHandler
    {
        private readonly string? _filePath;

        public FileInputHandler(string filePath)
        {
            _filePath = filePath;
        }

        public string GetInput()
        {
            return File.ReadAllText(_filePath ?? string.Empty);
        }
    }
}
