using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeAlphabet
{
    public class MainCode
    {
        public string Code(string code, string str)
        {
            char[] alph = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя".ToCharArray();

            int m = code.Length;

            string strWithoutSpace = str.Trim();

            List <string> lengthList = new List<string>();

            if (str.Length <= 0)
            {
                return "Неправильно";
            }

            for (int i = 0; i < strWithoutSpace.Length; i++)
            {
                string strFourSymbols = "";

                for (int j = strFourSymbols.Length; j < m; j++)
                {
                    strFourSymbols += strWithoutSpace[j].ToString();
                }
                lengthList.Add(strFourSymbols);
            }
            
        }
    }
}
