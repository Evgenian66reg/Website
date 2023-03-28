using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrdersApiAppSPD011.Model.Entity
{
    [Table("Orders")]
    public class Order
    {
        // сущность Заказа
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [ForeignKey("ClientId")]
        public int ClientId { get; set; }
        public Client Client { get; set; }

        public string Description { get; set; }

        public Order()
        {
            Client client = new Client();
            client.Id = ClientId;
            Description = "";
        }
    }
}
