using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KimMilyonerOlmakIster
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int correctAnswers = 0;

            // Soru 1
            Console.WriteLine("1 -> C# dilinde bir tamsayıyı saklamak için hangi veri tipi kullanılır?");
            Console.WriteLine("a) string b) int");
            string answer1 = Console.ReadLine().ToLower();

            if (answer1 == "b" || answer1 == "int")
            {
                correctAnswers++;
                Console.WriteLine("Doğru cevap!");
            }
            else
            {
                Console.WriteLine("Yanlış cevap!");
            }

            // Soru 2
            Console.WriteLine("2 -> C# dilinde bir string'i bir tamsayıya dönüştürmek için hangi yöntem kullanılır?");
            Console.WriteLine("a) Convert.ToInt32() b) Convert.ToString()");
            string answer2 = Console.ReadLine().ToLower();

            if (answer2 == "a" || answer2 == "convert.toint32()")
            {
                correctAnswers++;
                Console.WriteLine("Doğru cevap!");
            }
            else
            {
                Console.WriteLine("Yanlış cevap!");
            }

            // Kullanıcı ilk iki sorudan ikisini de yanlış cevapladıysa üçüncü soruyu sormuyoruz
            if (correctAnswers  >= 1)
            {
                // Soru 3
                Console.WriteLine("3 -> C# dilinde koşullu ifadeler için hangi anahtar kelime kullanılır?");
                Console.WriteLine("a) if b) for");
                string answer3 = Console.ReadLine().ToLower();

                if (answer3 == "a" || answer3 == "if")
                {
                    correctAnswers++;
                    Console.WriteLine("Doğru cevap!");
                }
                else
                {
                    Console.WriteLine("Yanlış cevap!");
                }
            }
         
            
            if (correctAnswers >= 2)
            {
                Console.WriteLine("Tebrikler! 1 Milyon TL'lik büyük ödülü kazandınız!".ToUpper());
            }
            else
            {
                Console.WriteLine("Üzgünüz, büyük ödülü kazanamadınız.");
            }
            Console.ReadKey();
        }
    }
}
