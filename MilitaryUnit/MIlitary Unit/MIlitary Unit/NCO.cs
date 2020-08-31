using System;
using System.Collections.Generic;
using System.Text;

namespace Military_Unit
{
    class NCO : Personel
    {
        public override string Greet() => "(You saluted officer)";
        public string Correction2() => "Look Away";
        public override string Rank()
        {
            return "your rank is old and covered in sharpie";
        }
        public string Mission1() => "Get accountability, EDL, Do a gear inspection, Run for fun";
        public override string Correction() => "Nah man thats the wrong answer";
        public string Setting() => "You have been in the Marines for eight years and some guy with a degree in accounting who failed out of flight school is now your boss\n" +
        "Everyday you dream about being in the Air force \n";
        public string EndSetting() => "You've made it another day! Only 1443 more to go until sweet EAS...";
    }
}