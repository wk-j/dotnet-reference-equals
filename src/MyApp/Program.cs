using System;
using MyLib;

namespace MyApp {
    class Program {

        static void Main(string[] args) {

            var e1 = Object.ReferenceEquals("Accept", HeaderNames.Accept);
            var e2 = Object.ReferenceEquals("Accept", HeaderNames.AcceptConst);
            var e3 = Object.ReferenceEquals(HeaderNames.Accept, HeaderNames.AcceptConst);


            Console.WriteLine(e1);
            Console.WriteLine(e2);
            Console.WriteLine(e3);
            Console.WriteLine(HeaderNames.IsAccept("accept"));
            Console.WriteLine(HeaderNames.IsAcceptConst("accept"));
        }
    }
}
