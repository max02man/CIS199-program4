using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program_4
{
    class LibraryBook
    {
        private string _title;
        private string _author;
        private string _publisher;
        private int _year;
        private string _number;
        private bool status;

        public LibraryBook(string title, string author, string publisher, int year, string cell)
        {
            Title = title;
            Author = author;
            Publisher = publisher;
            CopyrightYear = year;
            CallNumber = cell;
        }
        public string Title
        {
            get { return _title; }
           private set { _title = value; }
        }
        public string Author
        {
            get { return _author; }
            private set { _author = value; }
        }
        public string Publisher
        {
            get { return _publisher; }
            set { _publisher = value; }
        }
        public int CopyrightYear
        {
            get { return _year; }
          private  set
            {
                if (_year >= 0)
                    _year = value;
            }
        }
        public string CallNumber
        {
            get { return _number; }
            set { _number = value; }
        }
        public void CheckOut()
        {
            status = true;
        }
        public void ReturnToShelf()
        {
            status = false;
        }
        public bool IsCheckedOut()
        {
            if ( status==true)
            {return  true;}
            else{return false;}

        }
        public override string ToString()
        {
            string reslut;
            reslut = "Title: " + Title.ToString() + System.Environment.NewLine + "Author: " + Author.ToString() + System.Environment.NewLine +
                "Publisher: " + Publisher.ToString() + System.Environment.NewLine + "Copyright Year: " + CopyrightYear.ToString() +
                System.Environment.NewLine + "Call Number: " + CallNumber.ToString() + System.Environment.NewLine + "CheckOut: " + status.ToString();
            return reslut;
        }

    }
}
