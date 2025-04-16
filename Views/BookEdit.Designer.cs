namespace IHNRYA_Beadando.Views
{
    partial class BookEdit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            titleBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            authorBox = new TextBox();
            label3 = new Label();
            yearBox = new NumericUpDown();
            label4 = new Label();
            isbnBox = new TextBox();
            button1 = new Button();
            fileFormatTextBox = new TextBox();
            fileFormatTextBoxLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)yearBox).BeginInit();
            SuspendLayout();
            // 
            // titleBox
            // 
            titleBox.Location = new Point(68, 11);
            titleBox.Name = "titleBox";
            titleBox.Size = new Size(168, 23);
            titleBox.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 16);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.No;
            label1.Size = new Size(33, 15);
            label1.TabIndex = 1;
            label1.Text = "Title:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 45);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.No;
            label2.Size = new Size(47, 15);
            label2.TabIndex = 3;
            label2.Text = "Author:";
            // 
            // authorBox
            // 
            authorBox.Location = new Point(68, 40);
            authorBox.Name = "authorBox";
            authorBox.Size = new Size(168, 23);
            authorBox.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 74);
            label3.Name = "label3";
            label3.RightToLeft = RightToLeft.No;
            label3.Size = new Size(32, 15);
            label3.TabIndex = 5;
            label3.Text = "Year:";
            // 
            // yearBox
            // 
            yearBox.Location = new Point(68, 72);
            yearBox.Maximum = new decimal(new int[] { 2025, 0, 0, 0 });
            yearBox.Minimum = new decimal(new int[] { 1900, 0, 0, 0 });
            yearBox.Name = "yearBox";
            yearBox.Size = new Size(168, 23);
            yearBox.TabIndex = 6;
            yearBox.Value = new decimal(new int[] { 2005, 0, 0, 0 });
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 106);
            label4.Name = "label4";
            label4.RightToLeft = RightToLeft.No;
            label4.Size = new Size(35, 15);
            label4.TabIndex = 8;
            label4.Text = "ISBN:";
            // 
            // isbnBox
            // 
            isbnBox.Location = new Point(68, 101);
            isbnBox.Name = "isbnBox";
            isbnBox.Size = new Size(168, 23);
            isbnBox.TabIndex = 7;
            // 
            // button1
            // 
            button1.Location = new Point(161, 159);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 9;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // fileFormatTextBox
            // 
            fileFormatTextBox.Location = new Point(90, 130);
            fileFormatTextBox.Name = "fileFormatTextBox";
            fileFormatTextBox.Size = new Size(146, 23);
            fileFormatTextBox.TabIndex = 10;
            // 
            // fileFormatTextBoxLabel
            // 
            fileFormatTextBoxLabel.AutoSize = true;
            fileFormatTextBoxLabel.Location = new Point(15, 135);
            fileFormatTextBoxLabel.Name = "fileFormatTextBoxLabel";
            fileFormatTextBoxLabel.RightToLeft = RightToLeft.No;
            fileFormatTextBoxLabel.Size = new Size(69, 15);
            fileFormatTextBoxLabel.TabIndex = 11;
            fileFormatTextBoxLabel.Text = "File Format:";
            // 
            // BookEdit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(254, 213);
            Controls.Add(fileFormatTextBoxLabel);
            Controls.Add(fileFormatTextBox);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(isbnBox);
            Controls.Add(yearBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(authorBox);
            Controls.Add(label1);
            Controls.Add(titleBox);
            Name = "BookEdit";
            Text = "New Book";
            Load += BookEdit_Load;
            ((System.ComponentModel.ISupportInitialize)yearBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button1;
        private Label fileFormatTextBoxLabel;
        protected TextBox fileFormatTextBox;
        protected TextBox titleBox;
        protected TextBox authorBox;
        protected NumericUpDown yearBox;
        protected TextBox isbnBox;
    }
}