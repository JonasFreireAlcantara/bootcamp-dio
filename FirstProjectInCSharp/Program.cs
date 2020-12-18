using System;

namespace FirstProjectInCSharp {
    class Program {
        static void Main(string[] args) {
            int number = 9;

            Console.WriteLine($"Tab of {number}:\n");
            for (int multiple = 1; multiple <= 1000; multiple++) {
                Console.WriteLine($"{number} x {multiple} = {number * multiple}");
            }
        }
    }
}
