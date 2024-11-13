namespace PatikaMvcProject.Models;

public class BookEditViewModel
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Genre { get; set; }
    public DateOnly PublishDate { get; set; }
    public string ISBN { get; set; }
    public int CopiesAvailable { get; set; }
    public int AuthorId { get; set; }
}