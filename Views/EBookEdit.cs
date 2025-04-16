using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IHNRYA_Beadando.Models;

namespace IHNRYA_Beadando.Views
{
    public class EBookEdit: BookEdit
    {
        public EBookEdit(bool justForPoints) : base(justForPoints)
        {
        }

        protected override bool ShowFileFormat => true;
        protected override string BookLabel => "EBook";

        private new EBook? EditBook => base.EditBook as EBook;
        protected override void ExtraEditLoadFunction()
        {
            if (EditBook == null) return;
            fileFormatTextBox.Text = EditBook.FileFormat;
        }

        protected override void ExtraValidation(List<string> errors)
        {
            if (fileFormatTextBox.Text == "")
                errors.Add("Please enter a file format.");
        }

        protected override void ExtraEditUpdate()
        {
            if (EditBook == null) return;
            EditBook.FileFormat = fileFormatTextBox.Text;
        }

        protected override Book PrepareBook()
        {
            return new EBook(titleBox.Text, authorBox.Text, (int)yearBox.Value, isbnBox.Text, fileFormatTextBox.Text);
        }
    }
}
