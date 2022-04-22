using System;

namespace StatesApp {
    class MainClass {
        public static void Main(string[] args) {
            State[] states = new State[50];
            states[0] = new State("AL", "Alabama", "The Cotton State", 1852);
            states[1] = new State("AK", "Alaska", "The Last Frontier", 1959);
            states[2] = new State("AZ", "Arizona", "The Copper State", 1912);
            states[3] = new State("AR", "Arkansas", "The Land of Opportunity", 1836);
            states[4] = new State("CA", "California", "The Golden State", 1850);
            states[5] = new State("CO", "Colorado", "The Centennial State", 1876);
            states[6] = new State("", "", "", );
            states[7] = new State("", "", "", );
            states[8] = new State("", "", "", );
            states[9] = new State("", "", "", );
            states[10] = new State("", "", "", );
            states[11] = new State("", "", "", );
            states[12] = new State("", "", "", );
            states[13] = new State("", "", "", );
            states[14] = new State("", "", "", );
            states[15] = new State("", "", "", );
            states[16] = new State("", "", "", );
            states[17] = new State("", "", "", );
            states[18] = new State("", "", "", );
            states[19] = new State("", "", "", );
            states[20] = new State("", "", "", );
            states[21] = new State("", "", "", );
            states[22] = new State("", "", "", );
            states[23] = new State("", "", "", );
            states[24] = new State("", "", "", );
            states[25] = new State("", "", "", );
            states[26] = new State("", "", "", );
            states[27] = new State("", "", "", );
            states[28] = new State("", "", "", );
            states[29] = new State("", "", "", );
            states[30] = new State("", "", "", );
            states[31] = new State("", "", "", );
            states[32] = new State("", "", "", );
            states[33] = new State("", "", "", );
            states[34] = new State("", "", "", );
            states[35] = new State("", "", "", );
            states[36] = new State("", "", "", );
            states[37] = new State("", "", "", );
            states[38] = new State("", "", "", );
            states[39] = new State("", "", "", );
            states[40] = new State("", "", "", );
            states[41] = new State("", "", "", );
            states[42] = new State("", "", "", );
            states[43] = new State("", "", "", );
            states[44] = new State("", "", "", );
            states[45] = new State("", "", "", );
            states[46] = new State("", "", "", );
            states[47] = new State("", "", "", );
            states[48] = new State("", "", "", );
            states[49] = new State("", "", "", );


            Console.WriteLine(states[1].Nickname);
        }
    }

    public class State {
        public string Abbr;
        public string Name;
        public string Nickname;
        public int YearFounded;

        public State(string aAbbr, string aName, string aNickname, int aYearFounded) {
            Abbr = aAbbr;
            Name = aName;
            Nickname = aNickname;
            YearFounded = aYearFounded;
        }
    }
}