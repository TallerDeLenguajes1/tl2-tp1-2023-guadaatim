﻿// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System.Linq.Expressions;
using System.Security.Cryptography;
using EspacioCadete;
using EspacioCadeteria;
using EspacioCliente;
using EspacioPedido;
using EspacioAccesoADatos;

internal class Program
{
    private static void Main(string[] args)
    {
        AccesoADatos HelperADD = new AccesoADatos();

        List<Cadete> listadoCadetes = HelperADD.LeerArchivoCadetes("Cadetes.csv");
        List<Cadeteria> listadoCadeterias = HelperADD.LeerArchivoCadeteria("Cadeterias.csv", listadoCadetes);

        Console.WriteLine("Seleccione una cadeteria: ");
        
        int i = 0;
        foreach (var cadeteria in listadoCadeterias)
        {
            Console.WriteLine(i + cadeteria.Nombre);
            i++;
        }

        int opcionC;
        bool control = int.TryParse(Console.ReadLine(), out opcionC);

        if (control)
        {
            Cadeteria cadeteriaElegida = listadoCadeterias[opcionC];
            Console.WriteLine("Cadeteria elegida: " + cadeteriaElegida.Nombre);
            
            Console.WriteLine("Bienvenido!!!");
            int opcion = 0;

            do
            {
                Console.WriteLine("-------MENU-------");
                Console.WriteLine("1 - Dar de alta un pedido y asignar cadete");
                Console.WriteLine("2 - Cambiar de estado un pedido");
                Console.WriteLine("3 - Reasignar pedido");
                Console.WriteLine("4 - Mostrar informe");
                Console.WriteLine("5 - Salir");
                
                bool control2 = int.TryParse(Console.ReadLine(), out opcion);

                if (control2)
                {
                    switch (opcion)
                    {
                        case 1:
                            Console.WriteLine("-------Datos del cliente-------");
                            Console.WriteLine("Nombre del cliente: ");
                            string? nombreCliente = Console.ReadLine();
                            Console.WriteLine("Direccion del cliente: ");
                            string? direccionCliente = Console.ReadLine();
                            Console.WriteLine("Datos de referencia de la direcicon: ");
                            string? datosReferencia = Console.ReadLine();
                            Console.WriteLine("Telefono del cliente: ");
                            int telefonoCliente = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("-------Datos del pedido-------");
                            Console.WriteLine("Numero de pedido: ");
                            int numeroPedido = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Observacion: ");
                            string? observacionPedido = Console.ReadLine();

                            Console.WriteLine("Elija un cadete: ");
                            int idcadete = Convert.ToInt32(Console.ReadLine());

                            cadeteriaElegida.DarDeAltaPedido(numeroPedido, observacionPedido, nombreCliente, direccionCliente, telefonoCliente, datosReferencia, listadoCadetes[idcadete].Id);
                            Console.WriteLine("-------PEDIDO REALIZADO-------");
                            break;
                        case 2:
                            Console.WriteLine("Ingrese el id del cadete: ");
                            int idCad = Convert.ToInt32(Console.ReadLine());
                            Cadete cadeteElegido = listadoCadetes[idCad];

                            Console.WriteLine("Ingrese el id del pedido que desea modificar: ");
                            int idPedido = Convert.ToInt32(Console.ReadLine());

                            cadeteElegido.CambiarEstado(idPedido);
                            Console.WriteLine("-------ESTADO DE PEDIDO CAMBIADO-------");
                            break;
                        case 3:
                            Console.WriteLine("Ingrese el id del cadete: ");
                            int idCad1 = Convert.ToInt32(Console.ReadLine());
                            Cadete cadeteElegido1 = listadoCadetes[idCad1];
                            
                            Console.WriteLine("Ingrese el id del otro cadete: ");
                            int idCad2 = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("Ingrese el id del pedido que desea reasignar: ");
                            int idPedidoReasignar = Convert.ToInt32(Console.ReadLine());
                            
                            cadeteriaElegida.ReasignarPedido(cadeteElegido1.BuscarPedido(idPedidoReasignar), idCad1, idCad2);
                            cadeteElegido1.EliminarPedido(idPedidoReasignar);
                            Console.WriteLine("-------PEDIDO REASIGNADO-------");
                            break;
                        case 4:
                            cadeteriaElegida.Informe(listadoCadetes, 1);
                            break;
                        default:
                            break;
                    }
                }
                
                Console.WriteLine("Presione 5 para salir o 1 para volver al menu: ");
                opcion = Convert.ToInt32(Console.ReadLine());

            } while (opcion != 5);
        }
    }
}