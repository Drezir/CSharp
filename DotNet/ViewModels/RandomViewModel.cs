using DotNet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DotNet.ViewModels
{
    public class RandomViewModel
    {
        public Movie Movie { get; set; }
        public List<Customer> Customers { get; set; }
    }
}