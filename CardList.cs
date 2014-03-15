using System;
using System.Collections.Generic;
using System.Collections;

namespace WindowsFormsApplication2
{
	public class CardList
	{
		//ArrayList to hold cards
		private List<Cards> cardList;

		public CardList ()
		{
			cardList = new List<Cards> ();
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
		public void AddCard (Cards card)
		{
			//if (cardList.Count == 0) {
			cardList.Add (card);
			//} else {
			//	throw new NotImplementedException ();
			//}
		}

		/* <summary>
		 * Get the bottom face up card
		 * </summary>
		 */ 
		public Cards getBottomFaceUp(Cards c)
		{
			return cardList[0];
		}

		/* <summary>
		 * Get the top face up card
		 * </summary>
		 */
		public Cards getTopFaceUp(Cards c)
		{
			return cardList[cardList.Count - 1];
		}

		/* <summary>
		 * Removes the top face card from the list
		 * </summary>
		 */
		public void removetopFaceUpCard()
		{
			if(!isEmpty())
				cardList.RemoveAt(cardList.Count - 1);
		}
		/* <summary>
		 * This method will accept a card <br>
		 * A card will be inserted at the first <br>
		 * position of a list
		 * </summary>
		 */
		public void acceptCard(Cards card)
		{
			if (!isEmpty()) {
				cardList.Insert (0, card);
			}
			acceptCard(card);
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

