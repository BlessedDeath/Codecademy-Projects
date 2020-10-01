// Storm.cs
using System;

namespace MagicalInheritance
{
    class Storm
    {
        public string Essence
        { get; private set; }
        public bool IsStrong
        { get; private set; }
        public string Caster
        { get; private set; }

        public Storm(string essence, bool isStrong, string caster)
        {
            Essence = essence;
            IsStrong = isStrong;
            Caster = caster;
        }

        public string Announce()
        {
            string StormStrength = "";

            if (IsStrong == true)
            {
                StormStrength = "strong";
            }
            else
            {
                StormStrength = "weak";
            }
            return $"{Caster}, cast a {StormStrength} {Essence} storm!";
        }
    }
}
