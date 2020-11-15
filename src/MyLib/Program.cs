using System;

namespace MyLib {
    public class HeaderNames {
        public static string Accept = "Accept";
        public const string AcceptConst = "Accept";

        public static bool IsAccept(string x) {
            return object.ReferenceEquals(Accept, x) || StringComparer.OrdinalIgnoreCase.Equals(Accept, x);
        }

        public static bool IsAcceptConst(string x) {
            return object.ReferenceEquals(AcceptConst, x) || StringComparer.OrdinalIgnoreCase.Equals(Accept, x);
        }
    }

    class Program {
        static void Main(string[] args) {
        }
    }
}
