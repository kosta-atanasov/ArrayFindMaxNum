namespace FindMaxNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 16, 24, 32, 71, 12, 56, 78, };
            
            int max = arr[0];

            foreach (int i in arr)
            {

                if (i > max) 
                {

                    Console.WriteLine($"Максималната Стойност е:{max = i}"); //така господине ако случайно гледате този проект и сте ми гледате кода този коментар аз го пиша. 
                    //и искам да кажа че това винаги проверява коя е най-голямата стойност и я изписва.
                }

                //и също ме последвайте в git hub
            }

            Console.WriteLine($"Най-Голямото Число е:{max}");
        }
    //само добрите програмисти ще го разберат
    
    }
}
