using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_First
{
    public class Category
    {
        public int CategoryId { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }
    }

    // Veri tabanına tablo olarak yansıtma
    /////   
    ///// To send to database as table code below
    
    public class MoviesContext:DbContext
    {
        public DbSet<Category> Categories { get; set; } // Uygulamamda category diye bir nesne var ve ben onu tabloya dönüştürmek istiyorum //Categories şeklinde//

        public MoviesContext():base("MoviesConStr")
        {

        }

    }
    class Program
    {



        static void Main(string[] args)
        {
        }
    }
}
