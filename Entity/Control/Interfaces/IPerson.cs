using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control.Interfaces
{
    public interface IPerson
    {
        public bool isMaried { get; set; }
        public bool hasChildren { get; set; }
    }
}
