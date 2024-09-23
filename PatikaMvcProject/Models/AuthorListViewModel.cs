namespace PatikaMvcProject.Models;

public class AuthorListViewModel
{
    public int Id { get; set; }
    public string AuthorName{ get; set; } 
    public DateOnly DateOfBirth { get; set; }
    public bool IsDeleted { get; set; }
    
}