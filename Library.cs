using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp42
{
    class Library
    {
        List<Book> books = new List<Book>();
        public List<Book> FilterByPrice(int min, int max)
        {
            List<Book> filtered = new List<Book>();

            var filteredprice = books.FindAll(x => x.Price >= min && x.Price <= max);

            if(filteredprice!=null)
                filtered.add


        }

        public List<Book> FilterByGenre()
        {

        }
        public Book FİndBookByNo(int no)
        {
            

            return null;
        }
    }
}
