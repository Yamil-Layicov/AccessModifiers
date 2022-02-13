using System;

namespace VusalTaskBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Book[] arr = new Book[10];
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"{i + 1} kitabinin adi: ");
                string book_name = Console.ReadLine();
                Console.WriteLine($"{i + 1} kitabinin sahifesin daxil et: ");
                int book_page;
                int.TryParse(Console.ReadLine(), out book_page);
                Book book = new Book(book_name, book_page);
                arr[i] = book;

            }
            foreach (var item in arr)
            {
                Console.WriteLine(item.Info());
            }
        }
    }
}
