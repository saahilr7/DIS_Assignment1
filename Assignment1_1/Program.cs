


using System;
using System.Collections.Generic;

namespace Assignment1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            int n = 5;

            //PrintPattern(n);

            int n2 = 6;
            //PrintSeries(n2);

            string s = "09:15:35PM";
            string t = UsfTime(s);
            Console.WriteLine(t);


            //UsfNumbers(110, 11);

            




            //if (checkPalindromePair(vect) == true)
            //Console.WriteLine(vect);



            string[] words = new string[] { "abcd", "dcba", "lls", "s", "sssll" };
            //PalindromePairs(words);


            //Stones(7);

        }

        private static void PrintPattern(int n)
        {

            int length = n;
            if (length != 0)
            {
                for(int i = length; i > 0; i--)
                {
                    Console.Write(i);
                }
                Console.Write("\n");
                n--;
                PrintPattern(n);
            }
        }

        private static void PrintSeries(int n2)
        {
            try
            {
                int j = 1, k = 1;
                for (int i = 1; i <= n2; i++)
                {
                    j += 1;
                    k += j;
                    Console.Write(k + " ");
                }
            }
            catch
            {
                Console.WriteLine("Exception Occured while computing PrintSeries");
            }
        }

        



        public static string UsfTime(string s)
        {
             
                //Let us convert it into USF time
                //Splitting the string into hours minutes and seconds
                String[] strlist = s.Split(":");
                int totalSeconds = 0;
                string usf = "";
                //Parsing string into integer to denote x, y and z as the variables containing hours, minutes and seconds respectively
                int x = int.Parse(strlist[0]);
                int y = int.Parse(strlist[1]);
                String last = strlist[strlist.Length - 1];
                int z = int.Parse(strlist[2].Substring(0, 2));
                //int z = int.Parse(last.Substring(0,last.Length/2));
                //String amPm = int.Parse(strlist[2].Substring(2));
                //if the time is in PM we convert it into 24 hours format. i.e addition of 12 to x.
                //if (strlist[2].Substring(2) == "pm" && x != 0)
                
                if(strlist[2].Substring(2) == "PM" && x != 0)               
                totalSeconds = (x * 60 * 60 + (12 * 60 * 60)) + (y * 60) + z;

                if (x == 12)
                totalSeconds = (12 * 60 * 60) + (y * 60) + z ;
            
                
                if(strlist[2].Substring(2) == "AM" && x != 0)
                totalSeconds = (x * 60 * 60 + (12 * 60 * 60)) + (y * 60) + z;
                //if (x < 12)

                double u = (double)totalSeconds / 2700;
                double s1 = u - (int)u;
                double s2 = s1 * 60;
                double f = s2 - (int)s2;
                double f1 = f * 45;
                usf = (int)u + ":" + (int)s2 + ":" + (int)f1;


                
                return usf;

        }
        


        static void UsfNumbers(int n3, int k)
        {
            try
            {
                int i, j = 1;

                for (i = 1; i <= n3; i++)
                {
                    if (i % 3 == 0 & i % 5 == 0)                   
                        Console.Write("US");
                    
                    else if (i % 5 == 0 & i % 7 == 0)                   
                        Console.Write("SF");
                  
                    else if (i % 3 == 0 & i % 7 == 0)                    
                        Console.Write("UF");    
                    
                    else if (i % 3 == 0)                   
                        Console.Write("U");  
                    
                    else if (i % 5 == 0)                   
                        Console.Write("S");
                    
                    else if (i % 7 == 0)                   
                        Console.Write("F");
                    
                    else if (i % 3 != 0 & i % 5 != 0 & i % 7 != 0)                   
                        Console.Write(i + " ");                  
                    j++;
                    if (j > k)
                    {
                        Console.WriteLine();
                        j = 1;
                    }
                }
            }
            catch
            {
                Console.WriteLine("Exception occured while computing UsfNumbers()");
            }
        }



        static bool isPalindrome(String str)
        {
            int len = str.Length;

            // compare each character from starting 
            // with its corresponding character from last 
            for (int i = 0; i < len / 2; i++)
                if (str[i] != str[len - i - 1])
                    return false;

            
            return true;
            
        }

        // 
        

//Function to check if a palindrome pair exists
        public static void PalindromePairs(string[] words)
        {
            try
            {
                // Consider each pair one by one 
                for (int i = 0; i < words.Length - 1; i++)
                {
                    for (int j = 0; j < words.Length; j++)
                    {
                        String check_str = "";

                        // concatenate both strings 
                        check_str = check_str + words[i] + words[j];

                        // check if the concatenated string is 
                        // palindrome 
                        if (isPalindrome(check_str) == true)
                        {
                            //int ind1 = Array.IndexOf(words, isPalindrome(check_str));
                            //Console.Write(words[i] + " " + words[j]);
                            //Console.Write(ind1);
                        }
                        check_str = words[j] + words[i];

                        // check if the concatenated string is 
                        // palindrome 
                        if (isPalindrome(check_str))
                        {
                            Console.WriteLine(check_str);
                            Console.WriteLine(i + " " + j);
                        }
                    }
                }
                //Console.Write("It is not a palindrome!");
            }
            catch
            {

                Console.WriteLine("Exception occured while computing     PalindromePairs()");
            }
        }


        private static void Stones(int n4)
        {

            //1 means winning the game
            //0 means losing the game


            //int[] pos = new int[200];
            //findStates(pos);

            //if (pos[n4] == 1)
            //    Console.Write("p1 wins");
            //else
            //    Console.Write("p2 wins"); ;
            if (n4 % 4 != 0)
            {
                Console.Write("P1 wins");
                int size = 100;
                int[] arr = new int[size];

                Console.WriteLine(" ");
                printCompositions(arr, n4, 0);
            }
            else
                Console.Write("P2 wins");
            
        }

        static void printCompositions(int[] arr, int n, int i)
        {
            int MAX_POINT = 3;
            if (n == 0)
            {
                printArray(arr, i);
            }
            else if (n > 0)
            {
                for (int k = 1; k <= MAX_POINT; k++)
                {
                    arr[i] = k;
                    printCompositions(arr, n - k, i + 1);
                }
            }
        }

        // Utility function to print array arr[] 
        static void printArray(int[] arr, int m)
        {
            Console.Write("[");
            for (int i = 0; i < m; i++)
            {
                
                Console.Write(arr[i] + ",");
                
            }
            Console.Write("]");
            Console.WriteLine();
        }







        static void findStates(int[] position)
        {
            position[1] = 1;
            position[2] = 1;
            position[3] = 1;
            position[4] = 0;
            position[5] = 1;
            position[6] = 1;
            position[7] = 1;
            position[8] = 0;
            for (int i = 9; i < 100; i++)
            {
                if (position[i - 1] != 1 || position[i - 2] != 1 || position[i - 3] != 1)
                {
                    position[i] = 1;
                    //Console.Write(position[i]);
                }
                else
                {
                    position[i] = 0;
                    //Console.Write(position[i]);
                }
            }
            
        }

        

    }
}
