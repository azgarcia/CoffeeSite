using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NightsCoffee.Models
{
    public class CoffeeRepository: ICoffeeRepository
    {
        //allow access to AppDbContext via Constructor Injection
        private readonly AppDbContext _appDbContext;

        public CoffeeRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Coffee> GetAllCoffees()
        {
            return _appDbContext.Coffees;
        }

        public Coffee GetCoffeeById(int coffeeId)
        {
            return _appDbContext.Coffees.FirstOrDefault(c => c.Id == coffeeId);
        }
    }
}
