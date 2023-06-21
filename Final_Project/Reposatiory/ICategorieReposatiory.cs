using Final_Project.Models;

namespace Final_Project.Reposatiory
{
    public interface ICategorieReposatiory
    {
        List<Categorie> GetCategories();

        Author GetCategorie(int id);

        void Insert(Categorie categorie);
        void Update(int id, Categorie categorie);
        void Delete(int id);
        void Save();
    }
}
