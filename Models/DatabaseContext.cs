using Resources.CMS;
using System.Data.Entity;
namespace Models
{
    public class DatabaseContext : System.Data.Entity.DbContext
    {
        static DatabaseContext()
        {
            // فقط به درد برنامه نويسان آنهم در زمان پياده سازی می خورد
            //System.Data.Entity.Database.SetInitializer
            //	(new System.Data.Entity.DropCreateDatabaseAlways<DatabaseContext>());

            // فقط به درد برنامه نويسان آنهم در زمان پياده سازی می خورد
            System.Data.Entity.Database.SetInitializer
                (new System.Data.Entity.DropCreateDatabaseIfModelChanges<DatabaseContext>());

            // به درد مشتری می خورد
            //System.Data.Entity.Database.SetInitializer
            //	(new System.Data.Entity.CreateDatabaseIfNotExists<DatabaseContext>());
        }

        public DatabaseContext()
            : base()
        {
        }

        public DbSet<AcademyDay> AcademyDays { get; set; }
        public System.Data.Entity.DbSet<Course> Courses { get; set; }
        public System.Data.Entity.DbSet<Feature> Feature { get; set; }
        public System.Data.Entity.DbSet<Instrument> Instrumental { get; set; }
        public System.Data.Entity.DbSet<JoinToCourse> JoinToCourses { get; set; }
        public System.Data.Entity.DbSet<PaymentUniqueNumber> PaymentUniqueNumbers { get; set; }
        public System.Data.Entity.DbSet<PaymentCourse> PaymentCourses { get; set; }
        public System.Data.Entity.DbSet<Role> Roles { get; set; }
        public System.Data.Entity.DbSet<Room> Rooms { get; set; }
        public System.Data.Entity.DbSet<RoomsDay> RoomsDays { get; set; }
        public System.Data.Entity.DbSet<RoomsFeature> RoomsFeatures { get; set; }
        public System.Data.Entity.DbSet<TeachersInstrumental> TeachersInstrumental { get; set; }
        public System.Data.Entity.DbSet<Article> Articles { get; set; }
        public System.Data.Entity.DbSet<Menu> Menus { get; set; }
        public System.Data.Entity.DbSet<Contact> Contacts { get; set; }
        public System.Data.Entity.DbSet<Slider> Sliders { get; set; }

    }

}