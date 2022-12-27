using Microsoft.AspNetCore.Mvc;

namespace IssueTracker.Controllers;

public class CheckoutController : Controller
{

    private readonly ILogger<CheckoutController> _logger;

    public CheckoutController(ILogger<CheckoutController> logger)
    {
        _logger = logger;
    }

    [Route("/checkout")]
    public IActionResult Index()
    {
        return View();
    }
}