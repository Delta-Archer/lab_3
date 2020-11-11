using System.Collections.Generic;

namespace Lab_3.Models
{
    public class Companies
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public int Year { get; set; }
        public string CEO { get; set; }
        public IEnumerable<Mobiles> Mobiles { get; set; }

    }
}
