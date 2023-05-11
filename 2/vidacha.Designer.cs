namespace _2
{
    partial class vidacha
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
            label4 = new Label();
            kniga_edit_vidacha = new TextBox();
            chitatel_edit_vadacha = new TextBox();
            data_vidachi_edit_vidacha = new TextBox();
            data_vozvrata_edit_vidacha = new TextBox();
            save_vidacha = new Button();
            Exit_vidacha = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(14, 29);
            label1.Name = "label1";
            label1.Size = new Size(66, 28);
            label1.TabIndex = 0;
            label1.Text = "Книга";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(14, 87);
            label2.Name = "label2";
            label2.Size = new Size(94, 28);
            label2.TabIndex = 1;
            label2.Text = "Читатель";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(14, 145);
            label3.Name = "label3";
            label3.Size = new Size(128, 28);
            label3.TabIndex = 2;
            label3.Text = "Дата выдачи";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(14, 205);
            label4.Name = "label4";
            label4.Size = new Size(112, 28);
            label4.TabIndex = 3;
            label4.Text = "Дата сдачи";
            // 
            // kniga_edit_vidacha
            // 
            kniga_edit_vidacha.Location = new Point(146, 32);
            kniga_edit_vidacha.Margin = new Padding(3, 4, 3, 4);
            kniga_edit_vidacha.Name = "kniga_edit_vidacha";
            kniga_edit_vidacha.Size = new Size(114, 27);
            kniga_edit_vidacha.TabIndex = 4;
            // 
            // chitatel_edit_vadacha
            // 
            chitatel_edit_vadacha.Location = new Point(146, 89);
            chitatel_edit_vadacha.Margin = new Padding(3, 4, 3, 4);
            chitatel_edit_vadacha.Name = "chitatel_edit_vadacha";
            chitatel_edit_vadacha.Size = new Size(114, 27);
            chitatel_edit_vadacha.TabIndex = 5;
            // 
            // data_vidachi_edit_vidacha
            // 
            data_vidachi_edit_vidacha.Location = new Point(146, 148);
            data_vidachi_edit_vidacha.Margin = new Padding(3, 4, 3, 4);
            data_vidachi_edit_vidacha.Name = "data_vidachi_edit_vidacha";
            data_vidachi_edit_vidacha.Size = new Size(114, 27);
            data_vidachi_edit_vidacha.TabIndex = 6;
            // 
            // data_vozvrata_edit_vidacha
            // 
            data_vozvrata_edit_vidacha.Location = new Point(146, 208);
            data_vozvrata_edit_vidacha.Margin = new Padding(3, 4, 3, 4);
            data_vozvrata_edit_vidacha.Name = "data_vozvrata_edit_vidacha";
            data_vozvrata_edit_vidacha.Size = new Size(114, 27);
            data_vozvrata_edit_vidacha.TabIndex = 7;
            // 
            // save_vidacha
            // 
            save_vidacha.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            save_vidacha.Location = new Point(25, 280);
            save_vidacha.Margin = new Padding(3, 4, 3, 4);
            save_vidacha.Name = "save_vidacha";
            save_vidacha.Size = new Size(105, 41);
            save_vidacha.TabIndex = 8;
            save_vidacha.Text = "Сохранить";
            save_vidacha.UseVisualStyleBackColor = true;
            save_vidacha.Click += save_vidacha_Click;
            // 
            // Exit_vidacha
            // 
            Exit_vidacha.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Exit_vidacha.Location = new Point(155, 280);
            Exit_vidacha.Margin = new Padding(3, 4, 3, 4);
            Exit_vidacha.Name = "Exit_vidacha";
            Exit_vidacha.Size = new Size(105, 41);
            Exit_vidacha.TabIndex = 9;
            Exit_vidacha.Text = "Отмена";
            Exit_vidacha.UseVisualStyleBackColor = true;
            Exit_vidacha.Click += Exit_vidacha_Click;
            // 
            // vidacha
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(302, 355);
            Controls.Add(Exit_vidacha);
            Controls.Add(save_vidacha);
            Controls.Add(data_vozvrata_edit_vidacha);
            Controls.Add(data_vidachi_edit_vidacha);
            Controls.Add(chitatel_edit_vadacha);
            Controls.Add(kniga_edit_vidacha);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "vidacha";
            Text = "Выдача";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox kniga_edit_vidacha;
        private TextBox chitatel_edit_vadacha;
        private TextBox data_vidachi_edit_vidacha;
        private TextBox data_vozvrata_edit_vidacha;
        private Button save_vidacha;
        private Button Exit_vidacha;
    }
}