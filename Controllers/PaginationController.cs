using Microsoft.AspNetCore.Mvc;

namespace IssueTracker.Controllers;

public class PaginationController : Controller
{

    private readonly ILogger<PaginationController> _logger;

    public PaginationController(ILogger<PaginationController> logger)
    {
        _logger = logger;
    }

    [Route("/pagination")]
    public IActionResult Index()
    {
        return View();
    }
}