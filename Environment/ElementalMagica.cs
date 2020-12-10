using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtmosMagica.Environment
{
    public class ElementalMagica : IMagicaComponent
    {
        private String type = "NONE";
        private String sourceA = null;
        private String sourceB = null;
        private Int32 amount = 0;

        public String Type => this.type;
        public String SourceElementA { get => this.sourceA; internal set => this.sourceA = value; }
        public String SourceElementB { get => this.sourceB; internal set => this.sourceB = value; }
        public Int32 Amount
        {
            get => this.amount; set
            {
                if (value < 0)
                    throw new Exception("Amount < 0!");
                this.amount = value;
            }
        }

        internal ElementalMagica(String type)
        {
        }
        internal ElementalMagica(String type, Int32 amount) => this.Amount = amount;

        public void Add(Int32 amount) => this.amount = this.amount + amount;
        public Boolean Add(ElementalMagica elementalMagica)
        {
            if (this.type.Equals(elementalMagica.Type))
            {
                this.amount = this.amount + amount;
                return true;
            }
            return false;
        }
        public void Subtract(Int32 amount) => this.Amount = this.amount - amount;
        public Boolean Subtract(ElementalMagica elementalMagica)
        {
            if (this.type.Equals(elementalMagica.Type))
            {
                this.Amount = this.amount - amount;
                return true;
            }
            return false;
        }

        public Boolean TransverTo(ElementalMagica elementalMagica)
        {
            if (this.type.Equals(elementalMagica.Type))
            {
                elementalMagica.Add(this.amount);
                this.amount = 0;
                return true;
            }
            return false;
        }

        public Boolean HasMin(Int32 amount) => amount <= this.amount;

        public ElementalMagica Combine(ElementalMagica elementalMagica) => Atmosphere.Combine(this, elementalMagica);
    }
}
