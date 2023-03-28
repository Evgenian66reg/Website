using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrdersApiAppSPD011.Model.Entity
{
    [Table("StitchingOrdersProducts")]
    public class StitchingOrderProduct
    {
        // сущность расшивки заказ-товар
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [ForeignKey("OrderId")]
        public int OrderId { get; set; }
        public Order Order { get; set; }

        [ForeignKey("ProductId")]
        public int ProductId { get; set; }
        public Product Product { get; set; }

        public long CountProduct { get; set; }

        public StitchingOrderProduct()
        {
            CountProduct = 0;
        }

    }
}
