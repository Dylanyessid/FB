using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Data;
using System.Windows.Forms;

namespace FB.Modelo
{
    class clsConductor
    {
        
		private string placaMoto;
		private int numDocumentoIdentidad;
		private decimal calificacionPromedio;
		private char activo;
		private DateTime licenciaDesde;
		private DateTime licenciaHasta;
		private int solicitudActual;
    }
}
