using System;
using System.Collections.Generic;
using System.Linq;
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
        static void Main(string[] args)

        {
            string decryptString = decrypt("Lfi ulixvh ziv kivkzirmt uli z nzqli zggzxp lm gsv Arlmrhg vmvnb.Gsv ilxpvg fmrgh ziv ivzwb zmw dzrgrmt uli gsv hrtmzo. Ylnyh szev yvvm kozxvw mvzi pvb olxzgrlmh. Mfpsyz urtsgvih ziv hgzmwrmt yb uli tilfmw rmurogizgrlm. Gsv zggzxp droo yv hfwwvm zmw hgilmt -- gsvb dlm’g hvv rg xlnrmt. Dv nfhg hgzb srwwvm zmw pvvk gsv kozm hvxivg fmgro gsv ozhg nlnvmg. Erxglib rh mvzi. Hgzb ivzwb.");
        }
    }
}
