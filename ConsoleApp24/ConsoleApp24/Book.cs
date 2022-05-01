using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp24
{
    class Book
    {
        
        private static int _id=0;
        public int Id { get; }

        public string Name { get; set; }

        public string BookCode { get; set; }


        public Book(string name)
        {
            Id = ++_id;
            Name = name;
            BookCode = Name.Substring(0, 2).ToUpper() + (Id + 1000);
        }

        public $"

    }
}
