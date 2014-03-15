﻿using System;
using System.Collections.Generic;
using System.Collections;

namespace WindowsFormsApplication2
{
	public class Deck
	{
		private List<Cards> cardsToBeShuffled;
		//to be evaluated at run time rather than compile-time
		public readonly int FINITE_MAX_LENGTH = 52; 

		public Deck ()
		{
			//default constructor
			//deck is empty
			cardsToBeShuffled = new List<Cards> ();
		}

		public bool isEmpty ()
		{
			return cardsToBeShuffled.Count == 0;
		}

		public void AddCard (Cards card)
		{
			//if (cardList.Count == 0) {
			cardsToBeShuffled.Add (card);
			//} else {
			//	throw new NotImplementedException ();
			//}
		}

		/* <summary>
		 * Deals a card
		 * removes a card at the first index <br>
		 * then shuffles the cards
		 * </summary>
		*/
		public void dealACard ()
		{
			//Cards card = cardsToBeShuffled[0];

			cardsToBeShuffled.RemoveAt (0);
			Shuffle (cardsToBeShuffled);
			//am going too add my shuffling method once done
			//return card;
		} 

		
		public void moveToDiscardPile()
		{
			//don't know how to implement moving to discard file
			//don't i need to implement positions as well to be 
			//able to move the cards?
		}

		/* <summary>
		 * Adds to the pile and shuffles the deck <br>
		 * I am using the fisher-yates algorithm <br>
		 * to ensure no repitition of the same instance
		 * </summary>
		 */

		public void shuffleDeck(){
			Random rand = new Random ();
			int count = 1;
			int cardNum;
			Cards card;
			//int[] arr = new int[52];
			do {
				cardNum = rand.Next (1, 52);
				card = new Cards (cardNum + ".gif");
                if (isEmpty())
                {
					AddCard(card);
                }
                else
                {
                    ; //do nothing
                }
			} while(count <= 52);
			//Use fisher-Yates to ensure no duplicates of the same card instance
			Shuffle(cardsToBeShuffled);
		}

		/*
        public static void shuffleDeck(List<string>shuffleCards)
        {
            shuffleCards = new List<string>();
            for (int i = 0; i <= 52; i++) {
                //add cards to List
                shuffleCards.Add (new Cards("1.gif"));
                shuffleCards.Add (new Cards ("10.gif"));
                shuffleCards.Add (new Cards ("11.gif"));
                shuffleCards.Add (new Cards ("12.gif"));
                shuffleCards.Add (new Cards ("13.gif"));
                shuffleCards.Add (new Cards ("14.gif"));
                shuffleCards.Add (new Cards ("15.gif"));
                shuffleCards.Add (new Cards ("16.gif"));
                shuffleCards.Add (new Cards ("17.gif"));
                shuffleCards.Add (new Cards ("18.gif"));
                shuffleCards.Add (new Cards ("19.gif"));
                shuffleCards.Add (new Cards ("2.gif"));
                shuffleCards.Add (new Cards ("20.gif"));
                shuffleCards.Add (new Cards ("21.gif"));
                shuffleCards.Add (new Cards ("22.gif"));
                shuffleCards.Add (new Cards ("23.gif"));
                shuffleCards.Add (new Cards ("24.gif"));
                shuffleCards.Add (new Cards ("25.gif"));
                shuffleCards.Add (new Cards ("26.gif"));
                shuffleCards.Add (new Cards ("27.gif"));
                shuffleCards.Add (new Cards ("28.gif"));
                shuffleCards.Add (new Cards ("29.gif"));
                shuffleCards.Add (new Cards ("3.gif"));
                shuffleCards.Add (new Cards ("30.gif"));
                shuffleCards.Add (new Cards ("31.gif"));
                shuffleCards.Add (new Cards ("32.gif"));
                shuffleCards.Add (new Cards ("33.gif"));
                shuffleCards.Add (new Cards ("34.gif"));
                shuffleCards.Add (new Cards ("35.gif"));
                shuffleCards.Add (new Cards ("36.gif"));
                shuffleCards.Add (new Cards ("37.gif"));
                shuffleCards.Add (new Cards ("38.gif"));
                shuffleCards.Add (new Cards ("39.gif"));
                shuffleCards.Add (new Cards ("4.gif"));
                shuffleCards.Add (new Cards ("40.gif"));
                shuffleCards.Add (new Cards ("41.gif"));
                shuffleCards.Add (new Cards ("42.gif"));
                shuffleCards.Add (new Cards ("43.gif"));
                shuffleCards.Add (new Cards ("44.gif"));
                shuffleCards.Add (new Cards ("45.gif"));
                shuffleCards.Add (new Cards ("46.gif"));
                shuffleCards.Add (new Cards ("47.gif"));
                shuffleCards.Add (new Cards ("48.gif"));
                shuffleCards.Add (new Cards ("49.gif"));
                shuffleCards.Add (new Cards ("5.gif"));
                shuffleCards.Add (new Cards ("50.gif"));
                shuffleCards.Add (new Cards ("51.gif"));
                shuffleCards.Add (new Cards ("52.gif"));
                shuffleCards.Add (new Cards ("6.gif"));
                shuffleCards.Add (new Cards ("7.gif"));
                shuffleCards.Add (new Cards ("8.gif"));
                shuffleCards.Add (new Cards ("9.gif"));
            }
            //shuffle cards
            //check out this error
            Shuffle (shuffleCards);
        } 
		*/
		public static void Shuffle<T>(List<T> listToShuffle)
        {
			//fisher yates algorithm. Ensures no duplicates
			Random rand = new Random();
			int n = listToShuffle.Count;
			while (n > 1) {
				n--;
				int k = rand.Next (n + 1);
				T value = listToShuffle [k];
				listToShuffle [k] = listToShuffle [n];
				listToShuffle [n] = value;
			}

			//List<CardList> shuffle = this.Cards;
            //this.Cards = new CardList[shuffle.length];

            //fisher yates algorithm. Ensures no duplicates
			//var randResult = new Random ();
			//for (int i = array.Length; i > 1; i--) {
			//  int j = randResult.Next (i);
			//  T tmp = array [j];
			//  array [j] = array [i - 1];
			//  array [i - 1] = tmp;
			//}

        }
	}
}

