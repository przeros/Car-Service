using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace carService
{
    static class Program
    {
        /// <summary>
        /// Główny punkt wejścia dla aplikacji.
        /// </summary>
        [STAThread]
        static void Main()
        {
            const double basicStakePerHour = 50;

            // CREATE MECHANICS
            Mechanic mechanic1 = new Mechanic("John", "Walker", 1997, basicStakePerHour + 20);
            Mechanic mechanic2 = new Mechanic("Alan", "Mayer", 2012, basicStakePerHour + 12);
            Mechanic mechanic3 = new Mechanic("Adam", "Conway", 1999, basicStakePerHour);
            Mechanic mechanic4 = new Mechanic("Jeff", "Turing", 2004, basicStakePerHour);

            // CREATE CAR SERVICE
            CarService carService = new CarService("Warsztat_Obiektowy", 
                                                    new List<Mechanic>() 
                                                    { 
                                                        mechanic1,
                                                        mechanic2,
                                                        mechanic3,
                                                        mechanic4
                                                    });
            // SHOW MECHANICS
            /*Console.WriteLine("Mechanics:");
            foreach (Mechanic mechanic in carService.getMechanics())
            {
                Console.WriteLine(mechanic.getName());
            }

            // MAKE SOME REPAIRS
            carService.makeRepair(new Repair("GDA 7900", DateTime.Now, mechanic1, 1000, 10));
            carService.makeRepair(new Repair("GDA 2200", DateTime.Now, mechanic2, 1000, 1));

            // SHOW REPAIRS
            Console.WriteLine("Repairs:");
            foreach (Repair repair in carService.getRepairs())
            {
                Console.WriteLine(repair.ToString());
            }

            // SHOW CAR SERVICE EARNINGS
            Console.WriteLine("Car Service earnings:");
            Console.WriteLine(carService.getEarnings());

            // SHOW MECHANICS MONEY
            Console.WriteLine("Mechanics money:");
            foreach (Mechanic mechanic in carService.getMechanics())
            {
                Console.WriteLine($"{mechanic.getName()}: {mechanic.getMoney()}");
            }*/


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1(carService));

        }
    }
}
