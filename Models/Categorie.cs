namespace Laborator4_5.Models
{
    public class Categorie
    {
        public int id { get; set; }
        public string nume { get; set; }

        // Legătura cu Stire
        public ICollection<Stire> Stiri { get; set; }
    }
}
