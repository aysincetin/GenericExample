using System;

namespace GenericExample
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDirectory<string, string> letterASCII = new MyDirectory<string, string>();
            letterASCII.Add("065", "A");
            letterASCII.Add("066", "B");
            letterASCII.Add("067", "C");
            letterASCII.Add("097", "a");
            letterASCII.Add("098", "b");
            letterASCII.Add("099", "c");

            letterASCII.ListLetterASCII();
            Console.WriteLine( letterASCII.Count);
        }
    }

   

}
