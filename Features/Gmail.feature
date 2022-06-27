Feature: Gmailchecks



Background:
Given User launches gmail login page		
Scenario: Open gmail and check for interview emails	
	When User should be able to logged in
	Then User gets details of unread emails

