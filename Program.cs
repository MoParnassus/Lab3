using System;
using System.Text;

namespace Lab_3
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder builder = new StringBuilder();
            string text = string.Empty;
            float suma = 0;
            float wynik;

            while (text != "stop")
            {
                text = Console.ReadLine();
                builder.Append(text + " ");
            }


            string[] ocenyTxt = builder.ToString().Split(new[] { "\r\n", "stop", ";", ":", " " }, StringSplitOptions.RemoveEmptyEntries); //new char[] {','} zamiast tylko ',' w wersjach starszych niz dot net core 3.0
            float[] oceny = new float[ocenyTxt.Length];

            for (int i = 0; i < oceny.Length; i++)
            {
                oceny[i] = Convert.ToSingle(ocenyTxt[i]);
            }

            foreach (var ocena in oceny)
            {
                suma += ocena;
            }



            wynik = (float)suma / oceny.Length;

            Console.WriteLine(Math.Round(wynik, 2));

        }
    }
}
