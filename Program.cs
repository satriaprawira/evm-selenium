using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using NPOI.SS.UserModel;
using NPOI.SS.Util;
using NPOI.XSSF.UserModel;

namespace EvermosSelenium
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Automated Test is started");

            //Browser Reference

            IWebDriver driver = new ChromeDriver("D:\\Work\\Automated Test\\Chrome Driver");

            #region Create New Staging Account

            //Go to the url
            driver.Navigate().GoToUrl("https://evermos.com/registration?type=register");

            IWebElement element = driver.FindElement(By.XPath("/html/body/div[1]/div[2]/div/div[2]/div/form/div[1]/div[2]/div/div/div[2]/input"));
            element.SendKeys("89888111112");

            driver.Close();

            #endregion

        }

    }

}
