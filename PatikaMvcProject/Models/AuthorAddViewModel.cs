namespace PatikaMvcProject.Models;

public class AuthorAddViewModel
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateOnly DateOfBirth { get; set; }
    public bool IsDeleted { get; set; }  
}