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
    Random rand = new Random();

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
                    + "\foundations"
                    + " SHSH");
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

    private void toolStripContainer1_ContentPanel_Load(object sender, EventArgs e)
    {
    }

    private void pictureBox1_Click(object sender, EventArgs e)
    {

    }

    private void btnDeckPicutre_Click(object sender, EventArgs e)
    {
      base.OnMouseClick(null);

    }


    void control_Click(object sender, EventArgs e)
    {

    }

    private void CalculationGame_Load(object sender, EventArgs e)
    {
      foreach (string s in System.IO.Directory.GetFiles(System.IO.Path.GetFullPath("../cards/")))
      {
        if (!s.ToLower().Contains("Thumbs.db".ToLower()))
        {
          string fileName = System.IO.Path.GetFileName(s);
          deck.AddCard(new Cards(fileName));
          fPile.AddToPile(new Cards(fileName));
        }
      }

      int fbox1 = 0;//A of clubs
      int fbox2 = rand.Next(13, 22); //new suite diamonds
      int fbox3 = rand.Next(26, 35); //new suit 
      int fbox4 = rand.Next(39, 48); //new suit
      Cards card1 = deck.getCard(fbox1);
      Cards card2 = deck.getCard(fbox2);
      Cards card3 = deck.getCard(fbox3);
      Cards card4 = deck.getCard(fbox4);
      deck.removeCard(card1);
      deck.removeCard(card2);
      deck.removeCard(card3);
      deck.removeCard(card4);
      Bitmap image1 = (Bitmap)Image.FromFile(System.IO.Path.GetFullPath("../cards/" + card1.getCardName()), true);
      Bitmap image2 = (Bitmap)Image.FromFile(System.IO.Path.GetFullPath("../cards/" + card2.getCardName()), true);
      Bitmap image3 = (Bitmap)Image.FromFile(System.IO.Path.GetFullPath("../cards/" + card3.getCardName()), true);
      Bitmap image4 = (Bitmap)Image.FromFile(System.IO.Path.GetFullPath("../cards/" + card4.getCardName()), true);

      foundation1.BackgroundImage = image1;
      foundation2.BackgroundImage = image2;
      foundation3.BackgroundImage = image3;
      foundation4.BackgroundImage = image4;

      MessageBox.Show("FPile " + fPile.getCount().ToString());
      MessageBox.Show("Deck " + deck.getCount().ToString());
    }

    private void btnDeck_Click(object sender, EventArgs e)
    {
      int r = rand.Next(deck.getCount());
      Cards card = deck.getCard(r - 1);
      dPile.AddToPile(card);
      deck.removeCard(card);
      Bitmap image1 = (Bitmap)Image.FromFile(System.IO.Path.GetFullPath("../cards/" + card.getCardName()), true);
      wastePilePicture.BackgroundImage = image1;

      //Bitmap image2 = (Bitmap)Image.FromFile(System.IO.Path.GetFullPath("../cards/1.gif" + card.getCardName()), true);
      //foundation1.BackgroundImage = image2;
    }
    private void btnDiscardPile_Click(object sender, MouseEventArgs e)
    {
    }

    private void btnFoundPile1_Click_1(object sender, EventArgs e)
    {
      deck.removeCard(cards);
      Bitmap image1 = (Bitmap)Image.FromFile(System.IO.Path.GetFullPath("../cards/1.gif" + cards.getCardName()), true);
      foundation1.BackgroundImage = image1;
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

    private void discardPile1_onClick(object sender, EventArgs e)
    {

    }

    private void discardPile2_onClick(object sender, EventArgs e)
    {

    }

    private void discardPile3_onClick(object sender, EventArgs e)
    {

    }

    private void discardPile4_onClick(object sender, EventArgs e)
    {

    }

    private void panel1_DragEnter_1(object sender, DragEventArgs e)
    {
      e.Effect = DragDropEffects.All;

    }

    private void panel1_DragDrop_1(object sender, DragEventArgs e)
    {
      MessageBox.Show("test");
    }

  }
}
