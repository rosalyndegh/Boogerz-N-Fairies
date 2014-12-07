using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    class Nucleus
    {
        private enum MembraneStatus
        {
            Has,
            NotHas
        }
        private const String DefaultColor = "Purple";
        private MembraneStatus membraneStatus = MembraneStatus.Has;

        public bool HasMembrane { 
            get { 
                return membraneStatus == MembraneStatus.Has; 
            }
            set
            {
                if (value)
                {
                    membraneStatus = MembraneStatus.Has;
                }
                else
                {
                    membraneStatus = MembraneStatus.NotHas;
                }
            }
        }

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

        public override String ToString()
        {
            return String.Format("Nucleus : {0}, {1}, {2},  membrane status: {3}", this.EnzymeCount, this.NucleotideCount, this.Color, membraneStatus.ToString());
        }
    }
}
