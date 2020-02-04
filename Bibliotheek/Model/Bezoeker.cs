using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Bezoeker
    {
        public string FamilieNaam { get; set; }
        public string VoorNaam { get; set; }
        void RegistreerAlsLid() { }
        public virtual void ZoekItem() { }
        public virtual void ToonOverzicht() { }

    }
}
