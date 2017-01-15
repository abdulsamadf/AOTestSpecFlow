Feature: Search for Washing Machine
	In order to be able to search for Hotpoint Washing Machines
	As a general customer
	I want results to display 3 star customer rated washing machines

@mytag
Scenario: Search for Washing Machine
	Given I have searched for Washing machines
	And I have selected the Hotpoint Brand
	When I filter for 3 or more star customer rated washing machines
	Then the result should display Hotpoint Washing Machines with a 3-0 & above rating