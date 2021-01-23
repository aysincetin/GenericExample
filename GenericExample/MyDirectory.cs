using System;
using System.Collections.Generic;
using System.Text;

namespace GenericExample
{
    class MyDirectory<T,K>
    {

        T[] numberArray;
        T[] tempNumberArray;

        K[] nameArray;
        K[] tempNameArray;

        public MyDirectory()
        {
            numberArray = new T[0];
            nameArray = new K[0];
        }
        public void Add(T number, K name)
        {
            tempNumberArray = numberArray;
            numberArray = new T[numberArray.Length + 1];

            tempNameArray = nameArray;
            nameArray = new K[nameArray.Length + 1];

            for (int i = 0; i < tempNumberArray.Length; i++)
            {
                for (int j = 0; j < tempNameArray.Length; j++)
                {

                    nameArray[j] = tempNameArray[j];
                }
                numberArray[i] = tempNumberArray[i];
            }
            numberArray[numberArray.Length - 1] = number;
            nameArray[nameArray.Length - 1] = name;
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
                Console.WriteLine(numberArray[i] + " - " + nameArray[i]);
            }
        }
    }
}
