using System;
using System.Collections.Generic;
using System.Collections;

namespace WindowsFormsApplication2
{
	public class CardList
	{
		//ArrayList to hold cards
		private List<Card> cardList;

		public CardList ()
		{
			cardList = new List<Card> ();
		}
		/* <summary>
		 * Bool isEmpty method <br>
		 * Returns a count of 0
		 * </summary>
		 */
		public bool isEmpty ()
		{
			return cardList.Count == 0;
		}

		/* <summary>
		 * Adds a card to the pile
		 * @param: Cards card
		 * </summary>
		 */ 
		public void AddCard (Card card)
		{
			cardList.Add (card);
			
		}

		/* <summary>
		 * Get the bottom face up card
		 * </summary>
		 */ 
		public Card getBottomFaceUp(Card card)
		{
      if (!isEmpty())
      {
        throw new Exception("There are currently no cards available. "
                                + "Please add a card to continue");
      }
      else
      {
        AddCard(card);
      }
      return cardList[0];
		}

		/* <summary>
		 * Get the top face up card
		 * </summary>
		 */
		public Card getTopFaceUp(Card card)
		{
      if (!isEmpty())
      {
        throw new Exception("There are currently no cards available. "
                                + "Please add a card to continue");
      }
      else
      {
        AddCard(card);
      }
      return cardList[cardList.Count - 1];
		}

		/* <summary>
		 * Removes the top face card from the list
		 * </summary>
		 */
		public void removeBottomFaceUpCard()
		{
      if (!isEmpty())
      {
        throw new Exception("There are currently no cards available. "
                                + "Please add a card to continue");
      }
      else
      {
        cardList.RemoveAt(0);
      }
		}
		/* <summary>
		 * This method will accept a card <br>
		 * A card will be inserted at the first <br>
		 * position of a list
		 * </summary>
		 */
		public void acceptCard(Card card)
		{
			if (!isEmpty()) {
				cardList.Insert (0, card);
			}
		}

		/* <summary>
		 * Get total of all cards in the pile
		 * </summary>
		 */ 
		public int getCount ()
		{
			return cardList.Count;
		}

	}
}

