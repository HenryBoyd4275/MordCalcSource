using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MordCalc.Shared
{
  public static class Weapons
  {
    public const string Dagger = "Dagger";
    public const string HandWeapon = "HandWeapon";
    public const string Club = "Club";
    public const string Axe = "Axe";
    public const string Spear = "Spear";
    public const string Sword = "Sword";
    public const string Halberd = "Halberd";
    public const string DoubleHandedWeapon = "Double-Handed Weapon";
    public const string DragonSword = "Dragon Sword";
    public const string Rapier = "Rapier";
    public const string Flail = "Flail";
    public const string Morningstar = "Morningstar";
    public const string None = "None";
    public const string Shield = "Shield";
    public const string Buckler = "Buckler";
    public const string Beastlash = "Beastlash";
    public const string SteelWhip = "Steel Whip";
  }
  public class Warrior
  {
    public int status { get; set; } = 0;//0 is fine, 1 is knocked down, 2 is stunned
    public int WS { get; set; } = 3;
    public int S { get; set; } = 3;
    public int T { get; set; } = 3;
    public int W { get; set; } = 1;
    public int I { get; set; } = 3;
    public int A { get; set; } = 1;
    public int SV { get; set; } = 7;
    public bool Helmet { get; set; } = false;
    public bool BlackLotusP { get; set; } = false;
    public bool BlackLotusO { get; set; } = false;
    public bool NoStun { get; set; } = false;
    public bool Strike { get; set; } = false;
    public bool Reflex { get; set; } = false;
    public bool Step { get; set; } = false;
    public bool Strong { get; set; } = false;
    public bool Dwarf { get; set; } = false;
    public bool Hatred { get; set; } = false;
    public bool Frenzy { get; set; } = false;
    public bool Art { get; set; } = false;
    public bool MainPistol { get; set; } = false;
    public bool OffPistol { get; set; } = false;
    public bool Flies { get; set; } = false;
    public bool Wraith { get; set; } = false;
    public bool ParryPro { get; set; } = false;
    public string MainWeapon { get; set; } = Weapons.Club;
    public string Offhand { get; set; } = Weapons.Dagger;
  }
}
