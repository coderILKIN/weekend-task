using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp24
{
    class Library
    {
        private static int _id=0;
        public int Id { get;}

        public string Name { get; set; }


        public Library(string name)
        {
            Id = ++_id;
            Name = Name;
        }

       
        public List<Book> Books = new List<Book>();

        public void AddBook (Book book)
        {
            if (book != null)
            {
                Books.Add(book);
            }
        }

        public void ShowAllBooks()
        {
            foreach (var item in Books)
            {
                Console.WriteLine(Book.GetInfo());

            }

        }

        public Book FindAllBookId(int id)
        {
            if (Books.Exists(book => book.Id == id))
            {
                return Books.Find(x => x.Id == id);
            }
            return null;
        }


        public Book FindBookByBookCode(string bookcode)
        {
            if (Books.Exists(book => book.BookCode == bookcode))
            {
                return Books.Find(book => book.BookCode == bookcode);
            }
            return null;
        }







    }
}
