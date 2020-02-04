using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Item
    {
        public SoortItem SoortItem { get;  }
        public int ItemId { get;  }
        public string Titel { get;  }
        public string Auteur { get;  }
        public string Uitvoerder { get;  }
        bool UitGeleend { get;  }
        bool AfGevoerd { get;  }
        DateTime Jaartal { get;  }

    }
}
