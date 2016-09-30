Feature:LatestNews
	1.	Navigate to the www.valtech.com homepage
	a.	Assert that the “Latest News” section is displaying
	Navigate to CASES, SERVICES and JOBS pages via top navigation 
	and assert that H1 tag in each page is displaying the relevant page name. 
	Ex H1 tag in Services page is displaying as “Services”


@mytag
Scenario: Assert that the “Latest News” section is displaying
	Given that I navigate to the url "www.valtech.com"
	When I scroll to the “Latest News”
	Then I should see it the "Latest News" on the page

	
@mytag
Scenario: Navigate to CASES
	Given that I navigate to the url "www.valtech.com"
	When I click on CASES
	Then the CASES page should be displayed

Scenario: Navigate to SERVICES
	Given that I navigate to the url "www.valtech.com"
	When I click on SERVICES
	Then the SERVICES page should be displayed


Scenario: Navigate to JOBS
	Given that I navigate to the url "www.valtech.com"
	When I click on JOBS
	Then the JOBS page should be displayed

@mytag
Scenario: Navigate to Contact page and output
	Given that I navigate to the url "www.valtech.com"
	When I navigate to the contact page
	Then I can displaythe total number of Valtech offices


