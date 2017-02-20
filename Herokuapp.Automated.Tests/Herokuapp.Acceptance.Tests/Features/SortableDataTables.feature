Feature: SortableDataTables

Scenario: Getting email address
	Given sortable data tables page is loaded
	When I get "Jason Doe" email
	Then is equals to "jdoe@hotmail.com"