using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vintagestory.API.Common;

namespace AtmosMagica.Environment
{
    /// <summary>
    /// All Magic in the World is like a Layer of Magica (Magical Energy) in the Environment.
    /// Magic can be used in multiple Ways...
    /// 
    /// Sourcerers, Magical-Machinery
    ///     - Use Magic to rewrite Reality to their needs
    ///     - Conversion/Storage of Magica
    ///       - needs a Catalyst to convert energy from the Environment
    ///       - needs a Crystal(Battery) to store converted energy
    ///     - May do an action instantly but it consumes more energy
    /// 
    /// Mages, Magical-Entities, Spirits
    ///     - Use Magic to bend Reality
    ///     - Conversion/Storage of Magica
    ///       - Can store magical energy
    ///       - Can convert magical energy directly from the Environment
    ///     - Needs a Medium and or Spell to make a miracle happen (use a Magic-Spell)
    /// 
    /// Magica (Magical Energy)
    ///     - exists in the Environment
    ///     - Regeneration influences
    ///       - the biom
    ///       - the inhabitants (Players, Magical-Entities, Spirits)
    ///     - different types that make Magica up
    ///       - Primal Elemental Magic (Light, Dark, Fire, Earth, Water, Air)
    ///       - Extended Elemental Magic (Combinations of Primal Elements)
    ///       - Source Magic (Magic in Players and Magical-Entities / Blood Magic)
    ///       - Natura Magic (Magic in Plants and Minerals)
    /// 
    /// </summary>
    public class Atmosphere
    {
        private static ElementalMagicaRegistry elementalMagicaRegistry = new ElementalMagicaRegistry();


        private void setup()
        {
            Atmosphere.elementalMagicaRegistry.RegisterElement("LIGHT", null, null);
            Atmosphere.elementalMagicaRegistry.RegisterElement("DARK", null, null);
            Atmosphere.elementalMagicaRegistry.RegisterElement("FIRE", null, null);
            Atmosphere.elementalMagicaRegistry.RegisterElement("EARTH", null, null);
            Atmosphere.elementalMagicaRegistry.RegisterElement("WATER", null, null);
            Atmosphere.elementalMagicaRegistry.RegisterElement("AIR", null, null);
        }

        public Magica GetArealMagica(IWorldChunk chunk)
        {
            // TODO get Magica from chunk configs
            return null;
        }

        public static ElementalMagica Combine(ElementalMagica elementA, ElementalMagica elementB, Int32 amount)
        {
            if (!(elementA.HasMin(amount) && elementB.HasMin(amount)))
                return null;
            elementA.Subtract(amount);
            elementB.Subtract(amount);
            return Atmosphere.elementalMagicaRegistry.CreateCombo(elementA.Type, elementB.Type, amount);
        }
        public static ElementalMagica Combine(ElementalMagica elementA, ElementalMagica elementB) => Atmosphere.Combine(elementA, elementB, 1);

        public static void RegisterElementalMagica(String type, String sourceA, String sourceB) => Atmosphere.elementalMagicaRegistry.RegisterElement(type, sourceA, sourceB);
        public static ElementalMagica CreateElementalMagicaOfType(String type) => Atmosphere.elementalMagicaRegistry.Create(type);
    }
}
