using System.ComponentModel.DataAnnotations;

namespace MakeOrderWebApp.Models
{
    public class OrderVM
    {
        public Guid? Id { get; set; }
        public int Number { get; set; }
        [Required(ErrorMessage = "Это поле обязательно для заполнения")]
        public string SenderCity { get; set; }
        [Required(ErrorMessage = "Это поле обязательно для заполнения")]
        public string SenderAdress { get; set; }
        [Required(ErrorMessage = "Это поле обязательно для заполнения")]
        public string RecipientCity { get; set; }
        [Required(ErrorMessage = "Это поле обязательно для заполнения")]
        public string RecipientAdress { get; set; }
        [Required(ErrorMessage = "Это поле обязательно для заполнения")]
        [Range(100, 100000, ErrorMessage = "Вес груза от 100 до 100000")]
        public int CargoWeigth { get; set; }
        [Required(ErrorMessage = "Это поле обязательно для заполнения")]
        public DateTime Date { get; set; }
    }
}

