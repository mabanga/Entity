using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Item
    {
        public SoortItem SoortItem { get; set; }
        public int ItemId { get; set; }
        public string Titel { get; set; }
        public string Auteur { get; set; }
        public string Uitvoerder { get; set; }
        bool UitGeleend { get; set; }
        bool AfGevoerd { get; set; }
        DateTime Jaartal { get; set; }

    }
}
