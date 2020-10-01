using System;

namespace MagicalInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Storm wind = new Storm("wind", false, "Zul'rajas");
            Console.WriteLine(wind.Announce());

            Pupil p = new Pupil("Mezil-kree");
            Storm pSpell = p.CastWindStorm();
            Console.WriteLine(pSpell.Announce());

            Mage m = new Mage("Gul'dan");
            Storm mSpell = m.CastRainStorm();
            Console.WriteLine(mSpell.Announce());

            Archmage a = new Archmage("Nielas Aran");
            Storm aSpell = a.CastRainStorm();
            Storm abSpell = a.CastLightningStorm();
            Console.WriteLine(aSpell.Announce());
            Console.WriteLine(abSpell.Announce());
        }
    }
}