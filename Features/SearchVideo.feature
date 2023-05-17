Feature: SearchVideo
	as a user
	I want to be able to search a video by a query

@test
Scenario: user search for a video
	Given user is in the home page
	When user search input the query "Polyphia - playing god cover"
	And user clicks on the first video with name "playing god"
	Then user is able to watch the video