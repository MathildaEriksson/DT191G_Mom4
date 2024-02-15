using System.ComponentModel.DataAnnotations;
namespace DT191G_Mom4.Models;

public class Category
{
    public int CategoryId { get; set; }
    [Required]
    public string? Name { get; set; }
    public ICollection<Song> Songs { get; set; } = new List<Song>();
}