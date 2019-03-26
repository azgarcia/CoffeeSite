using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NightsCoffee.Models
{
    public class MockCoffeeRepository : ICoffeeRepository
    {

        private List<Coffee> _coffees;

        public MockCoffeeRepository()
        {
            if (_coffees == null)
            {
                InitializeCoffees();
            }
        }

        private void InitializeCoffees()
        {
            _coffees = new List<Coffee>
            {
                new Coffee {Id = 1, Name = "Night's Original Blend", Price = 14.95M, ShortDescription = "Our original blend.", LongDescription = "Our secrect original recipe guaranteed to satisfy your coffee needs." },
                new Coffee {Id = 2, Name = "Midnight Cream Coffee", Price = 17.85m, ShortDescription = "Perfectly smooth.", LongDescription = "Our smoothest recipe to date, perfect for lunch or on the go." },
                new Coffee {Id = 3, Name = "Full Moon Dark Roast", Price = 15.99m, ShortDescription = "Fully dark roasted.", LongDescription = "For nights when you need something to keep you going till sunrise!" },
                new Coffee {Id = 4, Name = "Night's Decaf", Price = 14.95m, ShortDescription = "High quality roast!", LongDescription = "Our original recipe for those who just want the surburb coffee taste but not the after effects!" }

            };
        }

        public IEnumerable<Coffee> GetAllCoffees()
        {
            return _coffees;
        }

        public Coffee GetCoffeeById(int coffeeId)
        {
            return _coffees.FirstOrDefault(c => c.Id == coffeeId);
        }
    }
}
