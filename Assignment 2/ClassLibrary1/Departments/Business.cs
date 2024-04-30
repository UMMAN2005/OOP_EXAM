using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Departments
{
    public class Business : Department {
        public uint MonthlyIncome { get; private set; }

        public Business() {
            Random random = new();
            MonthlyIncome = (uint)random.Next(1000, 5000);
        }

        protected void PayTaxes() {
            Random random = new();
            Budget -= random.Next(1000, 2000);
        }
    }
}
