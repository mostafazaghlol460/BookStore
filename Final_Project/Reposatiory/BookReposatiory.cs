using Final_Project.Models;
using Microsoft.EntityFrameworkCore;

namespace Final_Project.Reposatiory
{
    public class BookReposatiory : IBookReposatiory
    {
        BookStoreContext bookStoreContext;
        public BookReposatiory(BookStoreContext _bookStoreContext)
        {
            bookStoreContext = _bookStoreContext;
        }

        public void Delete(string id)
        {
            Book oldbook = GetBook(id);
            bookStoreContext.Books.Remove(oldbook);
            bookStoreContext.SaveChanges();
        }

        public Book GetBook(string id)
        {
            Book book = bookStoreContext.Books.FirstOrDefault(a => a.Id == id);
            return book;
        }
        public void Searchh(string Name)
        {
            var AuthorName = bookStoreContext.Authors.Where(x => x.Name.ToLower().Contains(Name.ToLower())).ToList();
        }
        public void Search(string Name)
        {
            var Author = bookStoreContext.Authors.ToList();
        }
        public List<Book> GetBooks()
        {
            return bookStoreContext.Books.Include(a => a.author).ToList();
        }

        public void Insert(Book book)
        {
            bookStoreContext.Books.Add(book);
            bookStoreContext.SaveChanges();
        }

        public void Save()
        {
            bookStoreContext.SaveChanges();
        }

        public void Update(string id, Book book)
        {
            bookStoreContext.Books.Update(book);
            bookStoreContext.SaveChanges();
            //Book oldbook = GetBook(id);
            //oldbook.Name = book.Name;
            //oldbook.author = book.author;
            //oldbook.Description = book.Description;
            //oldbook.categorie = book.categorie;
        }

    }
}
