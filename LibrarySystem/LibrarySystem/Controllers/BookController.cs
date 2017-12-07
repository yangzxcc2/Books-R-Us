using LibrarySystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LibrarySystem.Controllers
{
    public class BookController : Controller
    {
        public ViewResult All()
        {
            return View(MockDatabase.GetInstance().GetBookList());
        }

        [HttpGet]
        public ViewResult Search()
        {
            return View(new List<Book>());
        }

        [HttpPost]
        public ViewResult Search(string query)
        {
            return View(MockDatabase.GetInstance().GetBookSubList(query));
        }

        [HttpGet]
        public ViewResult Add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add(Book book)
        {
            MockDatabase.GetInstance().GetBookList().Add(book);
            return RedirectToAction("All");
        }

        [HttpGet]
        public ViewResult Edit(string bookID)
        {
            return View(MockDatabase.GetInstance().GetBookByID(bookID));
        }

        [HttpPost]
        public ActionResult Edit(Book book)
        {
            for (int i = 0; i < MockDatabase.GetInstance().GetBookList().Count; i++)
            {
                if (MockDatabase.GetInstance().GetBookList()[i].BookId.Equals(book.BookId))
                {
                    MockDatabase.GetInstance().GetBookList()[i] = book;
                }
            }
            return RedirectToAction("All");
        }

        public ViewResult Details(string bookID)
        {
            return View(MockDatabase.GetInstance().GetBookByID(bookID));
        }

        public ActionResult Delete(string bookID)
        {
            for (int i = 0; i < MockDatabase.GetInstance().GetBookList().Count; i++)
            {
                if (MockDatabase.GetInstance().GetBookList()[i].BookId.Equals(bookID))
                {
                    MockDatabase.GetInstance().GetBookList().Remove(MockDatabase.GetInstance().GetBookList()[i]);
                }
            }
            return RedirectToAction("All");
        }
    }
}