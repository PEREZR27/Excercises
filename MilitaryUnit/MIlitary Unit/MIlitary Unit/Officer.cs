using System;
using System.Collections.Generic;
using System.Text;

namespace Military_Unit
{
    class Officer : Personel
    {
        public override string Greet() => "(Some scumbag NCO salutes you)";
        public override string Rank() => "Your rank cost 2 more dollars than the enlisted swine";

        public override string Correction() => "*15 minute speech";
        public string Mission1() => $"You arrive in the company office and are greeted by the company clerk. You catch a glimmer of motivation in his eyes and decide to give him a five minute motivational speech about wisconsin cheese farmers\n" +
        "Just as you are about to tie it all back to the core principles of leadership the XO rudely interupts you\n" +
            "\"Hey there, Lt how about you stop harrassing ROW-GAYLEE-OOH and train some Marines OOHRAH?!?\"\n\n" +

            "Press [Enter] to continue.\n";
        public string Setting() => "You just got to work in your fuel efficient prius. Your lawyer called and said she dropped the charges. Its a perfect day to assume the persona of someone who has it all together so you can write about it in your personal blog that is read by your grandmother and guys in your ROTC frat.\n\n";
        public string EndSetting() => "You decide to \"hold\" the XO's gear for him until the next field op";


    }
}