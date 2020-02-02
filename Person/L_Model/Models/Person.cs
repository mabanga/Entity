using System;
using System.Collections.Generic;
using System.Text;

namespace L_Model.Models
{
    public abstract class Person
    {
        public int ID { get; set; }
        public Name Name { get; set; }
        public Address Address { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime DeadDate { get; set; }
        public Gender Gender { get; set; }
        public bool isMaried { get; set; }
        public bool hasChildren { get; set; }
    }
}
