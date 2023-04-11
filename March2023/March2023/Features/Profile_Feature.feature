Feature: Profile_Feature

A short summary of the feature

@tag1




Scenario: ACreate Profile record with valid details 
	Given I logged into MARS portal successfully
	When I Navigate to Skill field on profile page
	And  I add new skills on pages
	Then  The Skill should be added successfully

Scenario Outline: BUpdate existing skill record
	Given I logged into MARS portal successfully
	When I Navigate to Skill field on profile page
	And I Update '<Skill>','<Level>' on an existing skill field record
	Then The record should have updated '<Skill>','<Level>'

	Examples: 
	| Skill   | Level        |
	| Reading | Intermediate |
	| Writing | Expert       |
	
	
Scenario Outline: CDelete existing skill record
			Given I logged into MARS portal successfully
			When I Navigate to Skill field on profile page
			And I delete  on an existing skill field record
			Then The record should have deleted

Scenario: Add record to profile page
		Given  I logged into MARS portal successfully
		When Add all details to profile page
		Then profile is updated successfully

Scenario: Create share skill
Given  I logged into MARS portal successfully
When I navigate to share skill
And i add all details
Then Shareskill page data added successfully

Scenario: Create language
Given  I logged into MARS portal successfully
When I navigate to language field on profile page
And  I add new language
Then  language should added successfully

Scenario: Update existing skill record with same value
Given  I logged into MARS portal successfully
When I enter same value that already exist
And I click on update button
Then Record should not updated
And That should give a error message "This skill is already added to your skill list"


Scenario: I logged in with invalid data
Given  I logged into MARS portal unsuccessfully
When  I enter valid username and invalid password
And I click on login button
Then That should give me error message "Incorrect PAsswod"

Scenario: New user search skill
Given New user try to search skill
When They enter skill in search
And they click on search button
Then  Result should be filter based onn search

Scenario: User try to go on profile page without login
Given user navigate to profile page
When After skill search result they navigate to home page
And they try to open profile page by clicking on profile
Then New page should open is the Loginpage





	


