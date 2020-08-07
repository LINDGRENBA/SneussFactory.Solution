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
      return View();
    }

    public ActionResult Create()
    {
      return View();
    }

    [HttpPost]
    public ActionResult Create()
    {

      return RedirectToAction("Index");
    }

    public ActionResult Details()
    {

    }

    public ActionResult Edit()
    {

    }

    [HttpPost]
    public ActionResult Edit()
    {
      return RedirectToAction("Index");
    }

    public ActionResult AddEngineer()
    {

    }

    [HttpPost]
    public ActionResult AddEngineer()
    {

    }

    public ActionResult Delete()
    {

    }

    [HttpPost, ActionName("Delete")]
    public ActionResult DeleteConfirmed()
    {

    }

    [HttpPost]
    public ActionResult DeleteEngineer()
    {
      
    }
  }
}