using System;

namespace Model.Models
{
    public abstract class Unity
    {
        public int ID { get; set; }
        public Name Name { get; set; }
        public Address Address { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime DeadDate { get; set; }
        public Gender Gender { get; set; }
    }
}
