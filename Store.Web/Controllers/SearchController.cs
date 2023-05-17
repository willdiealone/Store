using Microsoft.AspNetCore.Mvc;

namespace Store.Web.Controllers;

public class SearchController : HomeController
{
    private readonly IBookRepository BookRepository;
    
    public SearchController(ILogger<HomeController> logger,IBookRepository bookRepository) : base(logger)
    {
        BookRepository = bookRepository;
    }

    [HttpGet]
    public IActionResult Index(string query)
    {
        var books = BookRepository.GetAllByTitle(query);
        
        return View("Index", books);
    }
}