Feature: Profile_Feature

A short summary of the feature

@tag1
Scenario: ACreate Profile record with valid details 
	Given I logged into turnup portal successfully
	When I Navigate to Skill field on profile page
	And  I add new skills on pages
	Then  The Skill should be added successfully

Scenario Outline:BUpdate existing skill record
	Given I logged into turnup portal successfully
	When I Navigate to Skill field on profile page
	And I Update '<Skill>','<Level>' on an existing skill field record
	Then The record should have updated '<Skill>','<Level>'

	Examples: 
	| Skill   | Level        |
	| Reading | Intermediate |
	| Writing | Expert       |
	
	Scenario Outline: CDelete existing skill record
			Given I logged into turnup portal successfully
			When I Navigate to Skill field on profile page
			And I delete  on an existing skill field record
			Then The record should have deleted

	


