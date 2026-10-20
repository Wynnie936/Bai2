using Bai2.Models;
using Bai2.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Bai2.Controllers;

public class FestivalController : Controller
{
    public IActionResult Index()
    {
        var organizer = new Organizer
        {
            OrganizerId = 1,
            Name = "Trung tâm Văn hóa Thành phố",
            Type = "Cơ quan nhà nước",
            Experience = 12
        };

        var festivals = new List<Festival>
        {
            new()
            {
                FestivalId = 1,
                Name = "Lễ hội Áo dài",
                Date = new DateTime(2026, 3, 8),
                Location = "Công viên Trung tâm",
                OrganizerId = organizer.OrganizerId,
                Organizer = organizer
            },
            new()
            {
                FestivalId = 2,
                Name = "Lễ hội Ẩm thực Việt Nam",
                Date = new DateTime(2026, 4, 30),
                Location = "Quảng trường Thành phố",
                OrganizerId = organizer.OrganizerId,
                Organizer = organizer
            }
        };

        organizer.Festivals = festivals;

        var viewModel = new FestivalManagementViewModel
        {
            Organizer = organizer,
            Festivals = festivals
        };

        return View(viewModel);
    }
}
