using System;
using System.Collections.Generic;
using System.Text;

namespace Library_Tracking_Program
{
    public enum Stats { Kütüphanede = 1, Abonede, Hasarlı, Kayıp }
    class LibraryBook
    {
        public int BarcodeNo { get; set; }
        public string BookName { get; set; }
        public string AuthorName { get; set; }
        public string PublishingHome { get; set; }
        public string Category { get; set; }
        public string? ProcurementType { get; set; }
        public DateTime? ProcurementDate { get; set; }
        public Stats St { get; set; }
        public int StockNumber { get; set; }
    }
}
