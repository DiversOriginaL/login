﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DataAccess.DataAccess;
using Common.Entidades;

namespace Domain.Domain
{
    public class CnFactura
    {
        CdFactura cdFactura = new CdFactura();
        DataTable dt = new DataTable();

        Facturas factura = new Facturas();
        DetallesFacturas detalle = new DetallesFacturas();


        public DataTable mostrarFacturas()
        {
            dt = cdFactura.mostrarFacturas();
            return dt;
        }

        public DataTable cargarServicios()
        {
            dt = cdFactura.cargarServicios();
            return dt;
        }

        public string ObtenerPrecio(string servicio)
        {
            string precio = cdFactura.ObtenerPrecio(servicio);
            return precio;
        }

        //CALCULOS DE LA FACTURA.
        
        public string ObtenerImporte(string precio, string cantidad)
        {
            try
            {
                decimal Precio = Convert.ToDecimal(precio);
                int Cantidad = Convert.ToInt32(cantidad);

                decimal resultado = Precio * Cantidad;
                return resultado.ToString();
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                throw;
            }


        }

        public string ObtenerSubTotal(string importe, string descuento)
        {
            decimal Importe = Convert.ToDecimal(importe);
            decimal Descuento = Convert.ToDecimal(descuento);

            decimal resultado = Importe - Descuento;
            return resultado.ToString();
        }

        public string ObtenerTotal(List<string> SubTotal)
        {
            decimal Total = 0;

            foreach (string subtotalstr in SubTotal)
            {
                if(decimal.TryParse(subtotalstr, out decimal subtotal))
                {
                    Total += subtotal;
                }
            }

            return Total.ToString();
        }
        //==================================================INSERTAR=================================================================

        public void insertarFactura(List<DetallesFacturas> detalles, List<int> ServicioID, string total, string pacienteid)
        {
            cdFactura.InsertarFacturaConDetalles(detalles, ServicioID, Convert.ToDecimal(total), DateTime.Now, Convert.ToInt32(pacienteid));
        }

    }
}
