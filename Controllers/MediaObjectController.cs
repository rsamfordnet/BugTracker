using Microsoft.AspNetCore.Mvc;

namespace IssueTracker.Controllers;

public class MediaObjectController : Controller
{

    private readonly ILogger<MediaObjectController> _logger;

    public MediaObjectController(ILogger<MediaObjectController> logger)
    {
        _logger = logger;
    }

    [Route("/mediaobject")]
    public IActionResult Index()
    {
        return View();
    }
}