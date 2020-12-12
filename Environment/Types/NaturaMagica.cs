using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtmosMagica.Environment.Types
{
    public class NaturaMagica : MagicaType
    {
        public static NaturaMagica Instance { get; private set; }

        public NaturaMagica() : base()
        {
            NaturaMagica.Instance = this;
        }
    }
}
