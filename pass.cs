using System;
using System.IO;

class Program
{
    static void Main()
    {
        Console.WriteLine("Şifre oluşturucuya hoşgeldiniz !");
        Console.WriteLine("Lütfen programı başlatmak için herhangi bir tuşa basınız !");
        Console.ReadLine();
        Console.Clear();

        string[] items = { "a", "b", "c", "d", "e", "f", "g", "h", "ı", "i", "j", "k", "l", "m", "n", "o", "ö", "p", "q", "r", "s", "ş", "t", "u", "ü", "v", "w", "x", "y", "z", ".", "-", "_", ",", "@", "#" };
        string dosyaYolu = "sifreler.txt"; // Şifrelerin kaydedileceği dosyanın adı

        // Dosyayı oluşturup şifreleri dosyaya yazma işlemi
        using (StreamWriter sw = new StreamWriter(dosyaYolu))
        {
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    sw.WriteLine(items[i] + items[j]);
                    for (int k = 0; k < items.Length; k++)
                    {
                        sw.WriteLine(items[i] + items[j] + items[k]);
                        for (int l = 0; l < items.Length; l++)
                        {
                            sw.WriteLine(items[i] + items[j] + items[k] + items[l]);
                            for (int m = 0; m < items.Length; m++)
                            {
                                sw.WriteLine(items[i] + items[j] + items[k] + items[l] + items[m]);
                                for (int n = 0; n < items.Length; n++)
                                {
                                    sw.WriteLine(items[i] + items[j] + items[k] + items[l] + items[m] + items[n]);
                                    for (int o = 0; o < items.Length; o++)
                                    {
                                        sw.WriteLine(items[i] + items[j] + items[k] + items[l] + items[m] + items[n] + items[o]);
                                        for (int p = 0; p < items.Length; p++)
                                        {
                                            sw.WriteLine(items[i] + items[j] + items[k] + items[l] + items[m] + items[n] + items[o] + items[p]);
                                            for (int q = 0; q < items.Length; q++)
                                            {
                                                sw.WriteLine(items[i] + items[j] + items[k] + items[l] + items[m] + items[n] + items[o] + items[p] + items[q]);
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        Console.WriteLine("Şifreler dosyaya kaydedildi.");
        Console.ReadLine();
    }
}
