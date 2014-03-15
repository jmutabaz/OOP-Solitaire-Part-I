using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class CalculationMenu : Form
    {
        public CalculationMenu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public class deckOfCards
        {
            public static void main(String[] args)
            {

            }

            int[] deck = new int[52];
            String[] suits = { "Spades", "Hearts", "Clubs", "Diamonds" };
            String[] ranks = { "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King" };

           // for (int i =
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new CalculationGame().Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
         
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("How To Play Calculation Solitaire" + "\n" + 
                            "Rules:" + "\n" + 
                            "1) Don't lose" + "\n" + 
                            "2) Dont be afraid to stack" + "\n" +
                            "..........."); 
        }
    }

       
}
