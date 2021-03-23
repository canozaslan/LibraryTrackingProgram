using System;
using System.Collections.Generic;
using System.Text;

namespace Library_Tracking_Program.Entities
{
    public enum RecordStatus{ Abonede = 1, Gecikmiş, TeslimAlınmış}
    public class ProcurementRecord
    {
        public int Id { get; set; }
        public int MembershipNumber { get; set; }
        public string NameSurname { get; set; }
        public int BarcodeNo { get; set; }
        public string BookName { get; set; }
        public RecordStatus RStatus { get; set; }
        public DateTime TakenTime { get; set; }
        public DateTime GivenTime { get; set; }
    }
}
