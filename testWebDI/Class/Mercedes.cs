using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using testWebDI.Core;

namespace testWebDI.Class
{
    public class Mercedes : IAraba
    {
        public string ArabayıSur()
        {
            return "Mercedes sürüyorum.";
        }
    }
}