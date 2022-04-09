using System;

namespace Workout {
    class MainClass {
        public static void Main(string[] args) {
            Console.Write("What would you like to work on today? (Legs, Arms, Chest, Back)");
            string response = Console.ReadLine();
            //Prints out what the user should do or use
            Console.Write("You should do/use the: " + Workout(response));
        }

        public static string Workout(string response) {
            //String Arrays filled with particular workouts for each part of body
            string[] legWorkouts = {"Leg Press", "Calf Extension"};
            string[] armWorkouts = {"Bench Press", "Bicep Curl"};
            string[] chestWorkouts = {"Bench Press", "Pectoral Fly"};
            string[] backWorkouts = {"Lat Pulldown", "Seated Row"};
            //Takes the Arrays stated above and joins them together to be printed out
            string legs = string.Join(", ", legWorkouts);
            string arms = string.Join(", ", armWorkouts);
            string chest = string.Join(", ", chestWorkouts);
            string back = string.Join(", ", backWorkouts);
            //Checks what the response to the workout question is and what to print out
            if(response == "Legs") {
                return legs;
            } else if(response == "Arms") {
                return arms;
            } else if(response == "Chest") {
                return chest;
            } else if(response == "Back") {
                return back;
            } else {
                return "That is not a valid response!";
            }
        }
    }
}