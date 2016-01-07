using System;
using System.Collections.Generic;
using System.Text;
using Sys = Cosmos.System;

namespace _431OS
{
    public class Kernel : Sys.Kernel
    {
        protected override void BeforeRun()
        {
        }

        protected override void Run()
        {
            var input = Console.ReadLine();
            command(input);
        }

        private void command(String input)
        {
            String[] command = input.Split(' ');
            switch (command[0])
            {
                case "echo":
                    Console.WriteLine();
                    break;
                default:
                    Console.WriteLine("Not a valid input.");
                    break;
            }
        }
    }
}
