using Models.Infrastructure;
using System;
using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class RoomsDay:BaseEntity
    {
        public RoomsDay():base()
        {
        }

        [Display(ResourceType = typeof(Resources.AcademyManagment.AcademyDay),
            Name =Resources.AcademyManagment.Strings.AcademyDayKeys.Name)]
        [Required(ErrorMessageResourceType = typeof(Resources.Messages),
                    ErrorMessage = Resources.Strings.MessagesKeys.DataRequeird)]
        public Guid AcademyDay_FK { get; set; }

        [Display(ResourceType = typeof(Resources.AcademyManagment.Room),
            Name = Resources.AcademyManagment.Strings.RoomKeys.Name)]
        [Required(ErrorMessageResourceType = typeof(Resources.Messages),
                    ErrorMessage = Resources.Strings.MessagesKeys.DataRequeird)]
        public Guid Room_FK { get; set; }

        [Display(ResourceType = typeof(Resources.AcademyManagment.RoomsDay),
            Name = Resources.AcademyManagment.Strings.RoomsDayKeys.CourseDateFrom)]
        [Required(ErrorMessageResourceType = typeof(Resources.Messages),
                    ErrorMessage = Resources.Strings.MessagesKeys.DataRequeird)]
        public DateTime CourseDateFrom { get; set; }

        [Display(ResourceType = typeof(Resources.AcademyManagment.RoomsDay),
            Name = Resources.AcademyManagment.Strings.RoomsDayKeys.CourseDateTo)]
        [Required(ErrorMessageResourceType = typeof(Resources.Messages),
                    ErrorMessage = Resources.Strings.MessagesKeys.DataRequeird)]
        public DateTime CourseDateTo { get; set; }

        public virtual AcademyDay AcademyDay { get; set; }

        public virtual Room Room { get; set; }
    }
}
