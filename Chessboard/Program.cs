using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chessboard
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Ensures that "◼︎" and "◻︎" are printed correctly in the console. */
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            /* Allows the user to input how many rows and columns they want by converting str to int via int.Parse, which is then stored as variables. */
            Console.WriteLine("Välj hur många rader du vill ha på schackbrädan");
            int column = int.Parse(Console.ReadLine());
            Console.WriteLine("\n");
            Console.WriteLine("Välj hur många kolumner du vill ha på shackbrädan");
            int rows = int.Parse(Console.ReadLine());
            Console.WriteLine("\n");
            Console.WriteLine("Vill du ha default brädan (Svart och Vit, '1') eller (Custom? '2') ");
            int answer = int.Parse(Console.ReadLine());

            string white = "◼︎";
            string black = "◻︎";

            // Creates a switch that uses the answer from the previous question to decide if the user wants the default board or a custom board where they can choose themselves.
            switch (answer)
            {
                case 1:
                    break;

                case 2:
                    /* Allows the user to input which characters the program should print as black and white. */
                    Console.WriteLine("Vilket tecken vill du ska vara vit?");
                    white = Console.ReadLine();
                    Console.WriteLine("Vilket Tecken vill du ska vara svart?");
                    black = Console.ReadLine();
                    Console.WriteLine("\n");
                    break;

                // If the user enters something other than 1 or 2, it runs case 1, as it's the default since I have already given the pieces a symbol outside the switch.
                default:
                    Console.WriteLine("Fel!, Schackbrädan kommer nu att använda default brädan");
                    break;

            }

            // Asks the user which piece they want and saves the choice in (player). Then asks the user where they want to place the piece and saves the value in position.
            Console.WriteLine("Vilken Pjäs vill du ha?");
            string player = Console.ReadLine();
            Console.WriteLine("Vart vill du lägga din pjäs? Ex: A2, D5");
            string position = Console.ReadLine();

            /* Creates a variable from the first letter of the user's input */
            char pos = position[0];

            /* Takes the user's column number minus A's ASCII value which is 65 and adds 1 so that it starts from 1 and not 0 if, for example, A5 is chosen. */
            int columnvalue = pos - 'A' + 1;

            /* Converts the user's row choice to a string */
            int rowvalue = int.Parse(position[1].ToString());


            /* This is a for-loop for rows. i is the value for rows and loops until the value entered by the user. */
            for (int i = 1; i <= rows; i++)
            {
                /* This is a for-loop for columns where x is the value for columns and loops to the value entered by the user. */
                for (int x = 1; x <= column; x++)
                {
                    // Checks if the column value is equal to X and if the row value is equal to i, if yes, it prints the player's piece instead of black or white.
                    if ((columnvalue == x) && (rowvalue == i))
                    {
                        Console.Write(player);
                    }

                    /* Takes (i + x) and checks if it is even using the modulus %. If the user enters 10/2, it will be 0, but if it's 10/3, it will leave 1, which is odd. */
                    else if ((i + x) % 2 == 0)
                    {
                        Console.Write(white);
                    }

                    /* If there is something left after (i + x), it prints ◻︎ */
                    else
                    {
                        Console.Write(black);
                    }

                }

                /* When the columns are done on the current row the column loop is on, the program breaks the line and starts a new row. */
                Console.WriteLine();

            }



        }
    }
}
