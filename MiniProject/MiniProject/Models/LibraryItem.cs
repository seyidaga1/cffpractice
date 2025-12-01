using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniProject.Models
{
    abstract class LibraryItem
    {
        private string _title;
        private string _author;
        private int _year;
        protected int Id;


        public string Title
        {
            get { return _title; }
            set 
            { 
                if(value.Trim() != "")
                {
                    _title = value;
                }
                else
                {
                    Console.WriteLine("Title cannot be empty.");
                }
            }
        }

        public string Author { get { return _author; } set { _author = value; } }

        public int Year
        {
            get { return _year; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Year cannot be negative.");
                }
                else
                {
                    _year = value;
                }
            }
        }

        public abstract void DisplayInfo();

        public virtual void GetSummary()
        {
            Console.WriteLine($"{Title} | {Author} | {Year}");
        }



    }
}
