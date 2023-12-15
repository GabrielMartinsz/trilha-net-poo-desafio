using DesafioPOO.Models;

class Program
{
    static void Main()
    {
        Nokia nokia = new Nokia("123456789", "NokiaXYZ");
        nokia.Ligar();
        nokia.ReceberLigacao();
        nokia.InstalarAplicativo("WhatsApp");

        Iphone iphone = new Iphone("987654321", "iPhone12");
        iphone.Ligar();
        iphone.ReceberLigacao();
        iphone.InstalarAplicativo("Instagram");
    }
}
