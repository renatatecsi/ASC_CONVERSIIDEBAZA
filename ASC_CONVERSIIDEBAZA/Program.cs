using System;
using System.Linq.Expressions;

namespace ConversiiDeBaza
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Introduceti un numar: ");
            int numarDat = int.Parse(Console.ReadLine());


            Console.WriteLine("Baza in care doriti sa convertiti: ");
            int bazaConvertire = int.Parse(Console.ReadLine());

            if (bazaConvertire < 2 || bazaConvertire > 16) // afisare mesaj eroare pt bazele inadecvate
                Console.WriteLine("Eroare! Baza in care se converteste nu poate fi mai mica decat 2 sau mai mare decat 16.");
            else
            {
               
                if (bazaConvertire == 2)
                {
                    // binary
                    string binary = IntToString(numarDat, new char[] { '0', '1' });
                    Console.WriteLine(binary);
                }
                else if (bazaConvertire == 3)
                {
                    //baza 3
                    string bazaTrei = IntToString(numarDat, new char[] { '0', '1', '2' });
                    Console.WriteLine(bazaTrei);
                }
                else if (bazaConvertire == 4)
                {
                    //baza 4
                    string bazaPatru = IntToString(numarDat,
                        new char[] { '0', '1', '2', '3' });
                    Console.WriteLine(bazaPatru);
                }
                else if (bazaConvertire == 5)
                {
                    //baza 5
                    string bazaCinci = IntToString(numarDat,
                        new char[] { '0', '1', '2', '3', '4' });
                    Console.WriteLine(bazaCinci);
                }
                else if (bazaConvertire == 6)
                {
                    //baza 6
                    string bazaSase = IntToString(numarDat,
                        new char[] { '0', '1', '2', '3', '4', '5' });
                    Console.WriteLine(bazaSase);
                }
                else if (bazaConvertire == 7)
                {
                    //baza 7
                    string bazaSapte = IntToString(numarDat,
                        new char[] { '0', '1', '2', '3', '4', '5', '6' });
                    Console.WriteLine(bazaSapte);
                }
                else if (bazaConvertire == 8)
                {
                    //baza 8
                    string bazaOpt = IntToString(numarDat,
                        new char[] { '0', '1', '2', '3', '4', '5', '6', '7' });
                    Console.WriteLine(bazaOpt);
                }
                else if (bazaConvertire == 9)
                {
                    //baza 9
                    string bazaNoua = IntToString(numarDat,
                        new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8' });
                    Console.WriteLine(bazaNoua);
                }
                else if (bazaConvertire == 10)
                {
                    //baza 10
                    string bazaZece = IntToString(numarDat,
                        new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8',
                        '9' });
                    Console.WriteLine(bazaZece);
                }
                else if (bazaConvertire == 11)
                {
                    //baza 11
                    string baza11 = IntToString(numarDat,
                        new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8',
                        '9', 'A' });
                    Console.WriteLine(baza11);
                }
                else if (bazaConvertire == 12)
                {
                    //baza 12
                    string baza12 = IntToString(numarDat,
                        new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8',
                        '9', 'A', 'B' });
                    Console.WriteLine(baza12);
                }
                else if (bazaConvertire == 13)
                {
                    //baza 13 
                    string baza13 = IntToString(numarDat,
                        new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8',
                        '9', 'A', 'B', 'C' });
                    Console.WriteLine(baza13);
                }
                else if (bazaConvertire == 14)
                {
                    //baza 14
                    string baza14 = IntToString(numarDat,
                        new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8',
                        '9', 'A', 'B', 'C', 'D', });
                    Console.WriteLine(baza14);
                }
                else if (bazaConvertire == 15)
                {
                    //baza 15
                    string baza15 = IntToString(numarDat,
                        new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8',
                        '9', 'A', 'B', 'C', 'D', 'E', });
                    Console.WriteLine(baza15);
                }
                else 
                {
                    // hexadecimal
                    string hex = IntToString(numarDat,
                        new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8',
                        '9', 'A', 'B', 'C', 'D', 'E', 'F' });
                    Console.WriteLine(hex);
                }
            }
        }

        public static string IntToString(int value, char[] caractereBaza)
        {
            string rezultat = string.Empty;
            int bazaConv = caractereBaza.Length;

            do
            {
                rezultat = caractereBaza[value % bazaConv] + rezultat;
                value = value / bazaConv;
            }
            while (value > 0);

            return rezultat;
        }
    }
}