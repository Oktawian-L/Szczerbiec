using System;
using System.Collections.Generic;
using System.Text;
using Szczerbiec.Enum;

namespace Szczerbiec.Model
{
    public class Weapon
    {
        public WeaponType Type {get; set;}

        public Weapon()
        {
            Type = SetRandomType();
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
    }
}
