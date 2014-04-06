using System;
using System.Collections.Generic;
using System.Collections;

namespace WindowsFormsApplication2
{
	public class HintPile:CardPile
	{
		private List<Card> pile;
		public HintPile ()
		{
			//default constructor
			//no cards in the pile
			pile = new List<Card>();
		}

		/* <summary>
		 * Bool isEmpty method <br>
		 * Returns a count of 0
		 * </summary>
		 */
		public override bool isEmpty ()
		{
			return pile.Count == 0;
		}

		/* <summary>
		 * Adds a card to the pile
		 * @param: Cards card
		 * </summary>
		 */ 
		public override void AddToPile (Card card)
		{
			if (pile.Count == 0) {
				pile.Add (card);
			} 
		}

		/* <summary>
		 * Get total of all cards in the pile
		 * </summary>
		 */ 
		public override int getCount ()
		{
			return pile.Count;
		}

		/* <summary>
		 * Get the last card from the pile
		 * </summary>
		 */ 
		public override Card getLastCardInPile ()
		{
			return pile [pile.Count - 1];
			//throw new NotImplementedException ();
		}

		/* <summary>
		 * Deals next card from the pile
		 * Also return next card from the list <br>
		 * essentially removing it from the list
		 * </summary>
		 */ 
		public override Card dealACard ()
		{
      if (!isEmpty())
      {
        throw new Exception("There are currently no cards available. "
                                + "Please add a card to continue");
      }
      else
      {
        Card card = pile[0];
        pile.RemoveAt(0);
        return card;
      }
      
      //Cards card = pile [0];
			//pile.RemoveAt (0);
			//return card;
		}

		public override void acceptCard(Card card)
		{
			if (pile.Count != 0) {
				pile .Insert (0, card);
			}
			acceptCard(card);
		}
	}
}

