Feature: NewFeature
	In order to avoid silly mistakes
	As a member of the team
	I want to be told if any test scenario is failing


Scenario Outline: 1-Access dot_net_core_app_for_testing
	Given I am accessing the url '<url_login>'
	When I authenticate with user 'tester' and password '1234'
	Then system displays the page '<home_page>'
	Examples: 
		| Id | url_login                                               | home_page                                    |
		| 1  | http://dotnetcoreappfortesting.herokuapp.com/Home/Login | http://dotnetcoreappfortesting.herokuapp.com |
		| 2  | http://dotnetcoreappfortesting.herokuapp.com/Home/Login | http://dotnetcoreappfortesting.herokuapp.com |
		| 3  | http://dotnetcoreappfortesting.herokuapp.com/Home/Login | http://dotnetcoreappfortesting.herokuapp.com |
		| 4  | http://dotnetcoreappfortesting.herokuapp.com/Home/Login | http://dotnetcoreappfortesting.herokuapp.com |
		| 5  | http://dotnetcoreappfortesting.herokuapp.com/Home/Login | http://dotnetcoreappfortesting.herokuapp.com |
		| 6  | http://dotnetcoreappfortesting.herokuapp.com/Home/Login | http://dotnetcoreappfortesting.herokuapp.com |