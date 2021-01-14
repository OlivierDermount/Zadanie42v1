using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie42
{
    class Program
    {
        static void Main(string[] args)
        {
            var fisBas = new FisBas();
           
            while (true)
            {
                try                                                             //.....
                {
                    var liczbaString = fisBas.WriteScrReadKeys("Podaj liczbę");                    
                    var fIs = fisBas.Fis(liczbaString);
                    var bAs = fisBas.Bas(liczbaString);
                    var lString = (fIs == "Fis" || bAs == "Bas") ?
                                    liczbaString = "" : liczbaString;
                    var gramyDalej = fisBas.WriteScrReadKeys($"\n " +
                                         $"{ fIs }{bAs}{lString} " +
                                                  $"\n \n Gramy dalej ? t / n");
                    Console.Clear();
                    if (gramyDalej != "t") break;
                }
                catch (Exception ex) // ....
                {
                    fisBas.WriteScrReadKeys(ex.Message+"\n \n Wciśnij Enter");
                    Console.Clear();
                }
            }
        }
    }
}
