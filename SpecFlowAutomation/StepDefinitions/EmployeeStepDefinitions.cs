using OpenQA.Selenium;
using SpecFlowAutomation.Hooks;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowAutomation.StepDefinitions
{
    [Binding]
    public class EmployeeStepDefinitions
    {
        string fName;

        [When(@"I click on PIM")]
        public void WhenIClickOnPIM()
        {
            AutomationHooks.driver.FindElement(By.XPath("//span[text() = 'PIM']")).Click();
        }

        [When(@"I click on Add Employee")]
        public void WhenIClickOnAddEmployee()
        {
            AutomationHooks.driver.FindElement(By.XPath("//a[text() = 'Add Employee']")).Click();
        }

        [When(@"I fill the Add Employee section")]
        public void WhenIFillTheAddEmployeeSection(Table table)
        {
             fName = table.Rows[0]["firstname"];
            string mName = table.Rows[0]["middlename"];
            string lName = table.Rows[0]["lastname"];
            string empId = table.Rows[0]["employee_id"];
            string toggleLoginDetail= table.Rows[0]["toggle_login_detail"];
            string userName = table.Rows[0]["username"];
            string password = table.Rows[0]["password"];
            string confpass = table.Rows[0]["confirm_password"];
            string status = table.Rows[0]["status"];

            AutomationHooks.driver.FindElement(By.Name("firstName")).SendKeys(fName);
            AutomationHooks.driver.FindElement(By.Name("middleName")).SendKeys(mName);
            AutomationHooks.driver.FindElement(By.Name("lastName")).SendKeys(lName);
            //AutomationHooks.driver.FindElement(By.XPath("//input[text() = 'Employee Id']")).SendKeys(empId);

            if (toggleLoginDetail.Equals("on"))
            {
                AutomationHooks.driver.FindElement(By.XPath("//span[contains(@class,'oxd-switch-input')]")).Click();
                
                AutomationHooks.driver.FindElement(By.XPath("//label[contains(text(),'Username')]/following::input")).SendKeys(userName);
                AutomationHooks.driver.FindElement(By.XPath("//label[contains(text(),'Password')]/following::input")).SendKeys(password);
                AutomationHooks.driver.FindElement(By.XPath("//label[contains(text(),'Confirm Password')]/following::input")).SendKeys(confpass);
                //AutomationHooks.driver.FindElement(By.CssSelector("input[type='password']")).Click();

                if(status.ToLower().Equals("disabled"))
                {
                    AutomationHooks.driver.FindElement(By.XPath("//label[text()='Disabled']")).Click();
                }
                else
                {
                    AutomationHooks.driver.FindElement(By.XPath("//label[text()='Enabled']")).Click();
                }

                
            }

        }

        [When(@"I click on Save Employee")]
        public void WhenIClickOnSaveEmployee()
        {
            AutomationHooks.driver.FindElement(By.CssSelector("button[type='submit']")).Click();
        }

        [Then(@"I should be navigated to personal details section with added employee records")]
        public void ThenIShouldBeNavigatedToPersonalDetailsSectionWithAddedEmployeeRecords()
        {
            string actualFirstname= AutomationHooks.driver.FindElement(By.Name("firstName")).GetAttribute("value");
            Assert.Equal(fName, actualFirstname);
        }
    }
}

//tagname[@attribute='']
//tagname[text()='']

