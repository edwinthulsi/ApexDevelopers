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
        public string StudentNo
        {
            get;
            set;
        }
        public string Name
        {
            get;
            set;
        }

        public string Surname
        {
            get;
            set;
        }
        public string Email
        {
            get;
            set;
        }
        public string telNo
        {
            get;
            set;
        }
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