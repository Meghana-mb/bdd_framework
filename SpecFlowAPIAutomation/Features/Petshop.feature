Feature: Petshop

In order to create an environment for managing petshop
As a user 
I want to create, edit, delete, get pet details


Scenario: Find pet by PetId
Given I have base url 'https://petstore.swagger.io/v2/' and resource with petid 'pet/102'
When I do the get request
Then I should get the response as 200
And I should get pet details in json format

Scenario: Find pet by invalid PetId
Given I have base url 'https://petstore.swagger.io/v2/' and resource with petid 'pet/-102'
When I do the get request
Then I should get the response as 400
And I should get message as 'Invalid ID supplied'

Scenario: Find pet by non-existant PetId
Given I have base url 'https://petstore.swagger.io/v2/' and resource with petid 'pet/502'
When I do the get request
Then I should get the response as 404
And I should get message as 'Pet not found'

Scenario: Delete pet by petId
Given I have base url 'https://petstore.swagger.io/v2/' and resource with petid 'pet/102'
And I need add api_key 'AK888' in the header
When I do the delete request
Then I should get the response as 200

Scenario: Delete pet by invalid petId
Given I have base url 'https://petstore.swagger.io/v2/' and resource with petid 'pet/-102'
And I need add api_key 'AK888' in the header
When I do the delete request
Then I should get the response as 400
And I should get message as 'Invalid ID supplied'

Scenario: Delete pet by non-existant PetId
Given I have base url 'https://petstore.swagger.io' and resource with petid 'pet/502'
And I need add api_key 'AK888' in the header
When I do the delete request
Then I should get the response as 404
And I should get message as 'Pet not found'
