using System;
using System.Collections.Generic;
using System.Text;

namespace VusalTaskBook
{
    class Book
    {
        private string _bookName;
        private int _pageCount;

        public Book(string name , int page)
        {
            BookName = name;
            PageCount = page;
        }

        public string BookName
        {
            get { return _bookName; }
            set
            {
                while (true)
                {
                    if (value.Length > 3)
                    {
                        _bookName = value;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Kitabin adini duzugun daxil edin");
                        value = Console.ReadLine();
                    }
                }
            }
        }

        public int PageCount
        {
            get { return _pageCount; }
            set
            {
                while (true)
                {
                    if (value > 10)
                    {
                        _pageCount = value;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Kitab sehifesini duzgun daxil edin");
                        int.TryParse(Console.ReadLine(), out value);
                    }
                }
            }
        } 

        public string Info()
        {
            return $"{_bookName} kitabi {_pageCount} sehifeden ibaretdir.";
        }
      
    }
}
