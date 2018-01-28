using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    class Chapter1
    {
        public char[] URLify(char[] url, int length)
        {
         try {
                int count = 0;
                for(int i =0; i<length;i++)
                {
                    if(url[i] == ' ')
                    {
                        count++;
                    }
                }
                int size = length + count * 2;
                char[] urltemp = new char[size];
                int j = 0;

            for (int i = 0; i < length; i++)
            {
                    if (url[i] == ' ')
                    {
                        //for (int j = length; j > i; j--)
                        //{
                        //    urltemp[j + 2] = url[j];
                        //}
                        urltemp[j] = '%';
                        urltemp[j + 1] = '2';
                        urltemp[j + 2] = '0';
                        j = j + 3;
                    }
                    else
                    {
                        urltemp[j] = url[i];
                        j++;
                    }
                }
            return urltemp;
        }  
            catch(IndexOutOfRangeException iex)
            {
                System.Console.WriteLine("Character Array Index is Out of Range");
                System.Console.WriteLine(iex.Message);
                System.Console.WriteLine(iex.StackTrace);
                return new char[' '];
            }
        }

        public void PalindromePermutation(string word)
        {
            string prefix = string.Empty;
            PalindromePermutation(prefix, word);
        }

        private void PalindromePermutation(string prefix, string str)
        {
            int i = 0;
            if (str == ""|| str==null)
            {
                if (CheckPalindrome(prefix))
                {
                    System.Console.WriteLine("Generated string {0} is a palindrome", prefix);
                }
                else
                {
                    //System.Console.WriteLine("Generated string {0} is NOT a palindrome", prefix);
                }
            }
            else
            { 
            for( i =0; i<str.Length;i++)
                {                    
                   string remaining = str.Substring(0, i) + str.Substring(i+1);               
                    PalindromePermutation(prefix + str.Substring(i, 1), remaining);
            }
            }
        }
       

        public bool CheckPalindrome(string word)
        {
            try { 
            int middle = (word.Length / 2);
            int j = word.Length - 1;
            int i = 0;
            char[] wordCharArray = word.ToCharArray();
            while(i!=j)
            {
                if (wordCharArray[i] != wordCharArray[j])
                {
                    return false;
                }
                    i++;
                    j--;
            }
            if (i == middle)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
            catch(IndexOutOfRangeException iex)
            {
                System.Console.WriteLine("Index reached out of bound");
                System.Console.WriteLine(iex.Message);
                System.Console.WriteLine(iex.StackTrace);
                return false;
            }
        }

        public bool OneAway(char[] str1, char[] str2)
        {
            int lengthDiff = Math.Abs(str1.Length - str2.Length);
            bool result = false;
            if (lengthDiff > 1)
            {
                System.Console.WriteLine("Strings can not be one edit Away as their length differs by {0}",lengthDiff);
                result = false;
                return result;
            }
            else
            if(str1.Length > str2.Length)
            {
               result =  CheckForRemove(str1, str2);
                if(result)
                {
                    System.Console.WriteLine("String {0} and string {1} are 1 edit away",str1.ToString(), str2.ToString());
                }
                else
                {
                    System.Console.WriteLine("String {0} and string {1} are NOT 1 edit away",str1.ToString(),str2.ToString());
                }
                return result;
            }
           
            else
            {
                result = CheckForRemove(str1, str2);
                if (result)
                {
                    System.Console.WriteLine("String {0} and string {1} are 1 edit away", str1.ToString(), str2.ToString());
                }
                else
                {
                    System.Console.WriteLine("String {0} and string {1} are NOT 1 edit away",str1.ToString(), str2.ToString());
                }
                return result;
            }
        }

        private bool CheckForRemove(char[] str1, char[] str2)
        {
            try
            {
                int i = 0;
                int j = 0;
                int counter = 0;
                for(i=0;i<str1.Length;)
                {
                    if(str1[i]==str2[j])
                    {
                        i++;
                        j++;
                    }
                    else
                    {
                        i++;
                        counter++;
                    }
                    if(counter>1)
                    {
                        return false;
                    }
                }
                return true;
            }

            catch (IndexOutOfRangeException ex) {
                System.Console.WriteLine(ex.Message);
                System.Console.WriteLine(ex.StackTrace);
                return false;

            }

        }

        public string StringCompression(string str)
        {
            char[] strArray = str.ToCharArray();
            char[] compressedArray = new char[str.Length];

            try {
                int k = 0;


                string compressedString = "";
                for (int i =0;i<strArray.Length;)
                {
                    int j = 0;
                    int count = 1;
                    
                    Char.ToString();
                    for (j=i+1;j<strArray.Length;)
                    {
                        if (strArray[i]!= strArray[j])
                        {
                            break;
                        }
                        else
                        {
                            j++;
                            count++;
                        }
                    }
                    compressedString += strArray[i] + count;
                    i = j;
                }
                //compressedString = new string(compressedArray);
                return compressedString;
            }
            catch(IndexOutOfRangeException ex)
            {
                System.Console.WriteLine(ex.Message);
                System.Console.WriteLine(ex.StackTrace);
                return ex.Message;
            }
        }

    }
}
