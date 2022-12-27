using Microsoft.AspNetCore.Mvc;

namespace IssueTracker.Controllers;

public class ProgressBarController : Controller
{

    private readonly ILogger<ProgressBarController> _logger;

    public ProgressBarController(ILogger<ProgressBarController> logger)
    {
        _logger = logger;
    }

    [Route("/progress")]
    public IActionResult Index()
    {
        return View();
    }
}