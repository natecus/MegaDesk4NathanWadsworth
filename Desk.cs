using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk3NathanWadsworth
{
    class Desk
    {

        public enum DesktopMaterial
        {
            Laminate,
            Oak,
            Rosewood,
            Veneer,
            Pine
        }
        int width, depth, drawers;
        string surface;
        
        Desk(int width, int depth, int drawers, string surface)
        {
            this.width = width;
            this.depth = depth;
            this.drawers = drawers;
            this.surface = surface;
        }

    }
}
