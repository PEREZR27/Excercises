using System;
using System.Collections.Generic;
using System.Text;

namespace Military_Unit
{
    class Personel
    {
        public string soul() => "You have none";
        public virtual string Greet() => "HI";
        public virtual string Rank() => "It means you make more or less than someone else";
        public virtual string Correction() => "*Screaming";
    }
}