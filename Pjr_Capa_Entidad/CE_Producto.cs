using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pjr_Capa_Entidad
{
   public class CE_Producto
    {
        string _idprod;
        string _descripcion;
        double _precioCompra;
        double _stockActual;
        int _idCat;
        string _foto;
        double _preventa;
        string _formatoCompra;
        double _utilidadUnint;
        double _valorxCant;
        string _principioActivo;
        string _laboratorio;
        int _und_min;
        int _und_max;
        DateTime _fechaIngreso;
        DateTime _fechaVence;
        string _venta_conReceta;

        public string Idprod { get => _idprod; set => _idprod = value; }
        public string Descripcion { get => _descripcion; set => _descripcion = value; }
        public double PrecioCompra { get => _precioCompra; set => _precioCompra = value; }
        public double StockActual { get => _stockActual; set => _stockActual = value; }
        public int IdCat { get => _idCat; set => _idCat = value; }
        public string Foto { get => _foto; set => _foto = value; }
        public double Preventa { get => _preventa; set => _preventa = value; }
        public string FormatoCompra { get => _formatoCompra; set => _formatoCompra = value; }
        public double UtilidadUnint { get => _utilidadUnint; set => _utilidadUnint = value; }
        public double ValorxCant { get => _valorxCant; set => _valorxCant = value; }
        public string PrincipioActivo { get => _principioActivo; set => _principioActivo = value; }
        public string Laboratorio { get => _laboratorio; set => _laboratorio = value; }
        public int Und_min { get => _und_min; set => _und_min = value; }
        public int Und_max { get => _und_max; set => _und_max = value; }
        public DateTime FechaIngreso { get => _fechaIngreso; set => _fechaIngreso = value; }
        public DateTime FechaVence { get => _fechaVence; set => _fechaVence = value; }
        public string Venta_conReceta { get => _venta_conReceta; set => _venta_conReceta = value; }
    }
}
