using System.ComponentModel.DataAnnotations;

namespace Bai2.Models;

public class Festival
{
    public int FestivalId { get; set; }

    [Required(ErrorMessage = "Tên lễ hội là bắt buộc.")]
    [StringLength(150, MinimumLength = 2, ErrorMessage = "Tên lễ hội phải từ 2 đến 150 ký tự.")]
    public string Name { get; set; } = string.Empty;

    [Required(ErrorMessage = "Ngày tổ chức là bắt buộc.")]
    [DataType(DataType.Date)]
    public DateTime Date { get; set; }

    [Required(ErrorMessage = "Địa điểm là bắt buộc.")]
    [StringLength(200, ErrorMessage = "Địa điểm không quá 200 ký tự.")]
    public string Location { get; set; } = string.Empty;

    [Required(ErrorMessage = "Phải chọn ban tổ chức.")]
    public int OrganizerId { get; set; }

    public Organizer? Organizer { get; set; }
}
