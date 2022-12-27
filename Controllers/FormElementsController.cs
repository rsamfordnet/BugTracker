using Microsoft.AspNetCore.Mvc;

namespace IssueTracker.Controllers;

public class FormElementsController : Controller
{

    private readonly ILogger<FormElementsController> _logger;

    public FormElementsController(ILogger<FormElementsController> logger)
    {
        _logger = logger;
    }

    [Route("/form-elements")]
    public IActionResult Index()
    {
        return View();
    }
}