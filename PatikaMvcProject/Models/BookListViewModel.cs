using System.ComponentModel.DataAnnotations;
using PatikaMvcProject.Entities;

namespace PatikaMvcProject.Models;

public class BookListViewModel
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Genre { get; set; }
    public DateOnly PublishDate { get; set; }
    public string ISBN { get; set; }
    public int CopiesAvailable { get; set; }
    public string AuthorName { get; set; }
    public bool IsRead { get; set; }
}