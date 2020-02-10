/* Saahil Rasheed
 * U85555983
 * ISM 6225 Distributed Information Systems
 * Assignment 1
*/
using System;
using System.Collections.Generic;

namespace Assignment1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int n = 5;
            Console.Write("The pattern is: ");
            PrintPattern(n);

            Console.WriteLine();

            int n2 = 6;
            Console.Write("The series is: ");
            PrintSeries(n2);

            Console.WriteLine();

            string s = "09:15:35PM";
            string t = UsfTime(s);
            Console.WriteLine("The time on planet USF is " + t);

            Console.WriteLine();

            
            UsfNumbers(110,11);

            Console.WriteLine();

            Console.WriteLine("The palindrome words followed by their index locations in the arrays are: ");
            string[] words = new string[] { "abcd", "dcba", "lls", "s", "sssll" };
            PalindromePairs(words);

            Console.WriteLine();

            Stones(7);

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
                Console.WriteLine();
            }
            catch
            {
                Console.WriteLine("Exception Occured while computing PrintSeries");
            }
        }

        



        public static string UsfTime(string s)
        {
            string usf = "";
            try
            {
                //Splitting the input string taking colon/: as the separator
                String[] strlist = s.Split(":");
                int totalSeconds = 0;
                
                //Storing earth's hours, minutes and seconds into h, m and sec.
                int h = int.Parse(strlist[0]);
                int m = int.Parse(strlist[1]);
                String last = strlist[strlist.Length - 1];
                int sec = int.Parse(strlist[2].Substring(0, 2));

                if (strlist[2].Substring(2) == "PM" && h != 0)
                    totalSeconds = (h * 60 * 60 + (12 * 60 * 60)) + (m * 60) + sec;

                if (h == 12)
                    totalSeconds = (12 * 60 * 60) + (m * 60) + sec;


                if (strlist[2].Substring(2) == "AM" && h != 0)
                    totalSeconds = (h * 60 * 60) + (m * 60) + sec;
                //if (x < 12)

                double u = (double)totalSeconds / 2700;
                double s1 = u - (int)u;
                double s2 = s1 * 60;
                double f = s2 - (int)s2;
                double f1 = f * 45;
                usf = (int)u + ":" + (int)s2 + ":" + string.Format("{0:0}",f1);
            }
            catch
            {
                Console.WriteLine("Exception Occured while computing UsfTime");
            }                  
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

                Console.WriteLine("Exception occured while computing PalindromePairs()");
            }
        }


        private static void Stones(int n4)
        {
            if (n4 % 4 != 0)
            {
                Console.Write("Player 1 wins!");
                int size = 100;
                int[] arr = new int[size];

                Console.WriteLine(" ");
                printCompositions(arr, n4, 0);
            }
            else
                Console.Write("Player 2 wins.");
            
        }

        //to print the total number of ways can P1 win. I decided to use print permutation/combinations of our input n4.
        static void printCompositions(int[] arr, int n, int i)
        {
            int max = 3;
            if (n == 0)
            {
                printArray(arr, i);
            }
            else if (n > 0)
            {
                for (int k = 1; k <= max; k++)
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
    }
}
