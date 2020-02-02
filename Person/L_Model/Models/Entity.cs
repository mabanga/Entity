using System;
using System.Collections.Generic;
using System.Text;

namespace L_Model.Models
{
    public class Entity:Person,IComparable<Entity>
    {
        public int CompareTo(Entity other)
        {
            return ID.CompareTo(other.ID);
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{ID} {Gender} '{Name}' '{Address}' {BirthDate.ToShortDateString()}");
            return $"{sb}";
        } 
    }
}
