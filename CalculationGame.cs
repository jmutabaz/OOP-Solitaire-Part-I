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
		CardList cardList = new CardList();
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

        private void pictureBox2_Click(object sender, EventArgs e)
        {

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

        private void Rules_Game_Click(object sender, EventArgs e)
        {
            MessageBox.Show("How To Play Calculation Solitaire" + "\n" +
                            "Rules:" + "\n" +
                            "1) Don't lose" + "\n" +
                            "2) Dont be afraid to stack" + "\n" +
                            "..........."); 
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

        }

        private void toolStripContainer1_ContentPanel_Load(object sender, EventArgs e)
        {
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //deck 
			/*
            Cards cards = new Cards();
            cards.getCardName();
            cards.getDescription();
            cardList.AddCard (cards);
			*/

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            //waste pile
        }

        private void deckPicutre_Click(object sender, EventArgs e)
        {
            
            //this.Click = click;
            base.OnMouseClick(null);

        }
         

         void control_Click(object sender, EventArgs e)
         {
             throw new NotImplementedException();
             Image newImage = Image.FromFile("1.gif");
             
             wastePilePicture.BackgroundImage= newImage;
             
             
         }

         private void DeckButton_Click_1(object sender, EventArgs e)
         {
             //Control control = DeckButton;
             // Set the text and backcolor of the parent control
            // control.BackColor = Color.Black;
             // Get the form that the Button control is contained within.
             //Form fm = DeckButton.FindForm();
            // control.Click += control_Click;
             string name, number, suit,  color;
             Boolean faceUp;
             //name = "C:/Users/alxph_000/Desktop/WindowsFormsApplication2/cards/12.gif";
             name = "1.gif";
             if (name == "1.gif") {
				//A of clubs - black
				number = "A";
				color = "black";
				suit = "club";
				faceUp = false;
			}
             //Image newImage = Image.FromFile("card/1.gif");
            
                 try
                 {



                     Bitmap image1 = (Bitmap)Image.FromFile(@"C:\Users\alxph_000\Desktop\WindowsFormsApplication2\cards\1.gif", true);
                     wastePilePicture.BackgroundImage = image1;



                 }
                 catch (System.IO.FileNotFoundException)
                 {
                     MessageBox.Show("There was an error opening the bitmap." +
                         "Please check the path.");
                 }

                 //wastePilePicture.BackgroundImage = newImage;
             


            
         }

         private void pictureBox3_Click_1(object sender, EventArgs e)
         {

         }
    }
}
