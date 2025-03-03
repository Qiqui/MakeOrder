using MakeOrder.Db.Models;

namespace MakeOrder.Db.Interfaces
{
    public interface IOrdersRepository
    {
        Order GetById(Guid id);
        List<Order> GetAll();
        void Add(Order order);
        int IncreaseNumber();
    }
}
