Feature: FormAuth
	In order to log in to the secure section
	As an anonymous user
	I want to be able to log in

 Scenario: Logging in correctly
	Given form authentication page is loaded 
	When I log in with "tomsmith" username and "SuperSecretPassword!" password
	Then a secure area opens

 Scenario: Logging in with wrong username
	Given form authentication page is loaded 
	When I log in with "bad" username and "bad" password
	Then an invalid username message opens

Scenario: Logging in with wrong password
	Given form authentication page is loaded 
	When I log in with "tomsmith" username and "bad" password
	Then an invalid password message opens