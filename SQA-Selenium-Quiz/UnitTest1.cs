using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
namespace SQA_Selenium_Quiz
{
    [TestClass]
    public class Hamza_testClass
    {
        [TestMethod]
        public void TestMethod1()
        {
            Hamza_register_user hamza_Register_User = new Hamza_register_user();
            hamza_Register_User.register_user("Hamza Khalid","khalidhhaqmzar3467342@gmail.com","qwer234asdfg","Muhammad Hamza","khalid","Contour","burewala","144 E.B","Pakistan","Burewala","123456","09637921534");


        }
        [TestMethod]
        public void TestMethod2()
        {
            Hamza_register_user hamza_Register_User = new Hamza_register_user();
            hamza_Register_User.register_withExisting_user("Hamza Khalid","khalidhamza342@gmail.com");

        }
        [TestMethod]

        public void download_invoice_after_purchase()
        {
            Hamza_register_user hamza_Register_User = new Hamza_register_user();
            hamza_Register_User.download_invoice_after_purchase();

        }
    }
}
