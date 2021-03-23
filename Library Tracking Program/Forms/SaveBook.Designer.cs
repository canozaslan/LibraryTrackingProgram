
namespace Library_Tracking_Program
{
    partial class SaveBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SaveBook));
            this.label_warning = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button_save = new System.Windows.Forms.Button();
            this.button_exit = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.tb_book_name = new System.Windows.Forms.TextBox();
            this.tb_author_name = new System.Windows.Forms.TextBox();
            this.tb_editor = new System.Windows.Forms.TextBox();
            this.cb_category = new System.Windows.Forms.ComboBox();
            this.cb_buying_style = new System.Windows.Forms.ComboBox();
            this.dtp_buying_date = new System.Windows.Forms.DateTimePicker();
            this.tb_stock_number = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label_warning
            // 
            this.label_warning.AutoSize = true;
            this.label_warning.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_warning.ForeColor = System.Drawing.Color.Red;
            this.label_warning.Location = new System.Drawing.Point(12, 262);
            this.label_warning.Name = "label_warning";
            this.label_warning.Size = new System.Drawing.Size(0, 19);
            this.label_warning.TabIndex = 0;
            this.label_warning.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kitap Adı:*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Yazar Adı:*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Yayın Evi:*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Kitap Türü:*";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "Temin Biçimi:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 190);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 15);
            this.label7.TabIndex = 6;
            this.label7.Text = "Temin Tarihi:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 218);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 15);
            this.label8.TabIndex = 7;
            this.label8.Text = "Stok Sayısı:*";
            // 
            // button_save
            // 
            this.button_save.BackColor = System.Drawing.Color.White;
            this.button_save.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button_save.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_save.Image = ((System.Drawing.Image)(resources.GetObject("button_save.Image")));
            this.button_save.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_save.Location = new System.Drawing.Point(41, 303);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(103, 80);
            this.button_save.TabIndex = 8;
            this.button_save.Text = "Kaydet";
            this.button_save.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_save.UseVisualStyleBackColor = false;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // button_exit
            // 
            this.button_exit.BackColor = System.Drawing.Color.White;
            this.button_exit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button_exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_exit.Image = ((System.Drawing.Image)(resources.GetObject("button_exit.Image")));
            this.button_exit.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_exit.Location = new System.Drawing.Point(191, 303);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(101, 80);
            this.button_exit.TabIndex = 9;
            this.button_exit.Text = "Çıkış";
            this.button_exit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_exit.UseVisualStyleBackColor = false;
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(35, 411);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(221, 15);
            this.label9.TabIndex = 10;
            this.label9.Text = "* işaretli alanlar doldurulmak zorundadır.";
            // 
            // tb_book_name
            // 
            this.tb_book_name.Location = new System.Drawing.Point(107, 20);
            this.tb_book_name.Name = "tb_book_name";
            this.tb_book_name.Size = new System.Drawing.Size(200, 23);
            this.tb_book_name.TabIndex = 12;
            // 
            // tb_author_name
            // 
            this.tb_author_name.Location = new System.Drawing.Point(107, 55);
            this.tb_author_name.Name = "tb_author_name";
            this.tb_author_name.Size = new System.Drawing.Size(200, 23);
            this.tb_author_name.TabIndex = 13;
            // 
            // tb_editor
            // 
            this.tb_editor.Location = new System.Drawing.Point(107, 86);
            this.tb_editor.Name = "tb_editor";
            this.tb_editor.Size = new System.Drawing.Size(200, 23);
            this.tb_editor.TabIndex = 14;
            // 
            // cb_category
            // 
            this.cb_category.FormattingEnabled = true;
            this.cb_category.Location = new System.Drawing.Point(107, 116);
            this.cb_category.Name = "cb_category";
            this.cb_category.Size = new System.Drawing.Size(200, 23);
            this.cb_category.TabIndex = 15;
            // 
            // cb_buying_style
            // 
            this.cb_buying_style.FormattingEnabled = true;
            this.cb_buying_style.Location = new System.Drawing.Point(107, 149);
            this.cb_buying_style.Name = "cb_buying_style";
            this.cb_buying_style.Size = new System.Drawing.Size(200, 23);
            this.cb_buying_style.TabIndex = 16;
            // 
            // dtp_buying_date
            // 
            this.dtp_buying_date.Location = new System.Drawing.Point(107, 184);
            this.dtp_buying_date.Name = "dtp_buying_date";
            this.dtp_buying_date.Size = new System.Drawing.Size(200, 23);
            this.dtp_buying_date.TabIndex = 17;
            // 
            // tb_stock_number
            // 
            this.tb_stock_number.Location = new System.Drawing.Point(107, 215);
            this.tb_stock_number.Name = "tb_stock_number";
            this.tb_stock_number.Size = new System.Drawing.Size(200, 23);
            this.tb_stock_number.TabIndex = 18;
            // 
            // SaveBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 435);
            this.Controls.Add(this.tb_stock_number);
            this.Controls.Add(this.dtp_buying_date);
            this.Controls.Add(this.cb_buying_style);
            this.Controls.Add(this.cb_category);
            this.Controls.Add(this.tb_editor);
            this.Controls.Add(this.tb_author_name);
            this.Controls.Add(this.tb_book_name);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button_exit);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label_warning);
            this.Name = "SaveBook";
            this.Text = "Kitap Kaydet";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_warning;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.Button button_exit;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tb_book_name;
        private System.Windows.Forms.TextBox tb_author_name;
        private System.Windows.Forms.TextBox tb_editor;
        private System.Windows.Forms.ComboBox cb_category;
        private System.Windows.Forms.ComboBox cb_buying_style;
        private System.Windows.Forms.DateTimePicker dtp_buying_date;
        private System.Windows.Forms.TextBox tb_stock_number;
    }
}