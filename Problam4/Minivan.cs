using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problam4
{
    class Minivan : Van
    {
        protected bool cargo_Net;
        protected bool dual_Sliding_Doors;

        public Minivan()
        {
        }
        public Minivan(bool cargo_Net, bool dual_Sliding_Doors)
        {
            this.cargo_Net = cargo_Net;
            this.dual_Sliding_Doors = dual_Sliding_Doors;
        }

        public void SetCargoNet(bool cargo_Net)
        {
            this.cargo_Net = cargo_Net;
        }
        public void SetDualSlidingDoors(bool dual_Sliding_Doors)
        {
            this.dual_Sliding_Doors = dual_Sliding_Doors;
        }

        public bool HasCargoNet()
        {
            return cargo_Net;
        }
        public bool HasDualSlidingDoors()
        {
            return dual_Sliding_Doors;
        }
    }
}
