using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MajutusAsundus
{
    public class Hotell : MajutusAsutus
    {
        private int _tubadeArv;
        private int _kohtiToas;
        public Hotell (decimal hind, int kohtiToas, int tubadeArv) : base(hind,tubadeArv * kohtiToas)
        {
            _tubadeArv = tubadeArv;
            _kohtiToas = kohtiToas;
        }
        public int  VabuTube { get => VabuTube; set => VabuTube = value; }
        public override int VabuKohti
        {
            get => VabuTube * _kohtiToas;
            set
            {
                base.vabuKohti = value;
            }
        }

    }
}
