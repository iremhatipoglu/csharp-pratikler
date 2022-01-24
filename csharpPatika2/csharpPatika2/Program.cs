using System;

namespace csharpPatika2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Atama ve İşlemli atama Operatörleri");

            //Atama ve İşlemli Atama
            int x = 3;
            int y = 3;
            y = y + 2;

            Console.WriteLine(y);
            y += 2;
            Console.WriteLine(y);
            y/= 1;
            Console.WriteLine(y);
            x *= 2;
            Console.WriteLine(x);

            //Mantıksal Operatörler
            // ||, &&, !

            bool isSuccess = true;
            bool isCompleted = false;

            if (isSuccess && isCompleted)
                Console.WriteLine("Perfect");
            if (isSuccess || isCompleted)
                Console.WriteLine("Great");
            if (isSuccess && !isCompleted)
                Console.WriteLine("Fine");

            //İlişkisel Operatörler
            // <,>,<=,>=,==,!=

            int a = 3;
            int b = 4;
            bool sonuc = a < b; 

            Console.WriteLine(sonuc);
            sonuc = a > b;
            Console.WriteLine(sonuc);
            sonuc = a >= b;
            Console.WriteLine(sonuc);
            sonuc = a <= b;
            Console.WriteLine(sonuc);
            sonuc = a == b;
            Console.WriteLine(sonuc);
            sonuc = a != b;
            Console.WriteLine(sonuc);

            //Aritmetik Operatörler
            // +,*,/,-,%

        }
    }
}
