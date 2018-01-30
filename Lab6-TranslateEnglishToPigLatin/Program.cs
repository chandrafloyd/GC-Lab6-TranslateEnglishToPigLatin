using System;
using System.Globalization;

namespace Lab6_TranslateEnglishToPigLatin
{
    class Program
    {
        static void Main(string[] args)
        {
            //INTRO
            Console.WriteLine("Welcome to the Pig Latin Translator!");
            Console.WriteLine("Enter a word and I will translate it for you:");

            //CONDITION TO END GAME OR CONTINUE
            bool EndGame = false;  //start with EndGame set to false in order to play the game  //the while will loop back to here

            while (EndGame == false)   //do this as long as ContinueProgram is set to true 
            {

                //INPUT AND OTHER VARIABLES

                string OriginalWord = Console.ReadLine();   //add validation: if upper or title case, convert to lower case
                string WordEnd, WordBeginning;
                char[] Vowels = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };


                
                //FIND THE FIRST VOWEL - NTS: is vowel in the first position or no? if first position, FirstVowel = true; add +way and end game

                int index = OriginalWord.IndexOfAny(Vowels);  //this finds the index of the first occurence of the vowel. ie, it looks at OriginalWord, compares it ot the list of vowels and finds the index of the first one and sets the value to an int. In this case, the int is called index.

                WordEnd = OriginalWord.Substring(index); //uses the found index to cut the string into a substring. The cutoff point starts at index and goes to the end of the string.
                WordBeginning = OriginalWord.Substring(0, index);  //this starts at the first position and reads up to the first occurence of the index



                
                if (index == 0)
                {
                    Console.WriteLine("Translation: " + OriginalWord + "way");
                    Console.WriteLine(" ");
                    Console.WriteLine("You are now bilingual!");
                    Console.WriteLine(" ");
                }

                else  //First letter is a consonant
                {
                    //take all letters in front of the FirstVowel and append to end of the word

                    Console.WriteLine($"Original = {OriginalWord} new word = {WordEnd}{WordBeginning}ay");
                }

                //PLAY OR END GAME?
                Console.WriteLine("Play again? Y/N");
                string Continue = Console.ReadLine();

                if (Continue.ToLower() == "n" || Continue.ToLower() == "no")   //if continue = N, End the game
                {
                    EndGame = true;  //set EndGame to true in order to end the loop and exit
                    Console.WriteLine("Thanks for playing!");
                }
                else                   //if continue = Y, play again
                {
                    EndGame = false;
                    Console.WriteLine("Ok let's play again!");
                    Console.Clear();

                }

            }




            ////Example
            // The input string
            //string value = "Your dog is cute.";
            //int temp = value.IndexOf("o");
            //// Test with IndexOf method
            //if (temp != -1)
            //{
            //    Console.WriteLine(temp);
            //}





            //Example
            //string pigLatin = "";
            //string firstLetter;
            //string restOfWord;
            //string vowels = "AEIOUaeiou";
            //int letterPosition;

            //foreach (string word in OriginalWord.Split())
            //{
            //    firstLetter = word.Substring(0, 1);
            //    restOfWord = word.Substring(1, word.Length - 1);
            //    letterPosition = vowels.IndexOf(firstLetter);
            //        if (letterPosition == -1)
            //        {
            //            pigLatin = restOfWord + firstLetter + "ay";
            //        }
            //        else
            //        {
            //            pigLatin = word + "way";
            //        }
            //txtTranslation.Text = pigLatin;
            //txtInput.Focus();


            //Example
            //FirstLetter = (OriginalWord.IndexOf("a"));

            //Console.WriteLine("The first vowel in " + OriginalWord + " is found at position {1}",
            //                      OriginalWord, OriginalWord.IndexOfAny(Vowels) + 1);

            ////Example
            //string str = "This";
            //string[] output = str.Split(' ');
            //foreach (string s in output)
            //{
            //    Console.Write(s[0] + " ");
            //}

            // Output
            // T i m s



            ////EXAMPLE
            //String s = "long and winding road...";
            //Console.WriteLine(" ");
            //Console.WriteLine("The first vowel in \n {0}\n is found at position {1}",
            //                  s, s.IndexOfAny(Vowels) + 1);




        }
    }
}

