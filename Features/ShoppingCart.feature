Feature: Shopping Cart

Scenario: Add a book to the shopping cart
    Given I am on the Demo Web Shop homepage
    When I navigate to Books
    And I select the Computing and Internet book
    And I add the book to the cart
    And I open the shopping cart