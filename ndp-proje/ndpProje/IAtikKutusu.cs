using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ndpProje
{
    interface IAtikKutusu : IDolabilen
    {
        double BosaltmaPuani();
        bool Ekle(Atik atik);
        bool Bosalt(Atik Atik);
        int Sure { get; }
    }
}
