using System.Collections.Generic;

namespace DNP1Assignment3.Models
{
    public class Child : Person
    {
        public IList<Interest> Interests { get; set; }
        public IList<Pet> Pets { get; set; }

        public Child()
        {
            Interests = new List<Interest>();
            Pets = new List<Pet>();
        }

        public override string ToString()
        {
            return $"{Interests} and {Pets}";
        }
    }
}