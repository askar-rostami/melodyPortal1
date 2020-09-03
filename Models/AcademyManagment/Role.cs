using Models.Infrastructure;
using System;
using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class Role:BaseEntity
    {
        public Role():base()
        {
        }

        [Display(Name ="نام")]
        [Required(ErrorMessage ="لطفا {0} را وارد نمایید",AllowEmptyStrings =false)]
        [StringLength(maximumLength:20)]
        public string Name { get; set; }

        [Display(Name = "نام در سیستم")]
        [Required(ErrorMessage = "لطفا {0} را وارد نمایید", AllowEmptyStrings = false)]
        [StringLength(maximumLength: 20)]
        public string NameInSystem { get; set; }
      
    }
}
