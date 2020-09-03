using System.Web.Mvc;

namespace Infrastructure
{
    public class BaseController : Controller
    {
        public BaseController():base()
        {
        }

        
        private Models.DatabaseContext _myDatabaseContext;

        /// <summary>
        /// Lazy Loading = Lazy Initialization
        /// </summary>
        protected Models.DatabaseContext MyDatabaseContext
        {
            get
            {
                if (_myDatabaseContext == null)
                {
                    _myDatabaseContext =
                        new Models.DatabaseContext();
                }

                return (_myDatabaseContext);
            }
        }
        // /Solution (4)

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (_myDatabaseContext != null)
                {
                    _myDatabaseContext.Dispose();
                    _myDatabaseContext = null;
                }
            }

            base.Dispose(disposing);
        }
    }
}