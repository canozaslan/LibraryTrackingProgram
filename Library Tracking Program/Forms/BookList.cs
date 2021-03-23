using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Library_Tracking_Program
{
    public partial class BookList : Form
    {
        MainScreen main = new MainScreen();
        LibraryOperations operations = new LibraryOperations();
        DataGridViewRow row;
        public BookList()
        {
            InitializeComponent();
            dgv_book_list.DataSource = operations.ShowTables("books");
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            main.Show();
            this.Hide();
        }

        private void dgv_book_list_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int selectedRow = e.RowIndex;
            row = dgv_book_list.Rows[selectedRow];
        }

        private void tb_category_TextChanged(object sender, EventArgs e)
        {
            dgv_book_list.DataSource = operations.SearchString(dgv_book_list, "books", 4, tb_category.Text.ToString());
        }

        private void tb_publishing_home_TextChanged(object sender, EventArgs e)
        {
            dgv_book_list.DataSource = operations.SearchString(dgv_book_list, "books", 3, tb_publishing_home.Text.ToString());
        }

        private void tb_author_TextChanged(object sender, EventArgs e)
        {
            dgv_book_list.DataSource = operations.SearchString(dgv_book_list, "books", 2, tb_author.Text.ToString());
        }

        private void tb_book_name_TextChanged(object sender, EventArgs e)
        {
            dgv_book_list.DataSource = operations.SearchString(dgv_book_list, "books", 1, tb_book_name.Text.ToString());
        }

        private void tb_barcode_no_TextChanged(object sender, EventArgs e)
        {
            dgv_book_list.DataSource = operations.SearchInt(dgv_book_list, "books", 0, tb_barcode_no.Text.ToString());
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            if (row == null)
            {
                label_warning.Text = "Silmeden önce bir kitap seçiniz.";
            }
            else
            {
                operations.DeleteBook(Convert.ToInt32(row.Cells[0].Value.ToString()));
                label_warning.Text = $"{row.Cells[1].Value} kitabı başarıyla sistemden silindi.";
            }

        }
    }
}
