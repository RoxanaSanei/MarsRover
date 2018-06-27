using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resolve.MarsRover
{
    class Program
    {

        static void Main(string[] args)
        {
            var commandString = buildCommandString();
            
            //Plateau _plateau = new Plateau(10, 10);
            //Position _position = new Position(1, 1, Position.Compass.N);
            //Rover _rover = new Rover(_plateau, _position);
            Composer _composer = new Composer();

            string _res = _composer.ComposeLocation(commandString);
                displayToConsole(commandString, _res);
            
        }
        private static void displayToConsole(string commandString, string _res)
        {
            
            Console.WriteLine("Input:");
            Console.WriteLine(commandString);
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("Output:");
            Console.WriteLine(_res);
            Console.Write(Environment.NewLine);
            Console.Write("Press <enter> to exit...");
            Console.ReadLine();
        }

        private static string buildCommandString()
        {
            var commandStringBuilder = new StringBuilder();
            commandStringBuilder.AppendLine("5 5");
            commandStringBuilder.AppendLine("1 2 N");
            commandStringBuilder.AppendLine("LMLMLMLMM");
            commandStringBuilder.AppendLine("3 3 E");
            commandStringBuilder.Append("MMRMMRMRRM");
            return commandStringBuilder.ToString();
        }
    }
}
