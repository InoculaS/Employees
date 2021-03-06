//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EmployeesApplication.Models
{
    using System;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;

    public partial class Employees
    {
        [Key]
        public int Id { get; set; }

        [Required, DisplayName("Payroll Number"), StringLength(16, MinimumLength = 6, ErrorMessage = "Lenght of this field must be between 8 and 16")]
        public string Payroll_Number { get; set; }

        [Required]
        public string Forenames { get; set; }

        [Required]
        public string Surname { get; set; }
        
        [DisplayName("Date of Birth"), DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public Nullable<System.DateTime> Date_of_Birth { get; set; }
        
        [DataType(DataType.PhoneNumber)]
        public string Telephone { get; set; }

        [Required,DataType(DataType.PhoneNumber), StringLength(20, MinimumLength = 7, ErrorMessage = "Lenght of this field must be between 7 and 20")]
        public string Mobile { get; set; }

        [Required, StringLength(50, MinimumLength = 3, ErrorMessage = "Lenght of this field must be between 3 and 50")]
        public string Address { get; set; }

        [DisplayName("Address 2")]
        public string Address_2 { get; set; }

        public string Postcode { get; set; }

        [DisplayName("Email"), DataType(DataType.EmailAddress)]
        public string EMail_Home { get; set; }

        [Required, DisplayName("Start Date"), DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public System.DateTime Start_Date { get; set; }
    }
}
