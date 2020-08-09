using Microsoft.AspNetCore.Mvc.Rendering;
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
      ViewBag.EngineerId = new SelectList(_db.Engineers, "EngineerId", "Name");
      return View();
    }

    [HttpPost]
    public ActionResult Create(Machine machine, int EngineerId)
    {
      _db.Machines.Add(machine);
      if(EngineerId != 0)
      {
        _db.EngineerMachine.Add(new EngineerMachine { MachineId = machine.MachineId, EngineerId = EngineerId});
      }
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

    public ActionResult Edit(int id)
    {
      var thisMachine = _db.Machines.FirstOrDefault(machine => machine.MachineId == id);
      ViewBag.EngineerId = new SelectList(_db.Engineers, "EngineerId", "Name");
      return View(thisMachine);
    }

    [HttpPost]
    public ActionResult Edit(Machine machine, int EngineerId)
    {
      if(EngineerId !=0)
      {
        _db.EngineerMachine.Add(new EngineerMachine() { MachineId = machine.MachineId, EngineerId = EngineerId});
      }
      _db.Entry(machine).State = EntityState.Modified;
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

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