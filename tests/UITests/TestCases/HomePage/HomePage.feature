Feature: Users can use the Home Page

    Scenario: Filter the Catalog
        When I set the Brand to '.NET'
        And I click Apply on the Results Filter
        Then There are 6 Catalog Items visible