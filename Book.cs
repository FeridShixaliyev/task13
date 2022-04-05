using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp42
{
    class Book
    {
        public Book(int no)
        {
            No = no;
            _no++;
        }
        private static int _no;
        public int No { get; set; }
        public string Name { get; set; }
        public string AuthorName { get; set; }
        public Enum Genre;
        public int Price { get; set; }
    }
}
