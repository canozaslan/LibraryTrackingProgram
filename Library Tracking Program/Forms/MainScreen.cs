using Library_Tracking_Program.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Tracking_Program
{
    public partial class MainScreen : Form
    {
        LibraryOperations operations = new LibraryOperations();
        DataGridViewRow UserRow;
        DataGridViewRow BookRow;
        LibraryMember member = new LibraryMember();
        LibraryBook book = new LibraryBook();
        ProcurementRecord record;
        public MainScreen()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            SaveBook savebook = new SaveBook();
            savebook.Show();
        }

        private void button_register_user_Click(object sender, EventArgs e)
        {
            RegisterUser register = new RegisterUser();
            register.Show();
        }

        private void button_open_memberList_Click(object sender, EventArgs e)
        {
            UserList users = new UserList();
            users.Show();
            this.Hide();
        }

        private void button_open_bookList_Click(object sender, EventArgs e)
        {
            BookList books = new BookList();
            books.Show();
            this.Hide();
        }

        private void button_open_givenBooks_Click(object sender, EventArgs e)
        {
            GivenBooks givenBooks = new GivenBooks();
            givenBooks.Show();
            this.Hide();
        }

        private void button_open_missinBooks_Click(object sender, EventArgs e)
        {
            MissingBooks missingBooks = new MissingBooks();
            missingBooks.Show();
            this.Hide();
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tb_name_surname_TextChanged(object sender, EventArgs e)
        {
            dgv_members.DataSource = operations.SearchString(dgv_members, "members", 1, tb_name_surname.Text.ToString());

        }

        private void tb_member_no_TextChanged(object sender, EventArgs e)
        {
            dgv_members.DataSource = operations.SearchInt(dgv_members, "members", 0, tb_member_no.Text.ToString());
        }

        private void tb_barcode_no_TextChanged(object sender, EventArgs e)
        {
            dgv_books.DataSource = operations.SearchInt(dgv_books, "books", 0, tb_barcode_no.Text.ToString(),$"Durum = '{((int)Stats.Kütüphanede).ToString()}'");
        }

        private void tb_book_name_TextChanged(object sender, EventArgs e)
        {
            dgv_books.DataSource = operations.SearchString(dgv_books, "books", 1, tb_book_name.Text.ToString(),$"Durum = '{((int)Stats.Kütüphanede).ToString()}'");
        }

        private void tb_author_TextChanged(object sender, EventArgs e)
        {
            dgv_books.DataSource = operations.SearchString(dgv_books, "books", 2, tb_author.Text.ToString(),$"Durum = '{((int)Stats.Kütüphanede).ToString()}'");
        }

        private void dgv_members_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int selectedRow = e.RowIndex;
            UserRow = dgv_members.Rows[selectedRow];
            member = operations.SelectMember(UserRow);

            tb_confirm_memberNo.Text = member.MembershipNumber.ToString();
            tb_confirm_name.Text = member.NameSurname;
            tb_book_number.Text = member.BookCount.ToString();
        }

        private void dgv_books_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int selectedRow = e.RowIndex;
            BookRow = dgv_books.Rows[selectedRow];
            book = operations.SelectBook(BookRow);

            tb_confirm_barcodeNo.Text = book.BarcodeNo.ToString();
            tb_confirm_book.Text = book.BookName;
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            DateTime receiveDate = dtp_receive_date.Value;
            record = new ProcurementRecord() { MembershipNumber = member.MembershipNumber, NameSurname = member.NameSurname, BarcodeNo = book.BarcodeNo, BookName = book.BookName, GivenTime = receiveDate, TakenTime = DateTime.Now, RStatus = RecordStatus.Abonede };

            operations.AddProcurementRecord(record);
            operations.UpdateBookStatus(Stats.Abonede,record);
            member.BookCount += 1;
            operations.UpdateMember(member);

            ClearFields();
            operations.ShowTables("members");
            operations.ShowTables("books");
            label_warning.Text = $"Kitap teslim kaydı başarıyla gerçekleştirildi. {member.MembershipNumber} nolu abone {book.BarcodeNo} nolu {book.BookName} kitabını aldı.";
        }
        public void ClearFields()
        {
            tb_member_no.Text = "";
            tb_name_surname.Text = "";
            tb_barcode_no.Text = "";
            tb_book_name.Text = "";
            tb_author.Text = "";
            tb_confirm_memberNo.Text = "";
            tb_confirm_name.Text = "";
            tb_confirm_barcodeNo.Text = "";
            tb_confirm_book.Text = "";
            tb_book_number.Text = "";
        }

        private void MainScreen_Load(object sender, EventArgs e)
        {
            dgv_books.DataSource = operations.ShowFilteredTable("books",$"Durum = '{((int)Stats.Kütüphanede).ToString()}'");
            dgv_members.DataSource = operations.ShowTables("members");
        }
    }
}
