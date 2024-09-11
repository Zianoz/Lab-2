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
            /* Ser till att "◼︎" och "◻︎" printas ut korrekt i konsolen.*/
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            /* Låter användaren skriva in hur många rader och kolumner de vill ha genom att ändra str till int genom int.Parse som senare sparas som variabler. */
            Console.WriteLine("Välj hur många rader du vill ha på schackbrädan");
            int kolumn = int.Parse(Console.ReadLine());
            Console.WriteLine("\n");
            Console.WriteLine("Välj hur många kolumner du vill ha på shackbrädan");
            int rader = int.Parse(Console.ReadLine());
            Console.WriteLine("\n");
            Console.WriteLine("Vill du ha default brädan (Svart och Vit, '1') eller (Custom? '2') ");
            int svar = int.Parse(Console.ReadLine());

            string vit = "◼︎";
            string svart = "◻︎";

            // Skapar en switch där den använder svar från den föregående frågan för att välja om använder vill använda default brädan eller ha en custom bräda som de kan välja själva. 
            switch (svar)
            {
                case 1:
                    break;

                case 2:
                    /* Låter användaren skriva in vilka tecken programmet ska skriva ut som svart och vit. */
                    Console.WriteLine("Vilket tecken vill du ska vara vit?");
                    vit = Console.ReadLine();
                    Console.WriteLine("Vilket Tecken vill du ska vara svart?");
                    svart = Console.ReadLine();
                    Console.WriteLine("\n");
                    break;

                // Om användaren skriver något annat än 1 eller 2 kör den case 1 helt enkelt eftersom den är default eftersom jag redan har gett pjäserna en symbol utanför switch.
                default:
                    Console.WriteLine("Fel!, Schackbrädan kommer nu att använda default brädan");
                    break;

            }

            //Frågar användaren vilken pjäs de vill ha och sparar valet i (spelare). Frågar sedan användaren vart de vill lägga pjäsen och sparar värdet i position.
            Console.WriteLine("Vilken Pjäs vill du ha?");
            string spelare = Console.ReadLine();
            Console.WriteLine("Vart vill du lägga din pjäs? Ex: A2, D5");
            string position = Console.ReadLine();

            /* Skapar en variabel till den första bokstaven från användarens input */
            char pos = position[0];

            /* Tar användarens kolumnnummer minus A's ASCII värde vilket är 65 och lägger till 1 så att det börjar från 1 och inte 0 om det är tillexempel A5 som har valts.*/
            int kolumnvarde = pos - 'A' + 1;

            /* Omvandlar användarens rad val till en string */
            int radervarde = int.Parse(position[1].ToString());


            /* Detta är en forloop för rader. i är värdet för rader och loopar tills värdet som användaren skrev in.*/
            for (int i = 1; i <= rader; i++)
            {
                /*Denna är en forloop för kolumner där x är värdet för kolumner och den loopar till det värdet användaren skrev in.*/
                for (int x = 1; x <= kolumn; x++)
                {
                    // Kollar om kolumnvärde är likamed X och om radervarde är likamed i, om ja skriver den ut spelarens pjäs istället för svart eller vit.
                    if ((kolumnvarde == x) && (radervarde == i))
                    {
                        Console.Write(spelare);
                    }

                    /* Tar (i + x) och kollar om det är jämt genom % modulus. Om användaren skriver in 10/2 blir det 0 kvar men om det är 10/3 kommer det bli 1 kvar vilket är ojämt.*/
                    else if ((i + x) % 2 == 0)
                    {
                        Console.Write(vit);
                    }

                    /* Om det blir något över efter (i + x) printar den ut ◻︎ */
                    else
                    {
                        Console.Write(svart);
                    }

                }

                /* När kolumnerna har blivit klara på den raden kolumnloopen ligger på bryter programmet raden och börjar på en ny rad.*/
                Console.WriteLine();

            }



        }
    }
}
