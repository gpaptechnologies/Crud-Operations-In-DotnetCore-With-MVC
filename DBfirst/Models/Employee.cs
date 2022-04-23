using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace DBfirst.Models
{
    public partial class Employee
    {
        public int Id { get; set; }
        [DisplayName("First Name")]
        public string FirstName { get; set; } = null!;
        [DisplayName("Last Name")]
        public string? LastName { get; set; }
    }
}
