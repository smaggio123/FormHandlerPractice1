using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dynammicXMLPractice1.Models
{
    public class FormInputField
    {
        public string? FieldName { get; set; }

        public bool IsTextInput { get; set; }

        public bool IsRadioBtn { get; set; }
        public bool IsCheckBox { get; set; }
        public List<Options>? CheckListParameters { get; set; }
    }
}
