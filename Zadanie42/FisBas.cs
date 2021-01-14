using System;


namespace Zadanie42
{
    class FisBas
    {
        public string WriteScrReadKeys(string text) //.......
        {
            Console.WriteLine(text);
            return Console.ReadLine();
        }
        public string Fis(string liczbaString)
        {
            string fIs;
            var liczbaInt = int.Parse(liczbaString);
            if ((liczbaInt % 3) == 0) fIs = "Fis";
            else fIs = "";
            return fIs;
        }
        public string Bas(string liczbaString)
        {
            string bAs;
            var liczbaInt = int.Parse(liczbaString);
            if ((liczbaInt % 5) == 0) bAs ="Bas";
            else bAs = "";
            return bAs;
        }
    }
}
