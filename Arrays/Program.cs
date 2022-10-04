using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] weapons = {"Pistol", "Machine Gun", "Bazooka", "Assault Rifle", "Rocket Launcher", "Grenade"};
            string[] ammo = {"100", "500", "8", "320", "5", "2"};

            foreach (String weapon in weapons)
                Console.WriteLine(weapon);

            Console.ReadKey(false);
        }
    }
}