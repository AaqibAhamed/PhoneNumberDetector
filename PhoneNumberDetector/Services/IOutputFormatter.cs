using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneNumberDetector.Services
{
    public interface IOutputFormatter
    {
        void DisplayDetectedNumbers(List<string> phoneNumbers);
    }
}
