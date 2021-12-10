Feature: Selenium documentation

@mytag
Scenario: Open Grid page
	Given Introduction page is opened
	When I navigate to The Selenium project and tools page
	And click on grid of browsers link
	Then assert that Grid page is opened