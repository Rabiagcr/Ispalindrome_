using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Bir metin girin:");

        string input = Console.ReadLine(); // Girdiğimiz metnin string olduğunu belirttik ve kullanıcıdan metin girişi için ReadLine kullanıyoruz.

        bool palindrom = IsPalindrome(input); // IsPalindrome metodunun boolean değer döndüreceğini belirtiyoruz.

        Console.WriteLine(palindrom); // Konsol ekranına palindrom olup olmadığını yazdırıyoruz.

        Console.ReadLine(); // Konsolun ekranda kalması için ReadLine ekledik.
    }

    static bool IsPalindrome(string text) // IsPalindrome metodunun boolean değer döndüreceğini belirtiyoruz.
    {
        string reversedText = ReverseText(text); // Metni tersine çeviren ReverseText metodunu çağırıyoruz.

        if (text == reversedText) // Eğer orijinal metin ters çevrilmiş metne eşitse
        {
            return true; // Palindromdur
        }
        else
        {
            return false; // Palindrom değildir
        }
    }

    static string ReverseText(string text) // ReverseText metodunun string döndüreceğini belirtiyoruz.
    {
        char[] chars = new char[text.Length]; // Char dizisi oluşturuyoruz.

        int index = 0;

        for (int i = text.Length - 1; i >= 0; i--) // Metni tersine çevirmek için döngü kullanıyoruz.
        {
            chars[index] = text[i]; // char dizisinin ilgili indeksine metnin son karakterinden başlayarak atama yapıyoruz.
            index++;
        }

        return new string(chars); // Char dizisini string olarak döndürüyoruz.
    }
}
