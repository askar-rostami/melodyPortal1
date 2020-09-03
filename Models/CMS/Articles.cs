using System;
using Models.Infrastructure;

namespace Models.CMS
{
   public class Articles:BaseEntity
    {
        public Articles() : base()
        {

        }
        public string Tilte { get; set; }
        public string  ContentBody { get; set; }
        public int   Priority { get; set; }
        public Guid  Person_Fk  { get; set; }
        public Guid Menu_Fk { get; set; }
        public virtual Menu Menu { get; set; }
        public virtual Person Person { get; set; }
    }

}
