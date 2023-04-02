using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using prueba_postgres_2.Models;
using prueba_postgres_2.Data;

namespace prueba_postgres_2.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly ApplicationDbContext _context;

    public HomeController(ApplicationDbContext context)
    {
        _context=context;
    }

    public IActionResult Index()
    {
        var personas = _context.Personas.ToList();

        return View(personas);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }

    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Create(Persona persona)
    {
        _context.Personas.Add(persona);
        _context.SaveChanges();
        return RedirectToAction("Index");
    }

    public IActionResult Edit(int id)
    {
        var persona = _context.Personas.Find(id);
        return View(persona);
    }

    [HttpPost]
    public IActionResult Edit(Persona persona)
    {
        _context.Personas.Update(persona);
        _context.SaveChanges();
        return RedirectToAction("Index");
    }

    public IActionResult Delete(int id)
    {
        var persona = _context.Personas.Find(id);
        return View(persona);
    }

    [HttpPost]
    public IActionResult DeleteConfirmed(int id)
    {
        System.Console.WriteLine(id);
        var persona = _context.Personas.Find(id);
        _context.Personas.Remove(persona);
        _context.SaveChanges();
        return RedirectToAction("Index");
    }
}
