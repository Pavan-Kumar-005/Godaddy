using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Godaddy1.Drivers
{
    public class godriver
    {
        public IWebDriver driver;

        public void go()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.godaddy.com/en-in");
            driver.Manage().Window.Maximize();
        }



    }
}
