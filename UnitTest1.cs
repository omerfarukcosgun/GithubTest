using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

namespace GithubTest
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{
			ChromeDriverService service = ChromeDriverService.CreateDefaultService();
			service.HideCommandPromptWindow = true;


			IWebDriver driver = new ChromeDriver(service);
			driver.Navigate().GoToUrl("https://github.com/aycayakicii/repositories");


			IWebElement element = driver.FindElement(By.Name("q"));
			element.SendKeys("aycayakici ccslema");
			Thread.Sleep(2000);
			element.SendKeys(Keys.Enter);
			Thread.Sleep(2000);




		}
	}
}
