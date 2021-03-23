using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Library_Tracking_Program
{
    public partial class SaveBook : Form
    {
        LibraryOperations operations = new LibraryOperations();
        List<string> categories = new List<string> { "Roman","Ansiklopedi","Biyografi"};
        List<string> buyingStyles = new List<string> { "Satın Alma","Bireysel Bağış", "Kurumsal Bağış"};
        public SaveBook()
        {
            InitializeComponent();
            cb_buying_style.DataSource = buyingStyles;
            cb_category.DataSource = categories; 
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            if (tb_book_name.Text.ToString().Trim().Equals("") || tb_author_name.Text.ToString().Trim().Equals("") || cb_category.Text.ToString().Trim().Equals("") || tb_editor.Text.ToString().Trim().Equals("") || tb_stock_number.Text.ToString().Trim().Equals(""))
            {
                label_warning.Text = "* işaretli alanlar doldurulmak zorundadır.";
            }
            else
            {
                try
                {
                    LibraryBook book = new LibraryBook
                    {
                        BarcodeNo = 1,
                        BookName = tb_book_name.Text.ToString(),
                        AuthorName = tb_author_name.Text.ToString(),
                        PublishingHome = tb_editor.Text.ToString(),
                        Category = cb_category.SelectedItem.ToString(),
                        ProcurementType = cb_buying_style.SelectedItem.ToString(),
                        ProcurementDate = dtp_buying_date.Value,
                        St = Stats.Kütüphanede,
                        StockNumber = Convert.ToInt32(tb_stock_number.Text.ToString())
                    };

                    operations.AddBook(book);
                    ClearFields();

                    label_warning.Text = $"{book.BookName} kitabı başarıyla sisteme kaydedildi.";
                }
                catch (Exception)
                {
                    label_warning.Text = "Kayıt işlemi sırasında bir hata meydana geldi.";
                    throw;
                }

            }
        }
        public void ClearFields()
        {
            tb_book_name.Text = "";
            tb_author_name.Text = "";
            tb_editor.Text = "";
            cb_category.Text = "";
            cb_buying_style.Text = "";
            dtp_buying_date.Text = "";
            tb_stock_number.Text = "";
        }
    }
}
