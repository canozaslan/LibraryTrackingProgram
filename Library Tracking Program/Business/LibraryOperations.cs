using Library_Tracking_Program.Entities;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace Library_Tracking_Program
{
    class LibraryOperations
    {
        Database database = new Database();
        LibraryMember member = new LibraryMember();
        LibraryBook book = new LibraryBook();
        ProcurementRecord record = new ProcurementRecord();
        int number;
        public LibraryOperations()
        {

        }
        public DataTable ShowTables(string tableName)
        {
            database.Open();
            MySqlCommand cmd = database.conn.CreateCommand();
            string query = $"Select * from {tableName}";

            try
            {
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();

                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
                return dt;
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                database.Close();
            }

        }
        public DataTable ShowFilteredTable(string tableName, string where)
        {
            database.Open();
            MySqlCommand cmd = database.conn.CreateCommand();
            string query = $"Select * from {tableName} where {where}";

            try
            {
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();

                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
                return dt;
            }
            catch (Exception e)
            {

                throw e;
            }
            finally
            {
                database.Close();
            }
        }
        public DataTable ShowMissingsTable(string tableName)
        {
            database.Open();
            MySqlCommand cmd = database.conn.CreateCommand();
            string query = $"Select * from {tableName} where TeslimTarihi < '{DateTime.Now.ToString("yyyy-MM-dd H:mm:ss")}' and EmanetDurumu = '1'";

            try
            {
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();

                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
                return dt;
            }
            catch (Exception e)
            {

                throw e;
            }
            finally
            {
                database.Close();
            }
        }
        public DataView SearchString(DataGridView table, string tableName, int columnNumber, string searchedWord)
        {
            database.Open();
            DataTable model = ShowTables(tableName);
            DataView dv = model.DefaultView;
            dv.RowFilter = $"{table.Columns[columnNumber].HeaderText} LIKE '{searchedWord}%'";
            database.Close();
            return dv;

        }
        public DataView SearchString(DataGridView table, string tableName, int columnNumber, string searchedWord, string where)
        {
            database.Open();
            DataTable model = ShowTables(tableName);
            DataView dv = model.DefaultView;
            dv.RowFilter = $"{table.Columns[columnNumber].HeaderText} LIKE '{searchedWord}%' and {where}";
            database.Close();
            return dv;

        }
        public DataView SearchInt(DataGridView table, string tableName, int columnNumber, string searchedNumber)
        {
            database.Open();
            DataTable model = ShowTables(tableName);
            DataView dv = model.DefaultView;
            string word = string.Empty;
            for (int i = 0; i < searchedNumber.Length; i++)
            {
                if (Char.IsDigit(searchedNumber[i]))
                {
                    word += searchedNumber[i];
                }
            }

            if (!searchedNumber.Equals(""))
            {
                if (word.Length > 0)
                {
                    number = int.Parse(word);
                    dv.RowFilter = $"{table.Columns[columnNumber].HeaderText} = '{number}'";
                }
                else
                {
                    dv.RowFilter = $"{table.Columns[2].HeaderText} LIKE '%'";
                }
                database.Close();
                return dv;
            }
            else
            {
                dv.RowFilter = $"{table.Columns[2].HeaderText} LIKE '{searchedNumber}%'";
                database.Close();
                return dv;
            }
        }
        public DataView SearchInt(DataGridView table, string tableName, int columnNumber, string searchedNumber, string where)
        {
            database.Open();
            DataTable model = ShowTables(tableName);
            DataView dv = model.DefaultView;
            string word = string.Empty;
            for (int i = 0; i < searchedNumber.Length; i++)
            {
                if (Char.IsDigit(searchedNumber[i]))
                {
                    word += searchedNumber[i];
                }
            }

            if (!searchedNumber.Equals(""))
            {
                if (word.Length > 0)
                {
                    number = int.Parse(word);
                    dv.RowFilter = $"{table.Columns[columnNumber].HeaderText} = '{number}' and {where}";
                }
                else
                {
                    dv.RowFilter = $"{table.Columns[2].HeaderText} LIKE '%' and {where}";
                }
                database.Close();
                return dv;
            }
            else
            {
                dv.RowFilter = $"{table.Columns[2].HeaderText} LIKE '{searchedNumber}%' and {where}";
                database.Close();
                return dv;
            }
        }
        public void AddProcurementRecord(ProcurementRecord record)
        {
            string query = $"Insert Into entrustedbooks (AboneNo, AdSoyad, BarkodNo, KitapAdı, EmanetDurumu, AlınmaTarihi, TeslimTarihi) " +
                $"Values ('{record.MembershipNumber}','{record.NameSurname}','{record.BarcodeNo}','{record.BookName}', {(int)record.RStatus},'{record.TakenTime.ToString("yyyy-MM-dd H:mm:ss")}','{record.GivenTime.ToString("yyyy-MM-dd H:mm:ss")}')";

            ExecuteQuery(query);
        }
        public void UpdateProcurementRecord(ProcurementRecord record)
        {
            string query = $" Update entrustedbooks set EmanetDurumu = {(int)record.RStatus} where id = {record.Id}";
            ExecuteQuery(query);
        }
        public LibraryBook SelectBook(DataGridViewRow row)
        {
            book.BarcodeNo = Convert.ToInt32(row.Cells[0].Value.ToString());
            book.BookName = row.Cells[1].Value.ToString();
            book.AuthorName = row.Cells[2].Value.ToString();
            book.PublishingHome = row.Cells[3].Value.ToString();
            book.Category = row.Cells[4].Value.ToString();
            book.ProcurementType = row.Cells[5].Value.ToString();
            book.ProcurementDate = Convert.ToDateTime(row.Cells[6].Value);
            book.St = (Stats)Convert.ToInt32(row.Cells[7].Value.ToString());
            return book;
        }
        public LibraryMember SelectMember(DataGridViewRow row)
        {
            member.MembershipNumber = Convert.ToInt32(row.Cells[0].Value.ToString());
            member.NameSurname = row.Cells[1].Value.ToString();
            member.IdentificationNumber = row.Cells[2].Value.ToString();
            member.BornDate = Convert.ToDateTime(row.Cells[3].Value);
            member.BornPlace = row.Cells[4].Value.ToString();
            member.PhoneNumber = row.Cells[5].Value.ToString();
            member.Email = row.Cells[6].Value.ToString();
            member.MembershipDate = Convert.ToDateTime(row.Cells[7].Value);
            member.Gender = row.Cells[8].Value.ToString();
            member.SchoolName = row.Cells[9].Value.ToString();
            member.Address = row.Cells[10].Value.ToString();
            member.BookCount = Convert.ToInt32(row.Cells[11].Value.ToString());
            member.Status = (UserStatus)Convert.ToInt32((row.Cells[12].Value.ToString()));
            return member;
        }
        public LibraryMember SelectMemberWithId(int id)
        {
            database.conn.Open();
            MySqlCommand cmd = database.conn.CreateCommand();
            string query = $"Select * from members where AboneNo = '{id}'";

            try
            {
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = query;
                var reader = cmd.ExecuteReader();

                int aboNo = reader.GetOrdinal("AboneNo");
                int boNo = reader.GetOrdinal("KitapSayısı");

                while (reader.Read())
                {
                    member.MembershipNumber = reader.GetInt32(aboNo);
                    member.BookCount = reader.GetInt32(boNo);
                }

                return member;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                database.Close();
            }

        }
        public ProcurementRecord SelectRecord(DataGridViewRow row)
        {
            record.Id = Convert.ToInt32(row.Cells[0].Value.ToString());
            record.MembershipNumber = Convert.ToInt32(row.Cells[1].Value.ToString());
            record.NameSurname = row.Cells[2].Value.ToString();
            record.BarcodeNo = Convert.ToInt32(row.Cells[3].Value.ToString());
            record.BookName = row.Cells[4].Value.ToString();
            record.TakenTime = Convert.ToDateTime(row.Cells[6].Value);
            record.GivenTime = Convert.ToDateTime(row.Cells[7].Value);
            record.RStatus = (RecordStatus)Convert.ToInt32(row.Cells[5].Value.ToString());
            return record;
        }
        public void AddMember(LibraryMember member)
        {
            string query = $"Insert into members (AboneNo,AdSoyad,TcKimlikNo,DoğumGünü,DoğumYeri,TelefonNumarası,EpostaAdresi,ÜyelikTarihi,Cinsiyet,OkulAdı,Adres,KitapSayısı,Durumu) " +
                $"Values ('{member.MembershipNumber}','{member.NameSurname}','{member.IdentificationNumber}','{member.BornDate.ToString("yyyy-MM-dd H:mm:ss")}','{member.BornPlace}','{member.PhoneNumber}','{member.Email}','{member.MembershipDate.ToString("yyyy-MM-dd H:mm:ss")}','{member.Gender}','{member.SchoolName}','{member.Address}',0,{(int)UserStatus.Aktif})";
            ExecuteQuery(query);
        }

        private void ExecuteQuery(string query)
        {
            database.Open();
            MySqlCommand cmd = database.conn.CreateCommand();

            try
            {
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {

                throw e;
            }
            finally
            {
                database.Close();
            }
        }

        public void UpdateMember(LibraryMember member)
        {
            string query = $"Update members set KitapSayısı='{member.BookCount}' where AboneNo = {member.MembershipNumber}";

            ExecuteQuery(query);
        }
        public void BanMember(ProcurementRecord record)
        {
            string query = $"Update members set Durumu = {(int)UserStatus.Engellenmiş} where AboneNo = {record.MembershipNumber}";

            ExecuteQuery(query);
        }
        public void DeleteMember(int memberNumber)
        {
            string query = $"Delete from member where AboneNo = '{memberNumber}'";

            ExecuteQuery(query);
        }
        public void AddBook(LibraryBook book)
        {
            for (int i = 0; i < book.StockNumber; i++)
            {
                string query = $"Insert into books (KitapAdı,YazarAdı,YayınEvi,KitapTürü,TedarikŞekli,TedarikTarihi,Durum) " +
                    $"values ('{book.BookName}','{book.AuthorName}','{book.PublishingHome}','{book.Category}','{book.ProcurementType}','{book.ProcurementDate?.ToString("yyyy-MM-dd H:mm:ss")}','{(int)Stats.Kütüphanede}')";

                ExecuteQuery(query);
            }

        }

        public void UpdateBookStatus(Stats status, ProcurementRecord record)
        {
            string query = $"Update books set Durum = '{(int)status}' where BarkodNo = {record.BarcodeNo}";

            ExecuteQuery(query);
        }
        public void DeleteBook(int barcodeNumber)
        {
            string query = $"Delete from books where BarkodNo = '{barcodeNumber}'";

            ExecuteQuery(query);
        }

    }
}
