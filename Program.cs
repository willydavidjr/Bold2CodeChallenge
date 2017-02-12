using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompressBold2CodeChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            UTF8Encoding utf8 = new UTF8Encoding();
            string sourceString = "The main cast of TV's Silicon Valley: Thomas Middleditch, T.J Miller, Josh Brener, Martin Starr, Kumail Nanjiani, Zach Woods";

            //TODO: Replace DummyAlgorithm with your own implementation
            CompressAlgo stringCompression = new CompressAlgo();

            //Assume UTF-8 character set
            Console.WriteLine("Original Text: " + sourceString);
            Console.WriteLine("\n");
            Console.WriteLine("Original size in bytes: " + utf8.GetBytes(sourceString).Length);
            Console.WriteLine("Original size in bytes: " + Encoding.ASCII.GetBytes(sourceString).Length);
            byte[] compressed = stringCompression.Compress(sourceString);
            Console.WriteLine("\n");
            Console.WriteLine("Compressed size in bytes: " + compressed.Length);
            string decodedString = stringCompression.Decompress(compressed);
            Console.WriteLine("\n");
            if (sourceString.Equals(decodedString))
            {
                Console.WriteLine("Success");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Fail");
                Console.ReadLine();
            }
        }
    }
}
