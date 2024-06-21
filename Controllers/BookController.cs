using CRUDApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace CRUDApp.Controllers;

public class BookController : Controller
{

    private AppDbContext con;

    public BookController(AppDbContext context)
        {
            con = context;
        }
    public IActionResult Index(){
        
        return View(con.Books);
    }
    public IActionResult Create(){
        return View();
    }

    [HttpPost]
    public IActionResult Post(Book book){
        con.Books.Add(book);
        con.SaveChanges();
        return RedirectToAction(nameof(Index));
    }
    public IActionResult Update(int id){
        return View();
    }
    public IActionResult Delete(int id){
        return View();
    }

}