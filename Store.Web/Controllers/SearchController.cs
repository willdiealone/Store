using Microsoft.AspNetCore.Mvc;

namespace Store.Web.Controllers;

public class SearchController : HomeController
{
    private readonly BookService bookService;
    
    public SearchController(ILogger<HomeController> logger,BookService bookService) : base(logger)
    {
        this.bookService = bookService;
    }

    [HttpGet]
    public IActionResult Index(string query)
    {
        var books = bookService.GetAllByQuery(query);
        
        return View("Index", books);
    }
}