using System;
using Models.Infrastructure;
using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class Person:BaseEntity
    {
        public Person():base()
        {
        }

        [Display(Name = "نام")]
        [StringLength(maximumLength: 20)]
        public string FirstName { get; set; }

        [Display(Name ="نام خانوادگی")]
        [Required(ErrorMessage ="لطفا {0} را وارد نمایید",AllowEmptyStrings =false)]
        [StringLength(maximumLength:30)]
        [System.ComponentModel.DataAnnotations.Schema.Index(IsUnique = false)]
        public string LastName { get; set; }


        [Display(Name = "تلفن همراه")]
        [Required(ErrorMessage = "لطفا {0} را وارد نمایید", AllowEmptyStrings = false)]
        [StringLength(maximumLength: 15)]
        [Range
        (type: typeof(int), minimum: "11", maximum: "15")]
        public string Mobile { get; set; }

        [Display(Name = "تلفن ضروری")]
        [StringLength(maximumLength: 15)]
        public string EmergancyPhone { get; set; }

        [Display(Name = "رزومه")]
        public string ResumeUrl { get; set; }

        [Display(Name ="ایمیل")]
        [Required(ErrorMessage ="لطفا {0} را وارد نمایید",AllowEmptyStrings =false)]
        [StringLength(maximumLength:50)]
        [System.ComponentModel.DataAnnotations.Schema.Index
(IsUnique = true)]
        public string Email { get; set; }

        [Display(Name ="رمز عبور")]
        [Required(ErrorMessage ="لطفا {0} را وارد نمایید",AllowEmptyStrings =false)]
        [StringLength(maximumLength:30)]
        [Range(type: typeof(int), minimum: "8", maximum: "30")]
        [DataType(DataType.Password)]
        public string Password { get; set; }


        public Guid Role_FK { get; set; }

        public virtual Role Role { get; set; }
    }
}
