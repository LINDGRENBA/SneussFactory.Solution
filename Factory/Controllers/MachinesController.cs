using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Factory.Models;
using System.Linq;

namespace Factory.Controllers
{
  public class MachinesController : Controller
  {
    private readonly FactoryContext _db;

    public MachinesController(FactoryContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      return View(_db.Machines.OrderBy(machines => machines.Type).ToList());
    }

    public ActionResult Create()
    {
      return View();
    }

    [HttpPost]
    public ActionResult Create(Machine machine)
    {
      _db.Machines.Add(machine);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Details(int id)
    {
      var thisMachine = _db.Machines
        .Include(machine => machine.Engineers)
        .ThenInclude(join => join.Engineer)
        .FirstOrDefault(machine => machine.MachineId == id);
        return View(thisMachine);
    }

    // public ActionResult Edit()
    // {

    // }

    // [HttpPost]
    // public ActionResult Edit()
    // {
    //   return RedirectToAction("Index");
    // }

    // public ActionResult AddEngineer()
    // {

    // }

    // [HttpPost]
    // public ActionResult AddEngineer()
    // {

    // }

    // public ActionResult Delete()
    // {

    // }

    // [HttpPost, ActionName("Delete")]
    // public ActionResult DeleteConfirmed()
    // {

    // }

    // [HttpPost]
    // public ActionResult DeleteEngineer()
    // {
      
    // }
  }
}