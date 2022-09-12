Feature: Employee
In order to add, edit, delete employee records
As an admin
I want to modify employee details

@tag1
Scenario Outline: Add valid employee
	Given I have a browser with orangehrm page
	When I enter username as '<username>'
	And I enter password as '<password>'
	And I click on login
	And I click on PIM
	And I click on Add Employee
	And I fill the Add Employee section
		| firstname   | middlename   | lastname   | employee_id | toggle_login_detail | username       | password           | confirm_password   | status   |
		| <firstname> | <middlename> | <lastname> | <empid>     | <toggle_login>      | <account_user> | <account_password> | <confirm_password> | <status> |
	And I click on Save Employee
	Then I should be navigated to personal details section with added employee records
Examples:
	| username | password | firstname | middlename | lastname   | empid | toggle_login | account_user | account_password | confirm_password | status   |
	| Admin    | admin123 | Meghana   | J          | Maringanty | 1001  | on           | person1      | Welcome@123      | Welcome@123      | disabled |
	| Admin    | admin123 | Aditi     | D          | Gupta      | 1001  | on           | person2      | Welcome@123      | Welcome@123      | disabled |


	
	#And I enter firstname as 
	#And I enter middlename as
	#And I enter lastname as
	#And I enter employee id as
	#And I upload employee image as
	#And I select create credential
	#And I enter username as
	#And I enter password as 
	#And I enter confirm password as
	#And I select status as 'Disabled'
	#And I click on save
	#Then Employee should be added 



#1. Navigate to the url
#2. Enter Admin username
#3. Enter password
#4. Click Login
#5. click on PIM
#6. Click on Add Employee
#7. Enter firstname
#8. Enter middlename
#9. Enter lastname
#10. Enter Employee Id
#11. Upload the employee image
#12. Check - create credential
#13. Enter Username
#14. Enter password
#15. Enter Confirm password
#16. Select status as Disabled
#17. Click on save

#Scenario: Add valid employee
#	Given I have a browser with orangehrm page
#	When I enter username as 'Admin'
#	And I enter password as 'admin123'
#	And I click on login
#	And I click on PIM
#	And I click on Add Employee
#	And I fill the Add Employee section
#		| firstname | middlename | lastname   | employee_id | toggle_login_detail | username  | password    | confirm_password | status   |
#		| Meghana   | J          | Maringanty | 1001        | on                  | jimmy1234 | Welcome@123 | Welcome@123      | disabled |
#	And I click on Save Employee
#	Then I should be navigated to personal details section with added employee records
