using Microsoft.AspNetCore.Mvc;

namespace IssueTracker.Controllers;

public class FaqsController : Controller
{

    private readonly ILogger<FaqsController> _logger;

    public FaqsController(ILogger<FaqsController> logger)
    {
        _logger = logger;
    }

    [Route("/faq")]
    public IActionResult Index()
    {
        return View();
    }
}