using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using DemoQA_TextBox.PageObjects;
using NUnit.Framework;

namespace DemoQA_TextBox
{
    [TestFixture]
    class Tests : Hooks
    {
        [Test]
        public void fillInTextBox()
        {
            //Arrange
            HomePage homePage = new HomePage(Driver);
            Thread.Sleep(millisecondsTimeout: 2000);


            //Act
            homePage.FillInForm();
            //Thread.Sleep(millisecondsTimeout: 2000);


            //Assert
            //Assert.IsTrue(homePage.DeconectareButton.Displayed);
            //Thread.Sleep(millisecondsTimeout: 2000);
        }
    }
}