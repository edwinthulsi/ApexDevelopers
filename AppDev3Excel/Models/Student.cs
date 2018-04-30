using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AppDev3Excel.Models
{
    public class Student
    {
        [Key]
        [Required(ErrorMessage = "Please enter a student number")]
        public string StudentNo
        {
            get;
            set;
        }
        [Required(ErrorMessage = "Please enter a name")]
        public string Name
        {
            get;
            set;
        }

        [Required(ErrorMessage = "Please enter a surname")]
        public string Surname
        {
            get;
            set;
        }

        [Required(ErrorMessage = "Please enter your Email Address")]
        [EmailAddress(ErrorMessage = "The email address is not valid")]
        public string Email
        {
            get;
            set;
        }

        [Required(ErrorMessage = "Please enter a telephone number")]
        [StringLength(10, ErrorMessage = "Telephone number must be 10 digits long", MinimumLength = 10)]
        [DataType(DataType.PhoneNumber)]
        public string telNo
        {
            get;
            set;
        }

        [Required(ErrorMessage = "Please Enter a mobile number")]
        [StringLength(10, ErrorMessage = "Mobile number must be 10 digits long", MinimumLength = 10)]
        [DataType(DataType.PhoneNumber)]
        public string mobileNo
        {
            get;
            set;
        }
        public bool isActive
        {
            get;
            set;
        }
    }
}