using PatikaMvcProject.Entities;

namespace PatikaMvcProject.Models;

public class BookDetailViewModel
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Genre { get; set; }
    public DateOnly PublishDate { get; set; }
    public string ISBN { get; set; }
    public int CopiesAvailable { get; set; }
    public string AuthorName { get; set; } 
    
}