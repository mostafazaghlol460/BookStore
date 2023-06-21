using Final_Project.Models;

namespace Final_Project.Reposatiory
{
    public interface IBookReposatiory
    {

        List<Book> GetBooks();

        Author GetBook(int id);

        void Insert(Book book);
        void Update(int id, Book book);
        void Delete(int id);
        void Save();
    }
}
