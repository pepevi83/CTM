Feature: Compare The Market Energy comparison
    In order to get quotes from different companies that provide energy products
    As a user of Compare The Market
    I want to be able to select different energy during the user journey

Scenario: Test1
	Given I visit the energy comparison site on CTM
	When I enter PE2 6YS postCode
		And I verify is a valid PostCode
		And I select Yes in I have my bill handy
		And I want to compare Gas&Electricity
		And I select No in Gas&Electricy is same supplier
		And I select E.ON as electricity supplier from radio buttons
		And I select Bulb as gas supplier from dropdown

