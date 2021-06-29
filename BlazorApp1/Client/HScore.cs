using System.ComponentModel.DataAnnotations;

public class HScore
{
    [Required]
    [StringLength(10, ErrorMessage = "Name is too long.")]
    public string Name { get; set; }
    public string Score { get; set; }
}