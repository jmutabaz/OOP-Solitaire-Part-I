using System;
using System.Drawing;

namespace WindowsFormsApplication2
{
	public class Cards
	{
		//variables
		private string name;
		private string number;
		private string color;
		private string suit;
		Boolean faceUp;

		public Cards() 
		{
			//constructor
		}

		public Cards(string name)
		{
			this.name = name;

			if (name == "1.gif") {
				//A of clubs - black
				number = "A";
				color = "black";
				suit = "club";
				faceUp = false;
				Bitmap cardImage = (Bitmap)Image.FromFile(@"C:\Users\johnniecris\Projects\WindowsFormsApplication2\cards\1.gif", true);
			}
			if (name == "2.gif") {
				//2 of clubs - black
				number = "2";
				color = "black";
				suit = "club";
				faceUp = false;
				Bitmap cardImage = (Bitmap)Image.FromFile(@"C:\Users\johnniecris\Projects\WindowsFormsApplication2\cards\2.gif", true);
			}
			if (name == "3.gif") {
				//3 of clubs - black
				number = "3";
				color = "black";
				suit = "club";
				faceUp = false;
				Bitmap cardImage = (Bitmap)Image.FromFile(@"C:\Users\johnniecris\Projects\WindowsFormsApplication2\cards\3.gif", true);
			}
			if (name == "4.gif") {
				//4 of clubs - black
				number = "4";
				color = "black";
				suit = "club";
				faceUp = false;
				Bitmap cardImage = (Bitmap)Image.FromFile(@"C:\Users\johnniecris\Projects\WindowsFormsApplication2\cards\4.gif", true);
			}
			if (name == "5.gif") {
				//5 of clubs - black
				number = "5";
				color = "black";
				suit = "club";
				faceUp = false;
				Bitmap cardImage = (Bitmap)Image.FromFile(@"C:\Users\johnniecris\Projects\WindowsFormsApplication2\cards\5.gif", true);
			}
			if (name == "6.gif") {
				//6 of clubs - black
				number = "6";
				color = "black";
				suit = "club";
				faceUp = false;
				Bitmap cardImage = (Bitmap)Image.FromFile(@"C:\Users\johnniecris\Projects\WindowsFormsApplication2\cards\6.gif", true);
			}
			if (name == "7.gif") {
				//7 of clubs - black
				number = "7";
				color = "black";
				suit = "club";
				faceUp = false;
				Bitmap cardImage = (Bitmap)Image.FromFile(@"C:\Users\johnniecris\Projects\WindowsFormsApplication2\cards\7.gif", true);
			}
			if (name == "8.gif") {
				//8 of clubs - black
				number = "8";
				color = "black";
				suit = "club";
				faceUp = false;
				Bitmap cardImage = (Bitmap)Image.FromFile(@"C:\Users\johnniecris\Projects\WindowsFormsApplication2\cards\8.gif", true);
			}
			if (name == "9.gif") {
				//9 of clubs - black
				number = "9";
				color = "black";
				suit = "club";
				faceUp = false;
				Bitmap cardImage = (Bitmap)Image.FromFile(@"C:\Users\johnniecris\Projects\WindowsFormsApplication2\cards\9.gif", true);
			}
			if (name == "10.gif") {
				//10 of clubs - black
				number = "10";
				color = "black";
				suit = "club";
				faceUp = false;
				Bitmap cardImage = (Bitmap)Image.FromFile(@"C:\Users\johnniecris\Projects\WindowsFormsApplication2\cards\10.gif", true);
			}
			if (name == "11.gif") {
				//J of clubs - black
				number = "J";
				color = "black";
				suit = "club";
				faceUp = false;
				Bitmap cardImage = (Bitmap)Image.FromFile(@"C:\Users\johnniecris\Projects\WindowsFormsApplication2\cards\11.gif", true);
			}
			if (name == "12.gif") {
				//K of clubs - black
				number = "K";
				color = "black";
				suit = "club";
				faceUp = false;
				Bitmap cardImage = (Bitmap)Image.FromFile(@"C:\Users\johnniecris\Projects\WindowsFormsApplication2\cards\12.gif", true);
			}
			if (name == "13.gif") {
				//Q of clubs - black
				number = "Q";
				color = "black";
				suit = "club";
				faceUp = false;
				Bitmap cardImage = (Bitmap)Image.FromFile(@"C:\Users\johnniecris\Projects\WindowsFormsApplication2\cards\13.gif", true);
			}
			if (name == "14.gif") {
				//A of diamonds - red
				number = "A";
				color = "red";
				suit = "diamond";
				faceUp = false;
				Bitmap cardImage = (Bitmap)Image.FromFile(@"C:\Users\johnniecris\Projects\WindowsFormsApplication2\cards\14.gif", true);
			}
			if (name == "15.gif") {
				//10 of diamonds - red
				number = "10";
				color = "red";
				suit = "diamond";
				faceUp = false;
				Bitmap cardImage = (Bitmap)Image.FromFile(@"C:\Users\johnniecris\Projects\WindowsFormsApplication2\cards\15.gif", true);
			}
			if (name == "16.gif") {
				//2 of diamonds - red
				number = "2";
				color = "red";
				suit = "diamond";
				faceUp = false;
				Bitmap cardImage = (Bitmap)Image.FromFile(@"C:\Users\johnniecris\Projects\WindowsFormsApplication2\cards\16.gif", true);
			}
			if (name == "17.gif") {
				//3 of diamonds - red
				number = "3";
				color = "red";
				suit = "diamond";
				faceUp = false;
				Bitmap cardImage = (Bitmap)Image.FromFile(@"C:\Users\johnniecris\Projects\WindowsFormsApplication2\cards\17.gif", true);
			}
			if (name == "18.gif") {
				//4 of diamonds - red
				number = "4";
				color = "red";
				suit = "diamond";
				faceUp = false;
				Bitmap cardImage = (Bitmap)Image.FromFile(@"C:\Users\johnniecris\Projects\WindowsFormsApplication2\cards\18.gif", true);
			}
			if (name == "19.gif") {
				//5 of diamonds - red
				number = "5";
				color = "red";
				suit = "diamond";
				faceUp = false;
				Bitmap cardImage = (Bitmap)Image.FromFile(@"C:\Users\johnniecris\Projects\WindowsFormsApplication2\cards\19.gif", true);
			}
			if (name == "20.gif") {
				//6 of diamonds - red
				number = "6";
				color = "red";
				suit = "diamond";
				faceUp = false;
				Bitmap cardImage = (Bitmap)Image.FromFile(@"C:\Users\johnniecris\Projects\WindowsFormsApplication2\cards\20.gif", true);
			}
			if (name == "21.gif") {
				//7 of diamonds - red
				number = "7";
				color = "red";
				suit = "diamond";
				faceUp = false;
				Bitmap cardImage = (Bitmap)Image.FromFile(@"C:\Users\johnniecris\Projects\WindowsFormsApplication2\cards\21.gif", true);
			}
			if (name == "22.gif") {
				//8 of diamonds - red
				number = "8";
				color = "red";
				suit = "diamond";
				faceUp = false;
				Bitmap cardImage = (Bitmap)Image.FromFile(@"C:\Users\johnniecris\Projects\WindowsFormsApplication2\cards\22.gif", true);
			}
			if (name == "23.gif") {
				//9 of diamonds - red
				number = "9";
				color = "red";
				suit = "diamond";
				faceUp = false;
				Bitmap cardImage = (Bitmap)Image.FromFile(@"C:\Users\johnniecris\Projects\WindowsFormsApplication2\cards\23.gif", true);
			}
			if (name == "24.gif") {
				//J of diamonds - red
				number = "J";
				color = "red";
				suit = "diamond";
				faceUp = false;
				Bitmap cardImage = (Bitmap)Image.FromFile(@"C:\Users\johnniecris\Projects\WindowsFormsApplication2\cards\24.gif", true);
			}
			if (name == "25.gif") {
				//K of diamonds - red
				number = "K";
				color = "red";
				suit = "diamond";
				faceUp = false;
				Bitmap cardImage = (Bitmap)Image.FromFile(@"C:\Users\johnniecris\Projects\WindowsFormsApplication2\cards\25.gif", true);
			}
			if (name == "26.gif") {
				//Q of diamonds - red
				number = "Q";
				color = "red";
				suit = "diamond";
				faceUp = false;
				Bitmap cardImage = (Bitmap)Image.FromFile(@"C:\Users\johnniecris\Projects\WindowsFormsApplication2\cards\26.gif", true);
			}
			if (name == "27.gif") {
				//A of hearts - red
				number = "A";
				color = "red";
				suit = "hearts";
				faceUp = false;
				Bitmap cardImage = (Bitmap)Image.FromFile(@"C:\Users\johnniecris\Projects\WindowsFormsApplication2\cards\27.gif", true);
			}
			if (name == "28.gif") {
				//10 of hearts - red
				number = "10";
				color = "red";
				suit = "hearts";
				faceUp = false;
				Bitmap cardImage = (Bitmap)Image.FromFile(@"C:\Users\johnniecris\Projects\WindowsFormsApplication2\cards\28.gif", true);
			}
			if (name == "29.gif") {
				//2 of hearts - red
				number = "2";
				color = "red";
				suit = "hearts";
				faceUp = false;
				Bitmap cardImage = (Bitmap)Image.FromFile(@"C:\Users\johnniecris\Projects\WindowsFormsApplication2\cards\29.gif", true);
			}
			if (name == "30.gif") {
				//3 of hearts - red
				number = "3";
				color = "red";
				suit = "hearts";
				faceUp = false;
				Bitmap cardImage = (Bitmap)Image.FromFile(@"C:\Users\johnniecris\Projects\WindowsFormsApplication2\cards\30.gif", true);
			}
			if (name == "31.gif") {
				//4 of hearts - red
				number = "4";
				color = "red";
				suit = "hearts";
				faceUp = false;
				Bitmap cardImage = (Bitmap)Image.FromFile(@"C:\Users\johnniecris\Projects\WindowsFormsApplication2\cards\31.gif", true);
			}
			if (name == "32.gif") {
				//5 of hearts - red
				number = "5";
				color = "red";
				suit = "hearts";
				faceUp = false;
				Bitmap cardImage = (Bitmap)Image.FromFile(@"C:\Users\johnniecris\Projects\WindowsFormsApplication2\cards\32.gif", true);
			}
			if (name == "33.gif") {
				//6 of hearts - red
				number = "6";
				color = "red";
				suit = "hearts";
				faceUp = false;
				Bitmap cardImage = (Bitmap)Image.FromFile(@"C:\Users\johnniecris\Projects\WindowsFormsApplication2\cards\33.gif", true);
			}
			if (name == "34.gif") {
				//7 of hearts - red
				number = "7";
				color = "red";
				suit = "hearts";
				faceUp = false;
				Bitmap cardImage = (Bitmap)Image.FromFile(@"C:\Users\johnniecris\Projects\WindowsFormsApplication2\cards\34.gif", true);
			}
			if (name == "35.gif") {
				//8 of hearts - red
				number = "8";
				color = "red";
				suit = "hearts";
				faceUp = false;
				Bitmap cardImage = (Bitmap)Image.FromFile(@"C:\Users\johnniecris\Projects\WindowsFormsApplication2\cards\35.gif", true);
			}
			if (name == "36.gif") {
				//9 of hearts - red
				number = "9";
				color = "red";
				suit = "hearts";
				faceUp = false;
				Bitmap cardImage = (Bitmap)Image.FromFile(@"C:\Users\johnniecris\Projects\WindowsFormsApplication2\cards\36.gif", true);
			}
			if (name == "37.gif") {
				//J of hearts - red
				number = "J";
				color = "red";
				suit = "hearts";
				faceUp = false;
				Bitmap cardImage = (Bitmap)Image.FromFile(@"C:\Users\johnniecris\Projects\WindowsFormsApplication2\cards\37.gif", true);
			}
			if (name == "38.gif") {
				//K of hearts - red
				number = "K";
				color = "red";
				suit = "hearts";
				faceUp = false;
				Bitmap cardImage = (Bitmap)Image.FromFile(@"C:\Users\johnniecris\Projects\WindowsFormsApplication2\cards\38.gif", true);
			}
			if (name == "39.gif") {
				//Q of hearts - red
				number = "Q";
				color = "red";
				suit = "hearts";
				faceUp = false;
				Bitmap cardImage = (Bitmap)Image.FromFile(@"C:\Users\johnniecris\Projects\WindowsFormsApplication2\cards\39.gif", true);
			}
			if (name == "40.gif") {
				//A of spades - black
				number = "A";
				color = "black";
				suit = "spades";
				faceUp = false;
				Bitmap cardImage = (Bitmap)Image.FromFile(@"C:\Users\johnniecris\Projects\WindowsFormsApplication2\cards\40.gif", true);
			}
			if (name == "41.gif") {
				//10 of spades - black
				number = "10";
				color = "black";
				suit = "spades";
				faceUp = false;
				Bitmap cardImage = (Bitmap)Image.FromFile(@"C:\Users\johnniecris\Projects\WindowsFormsApplication2\cards\41.gif", true);
			}
			if (name == "42.gif") {
				//2 of spades - black
				number = "2";
				color = "black";
				suit = "spades";
				faceUp = false;
				Bitmap cardImage = (Bitmap)Image.FromFile(@"C:\Users\johnniecris\Projects\WindowsFormsApplication2\cards\42.gif", true);
			}
			if (name == "43.gif") {
				//3 of spades - black
				number = "3";
				color = "black";
				suit = "spades";
				faceUp = false;
				Bitmap cardImage = (Bitmap)Image.FromFile(@"C:\Users\johnniecris\Projects\WindowsFormsApplication2\cards\43.gif", true);
			}
			if (name == "44.gif") {
				//4 of spades - black
				number = "4";
				color = "black";
				suit = "spades";
				faceUp = false;
				Bitmap cardImage = (Bitmap)Image.FromFile(@"C:\Users\johnniecris\Projects\WindowsFormsApplication2\cards\44.gif", true);
			}
			if (name == "45.gif") {
				//5 of spades - black
				number = "5";
				color = "black";
				suit = "spades";
				faceUp = false;
				Bitmap cardImage = (Bitmap)Image.FromFile(@"C:\Users\johnniecris\Projects\WindowsFormsApplication2\cards\45.gif", true);
			}
			if (name == "46.gif") {
				//7 of spades - black
				number = "7";
				color = "black";
				suit = "spades";
				faceUp = false;
				Bitmap cardImage = (Bitmap)Image.FromFile(@"C:\Users\johnniecris\Projects\WindowsFormsApplication2\cards\46.gif", true);
			}
			if (name == "47.gif") {
				//7 of spades - black
				number = "7";
				color = "black";
				suit = "spades";
				faceUp = false;
				Bitmap cardImage = (Bitmap)Image.FromFile(@"C:\Users\johnniecris\Projects\WindowsFormsApplication2\cards\47.gif", true);
			}
			if (name == "48.gif") {
				//8 of spades - black
				number = "8";
				color = "black";
				suit = "spades";
				faceUp = false;
				Bitmap cardImage = (Bitmap)Image.FromFile(@"C:\Users\johnniecris\Projects\WindowsFormsApplication2\cards\48.gif", true);
			}
			if (name == "49.gif") {
				//9 of spades - black
				number = "9";
				color = "black";
				suit = "spades";
				faceUp = false;
				Bitmap cardImage = (Bitmap)Image.FromFile(@"C:\Users\johnniecris\Projects\WindowsFormsApplication2\cards\49.gif", true);
			}
			if (name == "50.gif") {
				//J of spades - black
				number = "J";
				color = "black";
				suit = "spades";
				faceUp = false;
				Bitmap cardImage = (Bitmap)Image.FromFile(@"C:\Users\johnniecris\Projects\WindowsFormsApplication2\cards\50.gif", true);
			}
			if (name == "51.gif") {
				//K of spades - black
				number = "K";
				color = "black";
				suit = "spades";
				faceUp = false;
				Bitmap cardImage = (Bitmap)Image.FromFile(@"C:\Users\johnniecris\Projects\WindowsFormsApplication2\cards\51.gif", true);
			}
			if (name == "52.gif") {
				//Q of spades - black
				number = "Q";
				color = "black";
				suit = "spades";
				faceUp = false;
				Bitmap cardImage = (Bitmap)Image.FromFile(@"C:\Users\johnniecris\Projects\WindowsFormsApplication2\cards\52.gif", true);
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
		//public bool isfaceUp()
		//{
		//	Console.WriteLine(faceUp);
		//}

		/* <summary>
		 * Sets a new face of the card
		 * </summary>
		 */
		public void changeFace(Boolean newFace)
		{
			if (newFace != faceUp) {
				newFace = faceUp;
			}
		}

		/* <summary>
		 * Returns the full description of the card
		 * </summary>
		 */
		public string getDescription()
		{
			return name + " " + number + " " + color
				+ " " + suit + " " + faceUp;
		}

		/* <summary>
		 * Compares two cards based on their
		 * </summary>
		 */
		public void compareTwoCards(Cards card1, Cards card2)
		{
			bool flag = true;
			if(card1.getCardName()!=card2.getCardName() && flag){
				flag=false;
			}

			if(card1.getCardNumber()!=card2.getCardNumber() && flag){
				flag=false;
			}

			if(card1.getCardColor()!=card2.getCardColor() && flag){
				flag=false;
			}

			if(card1.getCardSuit()!=card2.getCardSuit() && flag){
				flag=false;
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
	}
}
