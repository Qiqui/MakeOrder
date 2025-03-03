namespace MakeOrder.Db.Models
{
    public class Order
    {
        public Guid Id { get; set; }
        public int Number { get; set; }
        public string SenderCity { get; set; }
        public string SenderAdress { get; set; }
        public string RecipientCity { get; set; }
        public string RecipientAdress { get; set; }
        public int CargoWeigth { get; set; }
        public DateTime Date { get; set; }
    }
}
