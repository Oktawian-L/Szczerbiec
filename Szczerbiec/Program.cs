using System;
using Szczerbiec.Enum;
using Szczerbiec.Model;

namespace Szczerbiec
{
    class Program
    {
        static void Main(string[] args)
        {
            var newWeapon = new Weapon();
            Random _random = new Random();
            var randomNumber = _random.Next(1, 2);
            var rnd = new Random();
            Random random = new Random();

            Type type = typeof(WeaponType);
            Array values = type.GetEnumValues();
            int index = random.Next(values.Length);

            WeaponType value = (WeaponType)values.GetValue(index);
            newWeapon.Type = value.ToString();
            Console.WriteLine("  " + newWeapon.Type);
        }


    }
}
