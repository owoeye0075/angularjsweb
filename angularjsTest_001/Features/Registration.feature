Feature: Registration
	As a User
	In order to use angularjs Website
	I will need to register to be user

@mytag
Scenario: Valid Registration
	Given I navigate to https://angularjs.realworld.io/
	And I clicked on Sign up
	And I enter username 
	And I enter valid email address
	And I enter password 
	When I click Sign up button
	Then I should successfully register 

@secondtage
Scenario: Invalid Email Registration 
	And I enter invalid email address


	@Thirdtag
Scenario: Invalid Password Registration 

# User enter password less than 6 character 
	And I enter invalid password address



	
	

	