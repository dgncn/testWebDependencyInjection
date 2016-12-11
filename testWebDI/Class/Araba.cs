using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using testWebDI.Core;

namespace testWebDI.Class
{
    public class Araba
    {
        // Ford _ford;
        IAraba _araba;
        public Araba(IAraba araba)
        {
            _araba = araba;
        }
        public string Yaz()
        {
           return _araba.ArabayıSur();
        }
    }
}