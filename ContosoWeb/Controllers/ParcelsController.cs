using Microsoft.AspNetCore.Mvc;
using ContosoWeb.Models;

namespace ContosoWeb.Controllers;

public class ParcelsController : Controller
{
    public IActionResult Index()
    {
        var parcels = new List<Parcel>();
        return View(parcels);
    }
}
