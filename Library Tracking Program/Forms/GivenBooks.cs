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
    public partial class GivenBooks : Form
    {
        MainScreen main = new MainScreen();
        LibraryOperations operations = new LibraryOperations();
        public ProcurementRecord record = new ProcurementRecord();
        LibraryMember member;
        public DataGridViewRow row;
        public GivenBooks()
        {
            InitializeComponent();
            
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            main.Show();
            this.Hide();
        }

        private void button_receive_Click(object sender, EventArgs e)
        {
            if (row == null)
            {
                label_warning.Text = "Önce bir satır seçiniz.";
            }
            else
            {
                ReceiveForm receive = new ReceiveForm(record,member);
                receive.Show();
            }
            
        }

        private void tb_member_no_TextChanged(object sender, EventArgs e)
        {
            dgv_given_books.DataSource = operations.SearchInt(dgv_given_books, "entrustedbooks", 1, tb_member_no.Text.ToString(), $"EmanetDurumu='{(int)RecordStatus.Abonede}'");
        }

        private void tb_name_surname_TextChanged(object sender, EventArgs e)
        {
            dgv_given_books.DataSource = operations.SearchString(dgv_given_books, "entrustedbooks", 2, tb_name_surname.Text.ToString(), $"EmanetDurumu='{(int)RecordStatus.Abonede}'");
        }

        private void tb_barcode_no_TextChanged(object sender, EventArgs e)
        {
            dgv_given_books.DataSource = operations.SearchInt(dgv_given_books, "entrustedbooks", 3, tb_barcode_no.Text.ToString(), $"EmanetDurumu='{(int)RecordStatus.Abonede}'");
        }

        private void tb_book_name_TextChanged(object sender, EventArgs e)
        {
            dgv_given_books.DataSource = operations.SearchString(dgv_given_books, "entrustedbooks", 4, tb_book_name.Text.ToString(), $"EmanetDurumu='{(int)RecordStatus.Abonede}'");
        }

        private void dgv_given_books_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int selectedRow = e.RowIndex;
            row = dgv_given_books.Rows[selectedRow];
            record = operations.SelectRecord(row);
            member = operations.SelectMemberWithId(record.MembershipNumber);
        }

        private void GivenBooks_Load(object sender, EventArgs e)
        {
            dgv_given_books.DataSource = operations.ShowFilteredTable("entrustedbooks",$"EmanetDurumu='{(int)RecordStatus.Abonede}'");
            /*if (form.receiveStatus == true)
            {
                label_warning.Text = $"{row.Cells[4].Value} isimli kitap {row.Cells[2].Value} kulanıcısından başarıyla teslim alındı.";
                System.Threading.Thread.Sleep(5000);
                form.receiveStatus = false;
            }
            else
            {
                label_warning.Text = "";
            }*/
        }
    }
}
