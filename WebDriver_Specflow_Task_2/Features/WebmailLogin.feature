Feature: Webmail login

@mytag
Scenario: Login with wrong credentials
	Given Webmail login form is opened
	When I enter wrong Email
	And I enter wrong Password
	And I click Log in button
	Then Invalid login attempt error message is displayed

Scenario: Login with empty credentials
	Given Webmail login form is opened
	When I click Log in button
	Then Credentials required error messages are displayed