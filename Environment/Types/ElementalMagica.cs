using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtmosMagica.Environment.Types
{
    public class ElementalMagica : MagicaType
    {
        public static ElementalMagica Instance { get; private set; }

        private readonly Dictionary<String, Element> elements = new Dictionary<string, Element>();

        public ElementalMagica() : base()
        {
            ElementalMagica.Instance = this;
            this.setup();
        }

        public void RegisterElement(Element element) => this.elements.Add(element.ID, element);

        public Element GetElement(String id) => this.elements[id];

        private void setup()
        {
            this.RegisterElement(new Element("air", null, null));
            this.RegisterElement(new Element("dark", null, null));
            this.RegisterElement(new Element("earth", null, null));
            this.RegisterElement(new Element("fire", null, null));
            this.RegisterElement(new Element("light", null, null));
            this.RegisterElement(new Element("water", null, null));
        }

        public class Element
        {
            private readonly String id;
            private readonly Element source0;
            private readonly Element source1;

            public String ID => this.id;
            public Element Source0 => this.source0;
            public Element Source1 => this.source1;

            public bool IsPrimal => this.source0 == null || this.source1 == null;

            public Element(String id, Element source0, Element source1) : base()
            {
                this.id = id;
                this.source0 = source0;
                this.source1 = source1;
            }
        }

        // primals
        public static Element AIR => ElementalMagica.Instance.GetElement("air");
        public static Element DARK => ElementalMagica.Instance.GetElement("dark");
        public static Element EARTH => ElementalMagica.Instance.GetElement("earth");
        public static Element FIRE => ElementalMagica.Instance.GetElement("fire");
        public static Element LIGHT => ElementalMagica.Instance.GetElement("light");
        public static Element WATER => ElementalMagica.Instance.GetElement("water");
        // combinations
    }
}
