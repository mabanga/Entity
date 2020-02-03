using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control.Interfaces
{
    public interface IPerson
    {
        bool isMaried { get; set; }
        bool hasChildren { get; set; }
    }
}
