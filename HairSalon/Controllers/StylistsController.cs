using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using HairSalon.Models;
using System.Collections.Generic;
using System.Linq;

namespace HairSalon.Controllers
{
  public class StylistsController : Controller
  {
    private readonly HairSalonContext _db;

    public StylistsController(HairSalonContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      List<Stylist> model = _db.Stylists.ToList();
      return View(model);
    }

    public ActionResult Create()
    {
      return View();
    }

    [HttpPost]
    public ActionResult Create(Stylist stylist)
    {
      _db.Stylists.Add(stylist);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Details(int id)
    {
      Stylist thisStylist = _db.Stylists.FirstOrDefault(stylist => stylist.StylistId == id);
      thisStylist.Clients = _db.Clients.Where(client => client.StylistId == id).ToList();
      return View(thisStylist);
    }

    public ActionResult Edit(int id)
    {
      Stylist thisStylist = _db.Stylists.FirstOrDefault(stylist => stylist.StylistId == id);
      return View(thisStylist);
    }

    [HttpPost]
    public ActionResult Edit(Stylist stylist)
    {
      _db.Entry(stylist).State = EntityState.Modified;
      _db.SaveChanges();
      return RedirectToAction("Details", new { id = stylist.StylistId });
    }

    public ActionResult Delete(int id)
    {
      Stylist stylistToDelete = _db.Stylists.FirstOrDefault(stylist => stylist.StylistId == id);
      return View(stylistToDelete);
    }

    [HttpPost, ActionName("Delete")]
    public ActionResult DeleteConfirmed(int id)
    {
      Stylist stylistToDelete = _db.Stylists.FirstOrDefault(stylist => stylist.StylistId == id);
      stylistToDelete.Clients = _db.Clients.Where(client => client.StylistId == id).ToList();
      foreach (Client client in stylistToDelete.Clients)
      {
        _db.Clients.Remove(client);
      }
      _db.Stylists.Remove(stylistToDelete);
      _db.SaveChanges();
      return RedirectToAction("Index");
    } 



  }
}  