using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudDapper.NewFolder
{
    public class Animal
    {
        public Animal(string name, string race, string family, int age, bool isDomestic)
        {
            Id = Guid.NewGuid();
            Name = name;
            Race = race;
            Family = family;
            Age = age;
            IsDomestic = isDomestic;
        }
        public Animal(Guid id, string name, string race, string family, int age, bool isDomestic)
        {
            Id = id;
            Name = name;
            Race = race;
            Family = family;
            Age = age;
            IsDomestic = isDomestic;
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Race { get; set; }
        public string Family { get; set; }
        public int Age { get; set; }
        public bool IsDomestic { get; set; }
    }
}
