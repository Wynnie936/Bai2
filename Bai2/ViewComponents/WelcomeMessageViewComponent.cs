using Microsoft.AspNetCore.Mvc;

namespace Bai2.ViewComponents;

public class WelcomeMessageViewComponent : ViewComponent
{
    public IViewComponentResult Invoke(string? message, int repeatCount = 3)
    {
        var model = new WelcomeMessageViewModel
        {
            Message = string.IsNullOrWhiteSpace(message)
                ? "Xin chào từ View Component!"
                : message,
            RepeatCount = Math.Clamp(repeatCount, 1, 10)
        };

        return View(model);
    }
}

public class WelcomeMessageViewModel
{
    public string Message { get; set; } = string.Empty;
    public int RepeatCount { get; set; }
}
