using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Aparel_List.Models
{
    public class Aparel_ListContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public Aparel_ListContext() : base("name=Aparel_ListContext")
        {
        }

        public System.Data.Entity.DbSet<Aparel_List.Models.Aparelhos> Aparelhos { get; set; }
    }
}
