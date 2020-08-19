using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
    Author's name : Wooram Moon
    Author's student Number : 301098673
    Date last Modified : 
    Program description
    1st Revision : Aug 17th
    2nd Revision : Aug 18th
 */

namespace COMP123_M2020_FinalExam
{
    public static class Program
    {
        public static Character character = new Character();
        public static SplashForm splashForm;
        public static GenerateNameForm generateNameForm;
        public static AbilityGeneratorForm abilityGeneratorForm;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            splashForm = new SplashForm();
            generateNameForm = new GenerateNameForm();
            abilityGeneratorForm = new AbilityGeneratorForm();

            Application.Run(splashForm);
        }
    }
}
