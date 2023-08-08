using BarcodeLib;
using System.Drawing;
using ZXing;

namespace QR_Code_Generator
{
    public class QRActions
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Barkod yazdırmak için metni girin: ");
            string text = Console.ReadLine();

            writeQR(text);
            readQR();
        }

        static void writeQR(string word)
        {
            Barcode barcode = new Barcode();


            Image img = barcode.Encode(TYPE.CODE128, word);

            Bitmap bmp = new Bitmap(img);

            string filePath = @"C:\Users\KAPTAN\source\repos\Patika_C#_Projeleri\QR_Code_Generator\qr.png";

            bmp.Save(filePath);
        }


        static void readQR()
        {

            BarcodeReader barcodeReader = new BarcodeReader(); 

            barcodeReader.Options.TryHarder = true; 

            var barcodeBitMap = new Bitmap(@"C:\Users\KAPTAN\source\repos\Patika_C#_Projeleri\QR_Code_Generator\qr.png");

            var result = barcodeReader.Decode(barcodeBitMap); 

            if (result != null) 
                Console.WriteLine("QR içeriği: " + result.Text);
            else
                Console.WriteLine("QR okunamadı.");
           
            Console.ReadKey();
        }
    }
}
