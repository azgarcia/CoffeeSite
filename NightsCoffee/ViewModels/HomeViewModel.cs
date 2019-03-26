using NightsCoffee.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NightsCoffee.ViewModels
{
    //list all data I need inside of view
    public class HomeViewModel
    {
        public string Title { get; set; }

        public List<Coffee> Coffees { get; set; }
    }
}
