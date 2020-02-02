using System;
using System.Text;

namespace L_Model.Models
{
    public class Employee: Entity,IComparable<Employee>
    {
        public int CompareTo(Employee other)
        {
            return Gender.CompareTo(other.Gender);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{ID} {Gender} '{Name}' '{Address}' {isMaried}");
            return $"{sb}";
        }
    }
}
