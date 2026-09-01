using Reqnroll;
using FirstPlaywright.Actions;
using Microsoft.Playwright;

namespace FirstPlaywright.StepDefinitions;

[Binding]
public class ShoppingCartSteps
{
    private readonly ShoppingCartActions _actions;

    public ShoppingCartSteps(ShoppingCartActions actions)
    {
        _actions = actions;
    }

    [Given("I am on the Demo Web Shop homepage")]
    public async Task GivenIAmOnTheHomepage()
    {
        await _actions.OpenHomePage();
    }

    [When("I navigate to Books")]
    public async Task WhenINavigateToBooks()
    {
        await _actions.OpenBooks();
    }

    [When("I select the Computing and Internet book")]
    public async Task WhenISelectTheBook()
    {
        await _actions.SelectBook();
    }

    [When("I add the book to the cart")]
    public async Task WhenIAddTheBookToTheCart()
    {
        await _actions.AddToCart();
    }

    [When("I open the shopping cart")]
    public async Task WhenIOpenTheShoppingCart()
    {
        await _actions.OpenCart();
    }
}