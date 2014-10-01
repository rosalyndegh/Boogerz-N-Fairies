using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    class Nucleus
    {
        private const String DefaultColor = "Purple";
        private bool hasMembrane = true;

        public bool HasMembrane { get { return hasMembrane; } set { hasMembrane = value; } }
        public int NucleotideCount { get; set; }
        public int EnzymeCount { get; set; }
        public String Color { get {
            return Nucleus.DefaultColor;
        }
        }

        public Nucleus(int nucleotideCount, int enzymeCount)
        {
            NucleotideCount = nucleotideCount;
            EnzymeCount = enzymeCount;

        }
        public String Get_Membrane_Status() 
        {
            if (hasMembrane == true)
            {
                return "Has Membrane";
            }
            else 
            { 
                return "No Membrane"; 
            }
        }

        public override String ToString()
        {
            return String.Format("nucleus : {0}, {1}, {2}", this.EnzymeCount, this.NucleotideCount, this.Color);
        }
    }
}
