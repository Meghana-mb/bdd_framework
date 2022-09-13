Feature: Store

In order manager orders
As a user 
I want to create, edit, delete, get order details

Scenario: Find order by orderId
Given I have base url 'https://petstore.swagger.io/v2/' and resource with petid 'store/order/3'
When I do the get request
Then I should get the response as 200
And I should get order details in json format

Scenario: Find order by non-existing orderId
Given I have base url 'https://petstore.swagger.io/v2/' and resource with petid 'store/order/103'
When I do the get request
Then I should get the response as 404

