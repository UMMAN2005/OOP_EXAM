using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Departments
{
    public class Fishing : Department
    {
        private uint _nmberOfWorkingBoats { get; set;  }
        private uint _numberOfDamagedBoats { get; set; }

        public Fishing() {
            Random random = new();
            _nmberOfWorkingBoats = (uint)random.Next(5, 10);
            _numberOfDamagedBoats = (uint)random.Next(1, 3);
        }

        protected void FixBoat() {
            Random random = new();
            if (_numberOfDamagedBoats == 0) return;
            _numberOfDamagedBoats--;
            _nmberOfWorkingBoats++;
            Budget -= random.Next(500, 1000);
        }
    }
}
