using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Factory.Models;
using System.Linq;

namespace Factory.Controllers
{
  public class HomeController : Controller
  {
    private readonly FactoryContext _db;
    public HomeController(FactoryContext db)
    {
      _db = db;
    }

    [HttpGet("/")]
    public ActionResult Index()
    {
      var model = _db.EngineerMachine.ToList();
      ViewBag.Engineer = _db.Engineers.OrderBy(engineer => engineer.Name).ToList();
      ViewBag.Machine = _db.Machines.OrderBy(machine => machine.Type).ToList();
      return View(model);
    }
  }
}