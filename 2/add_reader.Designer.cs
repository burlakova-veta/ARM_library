namespace _2
{
    partial class add_reader
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            add_last_name = new TextBox();
            add_first_name = new TextBox();
            add_patronymic = new TextBox();
            label4 = new Label();
            add_phone = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(56, 39);
            label1.Name = "label1";
            label1.Size = new Size(73, 20);
            label1.TabIndex = 0;
            label1.Text = "Фамилия";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(57, 124);
            label2.Name = "label2";
            label2.Size = new Size(72, 20);
            label2.TabIndex = 1;
            label2.Text = "Отчество";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(90, 82);
            label3.Name = "label3";
            label3.Size = new Size(39, 20);
            label3.TabIndex = 2;
            label3.Text = "Имя";
            label3.Click += label3_Click;
            // 
            // add_last_name
            // 
            add_last_name.Location = new Point(148, 32);
            add_last_name.Name = "add_last_name";
            add_last_name.Size = new Size(261, 27);
            add_last_name.TabIndex = 3;
            // 
            // add_first_name
            // 
            add_first_name.Location = new Point(148, 75);
            add_first_name.Name = "add_first_name";
            add_first_name.Size = new Size(261, 27);
            add_first_name.TabIndex = 4;
            // 
            // add_patronymic
            // 
            add_patronymic.Location = new Point(148, 117);
            add_patronymic.Name = "add_patronymic";
            add_patronymic.Size = new Size(261, 27);
            add_patronymic.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(2, 171);
            label4.Name = "label4";
            label4.Size = new Size(127, 20);
            label4.TabIndex = 6;
            label4.Text = "Номер телефона";
            // 
            // add_phone
            // 
            add_phone.Location = new Point(148, 164);
            add_phone.Name = "add_phone";
            add_phone.Size = new Size(261, 27);
            add_phone.TabIndex = 7;
            // 
            // button1
            // 
            button1.Location = new Point(166, 235);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 8;
            button1.Text = "Сохранить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // add_reader
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(427, 287);
            Controls.Add(button1);
            Controls.Add(add_phone);
            Controls.Add(label4);
            Controls.Add(add_patronymic);
            Controls.Add(add_first_name);
            Controls.Add(add_last_name);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "add_reader";
            Text = "add_reader";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox add_last_name;
        private TextBox add_first_name;
        private TextBox add_patronymic;
        private Label label4;
        private TextBox add_phone;
        private Button button1;
    }
}