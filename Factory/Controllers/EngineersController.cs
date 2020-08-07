using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Factory.Models;
using System.Linq;

namespace Factory.Controllers
{
  public class EngineersController : Controller
  {
    private readonly FactoryContext _db;

    public EngineersController(FactoryContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      return View(_db.Engineers.OrderBy(engineers => engineers.Name).ToList());
    }

        public ActionResult Create()
    {
      return View();
    }

    // [HttpPost]
    // public ActionResult Create()
    // {

    //   return RedirectToAction("Index");
    // }

    // public ActionResult Details()
    // {

    // }

    // public ActionResult Edit()
    // {

    // }

    // [HttpPost]
    // public ActionResult Edit()
    // {
    //   return RedirectToAction("Index");
    // }

    // public ActionResult AddMachine()
    // {

    // }

    // [HttpPost]
    // public ActionResult AddMachine()
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
    // public ActionResult DeleteMachine()
    // {
      
    // }
  }
}