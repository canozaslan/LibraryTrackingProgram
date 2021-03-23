using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Library_Tracking_Program
{
    public partial class RegisterUser : Form
    {
        LibraryOperations operations = new LibraryOperations();
        List<string> genders = new List<string> { "Kadın", "Erkek" };
        public RegisterUser()
        {
            InitializeComponent();
            cb_gender.DataSource = genders;
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            if (tb_tc_no.Text.Trim().Equals("")||tb_name_surname.Text.Trim().Equals("")||tb_born_city.Text.Trim().Equals("")||tb_phone_no.Text.Trim().Equals(""))
            {
                label_warning.Text = "* işaretli alanlar doldurulmak zorundadır.";
            }
            else
            {
                try
                {
                    LibraryMember member = new LibraryMember
                    {
                        IdentificationNumber = tb_tc_no.Text.ToString().Trim(),
                        NameSurname = tb_name_surname.Text.ToString(),
                        SchoolName = tb_school.Text.ToString(),
                        BornPlace = tb_born_city.Text.ToString(),
                        BornDate = dtp_born_date.Value,
                        PhoneNumber = tb_phone_no.Text.ToString().Trim(),
                        Email = tb_email.Text.ToString(),
                        MembershipDate = tb_membership_date.Value,
                        Gender = cb_gender.Text.ToString(),
                        Address = tb_address.Text.ToString(),
                        BookCount = 0,
                        Status = UserStatus.Aktif
                    };
                    operations.AddMember(member);

                    ClearFields();
                    label_warning.Text = $"{member.NameSurname} kullanıcısı başarıyla sisteme kaydedildi.";
                }
                catch (Exception ex)
                {
                    label_warning.Text = "Kayıt sırasında bir hata meydana geldi.";
                    throw ex;
                }
            }

        }
        public void ClearFields()
        {
            tb_tc_no.Text = "";
            tb_name_surname.Text = "";
            tb_school.Text = "";
            tb_born_city.Text = "";
            dtp_born_date.Text = "";
            tb_phone_no.Text = "";
            tb_email.Text = "";
            tb_membership_date.Text = "";
            cb_gender.Text = "";
            tb_address.Text = "";
        }

    }
}
