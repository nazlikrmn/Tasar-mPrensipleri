using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YZM2118_Odev
{
    interface IControl
    {
        string Play(Oynatılacak oynat);
        string Stop(Oynatılacak oynat);
    }
}
