using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQA_Selenium_Quiz
{
    public class Hamza_Baseclass
    {
        public static IWebDriver driver;

        public void SeleniumInit(string browser)

        {

            driver = new ChromeDriver();


        }


        public void CloseDriver()

        {

            driver.Close();

        }
        public void Write(By by, string value)

        {

            driver.FindElement(by).SendKeys(value);

        }
        public void Click(By by)

        {

            driver.FindElement(by).Click();

        }
        public void Clear(By by)

        {

            driver.FindElement(by).Clear();

        }
        public void OpenUrl(string url)

        {

            driver.Url = url;

        }
    }
}
