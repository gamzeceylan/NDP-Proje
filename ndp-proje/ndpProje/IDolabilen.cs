using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ndpProje
{
    interface IDolabilen
    {
        double Kapasite { get; set; }
        double DoluHacim();
        double DolulukOrani { get; }
    }
}
