using Final_Project.Models;

namespace Final_Project.Reposatiory
{
    public class AuthorRepository : IAuthorRepository
    {
        private readonly BookStoreContext _db;
        public AuthorRepository(BookStoreContext db)
        {
            _db = db;
        }
        public void Delete(int id)
        {
            // when i made delete i didn't make it delete i will make soft delete but  i will do later 
        }

        public Author GetAuthor(string id)
        {
            return _db.Authors.FirstOrDefault(a => a.Id == id);
        }

        public List<Author> GetAuthors()
        {
            return _db.Authors.ToList();
        }

        public void Insert(Author author)
        {
            _db.Authors.Add(author);
            Save();
        }

        public void Save()
        {
            _db.SaveChanges();
        }

        public void Update( Author author)
        {
            _db.Authors.Update(author);
            Save();
        }
    }

}
