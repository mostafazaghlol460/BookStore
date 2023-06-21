using Final_Project.Models;

namespace Final_Project.Reposatiory
{
    public interface IAuthorRepository
    {
        List<Author> GetAuthors();

        Author GetAuthor(string id);

        void Insert(Author author);
        void Update( Author author);
        void Delete(int id);
        void Save();
    }
}
