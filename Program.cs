using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EvermosSelenium
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Automated Test is started");

            //Browser Reference
            IWebDriver driver = new ChromeDriver();

            //Go to the url
            driver.Navigate().GoToUrl("https://evermos.com/");

            #region Create New Account
            IWebElement element = driver.FindElement(By.ClassName("content-daftar"));
            element.Click();

            element = driver.FindElement(By.XPath("/html/body/div[1]/div[2]/div/div/div/form/div/div/div[2]/input"));
            Thread.Sleep(2000);
            element.SendKeys("08988893419");
            Thread.Sleep(2000);

            element = driver.FindElement(By.ClassName("pageVerify__submitBtn"));
            element.Click();
            Thread.Sleep(2000);

            driver.Close();

            #endregion

        }

    }

}
