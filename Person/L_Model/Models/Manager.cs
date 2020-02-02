using System;
using System.Text;

namespace L_Model.Models
{
    public class Manager:Entity,IComparable<Manager>
    {
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{ID} {Gender} '{Name.FirstName}' '{Address}' {isMaried}");
            return $"{sb}";
        }

        public int CompareTo(Manager other)
        {
            return Name.CompareTo(other.Name);
        }

        public Manager(string firstname="noFirstName")
        {
            Name = new Name(firstname);
            //isMaried = ismaried;
        }
    }
}
