using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YZM2118_Odev
{
    public class Kontrol : IControl
    {
        public string Play(Oynatılacak oynat)
        {
            return  oynat.ad + " " + oynat.ceken + " " + oynat.kayıtTarihi ;
        }

        public string Stop(Oynatılacak oynat)
        {
            return oynat.ad + " " + oynat.ceken + " " + oynat.kayıtTarihi + " Durduruldu";
        }
    }
}
