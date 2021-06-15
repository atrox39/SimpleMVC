using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleMVC.Controler
{
    class Test : SimpleMVC.Model.Test
    {
        public DataSet Index()
        {
            return db.Query("SELECT * FROM "+SchemaName);
        }

        public void Insert(string nombre, string apellido, int edad)
        {
            db.NoQuery("INSERT INTO "+SchemaName+" ("+Columns[0].Name+", "+Columns[1].Name+", "+Columns[2].Name+") VALUES ('"+nombre+"', '"+apellido+"', "+edad+")");
        }

        public void Update(int _id, string nombre, string apellido, int edad)
        {
            string query = string.Format("UPDATE {0} SET {1}='{2}', {3}='{4}', {4}:{5} WHERE _id={6}",
                SchemaName,
                Columns[0].Name,
                nombre,
                Columns[1].Name,
                apellido,
                Columns[2].Name,
                _id);
            db.NoQuery(query);
        }
    }
}
