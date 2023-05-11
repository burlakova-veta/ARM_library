namespace _2
{
    partial class update_book
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
            update_button_book = new Button();
            update_year_book = new NumericUpDown();
            update_avtor_book = new TextBox();
            update_name_book = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)update_year_book).BeginInit();
            SuspendLayout();
            // 
            // update_button_book
            // 
            update_button_book.Location = new Point(107, 162);
            update_button_book.Name = "update_button_book";
            update_button_book.Size = new Size(156, 37);
            update_button_book.TabIndex = 20;
            update_button_book.Text = "Сохранить";
            update_button_book.UseVisualStyleBackColor = true;
            update_button_book.Click += update_button_book_Click;
            // 
            // update_year_book
            // 
            update_year_book.Location = new Point(95, 111);
            update_year_book.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            update_year_book.Name = "update_year_book";
            update_year_book.Size = new Size(223, 27);
            update_year_book.TabIndex = 19;
            // 
            // update_avtor_book
            // 
            update_avtor_book.Location = new Point(95, 64);
            update_avtor_book.Name = "update_avtor_book";
            update_avtor_book.Size = new Size(223, 27);
            update_avtor_book.TabIndex = 18;
            // 
            // update_name_book
            // 
            update_name_book.Location = new Point(95, 19);
            update_name_book.Name = "update_name_book";
            update_name_book.Size = new Size(223, 27);
            update_name_book.TabIndex = 17;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 111);
            label3.Name = "label3";
            label3.Size = new Size(33, 20);
            label3.TabIndex = 16;
            label3.Text = "Год";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 67);
            label2.Name = "label2";
            label2.Size = new Size(51, 20);
            label2.TabIndex = 15;
            label2.Text = "Автор";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 22);
            label1.Name = "label1";
            label1.Size = new Size(77, 20);
            label1.TabIndex = 14;
            label1.Text = "Название";
            // 
            // update_book
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(341, 246);
            Controls.Add(update_button_book);
            Controls.Add(update_year_book);
            Controls.Add(update_avtor_book);
            Controls.Add(update_name_book);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "update_book";
            Text = "update_book";
            ((System.ComponentModel.ISupportInitialize)update_year_book).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button update_button_book;
        private NumericUpDown update_year_book;
        private TextBox update_avtor_book;
        private TextBox update_name_book;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}