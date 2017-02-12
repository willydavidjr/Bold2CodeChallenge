using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompressBold2CodeChallenge
{
    public class CompressAlgo : ICompression<string>
    {
        public byte[] Compress(string source)
        {
            UTF32Encoding utf = new UTF32Encoding();
            int bit = 6;
            int length = Convert.ToInt32(source.Length);
            float tmpRet1 = 0, tmpRet2 = 0;
            tmpRet1 = 3.0f;
            tmpRet2 = 4.0f;
           
            byte[] compressed = new byte[(int)(tmpRet1 * Math.Ceiling(length / tmpRet2))];

            char[] str = source.ToCharArray();
            int chaVal = 0;
            string temp;
            string strBinary = "";
            for (int i = 0; i < length; i++)
            {
                temp = Convert.ToString(toValue((str[i])), 2);
                while (temp.Length % bit != 0)
                {
                    temp = "0" + temp;
                }
                strBinary = strBinary + temp;
            }

            while (strBinary.Length % 8 != 0)
            {
                strBinary = strBinary + "0";
            }

            int xx = 0;
            xx = Convert.ToInt32(strBinary.Substring(8, 8), 2);

            int tempInt = 0;
            for (int i = 0; i < strBinary.Length; i = i + 8)
            {
                tempInt = Convert.ToInt32(strBinary.Substring(i, 8), 2);
                compressed[i / 8] = Convert.ToByte(strBinary.Substring(i, 8), 2);
            }
            return compressed;
        }

        public string Decompress(byte[] compressed)
        {
            int bit = 6;
            string strTemp = "";
            string strBinary = "";
            string strFinal = "";
            int tempInt = 0;
            int intTemp = 0;
            for (int i = 0; i < compressed.Length; i++)
            {
                if (compressed[i] < 0)
                {
                    intTemp = (int)compressed[i] + 256;
                }
                else
                    intTemp = (int)compressed[i];
                strTemp = Convert.ToString(intTemp, 2);

                while (strTemp.Length % 8 != 0)
                {
                    strTemp = "0" + strTemp;
                }
                strBinary = strBinary + strTemp;
            }
            for (int i = 0; i < strBinary.Length; i = i + bit)
            {
                tempInt = Convert.ToInt32(strBinary.Substring(i, bit), 2);
                strFinal = strFinal + toChar(tempInt);
            }
            return strFinal.Trim();
        }

        public int toValue(char ch)
        {
            int chaVal = 0;
            switch (ch)
            {
                case ' ': chaVal = 0; break;
                case 'a': chaVal = 1; break;
                case 'b': chaVal = 2; break;
                case 'c': chaVal = 3; break;
                case 'd': chaVal = 4; break;
                case 'e': chaVal = 5; break;
                case 'f': chaVal = 6; break;
                case 'g': chaVal = 7; break;
                case 'h': chaVal = 8; break;
                case 'i': chaVal = 9; break;
                case 'j': chaVal = 10; break;
                case 'k': chaVal = 11; break;
                case 'l': chaVal = 12; break;
                case 'm': chaVal = 13; break;
                case 'n': chaVal = 14; break;
                case 'o': chaVal = 15; break;
                case 'p': chaVal = 16; break;
                case 'q': chaVal = 17; break;
                case 'r': chaVal = 18; break;
                case 's': chaVal = 19; break;
                case 't': chaVal = 20; break;
                case 'u': chaVal = 21; break;
                case 'v': chaVal = 22; break;
                case 'w': chaVal = 23; break;
                case 'x': chaVal = 24; break;
                case 'y': chaVal = 25; break;
                case 'z': chaVal = 26; break;
                case '.': chaVal = 27; break;
                case '\'': chaVal = 28; break;
                case ',': chaVal = 29; break;
                case ':': chaVal = 30; break;
                case 'Z': chaVal = 31; break;
                case 'A': chaVal = 32; break;
                case 'B': chaVal = 33; break;
                case 'C': chaVal = 34; break;
                case 'D': chaVal = 35; break;
                case 'E': chaVal = 36; break;
                case 'F': chaVal = 37; break;
                case 'G': chaVal = 38; break;
                case 'H': chaVal = 39; break;
                case 'I': chaVal = 40; break;
                case 'J': chaVal = 41; break;
                case 'K': chaVal = 42; break;
                case 'L': chaVal = 43; break;
                case 'M': chaVal = 44; break;
                case 'N': chaVal = 45; break;
                case 'O': chaVal = 46; break;
                case 'P': chaVal = 47; break;
                case 'Q': chaVal = 48; break;
                case 'R': chaVal = 49; break;
                case 'S': chaVal = 50; break;
                case 'T': chaVal = 51; break;
                case 'U': chaVal = 52; break;
                case 'V': chaVal = 53; break;
                case 'W': chaVal = 54; break;
                case '0': chaVal = 55; break;
                case '1': chaVal = 56; break;
                case '3': chaVal = 57; break;
                case '4': chaVal = 58; break;
                case '5': chaVal = 59; break;
                case '6': chaVal = 60; break;
                case '7': chaVal = 61; break;
                case '8': chaVal = 62; break;
                case '9': chaVal = 63; break;
                default: chaVal = 0; break;
            }
            return chaVal;
        }

        public char toChar(int val)
        {
            char ch = ' ';
            switch (val)
            {
                case 0: ch = ' '; break;
                case 1: ch = 'a'; break;
                case 2: ch = 'b'; break;
                case 3: ch = 'c'; break;
                case 4: ch = 'd'; break;
                case 5: ch = 'e'; break;
                case 6: ch = 'f'; break;
                case 7: ch = 'g'; break;
                case 8: ch = 'h'; break;
                case 9: ch = 'i'; break;
                case 10: ch = 'j'; break;
                case 11: ch = 'k'; break;
                case 12: ch = 'l'; break;
                case 13: ch = 'm'; break;
                case 14: ch = 'n'; break;
                case 15: ch = 'o'; break;
                case 16: ch = 'p'; break;
                case 17: ch = 'q'; break;
                case 18: ch = 'r'; break;
                case 19: ch = 's'; break;
                case 20: ch = 't'; break;
                case 21: ch = 'u'; break;
                case 22: ch = 'v'; break;
                case 23: ch = 'w'; break;
                case 24: ch = 'x'; break;
                case 25: ch = 'y'; break;
                case 26: ch = 'z'; break;
                case 27: ch = '.'; break;
                case 28: ch = '\''; break;
                case 29: ch = ','; break;
                case 30: ch = ':'; break;
                case 31: ch = 'Z'; break;
                case 32: ch = 'A'; break;
                case 33: ch = 'B'; break;
                case 34: ch = 'C'; break;
                case 35: ch = 'D'; break;
                case 36: ch = 'E'; break;
                case 37: ch = 'F'; break;
                case 38: ch = 'G'; break;
                case 39: ch = 'H'; break;
                case 40: ch = 'I'; break;
                case 41: ch = 'J'; break;
                case 42: ch = 'K'; break;
                case 43: ch = 'L'; break;
                case 44: ch = 'M'; break;
                case 45: ch = 'N'; break;
                case 46: ch = 'O'; break;
                case 47: ch = 'P'; break;
                case 48: ch = 'Q'; break;
                case 49: ch = 'R'; break;
                case 50: ch = 'S'; break;
                case 51: ch = 'T'; break;
                case 52: ch = 'U'; break;
                case 53: ch = 'V'; break;
                case 54: ch = 'W'; break;
                case 55: ch = '0'; break;
                case 56: ch = '1'; break;
                case 57: ch = '3'; break;
                case 58: ch = '4'; break;
                case 59: ch = '5'; break;
                case 60: ch = '6'; break;
                case 61: ch = '7'; break;
                case 62: ch = '8'; break;
                case 63: ch = '9'; break;
                default: ch = ' '; break;
            }
            return ch;
        }
    }
}
