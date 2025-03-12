using System.ComponentModel.DataAnnotations;

namespace CRUD.Modals
{
    public class Product
    {
        public Guid Id { get; set; }
        [Required] public string Name { get; set; }
        public double Price { get; set; }
        public int Qty { get; set; }
    }
}
