using System;
using System.ComponentModel.DataAnnotations;
using static DREAS.Models.Utility;

namespace DREAS.Models
{
    public class User: BaseModel
    {
        [Required(ErrorMessage ="Username is required")]
        [StringLength(128,ErrorMessage ="Username has exceeded the maximumn limit")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Password is required")]

        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public Boolean IsBlocked { get; set; } = false;
        public DateTime BlockedDate { get; set; }
        public Boolean IsConfirmed { get; set; } = false;
        public UserType UserType { get; set; }


    }
}
