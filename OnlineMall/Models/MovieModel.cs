using Models.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
   public class MovieModel
    {
        private OnlineMallDbContext contex = null;
        public MovieModel()
        {
            contex = new OnlineMallDbContext();
        }
       public List<Movie> ListAll()
        {
            var list = contex.Database.SqlQuery<Movie>("Sp_Movie_ListAll").ToList();
            return list;
        }
    }
}
