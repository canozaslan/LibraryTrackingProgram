
namespace Library_Tracking_Program
{
    partial class MainScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainScreen));
            this.button_save_book = new System.Windows.Forms.Button();
            this.button_register_user = new System.Windows.Forms.Button();
            this.button_open_bookList = new System.Windows.Forms.Button();
            this.button_open_givenBooks = new System.Windows.Forms.Button();
            this.button_open_missinBooks = new System.Windows.Forms.Button();
            this.button_exit = new System.Windows.Forms.Button();
            this.dgv_members = new System.Windows.Forms.DataGridView();
            this.dgv_books = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_member_no = new System.Windows.Forms.TextBox();
            this.tb_author = new System.Windows.Forms.TextBox();
            this.tb_book_name = new System.Windows.Forms.TextBox();
            this.tb_barcode_no = new System.Windows.Forms.TextBox();
            this.tb_name_surname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dtp_receive_date = new System.Windows.Forms.DateTimePicker();
            this.tb_confirm_name = new System.Windows.Forms.TextBox();
            this.tb_confirm_book = new System.Windows.Forms.TextBox();
            this.tb_book_number = new System.Windows.Forms.TextBox();
            this.tb_confirm_memberNo = new System.Windows.Forms.TextBox();
            this.tb_confirm_barcodeNo = new System.Windows.Forms.TextBox();
            this.button_save = new System.Windows.Forms.Button();
            this.button_open_memberList = new System.Windows.Forms.Button();
            this.label_warning = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_members)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_books)).BeginInit();
            this.SuspendLayout();
            // 
            // button_save_book
            // 
            this.button_save_book.BackColor = System.Drawing.Color.White;
            this.button_save_book.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button_save_book.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button_save_book.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_save_book.Image = ((System.Drawing.Image)(resources.GetObject("button_save_book.Image")));
            this.button_save_book.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_save_book.Location = new System.Drawing.Point(153, 28);
            this.button_save_book.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button_save_book.Name = "button_save_book";
            this.button_save_book.Size = new System.Drawing.Size(107, 82);
            this.button_save_book.TabIndex = 0;
            this.button_save_book.Text = "Kitap Kayıt";
            this.button_save_book.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_save_book.UseVisualStyleBackColor = false;
            this.button_save_book.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_register_user
            // 
            this.button_register_user.BackColor = System.Drawing.Color.White;
            this.button_register_user.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button_register_user.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button_register_user.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_register_user.Image = ((System.Drawing.Image)(resources.GetObject("button_register_user.Image")));
            this.button_register_user.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_register_user.Location = new System.Drawing.Point(302, 28);
            this.button_register_user.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button_register_user.Name = "button_register_user";
            this.button_register_user.Size = new System.Drawing.Size(100, 82);
            this.button_register_user.TabIndex = 1;
            this.button_register_user.Text = "Okuyucu Kayıt";
            this.button_register_user.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_register_user.UseVisualStyleBackColor = false;
            this.button_register_user.Click += new System.EventHandler(this.button_register_user_Click);
            // 
            // button_open_bookList
            // 
            this.button_open_bookList.BackColor = System.Drawing.Color.White;
            this.button_open_bookList.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button_open_bookList.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button_open_bookList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_open_bookList.Image = ((System.Drawing.Image)(resources.GetObject("button_open_bookList.Image")));
            this.button_open_bookList.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_open_bookList.Location = new System.Drawing.Point(583, 28);
            this.button_open_bookList.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button_open_bookList.Name = "button_open_bookList";
            this.button_open_bookList.Size = new System.Drawing.Size(106, 82);
            this.button_open_bookList.TabIndex = 3;
            this.button_open_bookList.Text = "Kitap Listesi";
            this.button_open_bookList.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_open_bookList.UseVisualStyleBackColor = false;
            this.button_open_bookList.Click += new System.EventHandler(this.button_open_bookList_Click);
            // 
            // button_open_givenBooks
            // 
            this.button_open_givenBooks.BackColor = System.Drawing.Color.White;
            this.button_open_givenBooks.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button_open_givenBooks.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button_open_givenBooks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_open_givenBooks.Image = ((System.Drawing.Image)(resources.GetObject("button_open_givenBooks.Image")));
            this.button_open_givenBooks.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_open_givenBooks.Location = new System.Drawing.Point(723, 28);
            this.button_open_givenBooks.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button_open_givenBooks.Name = "button_open_givenBooks";
            this.button_open_givenBooks.Size = new System.Drawing.Size(102, 82);
            this.button_open_givenBooks.TabIndex = 4;
            this.button_open_givenBooks.Text = "Emanet Kitaplar";
            this.button_open_givenBooks.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_open_givenBooks.UseVisualStyleBackColor = false;
            this.button_open_givenBooks.Click += new System.EventHandler(this.button_open_givenBooks_Click);
            // 
            // button_open_missinBooks
            // 
            this.button_open_missinBooks.BackColor = System.Drawing.Color.White;
            this.button_open_missinBooks.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button_open_missinBooks.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button_open_missinBooks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_open_missinBooks.Image = ((System.Drawing.Image)(resources.GetObject("button_open_missinBooks.Image")));
            this.button_open_missinBooks.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_open_missinBooks.Location = new System.Drawing.Point(850, 28);
            this.button_open_missinBooks.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button_open_missinBooks.Name = "button_open_missinBooks";
            this.button_open_missinBooks.Size = new System.Drawing.Size(102, 82);
            this.button_open_missinBooks.TabIndex = 5;
            this.button_open_missinBooks.Text = "Geciken Kitaplar";
            this.button_open_missinBooks.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_open_missinBooks.UseVisualStyleBackColor = false;
            this.button_open_missinBooks.Click += new System.EventHandler(this.button_open_missinBooks_Click);
            // 
            // button_exit
            // 
            this.button_exit.BackColor = System.Drawing.Color.White;
            this.button_exit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button_exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_exit.Image = ((System.Drawing.Image)(resources.GetObject("button_exit.Image")));
            this.button_exit.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_exit.Location = new System.Drawing.Point(987, 28);
            this.button_exit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(90, 82);
            this.button_exit.TabIndex = 6;
            this.button_exit.Text = "Çıkış";
            this.button_exit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_exit.UseVisualStyleBackColor = false;
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
            // 
            // dgv_members
            // 
            this.dgv_members.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_members.Location = new System.Drawing.Point(13, 191);
            this.dgv_members.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgv_members.Name = "dgv_members";
            this.dgv_members.RowTemplate.Height = 25;
            this.dgv_members.Size = new System.Drawing.Size(527, 245);
            this.dgv_members.TabIndex = 7;
            this.dgv_members.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_members_RowHeaderMouseClick);
            // 
            // dgv_books
            // 
            this.dgv_books.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_books.Location = new System.Drawing.Point(583, 191);
            this.dgv_books.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgv_books.Name = "dgv_books";
            this.dgv_books.RowTemplate.Height = 25;
            this.dgv_books.Size = new System.Drawing.Size(655, 245);
            this.dgv_books.TabIndex = 8;
            this.dgv_books.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_books_RowHeaderMouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(154, 148);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "Ad Soyad: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(351, 149);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "Abone No:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(578, 148);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "Barkod No:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(720, 148);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "Kitap Adı:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(909, 148);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 15);
            this.label6.TabIndex = 14;
            this.label6.Text = "Yazar:";
            // 
            // tb_member_no
            // 
            this.tb_member_no.Location = new System.Drawing.Point(421, 145);
            this.tb_member_no.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tb_member_no.Name = "tb_member_no";
            this.tb_member_no.Size = new System.Drawing.Size(58, 21);
            this.tb_member_no.TabIndex = 15;
            this.tb_member_no.TextChanged += new System.EventHandler(this.tb_member_no_TextChanged);
            // 
            // tb_author
            // 
            this.tb_author.Location = new System.Drawing.Point(961, 145);
            this.tb_author.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tb_author.Name = "tb_author";
            this.tb_author.Size = new System.Drawing.Size(100, 21);
            this.tb_author.TabIndex = 16;
            this.tb_author.TextChanged += new System.EventHandler(this.tb_author_TextChanged);
            // 
            // tb_book_name
            // 
            this.tb_book_name.Location = new System.Drawing.Point(784, 145);
            this.tb_book_name.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tb_book_name.Name = "tb_book_name";
            this.tb_book_name.Size = new System.Drawing.Size(106, 21);
            this.tb_book_name.TabIndex = 17;
            this.tb_book_name.TextChanged += new System.EventHandler(this.tb_book_name_TextChanged);
            // 
            // tb_barcode_no
            // 
            this.tb_barcode_no.Location = new System.Drawing.Point(650, 145);
            this.tb_barcode_no.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tb_barcode_no.Name = "tb_barcode_no";
            this.tb_barcode_no.Size = new System.Drawing.Size(52, 21);
            this.tb_barcode_no.TabIndex = 18;
            this.tb_barcode_no.TextChanged += new System.EventHandler(this.tb_barcode_no_TextChanged);
            // 
            // tb_name_surname
            // 
            this.tb_name_surname.Location = new System.Drawing.Point(223, 145);
            this.tb_name_surname.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tb_name_surname.Name = "tb_name_surname";
            this.tb_name_surname.Size = new System.Drawing.Size(100, 21);
            this.tb_name_surname.TabIndex = 19;
            this.tb_name_surname.TextChanged += new System.EventHandler(this.tb_name_surname_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(338, 485);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 15);
            this.label2.TabIndex = 20;
            this.label2.Text = "Teslim Tarihi:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(338, 519);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 15);
            this.label7.TabIndex = 21;
            this.label7.Text = "Ad Soyad:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(338, 549);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 15);
            this.label8.TabIndex = 22;
            this.label8.Text = "Kitap Adı:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(618, 485);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(112, 15);
            this.label9.TabIndex = 23;
            this.label9.Text = "Verilmiş Kitap Sayısı:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(618, 519);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 15);
            this.label10.TabIndex = 24;
            this.label10.Text = "Abone No:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(618, 549);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 15);
            this.label11.TabIndex = 25;
            this.label11.Text = "Barkod No:";
            // 
            // dtp_receive_date
            // 
            this.dtp_receive_date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_receive_date.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dtp_receive_date.Location = new System.Drawing.Point(415, 479);
            this.dtp_receive_date.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dtp_receive_date.Name = "dtp_receive_date";
            this.dtp_receive_date.Size = new System.Drawing.Size(105, 21);
            this.dtp_receive_date.TabIndex = 26;
            // 
            // tb_confirm_name
            // 
            this.tb_confirm_name.Location = new System.Drawing.Point(418, 516);
            this.tb_confirm_name.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tb_confirm_name.Name = "tb_confirm_name";
            this.tb_confirm_name.ReadOnly = true;
            this.tb_confirm_name.Size = new System.Drawing.Size(102, 21);
            this.tb_confirm_name.TabIndex = 27;
            // 
            // tb_confirm_book
            // 
            this.tb_confirm_book.Location = new System.Drawing.Point(418, 546);
            this.tb_confirm_book.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tb_confirm_book.Name = "tb_confirm_book";
            this.tb_confirm_book.ReadOnly = true;
            this.tb_confirm_book.Size = new System.Drawing.Size(102, 21);
            this.tb_confirm_book.TabIndex = 28;
            // 
            // tb_book_number
            // 
            this.tb_book_number.Location = new System.Drawing.Point(730, 482);
            this.tb_book_number.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tb_book_number.Name = "tb_book_number";
            this.tb_book_number.ReadOnly = true;
            this.tb_book_number.Size = new System.Drawing.Size(100, 21);
            this.tb_book_number.TabIndex = 29;
            // 
            // tb_confirm_memberNo
            // 
            this.tb_confirm_memberNo.Location = new System.Drawing.Point(730, 516);
            this.tb_confirm_memberNo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tb_confirm_memberNo.Name = "tb_confirm_memberNo";
            this.tb_confirm_memberNo.ReadOnly = true;
            this.tb_confirm_memberNo.Size = new System.Drawing.Size(100, 21);
            this.tb_confirm_memberNo.TabIndex = 30;
            // 
            // tb_confirm_barcodeNo
            // 
            this.tb_confirm_barcodeNo.Location = new System.Drawing.Point(730, 546);
            this.tb_confirm_barcodeNo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tb_confirm_barcodeNo.Name = "tb_confirm_barcodeNo";
            this.tb_confirm_barcodeNo.ReadOnly = true;
            this.tb_confirm_barcodeNo.Size = new System.Drawing.Size(100, 21);
            this.tb_confirm_barcodeNo.TabIndex = 31;
            // 
            // button_save
            // 
            this.button_save.BackColor = System.Drawing.Color.White;
            this.button_save.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button_save.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_save.Image = ((System.Drawing.Image)(resources.GetObject("button_save.Image")));
            this.button_save.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_save.Location = new System.Drawing.Point(926, 462);
            this.button_save.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(102, 82);
            this.button_save.TabIndex = 32;
            this.button_save.Text = "Kaydet";
            this.button_save.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_save.UseVisualStyleBackColor = false;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // button_open_memberList
            // 
            this.button_open_memberList.BackColor = System.Drawing.Color.White;
            this.button_open_memberList.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_open_memberList.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button_open_memberList.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button_open_memberList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_open_memberList.Image = ((System.Drawing.Image)(resources.GetObject("button_open_memberList.Image")));
            this.button_open_memberList.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_open_memberList.Location = new System.Drawing.Point(438, 28);
            this.button_open_memberList.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button_open_memberList.Name = "button_open_memberList";
            this.button_open_memberList.Size = new System.Drawing.Size(102, 82);
            this.button_open_memberList.TabIndex = 2;
            this.button_open_memberList.Text = "Okuyucu Listesi";
            this.button_open_memberList.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_open_memberList.UseVisualStyleBackColor = false;
            this.button_open_memberList.Click += new System.EventHandler(this.button_open_memberList_Click);
            // 
            // label_warning
            // 
            this.label_warning.AutoSize = true;
            this.label_warning.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_warning.ForeColor = System.Drawing.Color.Red;
            this.label_warning.Location = new System.Drawing.Point(321, 451);
            this.label_warning.Name = "label_warning";
            this.label_warning.Size = new System.Drawing.Size(0, 19);
            this.label_warning.TabIndex = 33;
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1251, 579);
            this.Controls.Add(this.label_warning);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.tb_confirm_barcodeNo);
            this.Controls.Add(this.tb_confirm_memberNo);
            this.Controls.Add(this.tb_book_number);
            this.Controls.Add(this.tb_confirm_book);
            this.Controls.Add(this.tb_confirm_name);
            this.Controls.Add(this.dtp_receive_date);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_name_surname);
            this.Controls.Add(this.tb_barcode_no);
            this.Controls.Add(this.tb_book_name);
            this.Controls.Add(this.tb_author);
            this.Controls.Add(this.tb_member_no);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_books);
            this.Controls.Add(this.dgv_members);
            this.Controls.Add(this.button_exit);
            this.Controls.Add(this.button_open_missinBooks);
            this.Controls.Add(this.button_open_givenBooks);
            this.Controls.Add(this.button_open_bookList);
            this.Controls.Add(this.button_open_memberList);
            this.Controls.Add(this.button_register_user);
            this.Controls.Add(this.button_save_book);
            this.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "MainScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kütüphane Kitap Takip Programı";
            this.Load += new System.EventHandler(this.MainScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_members)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_books)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_save_book;
        private System.Windows.Forms.Button button_register_user;
        private System.Windows.Forms.Button button_open_bookList;
        private System.Windows.Forms.Button button_open_givenBooks;
        private System.Windows.Forms.Button button_open_missinBooks;
        private System.Windows.Forms.Button button_exit;
        private System.Windows.Forms.DataGridView dgv_members;
        private System.Windows.Forms.DataGridView dgv_books;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_member_no;
        private System.Windows.Forms.TextBox tb_author;
        private System.Windows.Forms.TextBox tb_book_name;
        private System.Windows.Forms.TextBox tb_barcode_no;
        private System.Windows.Forms.TextBox tb_name_surname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dtp_receive_date;
        private System.Windows.Forms.TextBox tb_confirm_name;
        private System.Windows.Forms.TextBox tb_confirm_book;
        private System.Windows.Forms.TextBox tb_book_number;
        private System.Windows.Forms.TextBox tb_confirm_memberNo;
        private System.Windows.Forms.TextBox tb_confirm_barcodeNo;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.Button button_open_memberList;
        private System.Windows.Forms.Label label_warning;
    }
}

