using System;
using Szczerbiec.Enum;
using Szczerbiec.Model;

namespace Szczerbiec
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 20; i++)
            {
                var newWeapon = new Weapon();
                WriteFullLine(newWeapon.Type.ToString(), newWeapon.Rarity);
                Console.WriteLine(" ");
            }
        }

        static void WriteFullLine(string value, GearRarity rarity)
        {
            if (rarity == GearRarity.Uncommon)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
            }
            else if (rarity == GearRarity.Remarkable)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
            }
            else if (rarity == GearRarity.Rare)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
            }
            else if (rarity == GearRarity.Legendary)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
            }


            // Write an entire line to the console with the string.
            //Console.BackgroundColor = ConsoleColor.Green;
            //Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(value.PadRight(Console.WindowWidth - 1));
            // Reset the color.
            Console.ResetColor();
        }


    }
}
