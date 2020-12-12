using AtmosMagica.Environment.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vintagestory.API.Common;

namespace AtmosMagica.Environment
{
    // All Magic in the World is like a Layer of Magica (Magical Energy) in the Environment.
    // Magic can be used in multiple Ways...
    // 
    // Sourcerers, Magical-Machinery
    //     - Use Magic to rewrite Reality to their needs
    //     - Conversion/Storage of Magica
    //       - needs a Catalyst to convert energy from the Environment
    //       - needs a Crystal(Battery) to store converted energy
    //     - May do an action instantly but it consumes more energy
    // 
    // Mages, Magical-Entities, Spirits
    //     - Use Magic to bend Reality
    //     - Conversion/Storage of Magica
    //       - Can store magical energy
    //       - Can convert magical energy directly from the Environment
    //     - Needs a Medium and or Spell to make a miracle happen (use a Magic-Spell)
    // 
    // Magica (Magical Energy)
    //     - exists in the Environment
    //     - Regeneration influences
    //       - the biom
    //       - the inhabitants (Players, Magical-Entities, Spirits)
    //     - different types that make Magica up
    //       - Primal Elemental Magic (Light, Dark, Fire, Earth, Water, Air)
    //       - Extended Elemental Magic (Combinations of Primal Elements)
    //       - Source Magic (Magic in Players and Magical-Entities / Blood Magic)
    //       - Natura Magic (Magic in Plants and Minerals)

    /// <summary>
    /// The Atmosphere is the Layer of Magica (Magical Energy) in the Environment.
    /// </summary>
    public class Atmosphere
    {
        private static readonly Dictionary<Type, MagicaType> magicaTypes = new Dictionary<Type, MagicaType>();

        public static void RegisterMagicaType(MagicaType magicaType)
        {
            Atmosphere.magicaTypes.Add(magicaType.GetType(), magicaType);
            Console.WriteLine();
        }
    }
}
