using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Lid:Bezoeker
    {
        DateTime GeboorteDatum { get; set; }
        List<Item> UitLeenhistoriek;
        List<Item> ItemsuitGeleend;
        List<Item> Reservatie;
        void UitLenen(Item item) { }
        void TerugBrengen(Item item) { }
        void Reserveren(Item item) { }
        public override void ZoekItem() { }
        public override void ToonOverzicht()
        {
            base.ToonOverzicht();
        }
    }
}
