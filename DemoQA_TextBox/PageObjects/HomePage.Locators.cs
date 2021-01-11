using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace DemoQA_TextBox.PageObjects
{
    partial class HomePage
    {
        public IWebDriver _driver;

        public HomePage(IWebDriver driver)
        {
            _driver = driver;
        }
        private IWebElement fullNameFieldTextBox => _driver.FindElement(By.XPath("//*[@id='userName']"));
        private IWebElement emailFieldTextBox => _driver.FindElement(By.XPath("//input[@id='userEmail']"));
        private IWebElement currentAddressFieldTextBox => _driver.FindElement(By.XPath("//*[@id='currentAddress']"));
        private IWebElement permanentAddressTextBox => _driver.FindElement(By.XPath("//*[@id='permanentAddress']"));
        private IWebElement submitButton => _driver.FindElement(By.XPath("//button[@id='submit']"));
        
    }
}
