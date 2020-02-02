using L_Control.Admin;
using L_Control.Interfaces;
using System.Collections.Generic;


namespace L_Control
{
    public class Switch
    {
        public IPerson Bridge()
        {
            return new PersonAdmin();
        }
    }
}
