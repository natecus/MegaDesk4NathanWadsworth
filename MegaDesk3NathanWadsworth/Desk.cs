using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk4NathanWadsworth
{
    public class Desk
    {

        public enum DesktopMaterial
        {
            Laminate,
            Oak,
            Rosewood,
            Veneer,
            Pine
        }
        

        public double Width { get; set; }

        public double Height { get; set; }

        public double NumberOfDrawers { get; set; }
        
        public DesktopMaterial Material { get; set; }

    }
}
