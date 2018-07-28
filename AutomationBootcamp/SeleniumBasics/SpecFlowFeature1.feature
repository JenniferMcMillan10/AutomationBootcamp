Feature: SpecFlowFeature1
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario: Search something in wikipedia
	Given the user has navigated to wikipedia
	When the user enters 'testing' into the search field
	And clicks search
	Then they will have results on 'Test'
