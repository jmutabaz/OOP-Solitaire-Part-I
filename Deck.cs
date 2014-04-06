using System;
using System.Collections.Generic;
using System.Collections;

namespace WindowsFormsApplication2
{
	public class Deck
	{
		private List<Card> cardsToBeShuffled;
    Random rand = new Random();
		//to be evaluated at run time rather than compile-time
		//public readonly int FINITE_MAX_LENGTH = 52; 

		public Deck ()
		{
			//default constructor
			//deck is empty
			cardsToBeShuffled = new List<Card> ();
		}

		public bool isEmpty ()
		{
			return cardsToBeShuffled.Count == 0;
		}
    
		public void AddCard (Card card)
		{
			cardsToBeShuffled.Add (card);
		}

		/* <summary>
		 * Deals a card
		 * removes a card at the first index <br>
		 * then shuffles the cards
		 * </summary>
		*/
		public void dealACard ()
		{
      if (!isEmpty())
      {
        throw new Exception("There are currently no cards available. "
                                + "Please add a card to continue");
      }
      else
      {
        cardsToBeShuffled.RemoveAt(0);
      }
			Shuffle (cardsToBeShuffled);
		}

    /* <summary>
		 * Adds to the pile and shuffles the deck <br>
		 * I am using the fisher-yates algorithm <br>
		 * to ensure no repitition of the same instance
		 * </summary>
		 */
    public void removeCard(Card card)
    {
      
        cardsToBeShuffled.Remove(card);

    }

    public Card getCard(int index)
    {
        if (index >= 0 && cardsToBeShuffled.Count > 0)
            return cardsToBeShuffled[index];
        else
            return null;
    }
		

		/* <summary>
		 * Adds to the pile and shuffles the deck <br>
		 * I am using the fisher-yates algorithm <br>
		 * to ensure no repitition of the same instance
		 * </summary>
		 */

		public void shuffleDeck(){
			int count = 1;
			int cardNum;
			Card card;
			//int[] arr = new int[52];
			do 
      {
				cardNum = rand.Next (1, 52);
				card = new Card (cardNum + ".gif");
        if (isEmpty())
        {
          AddCard(card);
        }
        else
        {
          ; //do nothing
        }
			} while(count <= 52);
			Shuffle(cardsToBeShuffled);
		}

		public static void Shuffle<T>(List<T> listToShuffle)
    {
			//fisher yates algorithm. Ensures no duplicates
			Random rand = new Random();
			int n = listToShuffle.Count;
			while (n > 1)
      {
		    n--;
			  int k = rand.Next (n + 1);
			  T value = listToShuffle [k];
			  listToShuffle [k] = listToShuffle [n];
			  listToShuffle [n] = value;
		  }

    }

    /* <summary>
		 * Get total of all cards in the pile
		 * </summary>
		 */ 
    public int getCount()
    {
      return cardsToBeShuffled.Count;
    }
	}
}

