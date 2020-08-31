using System;
using System.Collections.Generic;
using System.Text;

namespace Military_Unit
{
    class Weapons
    {
        public virtual string Description() => "This is a weapon.";
        public virtual string Carry() => "You carry the weapon";
        public virtual string Stage() => "Stage your weapon";
        public virtual string Use() => "Use your weapon";


    }
}