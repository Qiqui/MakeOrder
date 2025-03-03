using MakeOrder.Db.Interfaces;
using MakeOrder.Db.Models;

namespace MakeOrder.Db.Repositories
{
    public class OrdersRepository : IOrdersRepository
    {
        private readonly DatabaseContext _databaseContext;

        public OrdersRepository(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }

        public void Add(Order order)
        {
            _databaseContext.Orders.Add(order);
            _databaseContext.SaveChanges();
        }

        public List<Order> GetAll()
        {
            return _databaseContext.Orders.ToList();
        }

        public Order GetById(Guid id)
        {
            return _databaseContext.Orders.FirstOrDefault(order => order.Id == id);
        }

        public int IncreaseNumber()
        {
            return _databaseContext.Orders.Count() + 1;
        }
    }
}
