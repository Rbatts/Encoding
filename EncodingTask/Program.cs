using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace EncodingTask
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Info> list = new List<Info>();

            using (var reader = new StreamReader(@"C:\Users\Rich\Documents\encoding.txt"))
            {
                while (!reader.EndOfStream)
                {
                    var splits = reader.ReadLine().Split(',');
                    var info = new Info(splits[0], splits[1], splits[2]);
                    list.Add(info);
                }
            }

            Console.WriteLine("\n  Book Table\n");

            foreach (var info in list)
            {
                if (info.Title.Length > 26)
                {
                    int maxLength = 26;
                    info.Title = info.Title.Substring(0, maxLength - 3) + "...";
                }
                if (info.Author.Length > 31)
                {
                    int maxLength = 31;
                    info.Author = info.Author.Substring(0, maxLength - 3) + "...";
                }

                Console.WriteLine(" | {0} | {1} | {2} |", info.PubDate, info.Title, info.Author);
            }
            Console.ReadLine();
        }

        //Console.WriteLine("\n |   Pub Date    |                                   Title | Authors                            |");
        //Console.WriteLine(" |==============================================================================================|");
        //Console.WriteLine(" |  28 Nov 2008  |                         Learning C# 3.0 | Jesse Liberty & Brian MacDonald.   |");
        //Console.WriteLine(" |  16 Sep 2013  |                           Head First C# | Jennifer Greene & Andrew Stellman. |");
        //Console.WriteLine(" |  27 Oct 2015  |  Learn C# in One Day and Learn It Well :| Jamie Chan.                        |");
        //Console.WriteLine(" |               |  C# for Beginners with Hands-on Project:|                                    |");
        //Console.WriteLine(" |               |  Volume 3                               |                                    |" );
        //Console.WriteLine(" |==============================================================================================|");
        //Console.ReadLine();

    }

}
