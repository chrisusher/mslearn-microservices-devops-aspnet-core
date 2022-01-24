Feature: Users can order Items from the Store

    @Smoke
    Scenario: Complete an Order
        Given I am logged in
        When I add an Item
        And I navigate to My Shopping Bag
        And I complete the Checkout
        Then My order appears in My Order List