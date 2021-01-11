using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DemoQA_TextBox.PageObjects
{
    partial class HomePage
    {
        public void FillInForm()
        {
            fullNameFieldTextBox.SendKeys("Irina Eris");
            emailFieldTextBox.SendKeys("irina.eris@yahoo.com");
            currentAddressFieldTextBox.SendKeys("Cristina");
            permanentAddressTextBox.SendKeys("Brasov");
            Thread.Sleep(2000);

            submitButton.Click();

        }

    }
}

