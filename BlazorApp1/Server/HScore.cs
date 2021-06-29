using System.ComponentModel.DataAnnotations;

public class HScore
{
    [Required]
    [StringLength(4, ErrorMessage = "Initials are too long.")]
    public string Name { get; set; }
    public string Score { get; set; }
}