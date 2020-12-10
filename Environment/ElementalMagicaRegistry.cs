using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtmosMagica.Environment
{
    internal class ElementalMagicaRegistry
    {
        private Dictionary<String, List<String>> repo = new Dictionary<String, List<String>>();
        public Boolean RegisterElement(String type, String sourceA, String sourceB)
        {
            if (!repo.ContainsKey(sourceA) || !repo.ContainsKey(sourceB))
                return false;
            repo.Add(type, new List<String>());
            repo[sourceA].Add(type);
            repo[sourceB].Add(type);
            return true;
        }

        public ElementalMagica CreateCombo(String sourceA, String sourceB, Int32 amount)
        {
            if (!repo.ContainsKey(sourceA) || !repo.ContainsKey(sourceB))
                return null;
            IEnumerable<String> l = repo[sourceA].Intersect(repo[sourceB]);
            if (l.Count() == 0)
                return null;
            return new ElementalMagica(l.First(), amount);
        }

        public ElementalMagica Create(String type) => this.repo.ContainsKey(type) ? new ElementalMagica(type) : null;
        public ElementalMagica Create(String type, Int32 amount) => this.repo.ContainsKey(type) ? new ElementalMagica(type, amount) : null;
    }
}
