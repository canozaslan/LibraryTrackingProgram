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
    public partial class ReceiveForm : Form
    {
        LibraryOperations operations = new LibraryOperations();
        ProcurementRecord _record;
        LibraryMember _member;
        public bool receiveStatus = false;
        public ReceiveForm(ProcurementRecord record, LibraryMember member)
        {
            _record = record;
            _member = member;
            var list = new List<Stats>() { Stats.Kütüphanede, Stats.Abonede, Stats.Hasarlı, Stats.Kayıp };
            InitializeComponent();
            cb_book_status.DataSource = list;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button_ok_Click(object sender, EventArgs e)
        {
            if (_record.RStatus == RecordStatus.Abonede)
            {
                _record.RStatus = RecordStatus.TeslimAlınmış;
                operations.UpdateProcurementRecord(_record);
                operations.UpdateBookStatus((Stats)(cb_book_status.SelectedIndex+1), _record);
                _member.BookCount -= 1;
                operations.UpdateMember(_member);
            }
            else if (_record.RStatus == RecordStatus.Gecikmiş)
            {
                _record.RStatus = RecordStatus.TeslimAlınmış;
                operations.UpdateProcurementRecord(_record);
                operations.UpdateBookStatus((Stats)(cb_book_status.SelectedIndex+1), _record);
            }

            receiveStatus = true;
            this.Hide();
        }

        private void ReceiveForm_Load(object sender, EventArgs e)
        {
  
                tb_name_surname.Text = _record.NameSurname.ToString();
                tb_book_name.Text = _record.BookName.ToString();
        }
    }
}
