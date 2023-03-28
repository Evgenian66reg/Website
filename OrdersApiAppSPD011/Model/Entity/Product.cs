using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrdersApiAppSPD011.Model.Entity
{
    [Table("Products")]
    public class Product
    {
        // сущность Товара
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string Name { get; set; }

        public long Articul { get; set; }

        public int Price { get; set; }

        public Product()
        {
            Name = "";
            Articul = 0;
            Price = 0;
        }
    }
}
