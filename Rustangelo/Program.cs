using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Rustangelo
{
    static class Program
    {
        /// <summary>
        /// Uygulamanın ana girdi noktası.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Thread recoil_thread = new Thread(Recoil);
            recoil_thread.Start();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Menu());
        }

        static void Recoil()
        {
            while (true)
            {
                try // For some reason it runs out of indexes 
                {
                    if (Menu.activ && Mouse.IsKeyDown(Keys.LButton) && Mouse.IsKeyDown(Keys.RButton)) // checking if he schould recoil
                    {
                        for (int i = 0; i < Weapons.Current_weapon().Item1.Length; i++)
                        {
                            double Recoil_x = ((Weapons.Current_weapon().Item1[i, 0] / 2) / Menu.sense) * Weapons.Attachment().Item1 * Weapons.Scope(); // doing /2 because tables are for .5
                            double Recoil_y = ((Weapons.Current_weapon().Item1[i, 1] / 2) / Menu.sense) * Weapons.Attachment().Item1 * Weapons.Scope(); // doing /2 because tables are for .5

                            for (int j = 0; j < Menu.smooth; j++)
                            {
                                if (!Mouse.IsKeyDown(Keys.LButton) || !Mouse.IsKeyDown(Keys.RButton))
                                {
                                    continue;
                                }
                                int move_x = Convert.ToInt32(Recoil_x / Menu.smooth);
                                int move_y = Convert.ToInt32(Recoil_y / Menu.smooth);

                                Mouse.RelativeMove(move_x, move_y);


                                double sleep = (Weapons.Current_weapon().Item2 / Menu.smooth) * Weapons.Attachment().Item2;
                                Thread.Sleep(Convert.ToInt32(sleep));
                            }
                            if (Menu.test1 && Mouse.IsKeyDown(Keys.LButton) && Mouse.IsKeyDown(Keys.RButton))
                            {
                                int lost_x = Convert.ToInt32(Recoil_x % Menu.smooth);
                                int lost_y = Convert.ToInt32(Recoil_y % Menu.smooth);
                                Mouse.RelativeMove(lost_x, lost_y);
                            }
                        }
                    }
                }
                catch { }
            }
        }
    }
}
