using System;
using System.Collections.Generic;
using System.Text;

namespace Shuffle_Deck
{
    
    class Deck_Manipulation: Random
    {
        static List<string> shuffled_Deck = new List<string>();
        static List<string> deck = new List<string>();

        static StringBuilder sb = new StringBuilder();
        static Random rand = new Random();

        static string card;
        static int number;
        static int random;

        public static List<string> create_Starting_Deck(List<string> faces, List<string> suits)
        {
            foreach (string s in suits)
            {
                foreach(string s_1 in faces)
                {
                    sb.Clear();
                    sb.Append(s_1);
                    sb.Append(" of ");
                    sb.Append(s);
                    card = sb.ToString();
                    deck.Add(card);
                }
            }
            return deck;
        }
        public static List<string> shuffle_Deck(List<string> unshuffled_Deck)
        {
            number = unshuffled_Deck.Count;
            while(shuffled_Deck.Count < 52)
            {
                random = rand.Next(number);

                if (shuffled_Deck.Contains(unshuffled_Deck[random]))
                {
                    goto cont;
                }
                else
                {
                    shuffled_Deck.Add(unshuffled_Deck[random]);
                }
                cont:;
            }
            return shuffled_Deck;
        }
    }
}
