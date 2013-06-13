using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DvdRental.Core.Models;

namespace DvdRental.Core.Components
{
    public class Database
    {
        private static PetaPoco.Database _session;
        public static PetaPoco.Database Session
        {
            get
            {
                if (_session == null)
                {
                    _session = new PetaPoco.Database("DvdRentalConnectionString");
                }
                return _session;
            }
        }

        public static int GetNextID<T>()
        {
            var t = typeof(T);
            var sqlStr = String.Format("SELECT Max(id) FROM {0}", t.Name.ToLower());
            return Session.ExecuteScalar<int>(sqlStr) + 1;
        }

        public static IEnumerable<T> Query<T>()
        {
            var t = typeof(T);
            var sql = String.Format("SELECT * FROM {0}", t.Name.ToLower());
            var x = Session.Query<T>(sql);
            return x;
        }

        public static void Insert(Dvd dvd)
        {
            Session.Execute("insert into dvd(id, title, releaseyear, description, genre, poster) values(@0, @1, @2, @3, @4, @5)",
                dvd.Id,
                dvd.Title,
                dvd.ReleaseYear,
                dvd.Description,
                dvd.Genre,
                new SqlParameter { SqlDbType = System.Data.SqlDbType.VarBinary, Value = dvd.Poster == null ? (object) DBNull.Value : (object)dvd.Poster });
        }

    }
}
