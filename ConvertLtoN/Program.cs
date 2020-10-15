using System;

namespace ConvertLtoN
{
    class Program
    {

        static void Main(string[] args)
        {
            /* int parsePhrase(char phrase)

            {
                string dial = Utils.GetInput("Enter your phrase: ");

                if (phrase == 'A' || phrase == 'B' || phrase == 'C')
                {
                    return 1;
                }
            } */








            //char ch;
            // Console.WriteLine("Enter prhase: ");
            //ch = Convert.ToChar(Console.ReadLine());
            //       have it giving me the letter now i need it to read a string and just take the char to run as a num





            
            string strletter = Utils.GetInput("Enter phrase: ");
            char[] letter;
            strletter = strletter.ToLower();
            letter = strletter.ToCharArray();

            foreach (char ch in letter)
            {


                switch (ch)
                {
                    case 'a':
                    case 'b':
                    case 'c':
                        
                            Console.Write("2");
                            break;
                        
                    case 'd':
                    case 'e':
                    case 'f':
                        
                            Console.Write("3");
                            break;
                        
                    case 'g':
                    case 'h':
                    case 'i':
                        
                            Console.Write("4");
                            break;
                        
                    case 'j':
                    case 'k':
                    case 'l':
                        
                            Console.Write("5");
                            break;
                        
                    case 'm':
                    case 'n':
                    case 'o':
                        
                            Console.Write("6");
                            break;
                        
                    case 'p':
                    case 'q':
                    case 'r':
                    case 's':
                        
                            Console.Write("7");
                            break;
                        
                    case 't':
                    case 'u':
                    case 'v':

                        
                            Console.Write("8");
                            break;
                        
                    case 'w':
                    case 'x':
                    case 'y':
                    case 'z':
                        
                            Console.Write("9");
                            break;

                    default: Console.Write(ch); break;



                }

            }
                   
                
        }
    }
}    