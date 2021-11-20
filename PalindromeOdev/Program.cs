using System;

namespace PalindromeOdev
{
    class Program
    {
        static void Main(string[] args)
        {
            string cumle = "bu gün hava çok güzel....arkadaşlar ile kavak olan bir yere gittik. tabi gitmeden ütü yaptım. orada ata bindim....";

            string[] cumles = cumle.Split(' ');
            bool isPalindrome = false;
            foreach (var item in cumles)
            {
                int bas = 0, son = 0;
                son = item.Length - 1;
                int l = item.Length / 2;
                for (int i = 0; i < l; i++)
                {
                    char ilkK, sonK;

                    ilkK = item[bas++];
                    sonK = item[son--];

                    if (ilkK == sonK)
                    {
                        isPalindrome = true;
                    }
                    else
                    {
                        isPalindrome = false;
                        break; // döngüdenden çık...
                    }
                }
                if (isPalindrome)
                {
                    Console.WriteLine($" {item} palindrome");
                }
            }


          

            Console.ReadKey();
        }
    }
}
