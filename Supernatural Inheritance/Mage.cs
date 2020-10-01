// Mage.cs
using System;

namespace MagicalInheritance
{
    class Mage : Pupil
    {
        public Mage(string Title) : base(Title)
        { }
        public virtual Storm CastRainStorm()
        {
            return new Storm("rain", false, Title);
        }
    }
}
