using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuietKid_TheGame
{
    class Emil
    {
        public int Physique { get; private set; }
        public int Coding { get; private set; }
        public int BloodLust { get; private set; }
        private int PTP { get; set; }
        private int CTP { get; set; }
        private int BTP { get; set; }
        public Emil()
        {
            Physique = Coding = BloodLust = 1;
            PTP = CTP = BTP = 0;
        }
        public void Train()
        {
            PTP += 1;
            if (PTP == Physique)
            {
                Console.WriteLine("Physique Level Up! ({0})", Physique);
                Physique += 1;
                PTP = 0;
            }
        }
        public void Code()
        {
            CTP += 1;
            if (CTP == Coding)
            {
                Console.WriteLine("Coding Level Up! ({0})", Coding);
                Coding += 1;
                CTP = 0;
            }
        }
        public void Seethe()
        {
            BTP += 1;
            if (BTP == BloodLust)
            {
                Console.WriteLine("Bloodlust Level Up! ({0})", BloodLust);
                BloodLust += 1;
                BTP = 0;
            }
        }
    }
}
