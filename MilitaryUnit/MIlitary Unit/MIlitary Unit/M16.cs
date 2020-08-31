using System;
using System.Collections.Generic;
using System.Text;

namespace Military_Unit
{
    class M16 : Weapons
    {
        public override string Description() => "This weapon sucks and its too long";
        public override string Use() => "You popped a few shots off";
        public override string Stage() => "You have a sling use it";
        public override string Carry() => "It is dangling from your sling";

    }
}