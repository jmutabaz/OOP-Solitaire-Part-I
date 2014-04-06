using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace WindowsFormsApplication2
{
  public partial class CalculationGame : Form
  {
    //instantiate classes
    Card cards = new Card();
    CardList cList = new CardList();
    Deck deck = new Deck();
    HintPile hPile = new HintPile();
    WastePile wPile = new WastePile();
    FoundationPile fPile_1 = new FoundationPile();
    FoundationPile fPile_2 = new FoundationPile();
    FoundationPile fPile_3 = new FoundationPile();
    FoundationPile fPile_4 = new FoundationPile();
    DiscardPile dPile1 = new DiscardPile();
    DiscardPile dPile2 = new DiscardPile();
    DiscardPile dPile3 = new DiscardPile();
    DiscardPile dPile4 = new DiscardPile();
    Random rand = new Random();
    Point dPile1LastCardLocation;
    Point dPile2LastCardLocation;
    Point dPile3LastCardLocation;
    Point dPile4LastCardLocation;

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

    private void CalculationGame_Load(object sender, EventArgs e)
    {
      //Load cards. We will use threads to speed up the way cards are loaded
      string[]cards=System.IO.Directory.GetFiles(System.IO.Path.GetFullPath("../cards/"));

      /*
      foreach (string card in cards)
      {
        if (!card.ToLower().Contains("Thumbs.db".ToLower()) && !card.ToLower().Contains("b2fh.gif".ToLower()))
        {
          string fileName = System.IO.Path.GetFileName(card);
          deck.AddCard(new Card(fileName));
        }
      }
       */



      Parallel.ForEach(cards, card =>
        {
          if (!card.ToLower().Contains("Thumbs.db".ToLower()) && !card.ToLower().Contains("b2fh.gif".ToLower()))
          {
            string fileName = System.IO.Path.GetFileName(card);
            deck.AddCard(new Card(fileName));
          }


        });
       
      int fbox1 = 0;//A of clubs
      int fbox2 = rand.Next(13, 22); //new suite diamonds
      int fbox3 = rand.Next(26, 35); //new suit 
      int fbox4 = rand.Next(39, 48); //new suit
      Card card1 = deck.getCard(fbox1);
      Card card2 = deck.getCard(fbox2);
      Card card3 = deck.getCard(fbox3);
      Card card4 = deck.getCard(fbox4);
      deck.removeCard(card1);
      deck.removeCard(card2);
      deck.removeCard(card3);
      deck.removeCard(card4);
      Bitmap image1 = card1.getCardImage();
      Bitmap image2 = card2.getCardImage();
      Bitmap image3 = card3.getCardImage();
      Bitmap image4 = card4.getCardImage();

      foundation1.BackgroundImage = image1;
      fPile_1.AddToPile(card1);
      foundation2.BackgroundImage = image2;
      fPile_2.AddToPile(card2);
      foundation3.BackgroundImage = image3;
      fPile_3.AddToPile(card3);
      foundation4.BackgroundImage = image4;
      fPile_4.AddToPile(card4);

      dPile1LastCardLocation = panel1.Location;
      dPile2LastCardLocation = panel2.Location;
      dPile3LastCardLocation = panel3.Location;
      dPile4LastCardLocation = panel4.Location;

      textBox1.Text = "2 3 4 5 6 7 8 9 10 J Q K";
      textBox2.Text = "4 6 8 10 Q A 3 5 7 9 J K";
      textBox3.Text = "6 9 Q 2 5 8 J A 4 7 10 K";
      textBox4.Text = "8 Q 3 7 J 2 6 10 A 5 9 K";



      //MessageBox.Show("FPile " + fPile.getCount().ToString());
      //MessageBox.Show("Deck " + deck.getCount().ToString());
    }

    private void btnDeck_Click(object sender, EventArgs e)
    {
      int r = rand.Next(deck.getCount());
      Card card = deck.getCard(r);
      if (card == null)
          MessageBox.Show("There are no cards in the deck");
      else
      {
          wPile.AddToPile(card);
          deck.removeCard(card);
          wastePilePicture.BackgroundImage = card.getCardImage();
      }
    }

    private void panel1_MouseEnter(object sender, EventArgs e)
    {
        panel1.BorderStyle = BorderStyle.Fixed3D;
    }

    private void panel1_MouseDown(object sender, MouseEventArgs e)
    {
        AddCardDiscardPile(e, panel1, dPile1, ref dPile1LastCardLocation, this.panel1_MouseDown);
    }

    private void panel2_MouseDown(object sender, MouseEventArgs e)
    {
        AddCardDiscardPile(e, panel2, dPile2, ref dPile2LastCardLocation, this.panel2_MouseDown);
    }

    private void panel3_MouseDown(object sender, MouseEventArgs e)
    {
        AddCardDiscardPile(e, panel3, dPile3, ref dPile3LastCardLocation, this.panel3_MouseDown);
    }

    private void panel4_MouseDown(object sender, MouseEventArgs e)
    {
        AddCardDiscardPile(e, panel4, dPile4, ref dPile4LastCardLocation, this.panel4_MouseDown);
    }



    private void AddCardDiscardPile(MouseEventArgs e, Panel sourcePanel, DiscardPile discardPile, ref Point lastLocation, MouseEventHandler methodToHandle)
    {
        if (e.Button == MouseButtons.Left)
        {
            if (wPile.getCount() > 0)
            {
                Card card = wPile.getLastCardInPile();
                discardPile.AddToPile(card);
                if (discardPile.getCount() == 1)
                    sourcePanel.BackgroundImage = card.getCardImage();
                else
                {
                    Panel p = new Panel();
                    p.BackgroundImage = card.getCardImage();
                    p.Height = sourcePanel.Height;
                    p.Width = sourcePanel.Width;
                    lastLocation.Offset(0, 20);
                    p.Location = lastLocation;
                    lastLocation = p.Location;
                    p.MouseDown += new System.Windows.Forms.MouseEventHandler(methodToHandle);
                    this.Controls.Add(p);
                    p.BringToFront();
                }

                //Remove card from the waste pile
                wPile.removeCard(card);
                wastePilePicture.BackgroundImage = null;
            }
        }
    }



  }
}
