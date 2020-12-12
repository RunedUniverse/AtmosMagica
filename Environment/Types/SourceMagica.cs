using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtmosMagica.Environment.Types
{
    public class SourceMagica : MagicaType
    {
        public static SourceMagica Instance { get; private set; }

        public SourceMagica() : base()
        {
            SourceMagica.Instance = this;
        }
    }
}
