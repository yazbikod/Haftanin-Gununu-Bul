using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Haftanın_Günleri_Quiz
{
    public class Haftagunu
    {
        public Haftagunu()
        {
            Console.WriteLine("Uygulamamıza Hoşgeldiniz....");

        }
        public void GunBelirle(int gun)
        {
            Console.Write("Hesabı haftanın kaçıncı gününden yapmak istiyorsunuz : ");
            int deger = Convert.ToInt16(Console.ReadLine());

            switch (deger)
            {
                case 1: gun = 1; Console.WriteLine("Hesap Günü : Pazartesi"); break;
                case 2: gun = 2; Console.WriteLine("Hesap Günü : Salı"); break;
                case 3: gun = 3; Console.WriteLine("Hesap Günü : Çarşamba"); break;
                case 4: gun = 4; Console.WriteLine("Hesap Günü : Perşembe"); break;
                case 5: gun = 5; Console.WriteLine("Hesap Günü : Cuma"); break;
                case 6: gun = 6; Console.WriteLine("Hesap Günü : Cumartesi"); break;
                case 7: gun = 7; Console.WriteLine("Hesap Günü : Pazar"); break;
                default: Console.WriteLine("Girilen değeri kontrol ediniz!"); break;
            }
        }

    }
}
