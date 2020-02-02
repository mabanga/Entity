using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Models
{
    public abstract class APerson:Unity
    {
        public bool isMaried { get; set; }
        public bool hasChildren { get; set; }
    }
}
