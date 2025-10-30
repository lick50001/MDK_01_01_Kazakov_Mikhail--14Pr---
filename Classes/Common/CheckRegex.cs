using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Regex_Kazakov.Classes.Common
{
    public class CheckRegex
    {
        public static bool Match(string Pattern, string Input){
            Match m = Regex.Match(Input, Pattern);
            return m.Success;
        }
    }
}
