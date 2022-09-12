Feature: Login
In order to maintain employee records
As a user
I want to login into the portal

Background: 
	Given I have a browser with orangehrm page


@high @valid
Scenario: Valid Credential
	When I enter username as 'Admin'
	And I enter password as 'admin123'
	And I click on login
	Then I should navigate to 'PIM' dashboard screen

	@low @invalid
Scenario Outline: Invalid Credential
	When I enter username as '<username>'
	And I enter password as '<password>'
	And I click on login
	Then I should get error message as '<error_msg>'
	Examples: 
	| username | password | error_msg           |
	| Admin    | admin123 | Invalid Credentials |
	| John     | john123  | Invalid Credentials |

