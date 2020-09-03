using System;
using Models.Infrastructure;

namespace Models.CMS
{
  public  class Slider:BaseEntity
    {
        public Slider():base()
        {

        }
        public string  Describtion { get; set; }
        public string Title{ get; set; }

        public string ImgUrl { get; set; }

        public Guid Person_Fk { get; set; }
        public virtual Person Person { get; set; }
    }
}
