using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MajutusAsundus
{
    // klass
    class MajutusAsutus
    {
        // Väljad
        protected int _kohti;
        protected decimal _hind;
        protected string vabuKohti;
        public MajutusAsutus(int koht, int hind, string vabuKohti)
        {
            // Väärtustamine
            _kohti = koht;
            _hind = hind;
            this.vabuKohti = vabuKohti;
        }
        // Funktsioon
        static void ArvutaMaksumus(string külalised)
        {
            if (vabuKohti =< külalised)
            {
                throw new ArgumentException("Vabukohti ei ole piisavalt");
            }
            if (külalised == )
            {
                throw new ArgumentException("Külalisi ei saa olla negatiivne arv");
            }
            else
            {
                kohti = vabuKohti - külalised;
            }
        }


        public override string ToString()
        {
            return base.ToString() + $"\nOlete reserveerinud: {_kohti}";
        }
    }
}
