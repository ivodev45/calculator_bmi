using System;

namespace BMICalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Tražimo od korisnika da unese visinu i težinu
            Console.WriteLine("Dobrodošli u BMI kalkulator!");

            Console.Write("Unesite vašu visinu u centimetrima: ");
            double visina = Convert.ToDouble(Console.ReadLine()); // Unos visine u cm

            Console.Write("Unesite vašu težinu u kilogramima: ");
            double tezina = Convert.ToDouble(Console.ReadLine()); // Unos težine u kg

            // Preračunavanje visine iz centimetara u metre
            double visinaMetri = visina / 100;

            // Izračunavanje BMI
            double bmi = tezina / (visinaMetri * visinaMetri);

            // Ispisivanje rezultata
            Console.WriteLine("Vaš BMI je: " + bmi.ToString("0.00"));

            // Pružamo preporuke na osnovu BMI vrednosti
            if (bmi < 18.5)
            {
                Console.WriteLine("Imate manjak telesne težine.");
                Console.WriteLine("Preporučuje se da unosite više kalorija i vežbate snagu.");
            }
            else if (bmi >= 18.5 && bmi < 24.9)
            {
                Console.WriteLine("Vaša telesna težina je normalna.");
                Console.WriteLine("Samo nastavite sa zdravom ishranom i redovnim vežbanjem.");
            }
            else if (bmi >= 25 && bmi < 29.9)
            {
                Console.WriteLine("Imate prekomernu telesnu težinu.");
                Console.WriteLine("Pokušajte da smanjite unos masne hrane i vežbate više.");
            }
            else
            {
                Console.WriteLine("Imate gojaznost.");
                Console.WriteLine("Preporučuje se da smanjite kalorijski unos i postepeno povećavate fizičku aktivnost.");
            }

            Console.WriteLine("Hvala što ste koristili naš BMI kalkulator!");
        }
    }
}