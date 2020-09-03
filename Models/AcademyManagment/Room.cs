using Models.Infrastructure;
using System;
using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class Room:BaseEntity
    {
        public Room():base()
        {
        }

        [Display(ResourceType = typeof(Resources.AcademyManagment.Room),
            Name =Resources.AcademyManagment.Strings.RoomKeys.Name)]
        [Required(ErrorMessageResourceType = typeof(Resources.Messages),AllowEmptyStrings =false,
                    ErrorMessage = Resources.Strings.MessagesKeys.DataRequeird)]
        [StringLength(maximumLength: 20)]
        public string Name { get; set; }
    }
}
