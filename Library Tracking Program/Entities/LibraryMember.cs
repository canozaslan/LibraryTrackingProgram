using System;
using System.Collections.Generic;
using System.Text;

namespace Library_Tracking_Program
{
    public enum UserStatus { Aktif = 1, Engellenmiş }
    public class LibraryMember
    {
        public int MembershipNumber { get; set; }
        public string NameSurname { get; set; }
        public string IdentificationNumber { get; set; }
        public DateTime BornDate { get; set; }
        public string BornPlace { get; set; }
        public string PhoneNumber { get; set; }
        public string? Email { get; set; }
        public DateTime MembershipDate { get; set; }
        public string Gender { get; set; }
        public string? SchoolName { get; set; }
        public string? Address { get; set; }
        public int BookCount { get; set; }
        public UserStatus Status { get; set; }
    }
}
