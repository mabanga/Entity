using System.Text;

namespace L_Model.Models
{
    public class Name
    {
        public string SurName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"{FirstName} {LastName}");
            return $"{sb}";
        }

        public int CompareTo(Name other)
        {
            return FirstName.CompareTo(other.FirstName);

        }

        public Name(string firstname, string surname = "noSurName", string lastname = "noLastName")
        {
            FirstName = firstname;
            SurName = surname;
            LastName = lastname;
        }
    }
}