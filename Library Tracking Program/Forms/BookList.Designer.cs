
namespace Library_Tracking_Program
{
    partial class BookList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookList));
            this.dgv_book_list = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_exit = new System.Windows.Forms.Button();
            this.tb_barcode_no = new System.Windows.Forms.TextBox();
            this.tb_book_name = new System.Windows.Forms.TextBox();
            this.tb_author = new System.Windows.Forms.TextBox();
            this.tb_publishing_home = new System.Windows.Forms.TextBox();
            this.tb_category = new System.Windows.Forms.TextBox();
            this.label_warning = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_book_list)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_book_list
            // 
            this.dgv_book_list.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_book_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_book_list.Location = new System.Drawing.Point(12, 71);
            this.dgv_book_list.Name = "dgv_book_list";
            this.dgv_book_list.RowTemplate.Height = 25;
            this.dgv_book_list.Size = new System.Drawing.Size(934, 229);
            this.dgv_book_list.TabIndex = 0;
            this.dgv_book_list.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_book_list_RowHeaderMouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Barkod No:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(201, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kitap Adı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(383, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Kitap Yazarı:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(575, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Yayın Evi:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(755, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "Kitap Türü:";
            // 
            // button_delete
            // 
            this.button_delete.BackColor = System.Drawing.Color.White;
            this.button_delete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button_delete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_delete.Image = ((System.Drawing.Image)(resources.GetObject("button_delete.Image")));
            this.button_delete.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_delete.Location = new System.Drawing.Point(609, 334);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(111, 80);
            this.button_delete.TabIndex = 6;
            this.button_delete.Text = "Sil";
            this.button_delete.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_delete.UseVisualStyleBackColor = false;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // button_exit
            // 
            this.button_exit.BackColor = System.Drawing.Color.White;
            this.button_exit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button_exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_exit.Image = ((System.Drawing.Image)(resources.GetObject("button_exit.Image")));
            this.button_exit.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_exit.Location = new System.Drawing.Point(782, 334);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(111, 80);
            this.button_exit.TabIndex = 7;
            this.button_exit.Text = "Çıkış";
            this.button_exit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_exit.UseVisualStyleBackColor = false;
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
            // 
            // tb_barcode_no
            // 
            this.tb_barcode_no.Location = new System.Drawing.Point(84, 30);
            this.tb_barcode_no.Name = "tb_barcode_no";
            this.tb_barcode_no.Size = new System.Drawing.Size(100, 23);
            this.tb_barcode_no.TabIndex = 8;
            this.tb_barcode_no.TextChanged += new System.EventHandler(this.tb_barcode_no_TextChanged);
            // 
            // tb_book_name
            // 
            this.tb_book_name.Location = new System.Drawing.Point(265, 30);
            this.tb_book_name.Name = "tb_book_name";
            this.tb_book_name.Size = new System.Drawing.Size(100, 23);
            this.tb_book_name.TabIndex = 9;
            this.tb_book_name.TextChanged += new System.EventHandler(this.tb_book_name_TextChanged);
            // 
            // tb_author
            // 
            this.tb_author.Location = new System.Drawing.Point(459, 30);
            this.tb_author.Name = "tb_author";
            this.tb_author.Size = new System.Drawing.Size(100, 23);
            this.tb_author.TabIndex = 10;
            this.tb_author.TextChanged += new System.EventHandler(this.tb_author_TextChanged);
            // 
            // tb_publishing_home
            // 
            this.tb_publishing_home.Location = new System.Drawing.Point(637, 30);
            this.tb_publishing_home.Name = "tb_publishing_home";
            this.tb_publishing_home.Size = new System.Drawing.Size(100, 23);
            this.tb_publishing_home.TabIndex = 11;
            this.tb_publishing_home.TextChanged += new System.EventHandler(this.tb_publishing_home_TextChanged);
            // 
            // tb_category
            // 
            this.tb_category.Location = new System.Drawing.Point(825, 30);
            this.tb_category.Name = "tb_category";
            this.tb_category.Size = new System.Drawing.Size(100, 23);
            this.tb_category.TabIndex = 12;
            this.tb_category.TextChanged += new System.EventHandler(this.tb_category_TextChanged);
            // 
            // label_warning
            // 
            this.label_warning.AutoSize = true;
            this.label_warning.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_warning.ForeColor = System.Drawing.Color.Red;
            this.label_warning.Location = new System.Drawing.Point(154, 334);
            this.label_warning.Name = "label_warning";
            this.label_warning.Size = new System.Drawing.Size(0, 19);
            this.label_warning.TabIndex = 13;
            // 
            // BookList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 450);
            this.Controls.Add(this.label_warning);
            this.Controls.Add(this.tb_category);
            this.Controls.Add(this.tb_publishing_home);
            this.Controls.Add(this.tb_author);
            this.Controls.Add(this.tb_book_name);
            this.Controls.Add(this.tb_barcode_no);
            this.Controls.Add(this.button_exit);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_book_list);
            this.Name = "BookList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kitap Listesi";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_book_list)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_book_list;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_exit;
        private System.Windows.Forms.TextBox tb_barcode_no;
        private System.Windows.Forms.TextBox tb_book_name;
        private System.Windows.Forms.TextBox tb_author;
        private System.Windows.Forms.TextBox tb_publishing_home;
        private System.Windows.Forms.TextBox tb_category;
        private System.Windows.Forms.Label label_warning;
    }
}