using System;

namespace ServiciosDeFacturacion
{
    public class Empresa
    {
        // Propiedades que representan los datos de una empresa.

        public string NombreCliente { get; set; } // Nombre del cliente de la empresa.
        public string ApellidosCliente { get; set; } // Apellidos del cliente.
        public int EdadCliente { get; set; } // Edad del cliente.
        public string RutCliente { get; set; } // RUT (Rol Único Tributario) del cliente.
        public string NombreEmpresa { get; set; } // Nombre de la empresa.
        public string RutEmpresa { get; set; } // RUT (Rol Único Tributario) de la empresa.
        public string GiroEmpresa { get; set; } // Giro o actividad de la empresa.
        public decimal TotalVentas { get; set; } // Total de ventas de la empresa.
        public decimal MontoVentas { get; set; } // Monto de ventas de la empresa.
        public decimal MontoIVAaPagar { get; set; } // Monto de IVA a pagar por la empresa.
        public decimal MontoUtilidades { get; set; } // Monto de utilidades de la empresa.
    }
}
