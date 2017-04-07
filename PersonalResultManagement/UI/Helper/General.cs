using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace PersonalResultManagement.UI.Helper
{
    public class General
    {
        public static void ClearField(List<object> fields)
        {
            foreach (var textBox in fields)
            {
                if (textBox is TextBox) ((TextBox)textBox).Clear();
                if (textBox is RadTextBox) ((RadTextBox)textBox).Clear();
                if (textBox is RadTextBoxControl) ((RadTextBoxControl)textBox).Clear();
            }
        }

        public static bool IsFieldFilled(List<object> fields, RadLabel errorLabel)
        {            
            foreach (var textBox in fields)
            {
                if (textBox is RadTextBox)
                {
                    if (String.IsNullOrWhiteSpace(((RadTextBox) textBox).Text))
                    {
                        errorLabel.Text = @"No field can be empty";
                        return true;
                    }                    
                }

                if (textBox is RadTextBoxControl)
                {
                    if (String.IsNullOrWhiteSpace(((RadTextBoxControl) textBox).Text))
                    {
                        errorLabel.Text = @"No field can be empty";
                        return true;
                    }                    
                }                
            }
            errorLabel.Text = "";
            return false;
        }
    }
}
