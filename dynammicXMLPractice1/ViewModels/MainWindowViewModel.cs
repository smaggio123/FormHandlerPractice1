using dynammicXMLPractice1.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace dynammicXMLPractice1.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        public List<FormInputField> InputFields { get; } = new List<FormInputField>()
        {
            new FormInputField
            {
                FieldName = "First Name:",
                IsTextInput = true,
                IsCheckBox = false,
                IsRadioBtn = false,
                CheckListParameters = null
            },
            new FormInputField
            {
                FieldName = "Is appointment today:",
                IsTextInput = false,
                IsCheckBox = false,
                IsRadioBtn = true,
                CheckListParameters = new List<Options>()
                {
                    new("Yes"),
                    new("No")
                }
            },
            new FormInputField
            {
                FieldName = "Appointment type:",
                IsTextInput = false,
                IsCheckBox = true,
                IsRadioBtn = false,
                CheckListParameters = new List<Options>()
                {
                    new("Hair cut"),
                    new("Nails")
                }
            },
            new FormInputField
            {
                FieldName = "Last Name:",
                IsTextInput = true,
                IsCheckBox = false,
                IsRadioBtn = false,
                CheckListParameters = null
            },
        };
    }
}
