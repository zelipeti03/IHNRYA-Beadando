using IHNRYA_Beadando.Models;
using IHNRYA_Beadando.Services;
using IHNRYA_Beadando.Views;

namespace IHNRYA_Beadando
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }


        private void Form_Load(object sender, EventArgs e)
        {
            BookService.Init();
            BookService.BooksChanged += (s, e) =>
            {
                UpdateBookList();
            };
            UpdateBookList();
        }

        private Book? SelectedBook = null;
        private void CloseApp_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NewBook_Click(object sender, EventArgs e)
        {
            var newBookWindow = new BookEdit(true);
            newBookWindow.EditBook = null; // this is redundant, but it is good to be explicit
            newBookWindow.ShowDialog();
        }
        private void NewEBook_Click(object sender, EventArgs e)
        {
            var newBookWindow = new EBookEdit(true);
            newBookWindow.EditBook = null; // this is redundant, but it is good to be explicit
            newBookWindow.ShowDialog();
        }


        private void bookSearchBox_TextChanged(object sender, EventArgs e)
        {
            UpdateBookList();
        }

        private void UpdateBookList()
        {
            UpdateSelectedBook(null);
            bookListBox.Items.Clear();
            var searchString = bookSearchBox.Text.ToLower();

            foreach (var book in BookService.Books)
                if (book.MatchesSearch(searchString))
                    bookListBox.Items.Add(book);
        }


        private void bookListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // we use 'as' to cast it to a Book, if it is not a Book, it will be null, we could also use explicit casting and it would be safe, but this way we avoid potential warnings
            UpdateSelectedBook(bookListBox.SelectedItem as Book);

        }

        private void UpdateSelectedBook(Book? book)
        {
            SelectedBook = book;
            if (SelectedBook == null)
                selectedBookPanel.Visible = false;
            else
            {
                selectedBookPanel.Visible = true;
                selectedBookTitle.Text = SelectedBook.Title;
                selectedBookAuthor.Text = SelectedBook.Author;
                selectedBookYear.Text = SelectedBook.Year.ToString();
                selectedBookISBN.Text = SelectedBook.ISBN;
                if (SelectedBook is EBook eBook)
                {
                    selectedBookFileFormat.Text = eBook.FileFormat;
                    selectedBookFileFormat.Visible = true;
                    selectedBookFileFormatLabel.Visible = true;
                }
                else
                {
                    selectedBookFileFormat.Visible = false;
                    selectedBookFileFormatLabel.Visible = false;
                }
            }
        }

        private void selectedBookEdit_Click(object sender, EventArgs e)
        {
            if (SelectedBook == null)
                return;
            BookEdit editBookWindow;
            if (SelectedBook is EBook)
                editBookWindow = new EBookEdit(true);
            else
                editBookWindow = new BookEdit(true);

            editBookWindow.EditBook = SelectedBook;
            editBookWindow.ShowDialog();
        }

        private void selectedBookDelete_Click(object sender, EventArgs e)
        {
            if (SelectedBook == null)
                return;
            var result = MessageBox.Show($"Are you sure you want to delete {SelectedBook.Title}?", "Delete book", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                BookService.Books.Remove(SelectedBook);
                BookService.Save();
            }
        }

    
    }
}
