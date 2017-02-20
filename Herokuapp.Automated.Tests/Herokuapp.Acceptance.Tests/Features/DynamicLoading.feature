Feature: DynamicLoading
	In order to check dynamic loading 
	As an anonymous user
	I want to be able to show a loading bar

 Scenario: Showing a loading bar
	Given dynamic loading page is loaded
    When I start loading 
    Then a loading bar appears
	And "Hello World!" message is displayed