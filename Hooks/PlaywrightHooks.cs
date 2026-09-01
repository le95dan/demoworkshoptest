using Microsoft.Playwright;
using Reqnroll;
using Reqnroll.BoDi;

namespace FirstPlaywright.Hooks;

[Binding]
public class PlaywrightHooks
{
    private IPlaywright? _playwright;
    private IBrowser? _browser;

    private readonly IObjectContainer _container;

    public PlaywrightHooks(IObjectContainer container)
    {
        _container = container;
    }

    [BeforeScenario]
    public async Task BeforeScenario()
    {
        _playwright = await Playwright.CreateAsync();

        _browser = await _playwright.Chromium.LaunchAsync(new()
        {
            Headless = false
        });

        var page = await _browser.NewPageAsync();

        _container.RegisterInstanceAs<IPage>(page);
    }

    [AfterScenario]
    public async Task AfterScenario()
    {
        if (_browser != null)
        {
            await _browser.CloseAsync();
        }

        _playwright?.Dispose();
    }
}