using Microsoft.AspNetCore.Mvc;

namespace IssueTracker.Controllers;

public class AddClientsController : Controller
{

    private readonly ILogger<AddClientsController> _logger;

    public AddClientsController(ILogger<AddClientsController> logger)
    {
        _logger = logger;
    }

    [Route("/clients-create")]
    public IActionResult Index()
    {
        return View();
    }
}