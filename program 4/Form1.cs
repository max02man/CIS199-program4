//Alaa Hawsawi 
//CIS199-01  
//Due date:12/8/2014
//This program will add a book in the library book and you can check out the book and return the book in the shelf 
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace program_4
{
    public partial class Form1 : Form
    {
        private List<LibraryBook> booklist = new List<LibraryBook>();

        public Form1()
        {
            InitializeComponent();
        }

        private void details_button_Click(object sender, EventArgs e)
        {
            int index = booklistBox.SelectedIndex;
            if (index >=0)
            {
                MessageBox.Show(booklist[index].ToString());
            }
            else
                MessageBox.Show("Select a book please");

        }


        private void Check_button_Click(object sender, EventArgs e)
        {
            int index = booklistBox.SelectedIndex;
            if (index >= 0)
            {
                booklist[index].CheckOut();
                MessageBox.Show("Book is Checked out");
            }
            else
                MessageBox.Show("Select a book please");

        }

        private void return_button_Click(object sender, EventArgs e)
        {
            int index = booklistBox.SelectedIndex;
            if (index >= 0)
            {
                booklist[index].ReturnToShelf();
                MessageBox.Show("Book is in the shelf");
            }
            else
                MessageBox.Show("Select a book please");

        }

        private void add_button_Click(object sender, EventArgs e)
        {
            int year;
            if (title_textBox.Text != "" && author_textBox.Text != "" && publisher_textBox.Text != "" &&
                year_textBox.Text != "" && number_textBox.Text != "") //won't accept any empty field 
            {
                string title = title_textBox.Text; //get the title
                string author = author_textBox.Text; // get the author name
                string publisher = publisher_textBox.Text; // get the publisher
                string callNumber = number_textBox.Text; //get the cellphone number

                if (int.TryParse(year_textBox.Text, out year)) // get the copyright year
                {
                    LibraryBook mybook = new LibraryBook(title, author, publisher, year,callNumber); 
                booklistBox.Items.Add(mybook.Title);
                booklist.Add(mybook);

                }
                else
                    MessageBox.Show("Enter Number Please");

            }
            else
                MessageBox.Show("Please full the empty filed or enter the right info");
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
