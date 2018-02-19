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
                    compressedString += strArray[i] +  count.ToString().Substring(0,1);
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

        /*Below algorithm is not giving correct results. This needs to be reviewed against KMP algorithm*/
        public bool isSubString(char[] src, char[] target)
        {
            try
            {

                int j = 0;
                int unique = 1;
                int i = 0;
                for (i = 0; i < (src.Length - 1); i++)
                {
                    if (src[i] == src[i + 1])
                    {
                        break;
                    }
                    unique++;
                }

                int k = 0;
                int start = 0;
                bool result = false;
                bool flag = true;
                unique = 1;

                for (i = 0; i < target.Length;)
                {
                    //if (target.Length - i < src.Length)
                    //{
                    //    break;
                    //}
                   
                    if (src[j] != target[i])
                    {
                        //k = i;
                        if (target.Length-(start+unique) >= src.Length)
                        { 
                        //if (target[i] == src[j - (unique-1)]
                        //if(target[i]==target[start+unique+j])
                        //{
                            start = start + (unique);
                            i = start;
                            j = 0;
                            unique = 1;
                        //}
                            //else
                            //{
                            //    if(target.Length-i>=src.Length)
                            //    { 
                            //    start = i;
                            //    j = 0;
                            //    unique = 1;
                            //    }
                            //    else
                            //    {
                            //        result = false;
                            //        break;
                            //    }
                            //}
                        }
                        else
                        {
                            result = false;
                            break;
                        }
                    }
                    else
                    {
                        if (j < src.Length - 1 && src[j] != src[j + 1] && flag)
                        {
                            unique++;
                        }
                        else
                        {
                            flag = false;
                        }
                        i++;
                        j++;                       
                    }
                    if (j == src.Length)
                    {
                        result = true;
                        break;
                    }
                   

                }
                return result;
            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex.Message);
                System.Console.WriteLine(ex.StackTrace);
                return false;
            }
        }

        public void RotateMatrix(float[,] before)
        {
            try
            {
                int length = Convert.ToInt32(Math.Sqrt(before.Length));

                float[,] after = new float[length, length];
                for (int column = 0; column < length; column++)
                {
                    for (int row = 0; row < length; row++)
                    {
                        after[column, row] = before[row, 2 - column];
                    }
                }
                System.Console.WriteLine("Matrix after rotation is as below");
                for (int row = 0; row < length; row++)
                {
                    for (int column = 0; column < length; column++)
                    {
                        System.Console.Write("{0},", after[row, column]);
                    }
                    System.Console.WriteLine("");
                }
            }
            catch (IndexOutOfRangeException ior)
            {
                System.Console.WriteLine(ior.Message);
                System.Console.WriteLine(ior.StackTrace);
            }
        }

        public void RotateMatrixApproach2(float[,] before)
        {
            try { 
            int n =  Convert.ToInt32(Math.Sqrt(before.Length));           
            for (int layer = 0; layer < n/2; layer++)
            {
                int first = layer;
                int last = n - 1- layer;
                for (int j = first; j < last; j++)
                {
                    int offset = j - first;
                    float temp = before[first,j];
                    before[first, j] = before[last-offset, first];
                    before[last-offset,first] = before[last, last-offset];
                    before[last, last-offset] = before[j, last];
                    before[j,last] = temp;
                }
            }
                System.Console.WriteLine("Matrix after rotation is as below");
                for (int row = 0; row < n; row++)
                {
                    for (int column = 0; column < n; column++)
                    {
                        System.Console.Write("{0},", before[row, column]);
                    }
                    System.Console.WriteLine("");
                }
            }
            catch (IndexOutOfRangeException ior)
            {
                System.Console.WriteLine(ior.Message);
                System.Console.WriteLine(ior.StackTrace);
            }
        }
    }
}
