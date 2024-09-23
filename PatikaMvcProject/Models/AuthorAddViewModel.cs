using System.ComponentModel.DataAnnotations;

namespace PatikaMvcProject.Models;

public class AuthorAddViewModel
{
    [Required (ErrorMessage = "This must be filled.")]
    public int Id { get; set; }
    [Required (ErrorMessage = "This must be filled.")]
    public string FirstName { get; set; }
    [Required (ErrorMessage = "This must be filled.")]
    public string LastName { get; set; }
    [Required (ErrorMessage = "This must be filled.")]
    public DateOnly DateOfBirth { get; set; }
    
    public bool IsDeleted { get; set; }  
}