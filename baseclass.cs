using Godaddy1.Drivers;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Godaddy1.page
{
    public class baseclass : godriver 
    {
        public baseclass(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);

        }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"id-68aad88a-f732-425d-b4c3-d14407a0aa2a\"]/summary/span[1]")]

        public IWebElement users { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"id-68aad88a-f732-425d-b4c3-d14407a0aa2a-flyout\"]/div[1]/div[2]/ul/li/a")]

        public IWebElement create { get; set;}

        [FindsBy(How = How.Id, Using = "sign-up-email")]

        public IWebElement clickemail { get; set; } 

        [FindsBy(How = How.XPath, Using = "//*[@id=\"email\"]")]

        public IWebElement newemail { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"username\"]")]

        public IWebElement username { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"sign-up-email\"]")]

        public IWebElement password { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"submitBtn\"]")]

        public IWebElement submit { get; set; }




    }

    
}
