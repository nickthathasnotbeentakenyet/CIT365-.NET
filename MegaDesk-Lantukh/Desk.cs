using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_Lantukh
{
    internal class Desk
    {
        public double width { get; set; }
        public double depth { get; set; }
        public int drawers { get; set; }
    }
    public enum SurfaceMaterials
    {
        Oak = 200,
        Laminate = 100,
        Pine = 50,
        Rosewood = 300,
        Veneer = 125
    }
}
