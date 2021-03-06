
namespace Library_Tracking_Program
{
    partial class GivenBooks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GivenBooks));
            this.dgv_given_books = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_member_no = new System.Windows.Forms.TextBox();
            this.tb_name_surname = new System.Windows.Forms.TextBox();
            this.tb_barcode_no = new System.Windows.Forms.TextBox();
            this.tb_book_name = new System.Windows.Forms.TextBox();
            this.button_exit = new System.Windows.Forms.Button();
            this.button_receive = new System.Windows.Forms.Button();
            this.label_warning = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_given_books)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_given_books
            // 
            this.dgv_given_books.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_given_books.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_given_books.Location = new System.Drawing.Point(12, 80);
            this.dgv_given_books.Name = "dgv_given_books";
            this.dgv_given_books.RowTemplate.Height = 25;
            this.dgv_given_books.Size = new System.Drawing.Size(1013, 222);
            this.dgv_given_books.TabIndex = 0;
            this.dgv_given_books.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_given_books_RowHeaderMouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Abone No:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(218, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ad Soyad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(550, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Barkod No:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(758, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Kitap Adı:";
            // 
            // tb_member_no
            // 
            this.tb_member_no.Location = new System.Drawing.Point(82, 36);
            this.tb_member_no.Name = "tb_member_no";
            this.tb_member_no.Size = new System.Drawing.Size(121, 23);
            this.tb_member_no.TabIndex = 5;
            this.tb_member_no.TextChanged += new System.EventHandler(this.tb_member_no_TextChanged);
            // 
            // tb_name_surname
            // 
            this.tb_name_surname.Location = new System.Drawing.Point(284, 36);
            this.tb_name_surname.Name = "tb_name_surname";
            this.tb_name_surname.Size = new System.Drawing.Size(155, 23);
            this.tb_name_surname.TabIndex = 6;
            this.tb_name_surname.TextChanged += new System.EventHandler(this.tb_name_surname_TextChanged);
            // 
            // tb_barcode_no
            // 
            this.tb_barcode_no.Location = new System.Drawing.Point(622, 36);
            this.tb_barcode_no.Name = "tb_barcode_no";
            this.tb_barcode_no.Size = new System.Drawing.Size(115, 23);
            this.tb_barcode_no.TabIndex = 7;
            this.tb_barcode_no.TextChanged += new System.EventHandler(this.tb_barcode_no_TextChanged);
            // 
            // tb_book_name
            // 
            this.tb_book_name.Location = new System.Drawing.Point(822, 36);
            this.tb_book_name.Name = "tb_book_name";
            this.tb_book_name.Size = new System.Drawing.Size(136, 23);
            this.tb_book_name.TabIndex = 8;
            this.tb_book_name.TextChanged += new System.EventHandler(this.tb_book_name_TextChanged);
            // 
            // button_exit
            // 
            this.button_exit.BackColor = System.Drawing.Color.White;
            this.button_exit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button_exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_exit.Image = ((System.Drawing.Image)(resources.GetObject("button_exit.Image")));
            this.button_exit.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_exit.Location = new System.Drawing.Point(842, 338);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(136, 84);
            this.button_exit.TabIndex = 9;
            this.button_exit.Text = "Çıkış";
            this.button_exit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_exit.UseVisualStyleBackColor = false;
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
            // 
            // button_receive
            // 
            this.button_receive.BackColor = System.Drawing.Color.White;
            this.button_receive.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button_receive.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button_receive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_receive.Image = ((System.Drawing.Image)(resources.GetObject("button_receive.Image")));
            this.button_receive.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_receive.Location = new System.Drawing.Point(622, 338);
            this.button_receive.Name = "button_receive";
            this.button_receive.Size = new System.Drawing.Size(147, 84);
            this.button_receive.TabIndex = 10;
            this.button_receive.Text = "Teslim Al";
            this.button_receive.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_receive.UseVisualStyleBackColor = false;
            this.button_receive.Click += new System.EventHandler(this.button_receive_Click);
            // 
            // label_warning
            // 
            this.label_warning.AutoSize = true;
            this.label_warning.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_warning.ForeColor = System.Drawing.Color.Red;
            this.label_warning.Location = new System.Drawing.Point(46, 338);
            this.label_warning.Name = "label_warning";
            this.label_warning.Size = new System.Drawing.Size(0, 19);
            this.label_warning.TabIndex = 11;
            // 
            // GivenBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 450);
            this.Controls.Add(this.label_warning);
            this.Controls.Add(this.button_receive);
            this.Controls.Add(this.button_exit);
            this.Controls.Add(this.tb_book_name);
            this.Controls.Add(this.tb_barcode_no);
            this.Controls.Add(this.tb_name_surname);
            this.Controls.Add(this.tb_member_no);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_given_books);
            this.Name = "GivenBooks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Emanet Verilen Kitaplar";
            this.Load += new System.EventHandler(this.GivenBooks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_given_books)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_given_books;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_member_no;
        private System.Windows.Forms.TextBox tb_name_surname;
        private System.Windows.Forms.TextBox tb_barcode_no;
        private System.Windows.Forms.TextBox tb_book_name;
        private System.Windows.Forms.Button button_exit;
        private System.Windows.Forms.Button button_receive;
        private System.Windows.Forms.Label label_warning;
    }
}