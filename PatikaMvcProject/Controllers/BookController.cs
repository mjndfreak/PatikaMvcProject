using Feliz;
using Microsoft.AspNetCore.Mvc;
using PatikaMvcProject.Entities;
using PatikaMvcProject.Models;

namespace PatikaMvcProject.Controllers;

public class BookController : Controller
{

    public static List<AuthorEntity> _authors = new List<AuthorEntity>
    {
        new AuthorEntity { Id = 1, FirstName = "George", LastName = "Orwell", DateOfBirth = new DateOnly(1903, 6, 25) },
        new AuthorEntity { Id = 2, FirstName = "Aldous", LastName = "Huxley", DateOfBirth = new DateOnly(1894, 7, 26) },
        new AuthorEntity { Id = 3, FirstName = "Ray", LastName = "Bradbury", DateOfBirth = new DateOnly(1920, 8, 22) },
        new AuthorEntity { Id = 4, FirstName = "Isaac", LastName = "Asimov", DateOfBirth = new DateOnly(1920, 1, 2) },
        new AuthorEntity { Id = 5, FirstName = "Jules", LastName = "Verne", DateOfBirth = new DateOnly(1828, 2, 8) },
        new AuthorEntity { Id = 6, FirstName = "Philip", LastName = "Dick", DateOfBirth = new DateOnly(1928, 12, 16) },
        new AuthorEntity
            { Id = 7, FirstName = "Arthur", LastName = "Clarke", DateOfBirth = new DateOnly(1917, 12, 16) },
        new AuthorEntity { Id = 8, FirstName = "Frank", LastName = "Herbert", DateOfBirth = new DateOnly(1920, 10, 8) },
        new AuthorEntity { Id = 9, FirstName = "H.G.", LastName = "Wells", DateOfBirth = new DateOnly(1866, 9, 21) },
        new AuthorEntity { Id = 10, FirstName = "Mary", LastName = "Shelley", DateOfBirth = new DateOnly(1797, 8, 30) },
        new AuthorEntity
            { Id = 11, FirstName = "William", LastName = "Gibson", DateOfBirth = new DateOnly(1948, 3, 17) },
        new AuthorEntity
            { Id = 12, FirstName = "Ursula", LastName = "Le Guin", DateOfBirth = new DateOnly(1929, 10, 21) },
        new AuthorEntity
            { Id = 13, FirstName = "Neal", LastName = "Stephenson", DateOfBirth = new DateOnly(1959, 10, 31) },
        new AuthorEntity
            { Id = 14, FirstName = "Douglas", LastName = "Adams", DateOfBirth = new DateOnly(1952, 3, 11) },
        new AuthorEntity
            { Id = 15, FirstName = "Kurt", LastName = "Vonnegut", DateOfBirth = new DateOnly(1922, 11, 11) },
    };




    public static List<BookEntity> _books = new List<BookEntity>
    {
        // George Orwell (Author 1)
        new BookEntity
        {
            Id = 1, Title = "1984", Genre = "Dystopian", PublishDate = new DateOnly(1949, 6, 8), ISBN = "9780451524935",
            CopiesAvailable = 100, AuthorId = 1, AuthorEntity = _authors[0]
        },
        new BookEntity
        {
            Id = 2, Title = "Animal Farm", Genre = "Allegorical novella", PublishDate = new DateOnly(1945, 8, 17),
            ISBN = "9780451526342", CopiesAvailable = 120, AuthorId = 1, AuthorEntity = _authors[0]
        },
        new BookEntity
        {
            Id = 3, Title = "Homage to Catalonia", Genre = "Memoir", PublishDate = new DateOnly(1938, 4, 25),
            ISBN = "9780156421171", CopiesAvailable = 70, AuthorId = 1, AuthorEntity = _authors[0]
        },

        // Aldous Huxley (Author 2)
        new BookEntity
        {
            Id = 4, Title = "Brave New World", Genre = "Dystopian", PublishDate = new DateOnly(1932, 9, 1),
            ISBN = "9780060850524", CopiesAvailable = 80, AuthorId = 2, AuthorEntity = _authors[1]
        },
        new BookEntity
        {
            Id = 5, Title = "Island", Genre = "Philosophical fiction", PublishDate = new DateOnly(1962, 6, 1),
            ISBN = "9780061561795", CopiesAvailable = 90, AuthorId = 2, AuthorEntity = _authors[1]
        },
        new BookEntity
        {
            Id = 6, Title = "The Doors of Perception", Genre = "Philosophy", PublishDate = new DateOnly(1954, 1, 1),
            ISBN = "9780061729072", CopiesAvailable = 65, AuthorId = 2, AuthorEntity = _authors[1]
        },

        // Ray Bradbury (Author 3)
        new BookEntity
        {
            Id = 7, Title = "Fahrenheit 451", Genre = "Dystopian", PublishDate = new DateOnly(1953, 10, 19),
            ISBN = "9781451673319", CopiesAvailable = 90, AuthorId = 3, AuthorEntity = _authors[2]
        },
        new BookEntity
        {
            Id = 8, Title = "The Martian Chronicles", Genre = "Science Fiction", PublishDate = new DateOnly(1950, 5, 4),
            ISBN = "9781451678192", CopiesAvailable = 75, AuthorId = 3, AuthorEntity = _authors[2]
        },
        new BookEntity
        {
            Id = 9, Title = "Something Wicked This Way Comes", Genre = "Fantasy",
            PublishDate = new DateOnly(1962, 1, 1), ISBN = "9780380977277", CopiesAvailable = 60, AuthorId = 3,
            AuthorEntity = _authors[2]
        },

        // Isaac Asimov (Author 4)
        new BookEntity
        {
            Id = 10, Title = "I, Robot", Genre = "Science Fiction", PublishDate = new DateOnly(1950, 12, 2),
            ISBN = "9780553294385", CopiesAvailable = 75, AuthorId = 4, AuthorEntity = _authors[3]
        },
        new BookEntity
        {
            Id = 11, Title = "Foundation", Genre = "Science Fiction", PublishDate = new DateOnly(1951, 1, 1),
            ISBN = "9780553293357", CopiesAvailable = 85, AuthorId = 4, AuthorEntity = _authors[3]
        },
        new BookEntity
        {
            Id = 12, Title = "The Gods Themselves", Genre = "Science Fiction", PublishDate = new DateOnly(1972, 5, 1),
            ISBN = "9780553288100", CopiesAvailable = 70, AuthorId = 4, AuthorEntity = _authors[3]
        },

        // Jules Verne (Author 5)
        new BookEntity
        {
            Id = 13, Title = "20,000 Leagues Under the Sea", Genre = "Adventure",
            PublishDate = new DateOnly(1870, 1, 1), ISBN = "9780140621184", CopiesAvailable = 60, AuthorId = 5,
            AuthorEntity = _authors[4]
        },
        new BookEntity
        {
            Id = 14, Title = "Journey to the Center of the Earth", Genre = "Adventure",
            PublishDate = new DateOnly(1864, 1, 1), ISBN = "9780141441979", CopiesAvailable = 65, AuthorId = 5,
            AuthorEntity = _authors[4]
        },
        new BookEntity
        {
            Id = 15, Title = "Around the World in Eighty Days", Genre = "Adventure",
            PublishDate = new DateOnly(1873, 1, 1), ISBN = "9780553213560", CopiesAvailable = 70, AuthorId = 5,
            AuthorEntity = _authors[4]
        },

        // Philip K. Dick (Author 6)
        new BookEntity
        {
            Id = 16, Title = "Do Androids Dream of Electric Sheep?", Genre = "Science Fiction",
            PublishDate = new DateOnly(1968, 1, 1), ISBN = "9780345404473", CopiesAvailable = 50, AuthorId = 6,
            AuthorEntity = _authors[5]
        },
        new BookEntity
        {
            Id = 17, Title = "The Man in the High Castle", Genre = "Alternate history",
            PublishDate = new DateOnly(1962, 10, 1), ISBN = "9780547572482", CopiesAvailable = 55, AuthorId = 6,
            AuthorEntity = _authors[5]
        },
        new BookEntity
        {
            Id = 18, Title = "Ubik", Genre = "Science Fiction", PublishDate = new DateOnly(1969, 1, 1),
            ISBN = "9780547572291", CopiesAvailable = 45, AuthorId = 6, AuthorEntity = _authors[5]
        },

        // Arthur C. Clarke (Author 7)
        new BookEntity
        {
            Id = 19, Title = "Childhood's End", Genre = "Science Fiction", PublishDate = new DateOnly(1953, 9, 1),
            ISBN = "9780345347954", CopiesAvailable = 70, AuthorId = 7, AuthorEntity = _authors[6]
        },
        new BookEntity
        {
            Id = 20, Title = "2001: A Space Odyssey", Genre = "Science Fiction",
            PublishDate = new DateOnly(1968, 6, 16), ISBN = "9780451457998", CopiesAvailable = 80, AuthorId = 7,
            AuthorEntity = _authors[6]
        },
        new BookEntity
        {
            Id = 21, Title = "Rendezvous with Rama", Genre = "Science Fiction", PublishDate = new DateOnly(1973, 7, 1),
            ISBN = "9780553287899", CopiesAvailable = 60, AuthorId = 7, AuthorEntity = _authors[6]
        },

        // Frank Herbert (Author 8)
        new BookEntity
        {
            Id = 22, Title = "Dune", Genre = "Science Fiction", PublishDate = new DateOnly(1965, 8, 1),
            ISBN = "9780441013593", CopiesAvailable = 150, AuthorId = 8, AuthorEntity = _authors[7]
        },
        new BookEntity
        {
            Id = 23, Title = "Dune Messiah", Genre = "Science Fiction", PublishDate = new DateOnly(1969, 10, 15),
            ISBN = "9780441172696", CopiesAvailable = 90, AuthorId = 8, AuthorEntity = _authors[7]
        },
        new BookEntity
        {
            Id = 24, Title = "Children of Dune", Genre = "Science Fiction", PublishDate = new DateOnly(1976, 4, 21),
            ISBN = "9780441104024", CopiesAvailable = 80, AuthorId = 8, AuthorEntity = _authors[7]
        },

        // H.G. Wells (Author 9)
        new BookEntity
        {
            Id = 25, Title = "The War of the Worlds", Genre = "Science Fiction", PublishDate = new DateOnly(1898, 1, 1),
            ISBN = "9780553213386", CopiesAvailable = 95, AuthorId = 9, AuthorEntity = _authors[8]
        },
        new BookEntity
        {
            Id = 26, Title = "The Time Machine", Genre = "Science Fiction", PublishDate = new DateOnly(1895, 1, 1),
            ISBN = "9780553213515", CopiesAvailable = 85, AuthorId = 9, AuthorEntity = _authors[8]
        },
        new BookEntity
        {
            Id = 27, Title = "The Invisible Man", Genre = "Science Fiction", PublishDate = new DateOnly(1897, 1, 1),
            ISBN = "9780553213515", CopiesAvailable = 75, AuthorId = 9, AuthorEntity = _authors[8]
        },

        // Mary Shelley (Author 10)
        new BookEntity
        {
            Id = 28, Title = "Frankenstein", Genre = "Science Fiction", PublishDate = new DateOnly(1818, 1, 1),
            ISBN = "9780141439471", CopiesAvailable = 200, AuthorEntity = _authors[9]
        }

    };




    // GET
    public IActionResult List()
    {
        var viewModel = _books.Join(
            _authors,
            _books => _books.AuthorId,
            _authors => _authors.Id,
            (_books, _authors) => new
            {
                Id = _books.Id,
                Title = _books.Title,
                AuthorName = _authors.FirstName + " " + _authors.LastName,
                Genre = _books.Genre,
                PublishDate = _books.PublishDate,
                ISBN = _books.ISBN,
                Copies = _books.CopiesAvailable,
                IsRead = _books.IsRead
            }
        ).Select(x => new BookListViewModel()
        {
            Id = x.Id,
            Title = x.Title,
            AuthorName = x.AuthorName,
            Genre = x.Genre,
            PublishDate = x.PublishDate,
            ISBN = x.ISBN,
            CopiesAvailable = x.Copies,
            IsRead = x.IsRead
        }).ToList();

        return View(viewModel);
    }

    public IActionResult Read(int id)
    {
        var book = _books.Find(x => x.Id == id);
        book.IsRead = !book.IsRead;
        return RedirectToAction("List", "Book");
    }

    public IActionResult Detail(int id)
    {
        var viewModel = _books.Where(x => x.Id == id).ToList();


        var bookDetailViewModel = new BookDetailViewModel()
        {
            Id = viewModel[0].Id,
            Title = viewModel[0].Title,
            Genre = viewModel[0].Genre,
            PublishDate = viewModel[0].PublishDate,
            ISBN = viewModel[0].ISBN,
            CopiesAvailable = viewModel[0].CopiesAvailable,
        };

        return View(bookDetailViewModel);
    }

    public IActionResult Add()
    {
        return View();
    }
}

