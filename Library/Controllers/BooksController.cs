using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Library.Models;

namespace Library.Controllers
{
  public class BooksController : Controller
  {
    private readonly LibraryContext _db;

    public BooksController(LibraryContext db)
    {
        _db = db;
    }

    public ActionResult Index(string searchString)
    {
      var model = _db.Books.ToList();

      // if (!String.IsNullOrEmpty(searchString))
      // {
      //     model = model.Where(m => m.Name.Contains(searchString) || m.Name.Contains(searchString));
      // }
      return View(model.ToList());
    }

    public ActionResult Create()
    {
      return View();
    }

    [HttpPost]
    public ActionResult Create(Book book)
    {
        _db.Books.Add(book);
        _db.SaveChanges();
        return RedirectToAction("Index");
    }

    public ActionResult Details(int id)
    {
        var thisBook = _db.Books
            .Include(book => book.Authors)
            .ThenInclude(join => join.Author)
            .FirstOrDefault(book => book.BookId == id);
        var thatBook = _db.Books
            .Include(book => book.Copys)
            .ThenInclude(join => join.Copy)
            .FirstOrDefault(book => book.BookId == id);
        return View(thisBook);
    }

    public ActionResult Delete(int id)
    {
        var thisBook = _db.Books.FirstOrDefault(books => books.BookId == id);
        return View(thisBook);
    }

    [HttpPost, ActionName("Delete")]
    public ActionResult DeleteConfirmed(int id)
    {
        var thisBook = _db.Books.FirstOrDefault(book => book.BookId == id);
        _db.Books.Remove(thisBook);
        _db.SaveChanges();
        return RedirectToAction("Index");
    }
  }
}