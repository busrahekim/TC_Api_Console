using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cosole_api
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long tc;
            string ad, soyad;
            int yil;

            Console.Write("TC giriniz: ");
            tc = long.Parse(Console.ReadLine());

            Console.Write("İsim giriniz: ");
            ad = Console.ReadLine();

            Console.Write("Soyisim giriniz: ");
            soyad = Console.ReadLine();

            Console.Write("Doğum yılınızı giriniz: ");
            yil = int.Parse(Console.ReadLine());

            k.KPSPublicSoapClient kontrol = new k.KPSPublicSoapClient();
            bool durum = kontrol.TCKimlikNoDogrula(tc,ad,soyad,yil);
            if (durum)
            {
                Console.WriteLine("TC Vatandaşı");
            }
            else
            {
                Console.WriteLine("TC Vatandaşı değil.");
            }
            Console.Read();
        }
    }
}
