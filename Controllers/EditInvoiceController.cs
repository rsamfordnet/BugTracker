using Microsoft.AspNetCore.Mvc;

namespace IssueTracker.Controllers;

public class EditInvoiceController : Controller
{

    private readonly ILogger<EditInvoiceController> _logger;

    public EditInvoiceController(ILogger<EditInvoiceController> logger)
    {
        _logger = logger;
    }

    [Route("/invoice-edit")]
    public IActionResult Index()
    {
        return View();
    }
}