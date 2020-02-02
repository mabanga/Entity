using System;
using System.Text;

namespace Model.Models
{
    public class Animal : AAnimal, IComparable<Animal>
    {
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{ID} {Gender} '{Name.FirstName}' '{Address}'");
            return $"{sb}";
        }
        public int CompareTo(Animal other)
        {
            return Name.CompareTo(other.Name);
        }
        public Animal(string firstname = "noFirstName")
        {
            Name = new Name(firstname);
        }
    }
}
