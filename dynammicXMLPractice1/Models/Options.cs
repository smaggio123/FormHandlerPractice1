using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dynammicXMLPractice1.Models
{
    public class Options
    {
        public string OptionName { get; set; }
        public Options(string name)
        {
            OptionName = name;
        }
    }
}
