using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.NUnitIntroduction.Models
{
    public class Person
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public int Id { get; set; }

        public DateTime Birthday { get; set; }

        public Order Order { get; set; }
    }
}
