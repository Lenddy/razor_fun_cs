using Microsoft.AspNetCore.Mvc;
namespace view.Controllers;
public class views : Controller
{
    [HttpGet("")]
    public ViewResult index()
    {
        return View("index");
    }
}