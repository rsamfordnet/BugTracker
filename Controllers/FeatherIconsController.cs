using Microsoft.AspNetCore.Mvc;

namespace IssueTracker.Controllers;

public class FeatherIconsController : Controller
{

    private readonly ILogger<FeatherIconsController> _logger;

    public FeatherIconsController(ILogger<FeatherIconsController> logger)
    {
        _logger = logger;
    }

    [Route("/icons4")]
    public IActionResult Index()
    {
        return View();
    }
}