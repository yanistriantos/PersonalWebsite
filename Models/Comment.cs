using System.ComponentModel.DataAnnotations;

namespace PersonalWebsite.Models;

public class Comment
{
    public int Id { get; set; }

    [Required]
    [StringLength(100)]
    public string Username { get; set; } = string.Empty;

    [Required]
    public string Message { get; set; } = string.Empty;

    public DateTime CreatedDate { get; set; } = DateTime.Now;

    [StringLength(100)]
    public string? SessionId { get; set; }
}



