namespace switch_case
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //    int sayi;
            //    Console.WriteLine("1 ile 7 arasında sayı giriniz:");
            //    sayi=Convert.ToInt32(Console.ReadLine());

            //    switch(sayi)
            //    {
            //        case 1: Console.WriteLine("gün pazartesi");
            //            break;
            //        case 2: Console.WriteLine("gün salı");
            //            break;
            //        case 3: Console.WriteLine("gün çarşamba");
            //            break;
            //        case 4: Console.WriteLine("gün perşembe");
            //            break;
            //        case 5: Console.WriteLine("gün cuma");
            //            break;
            //        case 6: Console.WriteLine("gün cumartesi");
            //            break;
            //        case 7: Console.WriteLine("gün pazar");
            //            break;

            //}
            //    Console.ReadLine();
            //{
            //    string mevsim;
            //    Console.WriteLine("mevsimi giriniz:");
            //    mevsim = Console.ReadLine();
            //    switch (mevsim)
            //    {
            //        case "yaz":
            //            Console.WriteLine("yaz mevsimi ayları:haziran temmuz ağustos");
            //            break;
            //        case "sonbahar":
            //            Console.WriteLine("sonbahar mevsimi ayları:eylül ekim kasım");
            //            break;
            //        case "kış":
            //            Console.WriteLine("kış mevsimi ayları:aralık ocak şubat");
            //            break;
            //        case "ilkbahar":
            //            Console.WriteLine("ilkbahar ayları:mart nisan mayıs");
            //            break;
            //    }
            //    Console.ReadLine();

            //}
            {
                string şehir;
                Console.WriteLine("şehri giriniz");
                şehir=Console.ReadLine();

                switch(şehir)
                {
                    case "elbistan":
                        Console.WriteLine("elbistanın eskişehire uzaklığı 731 kmdir ");
                        break;
                    case "maraş":
                        Console.WriteLine("maraşın eskişehire uzaklığı 850 kmdir");
                        break;  
                }
                Console.ReadLine();
                
            }

        }
    }
}
