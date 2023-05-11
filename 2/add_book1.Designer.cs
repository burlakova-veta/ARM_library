namespace _2
{
    partial class add_book1
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
            save_button_book = new Button();
            add_year_book = new NumericUpDown();
            add_avtor_book = new TextBox();
            add_name_book = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)add_year_book).BeginInit();
            SuspendLayout();
            // 
            // save_button_book
            // 
            save_button_book.Location = new Point(105, 163);
            save_button_book.Name = "save_button_book";
            save_button_book.Size = new Size(156, 37);
            save_button_book.TabIndex = 13;
            save_button_book.Text = "Сохранить";
            save_button_book.UseVisualStyleBackColor = true;
            save_button_book.Click += save_button_book_Click;
            // 
            // add_year_book
            // 
            add_year_book.Location = new Point(93, 112);
            add_year_book.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            add_year_book.Name = "add_year_book";
            add_year_book.Size = new Size(223, 27);
            add_year_book.TabIndex = 12;
            // 
            // add_avtor_book
            // 
            add_avtor_book.Location = new Point(93, 65);
            add_avtor_book.Name = "add_avtor_book";
            add_avtor_book.Size = new Size(223, 27);
            add_avtor_book.TabIndex = 11;
            // 
            // add_name_book
            // 
            add_name_book.Location = new Point(93, 20);
            add_name_book.Name = "add_name_book";
            add_name_book.Size = new Size(223, 27);
            add_name_book.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(10, 112);
            label3.Name = "label3";
            label3.Size = new Size(33, 20);
            label3.TabIndex = 9;
            label3.Text = "Год";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 68);
            label2.Name = "label2";
            label2.Size = new Size(51, 20);
            label2.TabIndex = 8;
            label2.Text = "Автор";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 23);
            label1.Name = "label1";
            label1.Size = new Size(77, 20);
            label1.TabIndex = 7;
            label1.Text = "Название";
            // 
            // add_book1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(355, 237);
            Controls.Add(save_button_book);
            Controls.Add(add_year_book);
            Controls.Add(add_avtor_book);
            Controls.Add(add_name_book);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "add_book1";
            Text = "add_book1";
            ((System.ComponentModel.ISupportInitialize)add_year_book).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button save_button_book;
        private NumericUpDown add_year_book;
        private TextBox add_avtor_book;
        private TextBox add_name_book;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}