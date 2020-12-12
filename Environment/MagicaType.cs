using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtmosMagica.Environment
{
    public abstract class MagicaType
    {
        protected MagicaType() => Atmosphere.RegisterMagicaType(this);

        public bool IsConvertableTo(MagicaType magicaType) => false;
    }
}
