namespace _2
{
    partial class Form1
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
            readers_table = new TabControl();
            tabPage1 = new TabPage();
            vidacha_table = new DataGridView();
            update_button = new Button();
            groupBox1 = new GroupBox();
            delete_landing_button = new Button();
            edit_landing_button = new Button();
            add_landing_button = new Button();
            tabPage2 = new TabPage();
            Book_table = new DataGridView();
            update_button_knigi = new Button();
            groupBox2 = new GroupBox();
            delete_landing2_button = new Button();
            edit_landing2_button = new Button();
            add_landing2_button = new Button();
            tabPage3 = new TabPage();
            dataGridView3 = new DataGridView();
            update_button_chitateli = new Button();
            groupBox3 = new GroupBox();
            delete_landing3_button = new Button();
            edit_landing3_button = new Button();
            add_landing3_button = new Button();
            readers_table.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)vidacha_table).BeginInit();
            groupBox1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Book_table).BeginInit();
            groupBox2.SuspendLayout();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // readers_table
            // 
            readers_table.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            readers_table.Controls.Add(tabPage1);
            readers_table.Controls.Add(tabPage2);
            readers_table.Controls.Add(tabPage3);
            readers_table.Location = new Point(0, 0);
            readers_table.Name = "readers_table";
            readers_table.SelectedIndex = 0;
            readers_table.Size = new Size(585, 384);
            readers_table.TabIndex = 0;
            readers_table.SelectedIndexChanged += tabControl1_SelectedIndexChanged_1;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(vidacha_table);
            tabPage1.Controls.Add(update_button);
            tabPage1.Controls.Add(groupBox1);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(577, 351);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Выдача";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // vidacha_table
            // 
            vidacha_table.AllowUserToAddRows = false;
            vidacha_table.AllowUserToDeleteRows = false;
            vidacha_table.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            vidacha_table.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            vidacha_table.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            vidacha_table.Location = new Point(3, 81);
            vidacha_table.Margin = new Padding(3, 4, 3, 4);
            vidacha_table.Name = "vidacha_table";
            vidacha_table.ReadOnly = true;
            vidacha_table.RowHeadersWidth = 51;
            vidacha_table.RowTemplate.Height = 25;
            vidacha_table.Size = new Size(565, 262);
            vidacha_table.TabIndex = 2;
            vidacha_table.CellContentClick += dataGridView1_CellContentClick_1;
            vidacha_table.SelectionChanged += dataGridView1_SelectionChanged;
            // 
            // update_button
            // 
            update_button.Location = new Point(325, 32);
            update_button.Name = "update_button";
            update_button.Size = new Size(94, 29);
            update_button.TabIndex = 1;
            update_button.Text = "Обновить";
            update_button.UseVisualStyleBackColor = true;
            update_button.Click += update_button_Click_1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(delete_landing_button);
            groupBox1.Controls.Add(edit_landing_button);
            groupBox1.Controls.Add(add_landing_button);
            groupBox1.Location = new Point(8, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(311, 69);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Управление";
            // 
            // delete_landing_button
            // 
            delete_landing_button.Location = new Point(208, 27);
            delete_landing_button.Name = "delete_landing_button";
            delete_landing_button.Size = new Size(94, 29);
            delete_landing_button.TabIndex = 2;
            delete_landing_button.Text = "Удалить";
            delete_landing_button.UseVisualStyleBackColor = true;
            delete_landing_button.Click += delete_landing_button_Click;
            // 
            // edit_landing_button
            // 
            edit_landing_button.Location = new Point(106, 27);
            edit_landing_button.Name = "edit_landing_button";
            edit_landing_button.Size = new Size(94, 29);
            edit_landing_button.TabIndex = 1;
            edit_landing_button.Text = "Изменить";
            edit_landing_button.UseVisualStyleBackColor = true;
            // 
            // add_landing_button
            // 
            add_landing_button.Location = new Point(6, 27);
            add_landing_button.Name = "add_landing_button";
            add_landing_button.Size = new Size(94, 29);
            add_landing_button.TabIndex = 0;
            add_landing_button.Text = "Добавить";
            add_landing_button.UseVisualStyleBackColor = true;
            add_landing_button.Click += add_landing_button_Click;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(Book_table);
            tabPage2.Controls.Add(update_button_knigi);
            tabPage2.Controls.Add(groupBox2);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(577, 351);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Книги";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // Book_table
            // 
            Book_table.AllowUserToAddRows = false;
            Book_table.AllowUserToDeleteRows = false;
            Book_table.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Book_table.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Book_table.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Book_table.Location = new Point(6, 83);
            Book_table.Name = "Book_table";
            Book_table.ReadOnly = true;
            Book_table.RowHeadersWidth = 51;
            Book_table.RowTemplate.Height = 29;
            Book_table.Size = new Size(566, 262);
            Book_table.TabIndex = 3;
            // 
            // update_button_knigi
            // 
            update_button_knigi.Location = new Point(325, 32);
            update_button_knigi.Name = "update_button_knigi";
            update_button_knigi.Size = new Size(94, 29);
            update_button_knigi.TabIndex = 2;
            update_button_knigi.Text = "Обновить";
            update_button_knigi.UseVisualStyleBackColor = true;
            update_button_knigi.Click += update_button_knigi_Click_1;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(delete_landing2_button);
            groupBox2.Controls.Add(edit_landing2_button);
            groupBox2.Controls.Add(add_landing2_button);
            groupBox2.Location = new Point(8, 5);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(311, 69);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Управление";
            // 
            // delete_landing2_button
            // 
            delete_landing2_button.Location = new Point(208, 27);
            delete_landing2_button.Name = "delete_landing2_button";
            delete_landing2_button.Size = new Size(94, 29);
            delete_landing2_button.TabIndex = 2;
            delete_landing2_button.Text = "Удалить";
            delete_landing2_button.UseVisualStyleBackColor = true;
            delete_landing2_button.Click += delete_landing2_button_Click;
            // 
            // edit_landing2_button
            // 
            edit_landing2_button.Location = new Point(106, 27);
            edit_landing2_button.Name = "edit_landing2_button";
            edit_landing2_button.Size = new Size(94, 29);
            edit_landing2_button.TabIndex = 1;
            edit_landing2_button.Text = "Изменить";
            edit_landing2_button.UseVisualStyleBackColor = true;
            edit_landing2_button.Click += edit_landing2_button_Click;
            // 
            // add_landing2_button
            // 
            add_landing2_button.Location = new Point(6, 27);
            add_landing2_button.Name = "add_landing2_button";
            add_landing2_button.Size = new Size(94, 29);
            add_landing2_button.TabIndex = 0;
            add_landing2_button.Text = "Добавить";
            add_landing2_button.UseVisualStyleBackColor = true;
            add_landing2_button.Click += add_landing2_button_Click;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(dataGridView3);
            tabPage3.Controls.Add(update_button_chitateli);
            tabPage3.Controls.Add(groupBox3);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(577, 351);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Читатели";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // dataGridView3
            // 
            dataGridView3.AllowUserToAddRows = false;
            dataGridView3.AllowUserToDeleteRows = false;
            dataGridView3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView3.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Location = new Point(3, 79);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.ReadOnly = true;
            dataGridView3.RowHeadersWidth = 51;
            dataGridView3.RowTemplate.Height = 29;
            dataGridView3.Size = new Size(566, 262);
            dataGridView3.TabIndex = 4;
            // 
            // update_button_chitateli
            // 
            update_button_chitateli.Location = new Point(325, 29);
            update_button_chitateli.Name = "update_button_chitateli";
            update_button_chitateli.Size = new Size(94, 29);
            update_button_chitateli.TabIndex = 3;
            update_button_chitateli.Text = "Обновить";
            update_button_chitateli.UseVisualStyleBackColor = true;
            update_button_chitateli.Click += update_button_chitateli_Click_1;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(delete_landing3_button);
            groupBox3.Controls.Add(edit_landing3_button);
            groupBox3.Controls.Add(add_landing3_button);
            groupBox3.Location = new Point(8, 3);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(311, 69);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Управление";
            // 
            // delete_landing3_button
            // 
            delete_landing3_button.Location = new Point(208, 27);
            delete_landing3_button.Name = "delete_landing3_button";
            delete_landing3_button.Size = new Size(94, 29);
            delete_landing3_button.TabIndex = 2;
            delete_landing3_button.Text = "Удалить";
            delete_landing3_button.UseVisualStyleBackColor = true;
            delete_landing3_button.Click += delete_landing3_button_Click;
            // 
            // edit_landing3_button
            // 
            edit_landing3_button.Location = new Point(106, 27);
            edit_landing3_button.Name = "edit_landing3_button";
            edit_landing3_button.Size = new Size(94, 29);
            edit_landing3_button.TabIndex = 1;
            edit_landing3_button.Text = "Изменить";
            edit_landing3_button.UseVisualStyleBackColor = true;
            // 
            // add_landing3_button
            // 
            add_landing3_button.Location = new Point(6, 27);
            add_landing3_button.Name = "add_landing3_button";
            add_landing3_button.Size = new Size(94, 29);
            add_landing3_button.TabIndex = 0;
            add_landing3_button.Text = "Добавить";
            add_landing3_button.UseVisualStyleBackColor = true;
            add_landing3_button.Click += add_landing3_button_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(585, 384);
            Controls.Add(readers_table);
            Name = "Form1";
            Text = "Библиотека";
            Load += Form1_Load_1;
            readers_table.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)vidacha_table).EndInit();
            groupBox1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Book_table).EndInit();
            groupBox2.ResumeLayout(false);
            tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl readers_table;
        private TabPage tabPage1;
        private Button update_button;
        private GroupBox groupBox1;
        private Button delete_landing_button;
        private Button edit_landing_button;
        private Button add_landing_button;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private DataGridView Book_table;
        private Button update_button_knigi;
        private GroupBox groupBox2;
        private Button delete_landing2_button;
        private Button edit_landing2_button;
        private Button add_landing2_button;
        private GroupBox groupBox3;
        private Button delete_landing3_button;
        private Button edit_landing3_button;
        private Button add_landing3_button;
        private DataGridView dataGridView3;
        private Button update_button_chitateli;
        private DataGridView vidacha_table;
    }
}