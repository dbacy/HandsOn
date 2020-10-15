using System;
using System.Collections.Generic;
using System.Text;

namespace ConvertLtoN
{
    class ForLaterMaybe
    {
        /*string dial = " ";
           string phrase = Utils.GetInput("Enter you phrase: ").ToLower();
           //string[] letter = phrase.Split(" ");

           if (phrase.Length == 7)
           {
               Console.WriteLine();
           }
           if (phrase.Length == 10)
           {
               Console.WriteLine("- - -");
           }
           else
           {
               Console.WriteLine("Enter phrase again: ");
           }



           switch (dial[0])
           {
               case 'A' :phrase = "1"; break;
               case 'B': phrase = "1"; break;
               case 'C': phrase = "1"; break;
               case 'D': phrase = "2"; break;
               case 'E': phrase = "2"; break;
               case 'F': phrase = "2"; break;
               case 'G': phrase = "3"; break;
               case 'H': phrase = "3"; break;
               case 'I': phrase = "3"; break;
               case 'J': phrase = "4"; break;
               case 'K': phrase = "4"; break;
               case 'L': phrase = "4"; break;
               case 'M': phrase = "5"; break;
               case 'N': phrase = "5"; break;
               case 'O': phrase = "5"; break;
               case 'P': phrase = "6"; break;
               case 'Q': phrase = "6"; break;
               case 'R': phrase = "6"; break;
               case 'S': phrase = "7"; break;
               case 'T': phrase = "7"; break;
               case 'U': phrase = "7"; break;
               case 'V': phrase = "8"; break;
               case 'W': phrase = "8"; break;
               case 'X': phrase = "8"; break;
               case 'Y': phrase = "9"; break;
               case 'Z': phrase = "9"; break;



           }
           switch (dial[1])
           {
               case 'A': phrase = "1"; break;
               case 'B': phrase = "1"; break;
               case 'C': phrase = "1"; break;
               case 'D': phrase = "2"; break;
               case 'E': phrase = "2"; break;
               case 'F': phrase = "2"; break;
               case 'G': phrase = "3"; break;
               case 'H': phrase = "3"; break;
               case 'I': phrase = "3"; break;
               case 'J': phrase = "4"; break;
               case 'K': phrase = "4"; break;
               case 'L': phrase = "4"; break;
               case 'M': phrase = "5"; break;
               case 'N': phrase = "5"; break;
               case 'O': phrase = "5"; break;
               case 'P': phrase = "6"; break;
               case 'Q': phrase = "6"; break;
               case 'R': phrase = "6"; break;
               case 'S': phrase = "7"; break;
               case 'T': phrase = "7"; break;
               case 'U': phrase = "7"; break;
               case 'V': phrase = "8"; break;
               case 'W': phrase = "8"; break;
               case 'X': phrase = "8"; break;
               case 'Y': phrase = "9"; break;
               case 'Z': phrase = "9"; break;


           }
           switch (dial[2])
           {
               case 'A': phrase = "1"; break;
               case 'B': phrase = "1"; break;
               case 'C': phrase = "1"; break;
               case 'D': phrase = "2"; break;
               case 'E': phrase = "2"; break;
               case 'F': phrase = "2"; break;
               case 'G': phrase = "3"; break;
               case 'H': phrase = "3"; break;
               case 'I': phrase = "3"; break;
               case 'J': phrase = "4"; break;
               case 'K': phrase = "4"; break;
               case 'L': phrase = "4"; break;
               case 'M': phrase = "5"; break;
               case 'N': phrase = "5"; break;
               case 'O': phrase = "5"; break;
               case 'P': phrase = "6"; break;
               case 'Q': phrase = "6"; break;
               case 'R': phrase = "6"; break;
               case 'S': phrase = "7"; break;
               case 'T': phrase = "7"; break;
               case 'U': phrase = "7"; break;
               case 'V': phrase = "8"; break;
               case 'W': phrase = "8"; break;
               case 'X': phrase = "8"; break;
               case 'Y': phrase = "9"; break;
               case 'Z': phrase = "9"; break;

           }
           switch (dial[3])
           {
               case 'A': phrase = "1"; break;
               case 'B': phrase = "1"; break;
               case 'C': phrase = "1"; break;
               case 'D': phrase = "2"; break;
               case 'E': phrase = "2"; break;
               case 'F': phrase = "2"; break;
               case 'G': phrase = "3"; break;
               case 'H': phrase = "3"; break;
               case 'I': phrase = "3"; break;
               case 'J': phrase = "4"; break;
               case 'K': phrase = "4"; break;
               case 'L': phrase = "4"; break;
               case 'M': phrase = "5"; break;
               case 'N': phrase = "5"; break;
               case 'O': phrase = "5"; break;
               case 'P': phrase = "6"; break;
               case 'Q': phrase = "6"; break;
               case 'R': phrase = "6"; break;
               case 'S': phrase = "7"; break;
               case 'T': phrase = "7"; break;
               case 'U': phrase = "7"; break;
               case 'V': phrase = "8"; break;
               case 'W': phrase = "8"; break;
               case 'X': phrase = "8"; break;
               case 'Y': phrase = "9"; break;
               case 'Z': phrase = "9"; break;


           }
           switch (dial[4])
           {
               case 'A': phrase = "1"; break;
               case 'B': phrase = "1"; break;
               case 'C': phrase = "1"; break;
               case 'D': phrase = "2"; break;
               case 'E': phrase = "2"; break;
               case 'F': phrase = "2"; break;
               case 'G': phrase = "3"; break;
               case 'H': phrase = "3"; break;
               case 'I': phrase = "3"; break;
               case 'J': phrase = "4"; break;
               case 'K': phrase = "4"; break;
               case 'L': phrase = "4"; break;
               case 'M': phrase = "5"; break;
               case 'N': phrase = "5"; break;
               case 'O': phrase = "5"; break;
               case 'P': phrase = "6"; break;
               case 'Q': phrase = "6"; break;
               case 'R': phrase = "6"; break;
               case 'S': phrase = "7"; break;
               case 'T': phrase = "7"; break;
               case 'U': phrase = "7"; break;
               case 'V': phrase = "8"; break;
               case 'W': phrase = "8"; break;
               case 'X': phrase = "8"; break;
               case 'Y': phrase = "9"; break;
               case 'Z': phrase = "9"; break;


           }
           switch (dial[4])
           {
               case 'A': phrase = "1"; break;
               case 'B': phrase = "1"; break;
               case 'C': phrase = "1"; break;
               case 'D': phrase = "2"; break;
               case 'E': phrase = "2"; break;
               case 'F': phrase = "2"; break;
               case 'G': phrase = "3"; break;
               case 'H': phrase = "3"; break;
               case 'I': phrase = "3"; break;
               case 'J': phrase = "4"; break;
               case 'K': phrase = "4"; break;
               case 'L': phrase = "4"; break;
               case 'M': phrase = "5"; break;
               case 'N': phrase = "5"; break;
               case 'O': phrase = "5"; break;
               case 'P': phrase = "6"; break;
               case 'Q': phrase = "6"; break;
               case 'R': phrase = "6"; break;
               case 'S': phrase = "7"; break;
               case 'T': phrase = "7"; break;
               case 'U': phrase = "7"; break;
               case 'V': phrase = "8"; break;
               case 'W': phrase = "8"; break;
               case 'X': phrase = "8"; break;
               case 'Y': phrase = "9"; break;
               case 'Z': phrase = "9"; break;


           }
           switch (dial[6])
           {
               case 'A': phrase = "1"; break;
               case 'B': phrase = "1"; break;
               case 'C': phrase = "1"; break;
               case 'D': phrase = "2"; break;
               case 'E': phrase = "2"; break;
               case 'F': phrase = "2"; break;
               case 'G': phrase = "3"; break;
               case 'H': phrase = "3"; break;
               case 'I': phrase = "3"; break;
               case 'J': phrase = "4"; break;
               case 'K': phrase = "4"; break;
               case 'L': phrase = "4"; break;
               case 'M': phrase = "5"; break;
               case 'N': phrase = "5"; break;
               case 'O': phrase = "5"; break;
               case 'P': phrase = "6"; break;
               case 'Q': phrase = "6"; break;
               case 'R': phrase = "6"; break;
               case 'S': phrase = "7"; break;
               case 'T': phrase = "7"; break;
               case 'U': phrase = "7"; break;
               case 'V': phrase = "8"; break;
               case 'W': phrase = "8"; break;
               case 'X': phrase = "8"; break;
               case 'Y': phrase = "9"; break;
               case 'Z': phrase = "9"; break;


           }
           switch (dial[7])
           {
               case 'A': phrase = "1"; break;
               case 'B': phrase = "1"; break;
               case 'C': phrase = "1"; break;
               case 'D': phrase = "2"; break;
               case 'E': phrase = "2"; break;
               case 'F': phrase = "2"; break;
               case 'G': phrase = "3"; break;
               case 'H': phrase = "3"; break;
               case 'I': phrase = "3"; break;
               case 'J': phrase = "4"; break;
               case 'K': phrase = "4"; break;
               case 'L': phrase = "4"; break;
               case 'M': phrase = "5"; break;
               case 'N': phrase = "5"; break;
               case 'O': phrase = "5"; break;
               case 'P': phrase = "6"; break;
               case 'Q': phrase = "6"; break;
               case 'R': phrase = "6"; break;
               case 'S': phrase = "7"; break;
               case 'T': phrase = "7"; break;
               case 'U': phrase = "7"; break;
               case 'V': phrase = "8"; break;
               case 'W': phrase = "8"; break;
               case 'X': phrase = "8"; break;
               case 'Y': phrase = "9"; break;
               case 'Z': phrase = "9"; break;


           }
           switch (dial[8])
           {
               case 'A': phrase = "1"; break;
               case 'B': phrase = "1"; break;
               case 'C': phrase = "1"; break;
               case 'D': phrase = "2"; break;
               case 'E': phrase = "2"; break;
               case 'F': phrase = "2"; break;
               case 'G': phrase = "3"; break;
               case 'H': phrase = "3"; break;
               case 'I': phrase = "3"; break;
               case 'J': phrase = "4"; break;
               case 'K': phrase = "4"; break;
               case 'L': phrase = "4"; break;
               case 'M': phrase = "5"; break;
               case 'N': phrase = "5"; break;
               case 'O': phrase = "5"; break;
               case 'P': phrase = "6"; break;
               case 'Q': phrase = "6"; break;
               case 'R': phrase = "6"; break;
               case 'S': phrase = "7"; break;
               case 'T': phrase = "7"; break;
               case 'U': phrase = "7"; break;
               case 'V': phrase = "8"; break;
               case 'W': phrase = "8"; break;
               case 'X': phrase = "8"; break;
               case 'Y': phrase = "9"; break;
               case 'Z': phrase = "9"; break;


           }
           switch (dial[9])
           {
               case 'A': phrase = "1"; break;
               case 'B': phrase = "1"; break;
               case 'C': phrase = "1"; break;
               case 'D': phrase = "2"; break;
               case 'E': phrase = "2"; break;
               case 'F': phrase = "2"; break;
               case 'G': phrase = "3"; break;
               case 'H': phrase = "3"; break;
               case 'I': phrase = "3"; break;
               case 'J': phrase = "4"; break;
               case 'K': phrase = "4"; break;
               case 'L': phrase = "4"; break;
               case 'M': phrase = "5"; break;
               case 'N': phrase = "5"; break;
               case 'O': phrase = "5"; break;
               case 'P': phrase = "6"; break;
               case 'Q': phrase = "6"; break;
               case 'R': phrase = "6"; break;
               case 'S': phrase = "7"; break;
               case 'T': phrase = "7"; break;
               case 'U': phrase = "7"; break;
               case 'V': phrase = "8"; break;
               case 'W': phrase = "8"; break;
               case 'X': phrase = "8"; break;
               case 'Y': phrase = "9"; break;
               case 'Z': phrase = "9"; break;


           }*/
        //Console.WriteLine(dial);
    }
}
