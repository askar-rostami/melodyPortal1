using Models.Infrastructure;
using System;
using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class TeachersInstrumental:BaseEntity
    {
        public TeachersInstrumental():base()
        {
        }

        [Display(ResourceType = typeof(Resources.AcademyManagment.Instrument),
            Name =Resources.AcademyManagment.Strings.InstrumentKeys.Name)]
        [Required(ErrorMessageResourceType = typeof(Resources.Messages),
                    ErrorMessage = Resources.Strings.MessagesKeys.DataRequeird)]
        public Guid Instrument_FK { get; set; }

        /// <summary>
        /// این شخص مدرس میباشد
        /// </summary>
        [Display(ResourceType = typeof(Resources.Person),
            Name = Resources.Strings.PersonKeys.TeacherName)]
        [Required(ErrorMessageResourceType = typeof(Resources.Messages),
                    ErrorMessage = Resources.Strings.MessagesKeys.DataRequeird)]
        public Guid Person_FK { get; set; }

        public virtual Instrument Instrument { get; set; }

        public virtual Person Person { get; set; }
    }
}
