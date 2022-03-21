using System.Collections.Generic;
using Monster.Models;

namespace Monster.ViewModels
{
    public class RandomMovieViewModel
    {
        public Movie Movie { get; set; }
        public List<Customer>Customers { get; set; }
    }
}