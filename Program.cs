using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace AT_BASH_project
{
    internal class Program
    {
        static string decrypt(string encryptedString)
        {
            string lowerAbc = "abcdefghijklmnopqrstuvwxyz";
            string upperAbc = lowerAbc.ToUpper();
            string decryptString = "";
            foreach (char chr in encryptedString)
            {
                if (!char.IsLetter(chr))
                {
                    decryptString += chr;
                }
                else
                {
                    if (char.IsLower(chr))
                    {
                        int index = lowerAbc.IndexOf(chr);
                        decryptString += lowerAbc[lowerAbc.Length - 1 - index];
                    }
                    else
                    {
                        int index = upperAbc.IndexOf(chr);
                        decryptString += upperAbc[upperAbc.Length - 1 - index];
                    }
                }
            }
            return decryptString;
        }


        static (string, int) SumOfWord(string str)
        {
            string[] strings = new string[] { "bomb", "nukhba", "fighter", "rocket", "secret", "bombs", "nukhbas", "fighters", "rockets", "secrets" };
            int count = 0;
            string[] words = str.Split();
            string result = "";
            foreach (string word in words)
            {
                string wordLower = word.ToLower();
                if (strings.Contains(wordLower))
                {
                    count++;
                    if (!result.Contains(wordLower))
                    {
                        result += wordLower + " ";
                    }
                }
            }

            return (result, count);
        }

        static string showFinalMassage((string words, int sumOfDangerousWord) massage)
        {
            string woringLevel;
            string words = massage.words;
            int sumOfDangerousWord = massage.sumOfDangerousWord;
            if (sumOfDangerousWord < 6)
            {
                woringLevel = "WARNING";
            }
            else if (sumOfDangerousWord < 11)
            {
                woringLevel = "DANGER!";
            }
            else
            {
                woringLevel = "ULTRA ALERT!";
            }
            return $"{words} {woringLevel}";
        }
        static void Main(string[] args)
        {
            string decryptString = decrypt("Lfi ulixvh ziv kivkzirmt uli z nzqli zggzxp lm gsv Arlmrhg vmvnb.Gsv ilxpvg fmrgh ziv ivzwb zmw dzrgrmt uli gsv hrtmzo. Ylnyh szev yvvm kozxvw mvzi pvb olxzgrlmh. Mfpsyz urtsgvih ziv hgzmwrmt yb uli tilfmw rmurogizgrlm. Gsv zggzxp droo yv hfwwvm zmw hgilmt -- gsvb dlm’g hvv rg xlnrmt. Dv nfhg hgzb srwwvm zmw pvvk gsv kozm hvxivg fmgro gsv ozhg nlnvmg. Erxglib rh mvzi. Hgzb ivzwb.");
            (string words, int sumOfDangerousWord) massage = SumOfWord(decryptString);
            Console.WriteLine(showFinalMassage(massage));
            Console.WriteLine(decryptString);
        }
    }
}
