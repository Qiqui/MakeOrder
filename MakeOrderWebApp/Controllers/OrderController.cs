using MakeOrder.Db.Interfaces;
using MakeOrderWebApp.Helpers;
using MakeOrderWebApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace MakeOrderWebApp.Controllers
{
    public class OrderController : Controller
    {
        private readonly IOrdersRepository _ordersRepository;
        public OrderController(IOrdersRepository ordersRepository)
        {
            this._ordersRepository = ordersRepository;
        }

        public IActionResult Index()
        {
            var orderVM = new OrderVM()
            {
                Number = _ordersRepository.IncreaseNumber()
            };

            return View(orderVM);
        }

        public IActionResult Order(Guid id)
        {
           var order = _ordersRepository.GetById(id);
           var orderVM = order.ToOrderVM();

            return View(orderVM);
        }

        public IActionResult Orders()
        {
            var orders = _ordersRepository.GetAll();
            var ordersVM = orders.ToOrdersVM();

            return View(ordersVM);
        }

        [HttpPost]
        public IActionResult Create(OrderVM orderVM)
        {
            if (!ModelState.IsValid)
                return View(nameof(Index), orderVM);

            var order = orderVM.ToOrder();
            _ordersRepository.Add(order);

            return View("Succses", orderVM);
        }
    }
}
