using System;
using System.Text;

namespace Model.Models
{
    public class Person : APerson, IComparable<Person>
    {
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{ID} {Gender} '{Name.FirstName}' '{Address}' {isMaried}");
            return $"{sb}";
        }
        public int CompareTo(Person other)
        {
            return Name.CompareTo(other.Name);
        }
        public Person(string firstname = "noFirstName")
        {
            Name = new Name(firstname);
        }
    }
}
