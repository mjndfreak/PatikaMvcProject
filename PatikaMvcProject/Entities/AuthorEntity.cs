namespace PatikaMvcProject.Entities;

public class AuthorEntity
{
    public AuthorEntity()
    {
        IsDeleted = false;
    }
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateOnly DateOfBirth { get; set; }
    public bool IsDeleted { get; set; }

    public string FullName
    {
        get
        {
            return FirstName + " " + LastName;
        }
    }
}