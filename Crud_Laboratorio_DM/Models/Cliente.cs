using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Crud_Laboratorio_DM.Models
{
    public class Cliente
    {
        public int ID_CLIENTE { get; set; }

        public int CEDULA { get; set; }


        public string NOMBRE { get; set; }
        public string  APELLIDO { get; set; }

        public string EMAIL { get; set; }
        public int TELEFONO { get; set; }

        public string DIRECCION { get; set; }
        public string USUARIO { get; set; }

    }
}
