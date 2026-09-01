# Demo Web Shop - Playwright Test Automation

A beginner test automation project built while learning C#, Microsoft Playwright and Behaviour-Driven Development (BDD).

The project automates user interactions on the Demo Web Shop website and is being developed as part of my transition into software testing and quality engineering.

## Technologies

- C#
- .NET
- Microsoft Playwright
- NUnit
- Reqnroll
- Gherkin / BDD
- Git & GitHub
- Visual Studio Code

## Current Test Scenario

The current automated scenario tests adding a product to the shopping cart.

```gherkin
Feature: Shopping Cart

Scenario: Add a book to the shopping cart
    Given I am on the Demo Web Shop homepage
    When I navigate to Books
    And I select the Computing and Internet book
    And I add the book to the cart
    And I open the shopping cart
