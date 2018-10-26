using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevBuild.Utilities;

namespace DevBuild.Assessment3_Question1 {
    class Program {
        public static string[] mainMenuOptions = { "Display list of Persons", "Add Person", "Delete Person" };

        static void Main(string[] args) {



            Console.Write("***********************************************************\n" +
              "*               Dev.Build(2.0) - My Peeps                 *\n" +
              "***********************************************************\n\n");

            MenuHandling.PrintMenuOptions(mainMenuOptions, menuMode: true);
            var userSelection = UserInput.SelectMenuOption(mainMenuOptions.Length);

            switch (mainMenuOptions[userSelection - 1]) {
                case "Display List of Persons": break;
                case "Add Person": break;
                case "Delete Person": break;
            }

            while (true) {
                //Display list for the first time in the loop
                //Prompt the user to determine whether or not they want to display list, add Person, or delete Person

                
            }
        }

        public void AddPerson() { }

        public void DeletePerson() { }
    }
}
