﻿Feature: Addition
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario: Add two numbers
	Given I have entered 50 into the calculator
	And I have entered 70 into the calculator
	When I press add
	Then the result should be 120 on the screen

Scenario: Add other numbers
	Given I have entered 30 into the calculator
	And I have entered 40 into the calculator
	When I press add
	Then the result should be 70 on the screen

Scenario: Add 3 numbers
	Given I enter first number 10
	And I enter second number 20
	And I enter third number 30
	When I press add
	Then the result should be 60 on the screen
