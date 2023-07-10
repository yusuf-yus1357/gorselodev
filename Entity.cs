using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OBUZ_ILETISIM
{
    public class Kontor
    {
        public Guid KontörID { get; set; }
        public string TelNo { get; set; }
        public string Tutar { get; set; }
        
    }

    public class Urunler
    {
        public Guid UrünID { get; set; }
        public string UrünKimlik { get; set; }
        public string UrünIsim { get; set; }
        public string UrünMarka { get; set; }
        public string UrünOzellik { get; set; }
        public string UrünFiyat { get; set; }
    }

    public class UrünTamir
    {
        public Guid TamirID { get; set; }
        public string UrünKimlik { get; set; }
        public string UrünIsim { get; set; }
        public string UrünMarka { get; set; }
        public string TamirSebep { get; set; }
        public string MüşteriTel { get; set; }
    }

    
}
