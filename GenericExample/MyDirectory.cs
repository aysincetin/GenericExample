using System;
using System.Collections.Generic;
using System.Text;

namespace GenericExample
{
    class MyDirectory<T,K>
    {

        T[] codeArray;
        T[] tempCodeArray;

        K[] letterArray;
        K[] tempLetterArray;

        public MyDirectory()
        {
            codeArray = new T[0];
            letterArray = new K[0];
        }
        public void Add(T code, K letter)
        {
            tempCodeArray = codeArray;
            codeArray = new T[codeArray.Length + 1];

            tempLetterArray = letterArray;
            letterArray = new K[letterArray.Length + 1];

            for (int i = 0; i < tempCodeArray.Length; i++)
            {
                for (int j = 0; j < tempLetterArray.Length; j++)
                {

                    letterArray[j] = tempLetterArray[j];
                }
                codeArray[i] = tempCodeArray[i];
            }
            codeArray[codeArray.Length - 1] = code;
            letterArray[letterArray.Length - 1] = letter;
        }
        public int Count
        {
            get
            {
                Console.Write("\nThe code of ASCII letters added is equal to: ");
                return codeArray.Length;
            }

        }

        public void ListLetterASCII()
        {
            Console.WriteLine("---ASCII letters---");
            for (int i = 0; i < codeArray.Length; i++)
            {
                Console.WriteLine(codeArray[i] + " - " + letterArray[i]);
            }
        }
    }
}
