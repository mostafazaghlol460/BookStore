using System.ComponentModel.DataAnnotations;

namespace Final_Project.Models
{
    public class Categorie
    {
        [Key]
        public string Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }

        public virtual List<Book> book { get; set; }
    }
}
