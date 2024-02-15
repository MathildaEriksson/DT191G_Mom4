using System.ComponentModel.DataAnnotations;
namespace DT191G_Mom4.Models;

public class Song
{
    public int SongId { get; set; }
    [Required]
    public string? Artist { get; set; }
    [Required]
    public string? Title { get; set; }
    [Required]
    public int Length { get; set; }
}
