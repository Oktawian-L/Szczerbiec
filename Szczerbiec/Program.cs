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

            Console.WriteLine("  " + newWeapon.Type);
        }


    }
}
