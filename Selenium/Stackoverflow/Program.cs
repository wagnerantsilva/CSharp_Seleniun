using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brasileiro_2019
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            var _url = @"https://www.cbf.com.br/futebol-brasileiro/competicoes/campeonato-brasileiro-serie-a/2019";

            driver.Navigate().GoToUrl(_url);
            driver.Manage().Window.Maximize();
            var timeout = driver.Manage().Timeouts();
            timeout.ImplicitWait = TimeSpan.FromSeconds(10);

            var table = driver.FindElement(By.TagName("table"));
            var rows = table.FindElements(By.TagName("tr"));

            foreach (var row in rows)
            {
                if (row.Text != "")
                {
                    Console.WriteLine(row.Text);
                }
                
            }
        }
    }
}
