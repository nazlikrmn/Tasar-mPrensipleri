using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YZM2118_Odev
{
   public class Player
    {
        public Video oynatılıyor { get; set; }
        public Resim oynatılıyorResim { get; set; }
       public bool playerDurum=false;

        public string Play()
        {
            if (playerDurum)
                return "Zaten açık";
            playerDurum = true;
            return "Player açıldı.";
        }

        public string Stop()
        {
            if (!playerDurum)
                return "Zaten kapalı";
            playerDurum = false;
            return "Player kapatıldı.";
        }
    }
}
