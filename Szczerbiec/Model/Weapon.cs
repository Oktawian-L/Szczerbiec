using System;
using System.Collections.Generic;
using System.Text;
using Szczerbiec.Enum;

namespace Szczerbiec.Model
{
    public class Weapon
    {
        public WeaponType Type {get; set;}

        public GearRarity Rarity { get; set; }

        public Weapon()
        {
            Type = SetRandomType();
            Rarity = SetRandomRarity();
        }

        public WeaponType SetRandomType()
        {
            Random random = new Random();

            Type type = typeof(WeaponType);
            Array values = type.GetEnumValues();
            int index = random.Next(values.Length);

            WeaponType value = (WeaponType)values.GetValue(index);

            return value;
        }

        public GearRarity SetRandomRarity()
        {
            Random random = new Random();
           var result =  random.Next(1, 100);

            if (result <= 50)
            {
                return GearRarity.Common;
            }
            else if (result > 50 && result <= 75)
            {
                return GearRarity.Uncommon;
            }
            else if (result > 75 && result <= 88)
            {
                return GearRarity.Remarkable;
            }
            else if (result > 88 && result <= 95)
            {
                return GearRarity.Rare;
            }
            else if (result > 95 && result <= 100)
            {
                return GearRarity.Legendary;
            }


            return GearRarity.Legendary;
        }
    }
}
