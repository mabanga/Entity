using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Medewerker:Lid
    {
        public void PromoveerLidNaarMedewerker() { }
        public void VoerItemAf() { }
        public void VoegItemToe() { }
        public void GeefOverzichtLeden() { }
        public override void ZoekItem() { }
        public void UitLenen(Item item) { }
        public void TerugBrengen(Item item) { }
        public void Reserveren(Item item) { }
        public override void ToonOverzicht()
        {
            base.ToonOverzicht();
        }

    }
}
