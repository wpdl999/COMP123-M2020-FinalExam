using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
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
    public partial class GenerateNameForm : Form
    {
        public List<Character> character { get; set; }

        public GenerateNameForm()
        {
            InitializeComponent();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            Program.abilityGeneratorForm.Show();
            this.Hide();
        }

        public void GenerateName()
        {
            Random rng = new Random();

            for (int i = 0; i < 51; i++)
            {
                int generator = rng.Next(0, 49) + 1;


                FirstNameTextBox.Text = FirstNameListBox.Items[generator].ToString();
                LastNameTextBox.Text = LastNameListBox.Items[generator].ToString();
            }
        }

        private void GenerateButton_Click(object sender, EventArgs e)
        {
            GenerateName();

            Character character = Program.character;
            character.FirstName = FirstNameTextBox.Text;
            character.LastName = LastNameTextBox.Text;
        }

        private void GenerateNameForm_Load(object sender, EventArgs e)
        {
            GenerateName();
        }
    }
}
