using Microsoft.Playwright;

namespace FirstPlaywright.Actions;

public class ShoppingCartActions
{
    private readonly IPage _page;

    public ShoppingCartActions(IPage page)
    {
        _page = page;
    }

    public async Task OpenHomePage()
    {
        await _page.GotoAsync(
            "https://demowebshop.tricentis.com/"
        );
    }

    public async Task OpenBooks()
    {
        await _page
            .GetByRole(AriaRole.Link, new() { Name = "Books" })
            .Nth(1)
            .ClickAsync();
    }

    public async Task SelectBook()
    {
        await _page
            .GetByRole(
                AriaRole.Link,
                new() { Name = "Picture of Computing and" }
            )
            .ClickAsync();
    }

    public async Task AddToCart()
    {
        await _page
            .Locator("#add-to-cart-button-13")
            .ClickAsync();
    }

    public async Task OpenCart()
    {
        await _page
            .GetByRole(
                AriaRole.Link,
                new() { Name = "Shopping cart (1)" }
            )
            .ClickAsync();
    }
}