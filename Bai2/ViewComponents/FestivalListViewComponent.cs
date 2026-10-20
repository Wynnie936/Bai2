using Bai2.Models;
using Microsoft.AspNetCore.Mvc;

namespace Bai2.ViewComponents;

public class FestivalListViewComponent : ViewComponent
{
    public IViewComponentResult Invoke(IReadOnlyList<Festival> festivals)
    {
        return View(festivals);
    }
}
