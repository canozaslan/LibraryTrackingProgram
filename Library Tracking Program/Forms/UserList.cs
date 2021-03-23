using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Library_Tracking_Program
{
    public partial class UserList : Form
    {
        MainScreen main = new MainScreen();
        LibraryOperations operations = new LibraryOperations();
        DataGridViewRow row;
        public UserList()
        {
            InitializeComponent();
            dgv_user_list.DataSource = operations.ShowTables("members");
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            this.Hide();
            main.Show();
        }

        private void tb_member_no_TextChanged(object sender, EventArgs e)
        {
            dgv_user_list.DataSource = operations.SearchInt(dgv_user_list, "members", 0, tb_member_no.Text.ToString());
        }

        private void tb_tc_no_TextChanged(object sender, EventArgs e)
        {
            dgv_user_list.DataSource = operations.SearchString(dgv_user_list, "members", 2, tb_tc_no.Text.ToString());
        }

        private void tb_name_surname_TextChanged(object sender, EventArgs e)
        {
            dgv_user_list.DataSource = operations.SearchString(dgv_user_list, "members", 1, tb_name_surname.Text.ToString());
        }

        private void tb_born_place_TextChanged(object sender, EventArgs e)
        {
            dgv_user_list.DataSource = operations.SearchString(dgv_user_list, "members", 4, tb_born_place.Text.ToString());
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            if (row == null)
            {
                label_warning.Text = "İşlem yapmadan önce bir abone seçin.";
            }
            else
            {
                operations.DeleteMember(Convert.ToInt32(row.Cells[0].Value.ToString()));
                label_warning.Text = $"{row.Cells[1].Value} kullanıcısı başarıyla sistemden silindi.";
            }

        }

        private void dgv_user_list_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int selectedRow = e.RowIndex;
            row = dgv_user_list.Rows[selectedRow];
        }
    }
}
