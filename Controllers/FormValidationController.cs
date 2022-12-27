using Microsoft.AspNetCore.Mvc;

namespace IssueTracker.Controllers;

public class FormValidationController : Controller
{

    private readonly ILogger<FormValidationController> _logger;

    public FormValidationController(ILogger<FormValidationController> logger)
    {
        _logger = logger;
    }

    [Route("/form-validation")]
    public IActionResult Index()
    {
        return View();
    }
}