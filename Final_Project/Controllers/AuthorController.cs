using Final_Project.Models;
using Final_Project.Reposatiory;
using Microsoft.AspNetCore.Mvc;

namespace Final_Project.Controllers
{
    public class AuthorController : Controller
    {
        IAuthorRepository authorReposatiory;
        IBookReposatiory bookReposatiory;
        public AuthorController(
            IAuthorRepository authorRepo,
            IBookReposatiory bookRebo

            )
        {
            authorReposatiory = authorRepo;
            bookReposatiory = bookRebo;

        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult getAll()
        {
            return View(authorReposatiory.GetAuthors());
        }
        public IActionResult getAuthorBtId(string id)
        {
            return View(authorReposatiory.GetAuthor(id));
        }

        [HttpGet]
        public IActionResult Create()
        {
            ViewData["bookList"] = bookReposatiory.GetBooks();

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Author author)
        {
            if (ModelState.IsValid == true)
            {
                authorReposatiory.Insert(author);
                return RedirectToAction("create", "Book");
            }
            else
            {
                ViewData["bookList"] = bookReposatiory.GetBooks();

                return View(author);
            }
        }

        [HttpGet]
        public IActionResult Edit(string Id)
        {
            Author author = authorReposatiory.GetAuthor(Id);
            ViewData["BooksList"] = bookReposatiory.GetBooks();
            return View(author);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Author author, string id)
        {
            if (ModelState.IsValid == true)
            {
                authorReposatiory.Update(id, author);
                authorReposatiory.Save();
                return RedirectToAction("getAll");
            }
            ViewData["BooksList"] = bookReposatiory.GetBooks();
            return View(author);
        }
        public IActionResult Delete(string id)
        {
            authorReposatiory.Delete(id);
            return RedirectToAction("getAll");
        }
    }

}
