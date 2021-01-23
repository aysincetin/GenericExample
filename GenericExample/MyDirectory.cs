using System;
using System.Collections.Generic;
using System.Text;

namespace GenericExample
{
    class MyDirectory<T,K>
    {

        T[] numberArray;
        T[] tempNumberArray;

        K[] codeArray;
        K[] tempcodeArray;

        public MyDirectory()
        {
            numberArray = new T[0];
            codeArray = new K[0];
        }
        public void Add(T number, K code)
        {
            tempNumberArray = numberArray;
            numberArray = new T[numberArray.Length + 1];

            tempcodeArray = codeArray;
            codeArray = new K[codeArray.Length + 1];

            for (int i = 0; i < tempNumberArray.Length; i++)
            {
                for (int j = 0; j < tempcodeArray.Length; j++)
                {

                    codeArray[j] = tempcodeArray[j];
                }
                numberArray[i] = tempNumberArray[i];
            }
            numberArray[numberArray.Length - 1] = number;
            codeArray[codeArray.Length - 1] = code;
        }
        public int Count
        {
            get
            {
                Console.Write("\nThe number of ASCII codes added is equal to: ");
                return numberArray.Length;
            }

        }

        public void ListLetterASCII()
        {
            Console.WriteLine("---ASCII Codes---");
            for (int i = 0; i < numberArray.Length; i++)
            {
                Console.WriteLine(numberArray[i] + " - " + codeArray[i]);
            }
        }
    }
}
