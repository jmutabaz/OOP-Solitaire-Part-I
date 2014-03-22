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
    public partial class CalculationGame : Form
    { 
		  //instantiate classes
		  Cards cards = new Cards();
		  CardList cList = new CardList();
		  Deck deck = new Deck();
		  HintPile hPile = new HintPile();
		  WastePile wPile = new WastePile();
		  FoundationPile fPile = new FoundationPile();
		  DiscardPile dPile = new DiscardPile();

		    private int _ticks;

        public CalculationGame()
        {
            InitializeComponent();
            timer1.Start(); 
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            _ticks++;
            this.Text = "Game Time:" + " " + _ticks.ToString();

            if (_ticks == 2000)
            {
                this.Text = "Game Over";
                Application.Exit(); 
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            this.Text = "Calculation Solitaire"; 
        }

        private void btnAuthors_onClick(object sender, EventArgs e)
        {
          MessageBox.Show("John Mutabazi, Nicholas Allen, Andrew Witworth "
                         + "\nJason Horn, and Richard Phelps");
        }
        
        private void btnRules_onClick(object sender, EventArgs e)
        {
          MessageBox.Show("1. First Locate and remove an Ace, two, three " 
                        + "and four card from the deck and deal them " 
                        + "onto the foundations face-up."
                        + "\n2. Pick one card from the deck at a time and "
                        + "add it to one of the foundations if possible. " 
                        + "\nIf you can't add it to the foundation, place " 
                        + "the card on one fo the four waste piles below the "
                        + "\foundations");
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripDropDownButton1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripDropDownButton2_Click(object sender, EventArgs e)
        {

        }

        private void CalculationGame_Load(object sender, EventArgs e)
        {
          foreach(string s in System.IO.Directory.GetFiles(System.IO.Path.GetFullPath("../cards/")))
          {
            if (!s.ToLower().Contains("Thumbs.db".ToLower()))
            { 
              string fileName = System.IO.Path.GetFileName(s);
              deck.AddCard(new Cards(fileName));
            }
          }
          //testing to see how many cards
          MessageBox.Show("There are currently " + deck.getCount().ToString() + " cards on the deck");
        }

        private void toolStripContainer1_ContentPanel_Load(object sender, EventArgs e)
        {
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnDiscardPile_Click(object sender, EventArgs e)
        {
            //waste pile
        }

        private void btnDeckPicutre_Click(object sender, EventArgs e)
        {
            
            //this.Click = click;
            base.OnMouseClick(null);

        }
         

         void control_Click(object sender, EventArgs e)
         {
             //throw new NotImplementedException();
             //Image newImage = Image.FromFile("1.gif");
             
             //wastePilePicture.BackgroundImage= newImage;
             
             
         }

         private void btnDeck_Click(object sender, EventArgs e)
         { 
            Random rand = new Random();   
            int r = rand.Next(deck.getCount());
            Cards card = deck.getCard(r-1);
            dPile.AddToPile(card);
            deck.removeCard(card);
            Bitmap image1 = (Bitmap)Image.FromFile(System.IO.Path.GetFullPath("../cards/" + card.getCardName()), true);
            wastePilePicture.BackgroundImage = image1;
         }

         private void btnFoundPile1_Click_1(object sender, EventArgs e)
         {

         }

         private void btnFoundPile2_Click(object sender, EventArgs e)
         {

         }

         private void btnFoundPile3_Click(object sender, EventArgs e)
         {

         }

         private void btnFoundPile4_Click(object sender, EventArgs e)
         {

         }
         
         private void pictureBox5_Click(object sender, EventArgs e)
         {

         }


         private void hintPile1_Click(object sender, EventArgs e)
         {
           
           MessageBox.Show("A 2 3 4 5 6 7"
                          + "\n8 9 10 J Q K");
           
         }

         private void hintPile2_Click(object sender, EventArgs e)
         {
           //this is the hintPile1_Click pile
           MessageBox.Show("2 4 6 8 10 Q"
                          + "\nA 3 5 7 9 J K");
         }

         private void hintPile3_Click(object sender, EventArgs e)
         {
           MessageBox.Show("3 6 9 Q 2 5 8"
                          + "\nJ A 4 7 10 K");
         }

         private void hintPile4_Click(object sender, EventArgs e)
         {
           //MessageBox.Show = "click here for hint";

         }

    }
}
