using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class CharacterReplacement
    {
        public static string[] Substitute(string[] inputStr)
        {
            if (inputStr == null || inputStr.Contains(null))
                throw new ArgumentNullException("String empty");
            StringBuilder[] outputBildStr=new StringBuilder[inputStr.Length];
            for (int i = 0; i < inputStr.Length; ++i)
            {
                outputBildStr[i] = new StringBuilder(inputStr[i]);
            }
            int countSymbl = 0;
            for (int i = 0; i < inputStr.Length; ++i)
            {
                countSymbl+= inputStr[i].Count(x => x == '#');
            }
            for (int i = 0,count =0; count < countSymbl/2; ++i)
            {
                for (int j = 0; j < inputStr[i].Length; ++j)
                {
                    if (outputBildStr[i][j] == '#')
                    {
                        outputBildStr[i][j] = '<';
                        count++;
                    }
                }
            }
            for (int i = inputStr.Length - 1, count = 0; count < countSymbl / 2; --i)
            {
                for (int j = inputStr[i].Length-1; j >=0; --j)
                {
                    if (outputBildStr[i][j] == '#')
                    {
                        outputBildStr[i][j] = '>';
                        count++;
                    }
                }
            }
            string[] outputStr = new string[inputStr.Length];
            for (int i = 0; i < inputStr.Length; ++i)
            {
                outputStr[i] = outputBildStr[i].ToString();
            }
            return outputStr;
        }
        public static string NameFile(string puthFile)
        {
            if (string.IsNullOrEmpty(puthFile) || string.IsNullOrWhiteSpace(puthFile))
                throw new ArgumentException("string is wrong.");
            int start_file=puthFile.LastIndexOf('\\')+1;
            int end_file = puthFile.IndexOf('.');
            string output= puthFile.Substring(start_file, end_file - start_file);
            return output;
        }

        public static string NameRootFolder(string puthFile)
        {
            if (string.IsNullOrEmpty(puthFile) || string.IsNullOrWhiteSpace(puthFile))
                throw new ArgumentException("string is wrong.");
            int end_RootFolder = puthFile.IndexOf('\\');
            string output = puthFile.Substring(0, end_RootFolder);
            return output;
        }

    }
}
