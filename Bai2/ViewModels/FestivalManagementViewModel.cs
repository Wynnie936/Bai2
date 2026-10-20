using Bai2.Models;

namespace Bai2.ViewModels;

public class FestivalManagementViewModel
{
    public Organizer Organizer { get; set; } = new();
    public IReadOnlyList<Festival> Festivals { get; set; } = Array.Empty<Festival>();
}
