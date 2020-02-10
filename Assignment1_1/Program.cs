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

            //string s = "09:15:35PM";
            //string t = UsfTime(s);
            //Console.WriteLine(t);

            


            List<String> vect = new List<String>(){"bat", "cat", "tab"};




            //if (checkPalindromePair(vect) == true)
            //Console.WriteLine(vect);

            //int numb=4;
            //int[] pos = new int[200];
            //findStates(pos);

            //if (pos[numb] == 1)
            //    Console.Write("p1 wins");
            //else
            //    Console.Write("p2 wins"); ;

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
            }
            catch
            {
                Console.WriteLine("Exception Occured while computing PrintSeries");
            }
        }

        public static void PalindromePairs(string[] words)
        {
            try
            {
                // Write your code here
            }
            catch
            {

                Console.WriteLine("Exception occured while computing     PalindromePairs()");
            }
        }



        public static string UsfTime(string s)
        {
             
                //Let us convert it into USF time
                //Splitting the string into hours minutes and seconds
                String[] strlist = s.Split(":");
                //Parsing string into integer to denote x, y and z as the variables containing hours, minutes and seconds respectively
                int x = int.Parse(strlist[0]);
                int y = int.Parse(strlist[1]);
                String last = strlist[strlist.Length - 1];
                //int z = int.Parse(strlist[2].Substring(0, 2));
                int z = int.Parse(last.Substring(0,last.Length/2));
                //String amPm = int.Parse(strlist[2].Substring(2));
                //if the time is in PM we convert it into 24 hours format. i.e addition of 12 to x.
                //if (strlist[2].Substring(2) == "pm" && x != 0)
                String usf ="";
                if(strlist[2].Substring(2) == "PM" && x != 0)
                {
                        usf = String.Format("%02d:%02d:%02d", (x + 12), y, z);

                        if (x == 12)
                            usf = String.Format("%02d:%02d:%02d", x , y, z);
                }
                //if (strlist[2].Substring(2) == "am" && x != 0)
                if(strlist[2].Substring(2) == "AM" && x != 0)
                {
                        usf = String.Format("%02d:%02d:%02d", (12-x), y, z);
                        if (x < 12)
                            usf = String.Format("%02d:%02d:%02d", x, y, z);
                }
                return usf;

        }
                // procedure to convert earth time to usf time
                // converting time to total number of seconds

                
                //if()
                
                //String msg = "The time at USF is   " + w.ToString() + ":" + q.ToString() + ":" + r.ToString() + "";
                //Console.WriteLine(msg);

                //return msg;


            
        


        static Boolean isPalindrome(String str)
        {
            int len = str.Length;

            // compare each character from starting 
            // with its corresponding character from last 
            for (int i = 0; i < len / 2; i++)
                if (str[i] != str[len - i - 1])
                    return false;

            return true;
        }

        // Function to check if a palindrome pair exists 
        static Boolean checkPalindromePair(List<String> vect)
        {
            // Consider each pair one by one 
            for (int i = 0; i < vect.Count - 1; i++)
            {
                for (int j = i + 1; j < vect.Count; j++)
                {
                    String check_str = "";

                    // concatenate both strings 
                    check_str = check_str + vect[i] + vect[j];

                    // check if the concatenated string is 
                    // palindrome 
                    if (isPalindrome(check_str))
                        Console.Write(vect[i] + " " + vect[j]);

                    check_str = vect[j] + vect[j];

                    // check if the concatenated string is 
                    // palindrome 
                    if (isPalindrome(check_str))
                        return true;
                }
            }
            return false;
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

            }
            else
                Console.Write("P2 wins");
            
        }



        static void heapPermutation(int[] a, int size, int n)
        {
            // if size becomes 1 then prints the obtained 
            // permutation 
            if (size == 1)
                printArr(a, n);

            for (int i = 0; i < size; i++)
            {
                heapPermutation(a, size - 1, n);

                // if size is odd, swap first and last 
                // element 
                if (size % 2 == 1)
                {
                    int temp = a[0];
                    a[0] = a[size - 1];
                    a[size - 1] = temp;
                }

                // If size is even, swap ith and last 
                // element 
                else
                {
                    int temp = a[i];
                    a[i] = a[size - 1];
                    a[size - 1] = temp;
                }
            }
        }

        static void printArr(int[] a, int n)
        {
            for (int i = 0; i < n; i++)
                Console.Write(a[i] + " ");
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
