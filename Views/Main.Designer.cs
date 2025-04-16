namespace IHNRYA_Beadando
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            booksToolStripMenuItem1 = new ToolStripMenuItem();
            newToolStripMenuItem1 = new ToolStripMenuItem();
            booksToolStripMenuItem2 = new ToolStripMenuItem();
            newBookToolStripMenuItem = new ToolStripMenuItem();
            newEBookToolStripMenuItem = new ToolStripMenuItem();
            newToolStripMenuItem = new ToolStripMenuItem();
            bookListBox = new ListBox();
            bookSearchBox = new TextBox();
            label1 = new Label();
            panel1 = new Panel();
            selectedBookPanel = new Panel();
            selectedBookEdit = new Button();
            selectedBookDelete = new Button();
            selectedBookFileFormat = new Label();
            selectedBookISBN = new Label();
            selectedBookYear = new Label();
            selectedBookAuthor = new Label();
            selectedBookTitle = new Label();
            label7 = new Label();
            selectedBookFileFormatLabel = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            menuStrip1.SuspendLayout();
            selectedBookPanel.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { booksToolStripMenuItem1, booksToolStripMenuItem2 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(532, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // booksToolStripMenuItem1
            // 
            booksToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { newToolStripMenuItem1 });
            booksToolStripMenuItem1.Name = "booksToolStripMenuItem1";
            booksToolStripMenuItem1.Size = new Size(37, 20);
            booksToolStripMenuItem1.Text = "File";
            // 
            // newToolStripMenuItem1
            // 
            newToolStripMenuItem1.Name = "newToolStripMenuItem1";
            newToolStripMenuItem1.Size = new Size(128, 22);
            newToolStripMenuItem1.Text = "Close App";
            newToolStripMenuItem1.Click += CloseApp_Click;
            // 
            // booksToolStripMenuItem2
            // 
            booksToolStripMenuItem2.DropDownItems.AddRange(new ToolStripItem[] { newBookToolStripMenuItem, newEBookToolStripMenuItem });
            booksToolStripMenuItem2.Name = "booksToolStripMenuItem2";
            booksToolStripMenuItem2.Size = new Size(51, 20);
            booksToolStripMenuItem2.Text = "Books";
            // 
            // newBookToolStripMenuItem
            // 
            newBookToolStripMenuItem.Name = "newBookToolStripMenuItem";
            newBookToolStripMenuItem.Size = new Size(180, 22);
            newBookToolStripMenuItem.Text = "New Book";
            newBookToolStripMenuItem.Click += NewBook_Click;
            // 
            // newEBookToolStripMenuItem
            // 
            newEBookToolStripMenuItem.Name = "newEBookToolStripMenuItem";
            newEBookToolStripMenuItem.Size = new Size(180, 22);
            newEBookToolStripMenuItem.Text = "New E-Book";
            newEBookToolStripMenuItem.Click += NewEBook_Click;
            // 
            // newToolStripMenuItem
            // 
            newToolStripMenuItem.Name = "newToolStripMenuItem";
            newToolStripMenuItem.Size = new Size(180, 22);
            newToolStripMenuItem.Text = "New";
            // 
            // bookListBox
            // 
            bookListBox.FormattingEnabled = true;
            bookListBox.ItemHeight = 15;
            bookListBox.Location = new Point(12, 65);
            bookListBox.Name = "bookListBox";
            bookListBox.Size = new Size(173, 364);
            bookListBox.TabIndex = 1;
            bookListBox.SelectedIndexChanged += bookListBox_SelectedIndexChanged;
            // 
            // bookSearchBox
            // 
            bookSearchBox.Location = new Point(98, 28);
            bookSearchBox.Name = "bookSearchBox";
            bookSearchBox.Size = new Size(87, 23);
            bookSearchBox.TabIndex = 2;
            bookSearchBox.TextChanged += bookSearchBox_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 33);
            label1.Name = "label1";
            label1.Size = new Size(80, 15);
            label1.TabIndex = 3;
            label1.Text = "Search Books:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gray;
            panel1.Location = new Point(191, 28);
            panel1.Name = "panel1";
            panel1.Size = new Size(1, 400);
            panel1.TabIndex = 4;
            // 
            // selectedBookPanel
            // 
            selectedBookPanel.Controls.Add(selectedBookEdit);
            selectedBookPanel.Controls.Add(selectedBookDelete);
            selectedBookPanel.Controls.Add(selectedBookFileFormat);
            selectedBookPanel.Controls.Add(selectedBookISBN);
            selectedBookPanel.Controls.Add(selectedBookYear);
            selectedBookPanel.Controls.Add(selectedBookAuthor);
            selectedBookPanel.Controls.Add(selectedBookTitle);
            selectedBookPanel.Controls.Add(label7);
            selectedBookPanel.Controls.Add(selectedBookFileFormatLabel);
            selectedBookPanel.Controls.Add(label5);
            selectedBookPanel.Controls.Add(label4);
            selectedBookPanel.Controls.Add(label3);
            selectedBookPanel.Controls.Add(label2);
            selectedBookPanel.Location = new Point(203, 30);
            selectedBookPanel.Name = "selectedBookPanel";
            selectedBookPanel.Size = new Size(317, 399);
            selectedBookPanel.TabIndex = 5;
            // 
            // selectedBookEdit
            // 
            selectedBookEdit.Location = new Point(94, 156);
            selectedBookEdit.Name = "selectedBookEdit";
            selectedBookEdit.Size = new Size(75, 23);
            selectedBookEdit.TabIndex = 12;
            selectedBookEdit.Text = "Edit";
            selectedBookEdit.UseVisualStyleBackColor = true;
            selectedBookEdit.Click += selectedBookEdit_Click;
            // 
            // selectedBookDelete
            // 
            selectedBookDelete.Location = new Point(13, 156);
            selectedBookDelete.Name = "selectedBookDelete";
            selectedBookDelete.Size = new Size(75, 23);
            selectedBookDelete.TabIndex = 11;
            selectedBookDelete.Text = "Delete";
            selectedBookDelete.UseVisualStyleBackColor = true;
            selectedBookDelete.Click += selectedBookDelete_Click;
            // 
            // selectedBookFileFormat
            // 
            selectedBookFileFormat.AutoSize = true;
            selectedBookFileFormat.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            selectedBookFileFormat.Location = new Point(82, 119);
            selectedBookFileFormat.Name = "selectedBookFileFormat";
            selectedBookFileFormat.Size = new Size(40, 15);
            selectedBookFileFormat.TabIndex = 10;
            selectedBookFileFormat.Text = "label8";
            // 
            // selectedBookISBN
            // 
            selectedBookISBN.AutoSize = true;
            selectedBookISBN.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            selectedBookISBN.Location = new Point(49, 99);
            selectedBookISBN.Name = "selectedBookISBN";
            selectedBookISBN.Size = new Size(40, 15);
            selectedBookISBN.TabIndex = 9;
            selectedBookISBN.Text = "label8";
            // 
            // selectedBookYear
            // 
            selectedBookYear.AutoSize = true;
            selectedBookYear.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            selectedBookYear.Location = new Point(49, 78);
            selectedBookYear.Name = "selectedBookYear";
            selectedBookYear.Size = new Size(40, 15);
            selectedBookYear.TabIndex = 8;
            selectedBookYear.Text = "label8";
            // 
            // selectedBookAuthor
            // 
            selectedBookAuthor.AutoSize = true;
            selectedBookAuthor.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            selectedBookAuthor.Location = new Point(62, 59);
            selectedBookAuthor.Name = "selectedBookAuthor";
            selectedBookAuthor.Size = new Size(40, 15);
            selectedBookAuthor.TabIndex = 7;
            selectedBookAuthor.Text = "label8";
            // 
            // selectedBookTitle
            // 
            selectedBookTitle.AutoSize = true;
            selectedBookTitle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            selectedBookTitle.Location = new Point(49, 39);
            selectedBookTitle.Name = "selectedBookTitle";
            selectedBookTitle.Size = new Size(40, 15);
            selectedBookTitle.TabIndex = 6;
            selectedBookTitle.Text = "label8";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label7.Location = new Point(14, 12);
            label7.Name = "label7";
            label7.Size = new Size(123, 21);
            label7.TabIndex = 5;
            label7.Text = "Selected Book:";
            // 
            // selectedBookFileFormatLabel
            // 
            selectedBookFileFormatLabel.AutoSize = true;
            selectedBookFileFormatLabel.Location = new Point(12, 119);
            selectedBookFileFormatLabel.Name = "selectedBookFileFormatLabel";
            selectedBookFileFormatLabel.Size = new Size(69, 15);
            selectedBookFileFormatLabel.TabIndex = 4;
            selectedBookFileFormatLabel.Text = "File Format:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 99);
            label5.Name = "label5";
            label5.Size = new Size(35, 15);
            label5.TabIndex = 3;
            label5.Text = "ISBN:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(11, 78);
            label4.Name = "label4";
            label4.Size = new Size(32, 15);
            label4.TabIndex = 2;
            label4.Text = "Year:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 59);
            label3.Name = "label3";
            label3.Size = new Size(47, 15);
            label3.TabIndex = 1;
            label3.Text = "Author:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 38);
            label2.Name = "label2";
            label2.Size = new Size(33, 15);
            label2.TabIndex = 0;
            label2.Text = "Title:";
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(532, 450);
            Controls.Add(selectedBookPanel);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(bookSearchBox);
            Controls.Add(bookListBox);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Main";
            Text = "Form1";
            Load += Form_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            selectedBookPanel.ResumeLayout(false);
            selectedBookPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem newToolStripMenuItem;
        private ToolStripMenuItem booksToolStripMenuItem1;
        private ToolStripMenuItem newToolStripMenuItem1;
        private ToolStripMenuItem booksToolStripMenuItem2;
        private ToolStripMenuItem newBookToolStripMenuItem;
        private ToolStripMenuItem newEBookToolStripMenuItem;
        private ListBox bookListBox;
        private TextBox bookSearchBox;
        private Label label1;
        private Panel panel1;
        private Panel selectedBookPanel;
        private Label label3;
        private Label label2;
        private Label selectedBookFileFormat;
        private Label selectedBookISBN;
        private Label selectedBookYear;
        private Label selectedBookAuthor;
        private Label selectedBookTitle;
        private Label label7;
        private Label selectedBookFileFormatLabel;
        private Label label5;
        private Label label4;
        private Button selectedBookEdit;
        private Button selectedBookDelete;
    }
}
