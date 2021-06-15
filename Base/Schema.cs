using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleMVC.Base.Structs;

namespace SimpleMVC.Base
{
    class Schema
    {
        public Database db;
        public string SchemaName;
        public Column[] Columns;

        public Schema()
        {
            db = new Database();
        }

        protected void Create()
        {
            string base_ = "CREATE TABLE IF NOT EXISTS "+SchemaName+" ";
            int c = 0;
            foreach(Column col in Columns)
            {
                if (c == 0)
                {
                    base_ += "(_id INTEGER PRIMARY KEY AUTOINCREMENT, " + col.Name + " " + col.Type + "(" + col.Size + "), ";
                }
                else if (c == Columns.Length - 1)
                {
                    base_ += col.Name + " " + col.Type + "(" + col.Size + "));";
                }
                else
                {
                    base_ += col.Name + " " + col.Type + "(" + col.Size + "), ";
                }
                c += 1;
            }
            db.NoQuery(base_);
        }

        public DataSet Index()
        {
            return db.Query("SELECT * FROM " + SchemaName);
        }
    }
}
