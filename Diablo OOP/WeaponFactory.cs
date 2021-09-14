using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diablo_OOP
{
    public class WeaponFactory
    {

        Random r = new Random();
        public Weapons CreateWeapons()
        {
            int weaponChoose = r.Next(1,21);
            switch (weaponChoose)
            {
                case 1: return new NormalWeapons("Axe", "Hand Axe", 3, 2, 3.2, 1.3); // Axe
                case 2: return new NormalWeapons("Scythe","Sacrificial Scythe", 371, 201, 371.8, 1.3); //Scythes 
                case 3: return new NormalWeapons("Spear","Hasta", 24, 17, 24.6, 1.2); //Spear
                case 4: return new NormalWeapons("Fist Weapon", "Talon", 20, 9, 20.3, 1.4); // Fist Weapons

                case 5: return new MagicWeapons("Sword", "Griswold's Edge", 4, 2, 4.2, 1.4, 3); // Sword
                case 6: return new MagicWeapons("Dagger", "The Clipper", 15, 5, 15, 1.5, 3); // Dagger
                case 7: return new MagicWeapons("Mace", "Wirt's Original Leg", 6, 3, 5.4, 1.2, 2); // Mace
                case 8: return new MagicWeapons("Axe", "The Butcher's Cleaver", 3, 2, 3.2, 1.3, 3); // Axe

                case 9: return new RareWeapons("Spear", "Disemboweler", 526, 353, 527.4, 1.2, 6); // Spear
                case 10: return new RareWeapons("Ceremonial Knive", "Flint Knife", 35, 9, 30.8, 1.4, 4); // Ceremonial Knives
                case 11: return new RareWeapons("Mighty Weapon", "Scythe", 36, 20, 36.4, 1.3, 4); // Mighty Weapons
                case 12: return new RareWeapons("Flail", "Shredder", 49, 27, 53.2, 1.4, 4); // Flails

                case 13: return new LegendaryWeapons("Dagger", "Wizardspike", 203, 67, 202.5, 1.5, 3, "Performing an attack has a 25 % chance to hurl a Frozen Orb.Arcane Orb deals 329 % increased damage. (Wizard Only)[300 - 350] %"); // Dagger
                case 14: return new LegendaryWeapons("Fist Weapon", "Demon Hand", 100, 43, 100.1, 1.4, 3, "None Secondary"); // Fist Weapons
                case 15: return new LegendaryWeapons("Mace", "Solanium", 51, 28, 47.4, 1.2, 3, "Critical Hits have a 3% chance to spawn a health globe. [3 - 4]%"); // Mace
                case 16: return new LegendaryWeapons("Flail", "Inviolable Faith", 40, 22, 43.4, 1.4, 3, "Casting Consecration also casts Consecration beneath all of your allies."); // Flails

                case 17: return new SetWeapons("Sword", "Born's Searing Spite", 24, 11, 24.5, 1.4, 3, "SetBonus 1: +2 % Life. SetBonus 2: +20 % Experience. (2.0 % at level 70)"); // Sword
                case 18: return new SetWeapons("Ceremonial Knive", "Hallowed Salvation", 288, 71, 251.3, 1.4, 5, "SetBonus 1: +40 Resistance to All Elements. SetBonus 2: Attack Speed Increased by 5.0 % "); //Ceremonial Knives
                case 19: return new SetWeapons("Mighty Weapon", "Hallowed Reckoning", 277, 150, 277.5, 1.3, 5, "SetBonus 1: +40 Resistance to All Elements. SetBonus 2: Attack Speed Increased by 5.0 % "); // Mighty Weapons
                case 20: return new SetWeapons("Scythe", "Jesseth Skullscythe", 461, 249, 461.5, 1.3, 3, "SetBonus 1: When the target of your Command Skeletons dies, your skeletons are automatically commanded to attack a nearby target. SetBonus 2: While your skeletons are commanded to attack a target, you deal 400 % increased damage."); // Scythes
                default:
                    return null;
            }
        }
    }
}
