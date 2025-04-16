using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IHNRYA_Beadando.Models;
using IHNRYA_Beadando.Services;

namespace IHNRYA_Beadando.Views
{
    public partial class BookEdit : Form
    {
        // the constructor parameter does nothing, it's just for points :) Technically we could put EditBook in here too.
        public BookEdit(bool justForPoints)
        {
            InitializeComponent();
        }
        public Book? EditBook { get; set; }

        protected virtual bool ShowFileFormat => false;
        protected virtual string BookLabel => "Book";

        protected virtual void ExtraEditLoadFunction()
        {

        }

        protected virtual void ExtraValidation(List<string> errors)
        {

        }

        protected virtual void ExtraEditUpdate()
        {

        }

        protected virtual Book PrepareBook()
        {
            return new Book(titleBox.Text, authorBox.Text, (int)yearBox.Value, isbnBox.Text);
        }
        public void BookEdit_Load(object sender, EventArgs e)
        {
            fileFormatTextBoxLabel.Visible = ShowFileFormat;
            fileFormatTextBox.Visible = ShowFileFormat;
            if (EditBook != null)
            {
                titleBox.Text = EditBook.Title;
                authorBox.Text = EditBook.Author;
                yearBox.Value = EditBook.Year;
                isbnBox.Text = EditBook.ISBN;
                ExtraEditLoadFunction();
            }
            this.Text = EditBook == null ? $"New {BookLabel}" : $"Edit {BookLabel}";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            // validation errors
            var errors = new List<string>();
            if (titleBox.Text == "")
                errors.Add("Please enter a title.");
            if (authorBox.Text == "")
                errors.Add("Please enter an author.");
            // year is validated
            if (isbnBox.Text == "")
                errors.Add("Please enter an ISBN.");
            ExtraValidation(errors);
            // if there are any validation errors
            if (errors.Count > 0)
            {
                MessageBox.Show(string.Join("\n", errors), "Validation errors", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (EditBook != null)
            {
                EditBook.Title = titleBox.Text;
                EditBook.Author = authorBox.Text;
                EditBook.Year = (int)yearBox.Value;
                EditBook.ISBN = isbnBox.Text;
                ExtraEditUpdate();
            }
            else
            {
                BookService.Books.Add(PrepareBook());
            }
            BookService.Save();

            MessageBox.Show("Book Saved", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
        }

    }
}
