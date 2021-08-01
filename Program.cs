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
using NPOI.HSSF.UserModel;
using System.IO;
using NUnit.Framework;

namespace EvermosSelenium
{
    class Program
    {
        IWebDriver driver = new ChromeDriver("D:\\Work\\Automated Test\\Chrome Driver New");

        static void Main(string[] args)
        {
            Console.Write("Automated Test is started");
        }

        [SetUp]
        public void Initialize()
        {
            //Go to the url
            driver.Navigate().GoToUrl("https://staging.evermosa2z.com/login");
        }

        [Test] //Attribute NUnit untuk bikin test
        public void Login()
        {
            IWebElement element = driver.FindElement(By.XPath("/html/body/div[1]/div[2]/div/div[2]/form/label[1]/span[2]/input"));
            element.SendKeys("6289888111325");

            element = driver.FindElement(By.XPath("/html/body/div[1]/div[2]/div/div[2]/form/label[2]/span[2]/input"));
            element.SendKeys("evm123!!");

            element = driver.FindElement(By.XPath("/html/body/div[1]/div[2]/div/div[3]/button"));
            element.Click();

            Thread.Sleep(5000);
        }

        [Test]
        public void Logout()
        {
            IWebElement element = driver.FindElement(By.XPath("/html/body/div[1]/div[2]/div/div[4]/div/a[1]/div[2]/div[1]"));
            element.Click();
        }

        [TearDown]
        public void CleanUp()
        {
            driver.Close();
        }

        //private void readRow(object sender, EventArgs e)
        //{
        //    string test;

        //    HSSFWorkbook hssfwb;
        //    using (FileStream file = new FileStream(@"D:\Work\Automated Test\Selenium\npoi-test.xls", FileMode.Open, FileAccess.Read))
        //    {
        //        hssfwb = new HSSFWorkbook(file);
        //    }

        //    ISheet sheet = hssfwb.GetSheet("Sheet1");
        //    for (int row = 0; row <= sheet.LastRowNum; row++)
        //    {
        //        if (sheet.GetRow(row) != null) //null is when the row only contains empty cells 
        //        {
        //            test = string.Format("Row {0} = {1}", row, sheet.GetRow(row).GetCell(0).StringCellValue);
        //        }
        //    }
        //}

    }

}
