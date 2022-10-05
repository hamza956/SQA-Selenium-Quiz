using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace SQA_Selenium_Quiz
{
    public class Hamza_register_user:Hamza_Baseclass
    {
        By loginsignbtn = By.XPath("//a[contains(text(),' Signup / Login')]");
        By nameuser = By.CssSelector("input[name='name']");
        By emailuser = By.CssSelector("input[data-qa='signup-email']");
        By signup = By.XPath("//button[contains(text(),'Signup')]");
        By title = By.CssSelector("input[value='Mr']");
        By psd = By.CssSelector("input[type='password']");
        By day = By.CssSelector("select[name='days']");
        By whichday = By.XPath("//option[contains(text(),'2')]");
        By moth = By.CssSelector("select[data-qa = 'months']");
        By monthchose = By.XPath("//option[contains(text(),'January')]");
        By year = By.CssSelector("select[data-qa='years']");
        By chooseYear = By.CssSelector("option[value='2020']");
        By newsletterchkbox = By.CssSelector("input[name='newsletter']");
        By special = By.CssSelector("input[name='optin']");
        By fname = By.CssSelector("input[data-qa='first_name']");
        By lname = By.CssSelector("input[data-qa='last_name']");
        By company = By.CssSelector("input[data-qa='company']");
        By addres = By.CssSelector("input[data-qa='address']");
        By addres2 = By.CssSelector("input[data-qa='address2']");
        By country = By.CssSelector("select[data-qa='country']");
        By countryse = By.CssSelector("option[value='India']");
        By state = By.CssSelector("input[data-qa='state']");
        By city = By.CssSelector("input[data-qa='city']");
        By zipcode = By.CssSelector("input[data-qa='zipcode']");
        By mobilenumber = By.CssSelector("input[data-qa='mobile_number']");
        By btn_click = By.CssSelector("button[data-qa='create-account']");
        By continoue_btn = By.CssSelector("a[data-qa='continue-button']");
        By verifypage = By.CssSelector("//a[contains(text(),' Logged in as ')]");
        By product1 = By.CssSelector("a[data-product-id='1']");
       
        By cart = By.LinkText("View Cart");
    public void assert()
        {
            string homeverify = driver.FindElement(By.XPath("//a[contains(text(),'Home')]")).Text;
            Assert.AreEqual("Home", homeverify);
        }
      
        public void register_user(string uname,string emaluser,string psdd,string fName,string lName,string compnyy,string adress,string adress2,string statee,string cIty,string zipcpode,string mnumbr)
        {
            SeleniumInit("chrome");
            OpenUrl("http://automationexercise.com");
            //MessageBox.Show(driver.Title);
            assert();
            Click(loginsignbtn);
            Assert.AreEqual("Automation Exercise - Signup / Login", driver.Title);
            Write(nameuser, uname);
            Write(emailuser, emaluser);
            Click(signup);
            Assert.AreEqual("Automation Exercise - Signup", driver.Title);
            Click(title);
            Write(psd, psdd);
            Click(day);
            Click(whichday);
            Click(moth);
            Click(monthchose);
            Click(year);
            Click(chooseYear);
            Click(newsletterchkbox);
            Click(special);
            Write(fname, fName);
            Write(lname, lName);
            Write(company, compnyy);
            Write(addres,adress);
            Write(addres2, adress2);
            Click(day);
            Click(countryse);
            Write(state, statee);
            Write(city, cIty);
            Write(zipcode, zipcpode);
            Write(mobilenumber,mnumbr);
            Click(btn_click);
            Assert.AreEqual("Automation Exercise - Account Created", driver.Title);
            Click(continoue_btn);
           
        }
        public void register_withExisting_user(string uname,string emaluser)
        {
            SeleniumInit("chrome");
            OpenUrl("http://automationexercise.com");
            assert();
            Click(loginsignbtn);
            Write(nameuser, uname);
            Write(emailuser, emaluser);
            Click(signup);
            string alreadyuser = driver.FindElement(By.XPath("//p[contains(text(),'Email Address already exist!')]")).Text;
            Assert.AreEqual("Email Address already exist!", alreadyuser);
        }

        public void download_invoice_after_purchase()
        {
            SeleniumInit("chrome");
            OpenUrl("http://automationexercise.com");
            //MessageBox.Show(driver.Title);
            assert();
            Click(product1);
            Click(cart);
        }
       
    }

  
}
