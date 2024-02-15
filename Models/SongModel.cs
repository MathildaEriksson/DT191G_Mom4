using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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

     // Foreign key
    public int CategoryId { get; set; }
    
    // Navigation property
    [ForeignKey("CategoryId")]
    public Category? Category { get; set; }
}
