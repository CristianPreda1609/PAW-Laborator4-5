namespace Laborator4_5.Models
{
    public class Stire
    {
        public int id { get; set; }
        public string titlu { get; set; }
        public string lead { get; set; }
        public string continut { get; set; }
        public string autor { get; set; }

        public int CategorieId { get; set; }
        public Categorie Categorie { get; set; }

        public DateTime Data {  get; set; }
    }
}
