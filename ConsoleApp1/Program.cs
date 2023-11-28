using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string code = "мышь";
            string str = "от улыбки каждый день светлей";
            char[] alphabet = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя".ToCharArray();

            int m = code.Length;

            string strWithoutSpace = str.Replace(" ", String.Empty);

            List<string> lengthList = new List<string>();
            Console.WriteLine(strWithoutSpace);

            SplitCode(strWithoutSpace, m, lengthList);

            string alph = "";

            string codeStr = "";

            int startPosition = 0;

            for (int i = 0; i < lengthList.Count; i++)
            {
                for (int j = 0; j < lengthList[i].Length; j++)
                {
                    for (int k = 0; k < alphabet.Length; k++)
                    {
                        if (alphabet[k] == code[j])
                        {
                            startPosition = k;
                            break;
                        }
                    }
                    alph = "";

                    for (int l = 0; l < 33; l++)
                    {
                        if (startPosition == 33)
                        {
                            startPosition = 0;
                        }
                        alph += alphabet[startPosition];
                        startPosition++;
                    }

                    int firstPosition = 0;


                    
                        for (int al = 0; al < alphabet.Length; al++)
                        {
                            if (lengthList[i][j] == alphabet[al])
                            {
                                firstPosition = al;
                                break;
                            }
                        }
                        codeStr += alph[firstPosition];
                    
                    
                }
            }
            List<string> lengthCodeList = new List<string>();
            SplitCode(codeStr, m, lengthCodeList);

            
       

            lengthList.ForEach(Console.WriteLine);
            Console.WriteLine(alph);
            lengthCodeList.ForEach(Console.WriteLine);
        }

        private static void SplitCode(string strWithoutSpace,int m,List<string> lengthList)
        {
            while (true)
            {
                string strFourSymbols = "";

                for (int j = 0; j < m; j++)
                {
                    if (j == strWithoutSpace.Length)
                    {
                        m = j;
                        break;
                    }
                    strFourSymbols += strWithoutSpace[j].ToString();
                }

                lengthList.Add(strFourSymbols);

                strWithoutSpace = strWithoutSpace.Remove(0, m);
                if (strWithoutSpace.Length <= 0)
                {
                    break;
                }
            }
        }
    }
}
