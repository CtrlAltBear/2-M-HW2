using System;
namespace Modul2HW2
{
   public class Starter
    {
        private readonly CartService _cart;
        private readonly Person _person;
        private OrderMaker _order;
        public Starter()
        {
            _cart = CartService.Instance;
            _person = new Person()
            {
                FirstName = "Доценко",
                LastName = "Даниил",
                Email = "Danil123@gmail.com",
                Telephone = "1245896743"
            };
        }

        public void Run()
        {
            var rnd = new Random();
            for (var i = 0; i < 1; i++)
            {
                _cart.Add(rnd.Next(10));
            }

            _order = new OrderMaker()
            {
                Person = _person
            };

            _order.Make();
        }
    }
}
