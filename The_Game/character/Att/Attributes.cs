using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using The_Game.Elements;

namespace The_Game.character.Att
{
    public class Attributes
    {
        public AttributesStat Physical { get; set; } = new AttributesStat("Physical");
        public AttributesStat Fire { get; set; } = new AttributesStat("Fire");
        public AttributesStat Water { get; set; } = new AttributesStat("Water");
        public AttributesStat Earth { get; set; } = new AttributesStat("Earth");
        public AttributesStat Air { get; set; } = new AttributesStat("Air");
        public AttributesStat Light { get; set; } = new AttributesStat("Light");
        public AttributesStat Dark { get; set; } = new AttributesStat("Dark");

        public void GainXPFor(ElementTypes type, int amount)
            {
                if (type == ElementTypes.Fire)
                {
                    Fire.GainXP(amount);
                }
                if (type == ElementTypes.Physical)
                {
                    Physical.GainXP(amount);
                }
                if (type == ElementTypes.Air)
                {
                    Air.GainXP(amount);            
                }
                if (type == ElementTypes.Water)
                {
                    Water.GainXP(amount);
                }
                if (type == ElementTypes.Earth)
                {
                    Earth.GainXP(amount);
                }
                if (type == ElementTypes.Light)
                {
                    Light.GainXP(amount);
                }
                if (type == ElementTypes.Dark)
                {
                    Dark.GainXP(amount);
                }
        }

        public int GetValue(ElementTypes type)
        {
            int value = 0;
            if (type == ElementTypes.Fire)
            {
                value = this.Fire.Value;
            }
            if (type == ElementTypes.Air)
            {
                value = this.Air.Value;
            }
            if (type == ElementTypes.Physical)
            {
                value = this.Physical.Value;
            }
            if (type == ElementTypes.Water)
            {
                value = this.Water.Value;
            }
            if (type == ElementTypes.Earth)
            {
                value = this.Earth.Value;
            }
            if (type == ElementTypes.Light)
            {
                value = this.Light.Value;
            }
            if (type == ElementTypes.Dark)
            {   
                value = this.Dark.Value;
            }

            return value;
        }

        public void GenValues(int x)
        {
            this.Fire.Value = new Random().Next(x * 10);
            this.Physical.Value = new Random().Next(x * 10);
            this.Air.Value = new Random().Next(x * 10);
            this.Earth.Value = new Random().Next(x * 10);
            this.Water.Value = new Random().Next(x * 10);
            this.Light.Value = new Random().Next(x * 10);
            this.Dark.Value = new Random().Next(x * 10);
        }
    }

    
}
