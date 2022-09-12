using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SpecFlowAutomation.Hooks;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowAutomation.StepDefinitions
{
    [Binding]
    public class LoginStepDefinitions
    {
        

        [Given(@"I have a browser with orangehrm page")]
        public void GivenIHaveABrowserWithOrangehrmPage()
        {
            //Console.WriteLine("Given");
            AutomationHooks.driver = new ChromeDriver();
            AutomationHooks.driver.Manage().Window.Maximize();
            AutomationHooks.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            AutomationHooks.driver.Url = "https://opensource-demo.orangehrmlive.com/";
        }

        [When(@"I enter username as '([^']*)'")]
        public void WhenIEnterUsernameAs(string username)
        {
            //Console.WriteLine(username);
            AutomationHooks.driver.FindElement(By.Name("username")).SendKeys(username);
        }

        [When(@"I enter password as '([^']*)'")]
        public void WhenIEnterPasswordAs(string password)
        {
            //Console.WriteLine(password);
            AutomationHooks.driver.FindElement(By.Name("password")).SendKeys(password);
        }

        [When(@"I click on login")]
        public void WhenIClickOnLogin()
        {
            //Console.WriteLine("Click on Login");
            AutomationHooks.driver.FindElement(By.CssSelector("button[type='submit']")).Click();
        }

        [Then(@"I should navigate to '([^']*)' dashboard screen")]
        public void ThenIShouldNavigateToDashboardScreen(string expectedvalue)
        {
            Console.WriteLine(expectedvalue);
        }

        [Then(@"I should get error message as '([^']*)'")]
        public void ThenIShouldGetErrorMessageAs(string expectederr)
        {
            Console.WriteLine(expectederr);
        }

    }
}
