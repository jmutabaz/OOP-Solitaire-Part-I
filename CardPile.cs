using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication2
{
	public abstract class CardPile
	{
		/*
		 * <summary>
		 * Type: abstract class
		 * This class contains common behavioral patterns <br>
		 * that can be used by other classes
		 */ 
		public CardPile () {}

		//will get count of cards
		public abstract int getCount ();

		//will determine if empty
		public abstract bool isEmpty ();

		//will add a card to the pile
		public abstract void AddToPile (Cards card);

		//will return last card in the pile
		public abstract Cards getLastCardInPile();

		//will deal next card in the pile and remove it from pile
		public abstract Cards dealACard();

		public abstract void acceptCard (Cards card);
	} 
}

/*
	class Piles
    {
        int max = 52; 
       // private Stack<Card> CardStack = new Stack<Card>();

       /* public Cardstack()
        { 
 
        } 
        

        private void PeekTopCard()
        {
      //      CardStack.Peek();
        }

        private void PopCard(Card c)
        {
          //  if(CardStack.Count == 0) 
           //     throw Exception; 
            else
            {
            //CardStack.Pop(c);
            }

        }

        private void PushCard(Card c)
        {
            if(CardStack.size == max) 
                throw Exception; 
            else
            {
            CardStack.Push(c);
            }
        }

        private Boolean isEmpty()
        {
            if (CardStack.Count == null || CardStack.Count == 0)
            {
                return true;
            }
            else
            {
                return false; 
            }
        }

        private boolean isFull()
        {
            if(CardStack.Count == max) 
                return true;  
            else 
                return false; 
        } 

	}*/
