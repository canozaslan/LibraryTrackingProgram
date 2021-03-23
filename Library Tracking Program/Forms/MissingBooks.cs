using Library_Tracking_Program.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Library_Tracking_Program
{
    public partial class MissingBooks : Form
    {
        MainScreen main = new MainScreen();
        public ProcurementRecord record;
        LibraryOperations operations = new LibraryOperations();
        LibraryMember member;
        ReceiveForm form;
        DataGridViewRow row;
        public MissingBooks()
        {
            InitializeComponent();
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            main.Show();
            this.Hide();
        }

        private void tb_member_no_TextChanged(object sender, EventArgs e)
        {
            dgv_missing_books.DataSource = operations.SearchInt(dgv_missing_books, "entrustedbooks", 1, tb_member_no.Text.ToString(), $"TeslimTarihi < '{DateTime.Now.ToString("yyyy-MM-dd H:mm:ss")}'");
        }

        private void tb_name_surname_TextChanged(object sender, EventArgs e)
        {
            dgv_missing_books.DataSource = operations.SearchString(dgv_missing_books, "entrustedbooks", 2, tb_name_surname.Text.ToString(), $"TeslimTarihi < '{DateTime.Now.ToString("yyyy-MM-dd H:mm:ss")}'"); ;
        }

        private void tb_barcode_no_TextChanged(object sender, EventArgs e)
        {
            dgv_missing_books.DataSource = operations.SearchInt(dgv_missing_books, "entrustedbooks", 3, tb_barcode_no.Text.ToString(), $"TeslimTarihi < '{DateTime.Now.ToString("yyyy-MM-dd H:mm:ss")}'");
        }

        private void tb_book_name_TextChanged(object sender, EventArgs e)
        {
            dgv_missing_books.DataSource = operations.SearchString(dgv_missing_books, "entrustedbooks", 4, tb_book_name.Text.ToString(), $"TeslimTarihi < '{DateTime.Now.ToString("yyyy-MM-dd H:mm:ss")}'");
        }

        private void button_receive_Click(object sender, EventArgs e)
        {
            if (row == null)
            {
                label_warning.Text = "Önce bir satır seçin.";
            }
            else
            {
                form = new ReceiveForm(record,member);
                form.Show();
            }
        }
        private void dgv_missing_books_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int selectedRow = e.RowIndex;
            row = dgv_missing_books.Rows[selectedRow];
            record = operations.SelectRecord(row);
            member = operations.SelectMemberWithId(record.MembershipNumber);
        }
        private void button_ban_user_Click(object sender, EventArgs e)
        {
            if (row == null)
            {
                label_warning.Text = "Önce bir satır seçin.";
            }
            else
            {
                operations.BanMember(record);
                label_warning.Text = $"{record.NameSurname} kullanıcısı sistemden engellendi.";
            }
        }
        private void MissingBooks_Load(object sender, EventArgs e)
        {
            form = new ReceiveForm(record,member);
            dgv_missing_books.DataSource = operations.ShowMissingsTable("entrustedbooks");
            if (form.receiveStatus == true)
            {
                label_warning.Text = $"{row.Cells[4].Value} isimli kitap {row.Cells[2].Value} kullanıcısından teslim alındı.";
                System.Threading.Thread.Sleep(5000);
                form.receiveStatus = false;
            }
            else
            {
                label_warning.Text = "";
            }
        }
    }
}
