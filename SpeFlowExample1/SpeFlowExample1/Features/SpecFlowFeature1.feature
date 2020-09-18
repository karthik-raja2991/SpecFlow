Feature: SpecFlowFeature1
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@smoke
Scenario: Add two numbers
	Given the first number is 50
	And the second number is 70
	When the two numbers are added
	Then the result should be 120

Scenario: Create a new employee with mandatory details
	#Given I have opened my application
	#Then I should see employee details page
	When I fill all mandatory detaisl in form 
	| Name    | Age | Phone      | Email                 |
	| karthik | 28  | 7975208680 | karthik2991@gmail.com |
	| Sri | 29  | 7975208682 | sri2991@gmail.com |
	#And click on save button
	#Then i should see all details saved in application DB

Scenario Outline: Create a new employee with mandatory details one by one
	#Given I have opened my application
	#Then I should see employee details page
	When I fill all mandatory detaisl in form <Name>, <Age> and <Phone>
	#And click on save button
	#Then i should see all details saved in application DB
Examples: 
	| Name    | Age | Phone      | 
	| karthik | 28  | 7975208680 | 
	| Sri | 29  | 7975208682 | 

Scenario: Add two numbers and give the result
	Given the first number is 50
	And the second number is 70
	And the third number is 100
	When the two numbers are added
	Then the result should be 120

Scenario: Add two numbers and give the result and publish result to Azure
	Given the first number is 50
	And the second number is 70
	And the third number is 100
	When the two numbers are added
	Then the result should be 120