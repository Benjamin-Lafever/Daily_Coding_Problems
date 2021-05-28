using System;
using System.Collections.Generic;

namespace Shuffle_Deck
{
    class Program
    {
        static List<string> suits = new List<string>{ "Spades", "Hearts", "Diamonds", "Clubs" };
        static List<string> faces = new List<string>{ "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
        static List<string> deck = new List<string>();

        static void Main(string[] args)
        {
            deck = Deck_Manipulation.create_Starting_Deck(faces, suits);
            deck.ForEach(Console.WriteLine);
            Console.WriteLine("\n Press enter to shuffle your deck\n");
            Console.ReadLine();
            deck = Deck_Manipulation.shuffle_Deck(deck);
            deck.ForEach(Console.WriteLine);
            Console.ReadLine();

        }
    }
}

//Good morning! Here's your coding interview problem for today.

//This problem was asked by Facebook.

//Given a function that generates perfectly random numbers between 1 and k (inclusive), where k is an input, write a function that shuffles a deck of cards represented as an array using only swaps.

//It should run in O(N) time.

//Hint: Make sure each one of the 52! permutations of the deck is equally likely.
