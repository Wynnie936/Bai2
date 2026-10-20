using System.ComponentModel.DataAnnotations;

namespace Bai2.Models;

public class Organizer
{
    public int OrganizerId { get; set; }

    [Required(ErrorMessage = "Tên ban tổ chức là bắt buộc.")]
    [StringLength(100, MinimumLength = 2, ErrorMessage = "Tên ban tổ chức phải từ 2 đến 100 ký tự.")]
    public string Name { get; set; } = string.Empty;

    [Required(ErrorMessage = "Loại ban tổ chức là bắt buộc.")]
    [StringLength(50, ErrorMessage = "Loại ban tổ chức không quá 50 ký tự.")]
    public string Type { get; set; } = string.Empty;

    [Range(0, 100, ErrorMessage = "Kinh nghiệm phải nằm trong khoảng 0 đến 100 năm.")]
    public int Experience { get; set; }

    public ICollection<Festival> Festivals { get; set; } = new List<Festival>();
}
