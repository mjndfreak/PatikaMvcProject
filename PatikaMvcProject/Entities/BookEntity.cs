using System.ComponentModel.DataAnnotations;

namespace PatikaMvcProject.Entities;

public class BookEntity
{
    public BookEntity()
    {
        IsRead = false;
    }
    public int Id { get; set; }
    public string Title { get; set; }
    public int AuthorId { get; set; }
    public string Genre { get; set; }
    public DateOnly PublishDate { get; set; }
    public string ISBN { get; set; }

    public int CopiesAvailable { get; set; }
    public bool IsRead { get; set; }
    
    // navigation property to the Author model
    public AuthorEntity AuthorEntity { get; set; }
}

