using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Лабараторна_1_3._0;

namespace Лаба_1_4._0
{
    public partial class BookForm : Form
    {
        public BookForm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
    public partial class BookForm : Form
    {
        private Library library = new Library(); 

        public BookForm()
        {
            InitializeComponent();
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            string title = txtTitle.Text;
            string author = txtAuthor.Text;
            int year = int.Parse(txtYear.Text);
            string isbn = txtISBN.Text;

            Book book = new Book(title, author, year, isbn);
            library.AddBook(book);
            UpdateBookList();
        }

        private void btnRemoveBook_Click(object sender, EventArgs e)
        {
            string isbn = txtISBN.Text;
            library.RemoveBook(isbn);
            UpdateBookList();
        }

        private void btnSearchByAuthor_Click(object sender, EventArgs e)
        {
            string author = txtSearch.Text;
            var books = library.SearchByAuthor(author);
            lstBooks.DataSource = books;
        }

        private void btnSearchByTitle_Click(object sender, EventArgs e)
        {
            string title = txtSearch.Text;
            var books = library.SearchByTitle(title);
            lstBooks.DataSource = books;
        }

        private void btnShowAllBooks_Click(object sender, EventArgs e)
        {
            UpdateBookList();
        }

        private void UpdateBookList()
        {
            lstBooks.DataSource = null;
            lstBooks.DataSource = library.GetAllBooks();
        }
    }

}
