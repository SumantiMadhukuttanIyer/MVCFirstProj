using MVCFirstProj.Models;
using Microsoft.AspNetCore.Mvc;
namespace MVCFirstProj.Controllers;

public class FirstController : Controller
{
    // Index Action

    // Hello Action

    public IActionResult Info()
    {
        Person person = new Person();
        person.Name = "Sherin";
        person.Age = 21;
        person.Location = "Ukarine";
        return View(person);
    }
}
