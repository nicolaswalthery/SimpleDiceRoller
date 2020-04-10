using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleDiceRoller
{
    public partial class Mainform : Form
    {


        public Mainform()
        {
            InitializeComponent();
        }

        private void textBoxNDice_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBoxNSides_TextChanged(object sender, EventArgs e)
        {

        }
        //[1] Here the user can clic the buttonToller to generate the outcome of the dice previously defined.
        private void buttonRoller_Click(object sender, EventArgs e)
        {
            //Align (Center) the text diplayed in the richTextBoxOutcome
            richTextBoxOutcome.SelectionAlignment = HorizontalAlignment.Center;

            //Check if the number of dice and the number of sides are not "" and if so, set them to 1 and 6 respectively.
            if (this.textBoxNDice.Text == "")
                this.textBoxNDice.Text = "1";

            if (this.textBoxNSides.Text == "")
                this.textBoxNSides.Text = "6";

            string numberDice = this.textBoxNDice.Text;
            string sidesDie   = this.textBoxNSides.Text;

            Dice die = new Dice(Convert.ToInt32(numberDice), Convert.ToInt32(sidesDie));

            richTextBoxOutcome.Text = die.ThrowIt.ToString();
        }
        //[2] This is in that textBox that the outcome of the die will be display.
        private void richTextBox1_TextChanged(object sender, EventArgs e) //richTextBoxOutcome
        {
        }
        
        private void labelNumSides_Click(object sender, EventArgs e)
        {
        }
    }
}
