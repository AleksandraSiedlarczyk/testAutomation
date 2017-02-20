Feature: DynamicControls
	In order to check dynamic controls 
	As an anonymous user
	I want to be able to add and remove checkbox

 Scenario: Removing checkbox
	Given dynamic controls page is loaded
    When I remove checkbox
    Then checkbox is not displayed

 Scenario: Adding checkbox
	Given dynamic controls page is loaded
	And checkbox is removed
    When I add checkbox
    Then checkbox is displayed