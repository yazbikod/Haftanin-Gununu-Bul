internal class Program
{

    private static void Main(string[] args)
    {
        int hesapgunu1 = haftaningununubelirle(1);
        Console.Write("Kaç gün eklenecek: ");
        int hesapgunu2 = Convert.ToInt32(Console.ReadLine());
        int sonuc = hesapgunu1 + hesapgunu2;

        switch (sonuc % 7)
        {
            case 1: Console.WriteLine("Next Day: Pazartesi"); break;
            case 2: Console.WriteLine("Next Day: Salı"); break;
            case 3: Console.WriteLine("Next Day: Çarşamba"); break;
            case 4: Console.WriteLine("Next Day: Perşembe"); break;
            case 5: Console.WriteLine("Next Day: Cuma"); break;
            case 6: Console.WriteLine("Next Day: Cumartesi"); break;
            case 7: Console.WriteLine("Next Day: Pazar"); break;
            default: Console.WriteLine("Yanlış değer girdiniz!"); break;
        }



    }

    static int haftaningununubelirle(int gun)
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
        return gun;

    }
}