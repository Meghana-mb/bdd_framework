using OpenQA.Selenium;
using SpecFlowAutomation.Hooks;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowAutomation.StepDefinitions
{
    [Binding]
    public class EmergencyContactStepDefinitions
    {
        
        private static Table  tbl;
        [When(@"I click on My Info")]
        public void WhenIClickOnMyInfo()
        {
            AutomationHooks.driver.FindElement(By.XPath("//span[text() = 'My Info']")).Click();
        }

        [When(@"I click on Emerency Contacts")]
        public void WhenIClickOnEmerencyContacts()
        {
            AutomationHooks.driver.FindElement(By.XPath("//a[text() = 'Emergency Contacts']")).Click();
        }

        [When(@"I click on Add")]
        public void WhenIClickOnAdd()
        {
            AutomationHooks.driver.FindElement(By.XPath("//h6[contains(@class,'orange')]/following::button")).Click();
        }

        [When(@"I fill the Save Emergency Contact Section")]
        public void WhenIFillTheSaveEmergencyContactSection(Table table)
        {
            tbl = table;
            string name = table.Rows[0]["name"];
            string relationship = table.Rows[0]["relationship"];
            string homeTelephone = table.Rows[0]["home_telephone"];
            string mobile = table.Rows[0]["mobile"];
            string workTelephone = table.Rows[0]["work_telephone"];

            AutomationHooks.driver.FindElement(By.XPath("//label[contains(text(),'Name')]/following::input")).SendKeys(name);
            AutomationHooks.driver.FindElement(By.XPath("//label[contains(text(),'Relationship')]/following::input")).SendKeys(relationship);
            AutomationHooks.driver.FindElement(By.XPath("//label[contains(text(),'Home Telephone')]/following::input")).SendKeys(homeTelephone);
            AutomationHooks.driver.FindElement(By.XPath("//label[contains(text(),'Mobile')]/following::input")).SendKeys(mobile);
            AutomationHooks.driver.FindElement(By.XPath("//label[contains(text(),'Work Telephone')]/following::input")).SendKeys(workTelephone);
        }

        [When(@"I click on Save Emergency Contact")]
        public void WhenIClickOnSaveEmergencyContact()
        {
            AutomationHooks.driver.FindElement(By.CssSelector("button[type='submit']")).Click();
        }

        [Then(@"I should be navigated to emergency contacts section with added contact")]
        public void ThenIShouldBeNavigatedToEmergencyContactsSectionWithAddedContact()
        {
            string actualData = AutomationHooks.driver.FindElement(By.XPath("//div[@class='oxd-table']")).Text;
            string expectedName = tbl.Rows[0]["Name"];
            Assert.Equal(expectedName, actualData);
        }
    }
}
