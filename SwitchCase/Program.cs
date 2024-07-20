using System;

class SwitchCase
{
    static void Main(string[] args)
    {
        Console.WriteLine("Rüya Manavına Hoş Geldiniz! " +
                          "\nElma = 2 TL " +
                          "\nArmut = 3 TL " +
                          "\nÇilek = 2 TL " +
                          "\nMuz = 3 TL " +
                          "\nDiğer bütün meyveler = 4 TL");

        Console.Write($"Hangi meyveyi satın almak istersiniz? (Elma/Armut/Çilek/Muz/Diğer):");
        
        string fruit = Console.ReadLine();

       
        // Kullanıcıdan aldığımız string ifade ToLower metodunu kullanarak küçük harfe çevirdim.

        fruit = fruit.ToLower();


        // Fiyat listesi sabit olduğu için switch case koşulu daha mantıklı geliyor.


        switch (fruit)
        {
            case "elma":
                Console.WriteLine("Seçtiğiniz meyvenin fiyatı : 2 TL");
                break;
            case "armut":
                Console.WriteLine("Seçtiğiniz meyvenin fiyatı : 3 TL");
                break;
            case "çilek":
                Console.WriteLine("Seçtiğiniz meyvenin fiyatı : 2 TL");
                break;
            case "muz":
                Console.WriteLine("Seçtiğiniz meyvenin fiyatı : 3 TL");
                break;
            default :
                Console.WriteLine("Seçtiğiniz meyvenin fiyatı : 4 TL");
                break;
        }



        if (fruit == "elma")
        {
            Console.WriteLine("Seçtiğiniz meyvenin fiyatı : 2 TL");
         
        }
        else if (fruit == "armut")
        {
            Console.WriteLine("Seçtiğiniz meyvenin fiyatı : 3 TL");
        }
        else if (fruit == "cilek" )
        {
            Console.WriteLine("Seçtiğiniz meyvenin fiyatı : 2 TL");
        }
        else if (fruit == "muz")
        {
            Console.WriteLine("Seçtiğiniz meyvenin fiyatı : 3 TL");
        }
        else
        {
            Console.WriteLine("Seçtiğiniz meyvenin fiyatı : 4 TL");
        }



    }
}