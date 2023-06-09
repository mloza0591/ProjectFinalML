Feature: Get Posts

A short summary of the feature

@smoke @positive @caso1
Scenario: Get by Id
	Given I have an Id with value 17
	When I send I get request
	Then I expected a valid code response

@smoke @positive @caso2
Scenario: Get all produts
	Given I have the url complement
	When I send I get all request
	Then I expected a valid code response get all

@smoke @positive @caso3
Scenario: Post Product
	Given I have a name with value Black Glass and description with value Black Glass and image with value black-glass.jpg and price with value 20.50 and categoryId with value 7
	When I send I post request
	Then I expected a valid code response post

@smoke @positive @caso4
Scenario: Put Product
	Given I want edit a product with id 17 
	And I edit a name with value Black Glass and description with value Black Glass and image with value black-glass.jpg and price with value 20.50 and categoryId with value 7
	When I send I put request
	Then I expected a valid code response put