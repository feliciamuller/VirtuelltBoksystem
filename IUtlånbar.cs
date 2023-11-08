using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtuelltBoksystem
{
    internal interface IUtlånbar
    {

        public void LånaUt();

        public void Återlämna();
    }
}
