using Final_Project.Models;
using System.ComponentModel;

namespace Final_Project.ViewModels
{
    public class AddBook
    {
        public string? Id { get; set; }
        public string Name { get; set; }
        [DefaultValue(" ")]
        public string Title { get; set; }
        [DefaultValue(" ")]
        public string Description { get; set; }
        public string? Photo { get; set; } = "default.png";
        public double Salary { get; set; }
        public string Author_Id { get; set; }
        public string categories_Id { get; set; }
        public  List<Categorie>? Cat { get; set; }
        
    }
}
