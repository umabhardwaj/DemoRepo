
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;

using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium1
{
    class Demo
    {
        IWebDriver driver;

        [SetUp]
        public void startBrowser()
        {
           
           // ChromeDriverService service = ChromeDriverService.CreateDefaultService(@"C:\Users\ubhardwa\Downloads\geckodriver-v0.21.0-win64", "geckodriver.exe");
            //service.Start();
            //System.setProperty("webdriver.gecko.driver", @"C:\Users\ubhardwa\Downloads\geckodriver-v0.21.0-win64");
            driver = new ChromeDriver(@"C: \Users\ubhardwa\Downloads\chromedriver_win32");
        }

        [Test]
        public void test()
        {
            driver.Url = "http://google.com";
        }

        [TearDown]
        public void closeBrowser()
        {
            driver.Close();
        }
    }
}
