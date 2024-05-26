using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneNumberDetector.Services
{
    public interface IPhoneNumberDetector
    {
        List<string> DetectPhoneNumbers(string input);
    }
}
