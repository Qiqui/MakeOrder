using MakeOrder.Db.Models;
using MakeOrderWebApp.Models;

namespace MakeOrderWebApp.Helpers
{
    public static class Mapping
    {
        public static Order ToOrder(this OrderVM orderVM)
        {
            return new Order()
            {
                Number = orderVM.Number,
                SenderCity = orderVM.SenderCity,
                SenderAdress = orderVM.SenderAdress,
                RecipientCity = orderVM.RecipientCity,
                RecipientAdress = orderVM.RecipientAdress,
                CargoWeigth = orderVM.CargoWeigth,
                Date = orderVM.Date
            };
        }
        public static OrderVM ToOrderVM(this Order order)
        {
            return new OrderVM()
            {
                Id = order.Id,
                Number = order.Number,
                SenderCity = order.SenderCity,
                SenderAdress = order.SenderAdress,
                RecipientCity = order.RecipientCity,
                RecipientAdress = order.RecipientAdress,
                CargoWeigth = order.CargoWeigth,
                Date = order.Date
            };
        }
        public static List<OrderVM> ToOrdersVM(this List<Order> orders)
        {
            var ordersVM = new List<OrderVM>();
            foreach(var order in orders)
            {
                var orderVM = order.ToOrderVM();
                ordersVM.Add(orderVM);
            }

            return ordersVM;
        }
    }
}
