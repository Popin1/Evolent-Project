using System.ComponentModel;

namespace ClientWinformCallingWebAPI.Model
{
    public class Contact
    {
        [DisplayName("Contact Id")]
        public int Id { get; set; }
        [DisplayName("First name")]
        public string FirstName { get; set; }
        [DisplayName("Last name")]
        public string LastName { get; set; }
        [DisplayName("Email")]
        public string Email { get; set; }
        [DisplayName("Phone No.")]
        public string Phone { get; set; }
        [DisplayName("Active")]
        public bool IsActive { get; set; }
    }
}