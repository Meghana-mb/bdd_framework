Feature: Emergency Contact

A short summary of the feature

@tag1
Scenario: Add Emergency Contact
	Given I have a browser with orangehrm page
	When I enter username as '<username>'
	And I enter password as '<password>'
	And I click on login
	And I click on My Info
	And I click on Emerency Contacts
	And I click on Add
	And I fill the Save Emergency Contact Section
		| name   | relationship   | home_telephone   | mobile   | work_telephone   |
		| <name> | <relationship> | <home_telephone> | <mobile> | <work_telephone> |
	And I click on Save Emergency Contact
	Then I should be navigated to emergency contacts section with added contact
Examples:
	| username | password | name    | relationship | home_telephone | mobile | work_telephone |
	| Admin    | admin123 | Meghana | Sister       | 12345          | 67890  | 24680          |
	| Admin    | admin123 | Jimmy   | Brother      | 12345          | 67890  | 24680          |

	#Scenario: Add Emergency Contact
	#Given I have a browser with orangehrm page
	#When I enter username as 'Admin'
	#And I enter password as 'admin123'
	#And I click on login
	#And I click on My Info
	#And I click on Emerency Contacts
	#And I click on Add
	#And I fill the Save Emergency Contact Section
	#	| name    | relationship | home_telephone | mobile | work_telephone |
	#	| Meghana | Sister       | 12345          | 67890  | 24680          |
	#And I click on Save
	#Then I should be navigated to emergency contacts section with added contact
