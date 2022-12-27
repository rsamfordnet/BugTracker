using Microsoft.AspNetCore.Mvc;

namespace IssueTracker.Controllers;

public class ClientsController : Controller
{

    private readonly ILogger<ClientsController> _logger;

    public ClientsController(ILogger<ClientsController> logger)
    {
        _logger = logger;
    }

    [Route("/clients")]
    public IActionResult Index()
    {
        return View();
    }
}