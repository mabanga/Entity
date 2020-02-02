using System.Text;

namespace Model.Models
{
    public class Address
    {
        public string Street { get; set; }
        public string HouseNumber { get; set; }
        public string PostBox { get; set; }
        public string ZipCode { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Fax { get; set; }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"{Street} {HouseNumber}/{PostBox} {ZipCode} {City} {Phone} {Email}");
            return $"{sb}";
        }

        public int CompareTo(Address other)
        {
            return Email.CompareTo(other.Email);
        }

        public Address(string street = "noStreet", string houseNumber = "noHouseNumber", string postBox = "noPostBox", string zipCode = "noZipCode", string city = "noCity", string country = "noCountry", string phone = "noPhone", string email = "noEmail", string fax = "noFax")
        {
            Street = street;
            HouseNumber = houseNumber;
            PostBox = postBox;
            ZipCode = zipCode;
            City = city;
            Country = country;
            Phone = phone;
            Email = email;
            Fax = fax;
        }
    }
}