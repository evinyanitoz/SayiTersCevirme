namespace SayiTersCevirme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //kullanıcıdan bir sayı girmesini iste en az 4 haneli girilen sayıyı tersten ekrana yazdır.


            Console.WriteLine("SAYI GİRİNİZ ");
            string sayi = Console.ReadLine();


            for (int i = sayi.Length - 1; i >= 0; i--)
            {
                Console.Write(sayi[i].ToString());
            }





        }
    }
}
