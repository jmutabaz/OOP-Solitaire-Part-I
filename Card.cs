using System;
using System.Drawing;

namespace WindowsFormsApplication2
{
  public class Card
  {
    //variables
    private string name;
    private string number;
    private string color;
    private string suit;
    Boolean faceUp;
    Bitmap cardImage;

    public Card()
    {
      //constructor
    }

    public Card(string name)
    {
      this.name = name;
      this.cardImage = (Bitmap)Image.FromFile(System.IO.Path.GetFullPath("../cards/" + name), true);
      switch (name)
      {
        /*case "1.gif":
          //A of clubs - black
          number = "A";
          color = "black";
          suit = "club";
          faceUp = false;
          break;*/
        case "2.gif":
          //2 of clubs - black
          number = "2";
          color = "black";
          suit = "club";
          faceUp = false;
          break;
        case "3.gif":
          //3 of clubs - black
          number = "3";
          color = "black";
          suit = "club";
          faceUp = false;
          break;
        case "4.gif":
          //4 of clubs - black
          number = "4";
          color = "black";
          suit = "club";
          faceUp = false;
          break;
        case "5.gif":
          //5 of clubs - black
          number = "5";
          color = "black";
          suit = "club";
          faceUp = false;
          break;
        case "6.gif":
          //6 of clubs - black
          number = "6";
          color = "black";
          suit = "club";
          faceUp = false;
          break;
        case "7.gif":
          //7 of clubs - black
          number = "7";
          color = "black";
          suit = "club";
          faceUp = false;
          break;
        case "8.gif":
          //8 of clubs - black
          number = "8";
          color = "black";
          suit = "club";
          faceUp = false;
          break;
        case "9.gif":
          //9 of clubs - black
          number = "9";
          color = "black";
          suit = "club";
          faceUp = false;
          break;
        case "10.gif":
          //10 of clubs - black
          number = "10";
          color = "black";
          suit = "club";
          faceUp = false;
          break;
        case "11.gif":
          //J of clubs - black
          number = "J";
          color = "black";
          suit = "club";
          faceUp = false;
          break;
        case "12.gif":
          //K of clubs - black
          number = "K";
          color = "black";
          suit = "club";
          faceUp = false;
          break;
        case "13.gif":
          //Q of clubs - black
          number = "Q";
          color = "black";
          suit = "club";
          faceUp = false;
          break;
        case "14.gif":
          //A of diamonds - red
          number = "A";
          color = "red";
          suit = "diamond";
          faceUp = false;
          break;
        case "15.gif":
          //10 of diamonds - red
          number = "10";
          color = "red";
          suit = "diamond";
          faceUp = false;
          break;
        /*case "16.gif":
          //2 of diamonds - red
          number = "2";
          color = "red";
          suit = "diamond";
          faceUp = false;
          break;
        case "17.gif":
          //3 of diamonds - red
          number = "3";
          color = "red";
          suit = "diamond";
          faceUp = false;
          break;
        case "18.gif":
          //4 of diamonds - red
          number = "4";
          color = "red";
          suit = "diamond";
          faceUp = false;
          break;*/
        case "19.gif":
          //5 of diamonds - red
          number = "5";
          color = "red";
          suit = "diamond";
          faceUp = false;
          break;
        case "20.gif":
          //6 of diamonds - red
          number = "6";
          color = "red";
          suit = "diamond";
          faceUp = false;
          break;
        case "21.gif":
          //7 of diamonds - red
          number = "7";
          color = "red";
          suit = "diamond";
          faceUp = false;
          break;
        case "22.gif":
          //8 of diamonds - red
          number = "8";
          color = "red";
          suit = "diamond";
          faceUp = false;
          break;
        case "23.gif":
          //9 of diamonds - red
          number = "9";
          color = "red";
          suit = "diamond";
          faceUp = false;
          break;
        case "24.gif":
          //J of diamonds - red
          number = "J";
          color = "red";
          suit = "diamond";
          faceUp = false;
          break;
        case "25.gif":
          //K of diamonds - red
          number = "K";
          color = "red";
          suit = "diamond";
          faceUp = false;
          break;
        case "26.gif":
          //Q of diamonds - red
          number = "Q";
          color = "red";
          suit = "diamond";
          faceUp = false;
          break;
        case "27.gif":
          //A of hearts - red
          number = "A";
          color = "red";
          suit = "hearts";
          faceUp = false;
          break;
        case "28.gif":
          //10 of hearts - red
          number = "10";
          color = "red";
          suit = "hearts";
          faceUp = false;
          break;
        case "29.gif":
          //2 of hearts - red
          number = "2";
          color = "red";
          suit = "hearts";
          faceUp = false;
          break;
        case "30.gif":
          //3 of hearts - red
          number = "3";
          color = "red";
          suit = "hearts";
          faceUp = false;
          break;
        case "31.gif":
          //4 of hearts - red
          number = "4";
          color = "red";
          suit = "hearts";
          faceUp = false;
          break;
        case "32.gif":
          //5 of hearts - red
          number = "5";
          color = "red";
          suit = "hearts";
          faceUp = false;
          break;
        case "33.gif":
          //6 of hearts - red
          number = "6";
          color = "red";
          suit = "hearts";
          faceUp = false;
          break;
        case "34.gif":
          //7 of hearts - red
          number = "7";
          color = "red";
          suit = "hearts";
          faceUp = false;
          break;
        case "35.gif":
          //8 of hearts - red
          number = "8";
          color = "red";
          suit = "hearts";
          faceUp = false;
          break;
        case "36.gif":
          //9 of hearts - red
          number = "9";
          color = "red";
          suit = "hearts";
          faceUp = false;
          break;
        case "37.gif":
          //J of hearts - red
          number = "J";
          color = "red";
          suit = "hearts";
          faceUp = false;
          break;
        case "38.gif":
          //K of hearts - red
          number = "K";
          color = "red";
          suit = "hearts";
          faceUp = false;
          break;
        case "39.gif":
          //Q of hearts - red
          number = "Q";
          color = "red";
          suit = "hearts";
          faceUp = false;
          break;
        case "40.gif":
          //A of spades - black
          number = "A";
          color = "black";
          suit = "spades";
          faceUp = false;
          break;
        case "41.gif":
          //10 of spades - black
          number = "10";
          color = "black";
          suit = "spades";
          faceUp = false;
          break;
        case "42.gif":
          //2 of spades - black
          number = "2";
          color = "black";
          suit = "spades";
          faceUp = false;
          break;
        case "43.gif":
          //3 of spades - black
          number = "3";
          color = "black";
          suit = "spades";
          faceUp = false;
          break;
        case "44.gif":
          //4 of spades - black
          number = "4";
          color = "black";
          suit = "spades";
          faceUp = false;
          break;
        case "45.gif":
          //5 of spades - black
          number = "5";
          color = "black";
          suit = "spades";
          faceUp = false;
          break;
        case "46.gif":
          //7 of spades - black
          number = "7";
          color = "black";
          suit = "spades";
          faceUp = false;
          break;
        case "47.gif":
          //7 of spades - black
          number = "7";
          color = "black";
          suit = "spades";
          faceUp = false;
          break;
        case "48.gif":
          //8 of spades - black
          number = "8";
          color = "black";
          suit = "spades";
          faceUp = false;
          break;
        case "49.gif":
          //9 of spades - black
          number = "9";
          color = "black";
          suit = "spades";
          faceUp = false;
          break;
        case "50.gif":
          //J of spades - black
          number = "J";
          color = "black";
          suit = "spades";
          faceUp = false;
          break;
        case "51.gif":
          //K of spades - black
          number = "K";
          color = "black";
          suit = "spades";
          faceUp = false;
          break;
        case "52.gif":
          //Q of spades - black
          number = "Q";
          color = "black";
          suit = "spades";
          faceUp = false;
          break;
        default:
          System.Console.WriteLine(name + " is not in the directory");
          break;
      }
      
    }

    /* <summary>
     * Returns the card's name
     * </summary>
     */
    public string getCardName()
    {
      return name;
    }

    /* <summary>
     * Returns the card's number
     * </summary>
     */
    public string getCardNumber()
    {
      return number;
    }

    /* <summary>
     * Returns the card's color
     * </summary>
     */
    public string getCardColor()
    {
      return color;
    }

    /* <summary>
     * Returns the card's suite
     * </summary>
     */
    public string getCardSuit()
    {
      return suit;
    }

    /* <summary>
     * Returns the card's face
     * </summary>
     */
    public bool isfaceUp()
    {
      return faceUp;
    }

    /* <summary>
     * Sets a new face of the card
     * </summary>
     */
    public void changeFace(Boolean newFace)
    {
      if (newFace != faceUp)
      {
        newFace = faceUp;
      }
    }

    /* <summary>
     * Compares two cards based on their
     * </summary>
     */
    public void compareTwoCards(Card card1, Card card2)
    {
      bool flag = true;
      if (card1.getCardName() != card2.getCardName() && flag)
      {
        flag = false;
      }

      if (card1.getCardNumber() != card2.getCardNumber() && flag)
      {
        flag = false;
      }

      if (card1.getCardColor() != card2.getCardColor() && flag)
      {
        flag = false;
      }

      if (card1.getCardSuit() != card2.getCardSuit() && flag)
      {
        flag = false;
      }
    }

    /*
     * 
    public string getPathCard()
    {
      return "/Application/cards/" + name;
    }
     */

    /*
    public static void Main (string[] args)
    {
      for (int i = 0; i < 10; i++) {
        if (i < 5) {
          continue;
        }
        Console.WriteLine ("continue");
        Console.WriteLine (i);
      }
    } 
    */

    public Bitmap getCardImage()
    {
        return cardImage;
    }
  }
}
