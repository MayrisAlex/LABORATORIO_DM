using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD_LABORATORIO_DM1._0.Models
{
    public class CLIENTE
    {

        public int ID_CLIENTE { get; set; }
        public string CEDULA { get; set; }
        public string NOMBRE { get; set; }
        public string APELLIDO { get; set; }
        public string EMAIL { get; set; }
        public string TELEFONO { get; set; }
        public string DIRECCION { get; set; }
        public string USUARIO { get; set; }

        public string DESCRIPCION_SERVICIO { get; set; }
        public DateTime FECHA_RECEPCION { get; set; }
        public DateTime FECHA_ENTREGA { get; set; }
        public string OBSERVACIONES { get; set; }


    }
}
