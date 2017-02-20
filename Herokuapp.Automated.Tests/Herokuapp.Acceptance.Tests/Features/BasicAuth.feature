Feature: BasicAuth
	In order to get access to the basic authenication section
	As an anonymous user
	I want to be able to sign in

 Scenario: Signing in correctly
	When I log in with correct data
	Then a success message is displayed