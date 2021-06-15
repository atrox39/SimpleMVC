using SimpleMVC.Base.Structs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleMVC.Model
{
    class Test : Base.Schema
    {
        public Test()
        {
            // Este es un modelo base y para crear los modelos siguientes debes usar este como base
            SchemaName = "tb_"+this.GetType().Name; // No modificar
            Columns = new Column[] // Ejemplo de como crear columnas, recibe 3 parametros (Nombre, Tipo, Tamaño)
            {
                new Column("Nombre", "VARCHAR", 10),
                new Column("Apellido", "VARCHAR", 10),
                new Column("Edad", "INT", 10)
            };
            Create();
        }
    }
}
