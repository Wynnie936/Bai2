using Microsoft.AspNetCore.Mvc;

namespace Bai2.ViewComponents;

public class SiteMenuViewComponent : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        var menuItems = new List<SiteMenuItem>
        {
            new("Home", "Home", "Index"),
            new("Privacy", "Home", "Privacy"),
            new("Welcome", "Hello", "Welcome1")
        };

        return View(menuItems);
    }
}

public record SiteMenuItem(string Text, string Controller, string Action);
