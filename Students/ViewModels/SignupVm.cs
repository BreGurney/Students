﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Students.ViewModels
{
    public class SignupVm
    {
        public int Id { get; set; }
        public string StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
    }
}