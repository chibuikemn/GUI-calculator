using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI_Testin1
{
    public interface ISolve
    {
        void Accumulate(string s);
        void Clear();
        double solve();

    }
}
//cintent of this is void accummulate, void clear, double solve, solver(this implemenats ISolve)