using Microsoft.AspNetCore.Mvc;

namespace IssueTracker.Controllers;

public class AccordionsController : Controller
{

    private readonly ILogger<AccordionsController> _logger;

    public AccordionsController(ILogger<AccordionsController> logger)
    {
        _logger = logger;
    }

    [Route("/accordions")]
    public IActionResult Index()
    {
        return View();
    }
}