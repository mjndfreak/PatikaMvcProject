using Microsoft.AspNetCore.Mvc;
using PatikaMvcProject.Entities;
using PatikaMvcProject.Models;
using PatikaMvcProject.Controllers;

namespace PatikaMvcProject.Controllers;

public class AuthorController : Controller
{
    public static List<AuthorEntity> _authors = new List<AuthorEntity>
    {
        new AuthorEntity { Id = 1, FirstName = "George", LastName = "Orwell", DateOfBirth = new DateOnly(1903, 6, 25) },
        new AuthorEntity { Id = 2, FirstName = "Aldous", LastName = "Huxley", DateOfBirth = new DateOnly(1894, 7, 26) },
        new AuthorEntity { Id = 3, FirstName = "Ray", LastName = "Bradbury", DateOfBirth = new DateOnly(1920, 8, 22) },
        new AuthorEntity { Id = 4, FirstName = "Isaac", LastName = "Asimov", DateOfBirth = new DateOnly(1920, 1, 2) },
        new AuthorEntity { Id = 5, FirstName = "Jules", LastName = "Verne", DateOfBirth = new DateOnly(1828, 2, 8) },
        new AuthorEntity { Id = 6, FirstName = "Philip", LastName = "Dick", DateOfBirth = new DateOnly(1928, 12, 16) },
        new AuthorEntity { Id = 7, FirstName = "Arthur", LastName = "Clarke", DateOfBirth = new DateOnly(1917, 12, 16) },
        new AuthorEntity { Id = 8, FirstName = "Frank", LastName = "Herbert", DateOfBirth = new DateOnly(1920, 10, 8) },
        new AuthorEntity { Id = 9, FirstName = "H.G.", LastName = "Wells", DateOfBirth = new DateOnly(1866, 9, 21) },
        new AuthorEntity { Id = 10, FirstName = "Mary", LastName = "Shelley", DateOfBirth = new DateOnly(1797, 8, 30) },
        new AuthorEntity { Id = 11, FirstName = "William", LastName = "Gibson", DateOfBirth = new DateOnly(1948, 3, 17) },
        new AuthorEntity { Id = 12, FirstName = "Ursula", LastName = "Le Guin", DateOfBirth = new DateOnly(1929, 10, 21) },
        new AuthorEntity { Id = 13, FirstName = "Neal", LastName = "Stephenson", DateOfBirth = new DateOnly(1959, 10, 31) },
        new AuthorEntity { Id = 14, FirstName = "Douglas", LastName = "Adams", DateOfBirth = new DateOnly(1952, 3, 11) },
        new AuthorEntity { Id = 15, FirstName = "Kurt", LastName = "Vonnegut", DateOfBirth = new DateOnly(1922, 11, 11) },
    };
    
    
    // The "List" Action method returns a view displaying a list of the Author's detail excluding the deleted ones
    // GET
    public IActionResult List()
    {
        var viewModel = _authors.Where(x => x.IsDeleted == false).Select(x => new AuthorListViewModel()
        {
            Id = x.Id,
            AuthorName = x.FirstName + " " + x.LastName,
            DateOfBirth = x.DateOfBirth,
            IsDeleted = x.IsDeleted
        }).ToList();
        return View(viewModel);
    }
    // This method enables toggling of an author's deleted status
    public IActionResult Delete(int id)
    {
        var author = _authors.Find(x => x.Id == id);
        author.IsDeleted = !author.IsDeleted;
        return RedirectToAction("List","Author");
    }
    // This method returns detailed information about a specific author
    public IActionResult Detail(int id)
    {
        var viewModel = _authors.Find(x => x.Id == id);
        var authorDetailViewModel = new AuthorDetailViewModel()
        {
            Id = viewModel.Id,
            FirstName = viewModel.FirstName,
            LastName = viewModel.LastName,
            DateOfBirth = viewModel.DateOfBirth,
            IsDeleted = viewModel.IsDeleted
        };
        return View(authorDetailViewModel);
    }
    // This action will show a form for adding new authors
    [HttpGet]
    public IActionResult Add()
    {
        return View();
    }
    // This is a post action for adding new authors
    [HttpPost]
    public IActionResult Add(AuthorAddViewModel formData)
    {
        if (!ModelState.IsValid)
        {
            return View(formData);
        }
        return RedirectToAction("List", "Author");
    }
}

