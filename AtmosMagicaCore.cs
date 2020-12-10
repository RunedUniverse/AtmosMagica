using AtmosMagica.Environment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vintagestory.API.Common;

namespace AtmosMagica
{
    public class AtmosMagicaCore : ModSystem
    {
        private static Atmosphere atmos = null;

        public Atmosphere GetAtmosphere() => AtmosMagicaCore.atmos;

        public override void StartPre(ICoreAPI api)
        {
            AtmosMagicaCore.atmos = new Atmosphere();
        }

        public override void Start(ICoreAPI api)
        {
        }

        public override void Dispose()
        {
        }
    }
}
