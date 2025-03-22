using System.ComponentModel.DataAnnotations;

namespace dndhelper.Models;

public class Character
{
    public required string Id { get; set; }   // Unique identifier for the character
    [Required]
    public string? Name { get; set; }        // Name of the character
    [Required]
    public string? CClass { get; set; }       // Class of the character
    [Required]
    public string? Race { get; set; }
    public string?  { get; set; }
}
