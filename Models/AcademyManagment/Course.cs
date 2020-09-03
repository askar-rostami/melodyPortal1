﻿using Models.Infrastructure;
using System;
using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class Course:BaseEntity
    {
        public Course():base()
        {
        }
        [Display(ResourceType = typeof(Resources.AcademyManagment.Course),
            Name =Resources.AcademyManagment.Strings.CourseKeys.Name)]
        [Required(ErrorMessageResourceType = typeof(Resources.Messages),
                    ErrorMessage = Resources.Strings.MessagesKeys.DataRequeird)]
        public string Name { get; set; }

        [Display(ResourceType = typeof(Resources.AcademyManagment.Course),
            Name =Resources.AcademyManagment.Strings.InstrumentKeys.Name)]
        [Required(ErrorMessageResourceType =typeof(Resources.Messages),
            ErrorMessage =Resources.Strings.MessagesKeys.DataRequeird)]
        public Guid Instrument_FK { get; set; }


        /// <summary>
        /// این شخص مدرس میباشد
        /// </summary>
        [Display(ResourceType = typeof(Resources.Person),
            Name =Resources.Strings.PersonKeys.TeacherName)]
        [Required(ErrorMessageResourceType = typeof(Resources.Messages),
            ErrorMessage = Resources.Strings.MessagesKeys.DataRequeird)]
        public Guid Person_FK { get; set; }

        [Display(ResourceType = typeof(Resources.AcademyManagment.Room),
            Name =Resources.AcademyManagment.Strings.RoomKeys.Name)]
        [Required(ErrorMessageResourceType = typeof(Resources.Messages),
            ErrorMessage = Resources.Strings.MessagesKeys.DataRequeird)]
        public Guid Room_FK { get; set; }

        [Display(ResourceType = typeof(Resources.AcademyManagment.AcademyDay),
            Name =Resources.AcademyManagment.Strings.AcademyDayKeys.Name)]
        [Required(ErrorMessageResourceType = typeof(Resources.Messages),
                    ErrorMessage = Resources.Strings.MessagesKeys.DataRequeird)]
        public Guid AcademyDay_FK { get; set; }

        [Display(ResourceType = typeof(Resources.AcademyManagment.Course),
            Name =Resources.AcademyManagment.Strings.CourseKeys.DateFrom)]
        [Required(ErrorMessageResourceType = typeof(Resources.Messages),
            ErrorMessage = Resources.Strings.MessagesKeys.DataRequeird)]
        public DateTime CourseDateFrom { get; set; }

        [Display(ResourceType = typeof(Resources.AcademyManagment.Course),
            Name =Resources.AcademyManagment.Strings.CourseKeys.DateTo)]
        [Required(ErrorMessageResourceType = typeof(Resources.Messages),
            ErrorMessage = Resources.Strings.MessagesKeys.DataRequeird)]
        public DateTime CourseDateTo { get; set; }

        [Display(ResourceType = typeof(Resources.AcademyManagment.Course),
            Name =Resources.AcademyManagment.Strings.CourseKeys.DurationFrom)]
        [Required(ErrorMessageResourceType = typeof(Resources.Messages), AllowEmptyStrings = false,
            ErrorMessage = Resources.Strings.MessagesKeys.DataRequeird)]
        public string CourseDurationFrom { get; set; }

        [Display(ResourceType = typeof(Resources.AcademyManagment.Course),
            Name = Resources.AcademyManagment.Strings.CourseKeys.DurationTo)]
        [Required(ErrorMessageResourceType = typeof(Resources.Messages),AllowEmptyStrings =false,
            ErrorMessage = Resources.Strings.MessagesKeys.DataRequeird)]
        public string CourseDurationTo { get; set; }



        [Display(ResourceType = typeof(Resources.AcademyManagment.Course),
            Name =Resources.AcademyManagment.Strings.CourseKeys.Price)]
        [Required(ErrorMessageResourceType = typeof(Resources.Messages),
                    ErrorMessage = Resources.Strings.MessagesKeys.DataRequeird)]
        public int CoursePrice { get; set; }


        [Display(ResourceType = typeof(Resources.AcademyManagment.Course),
            Name = Resources.AcademyManagment.Strings.CourseKeys.IsActive)]
        public bool IsActive { get; set; }

        public virtual AcademyDay AcademyDay { get; set; }

        public virtual Room Room { get; set; }

        public virtual Instrument Instrument { get; set; }

        public virtual Person Person { get; set; }

    }
}
