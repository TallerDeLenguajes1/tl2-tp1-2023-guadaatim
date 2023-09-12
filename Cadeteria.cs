namespace EspacioCadeteria;
using EspacioCadete;
using EspacioPedido;
using EspacioCliente;
using System.ComponentModel;

public class Cadeteria
{
    private string? nombre;
    private string? telefono;
    private List<Cadete>? listadoCadetes;

    public Cadeteria(string nombre, string telefono, List<Cadete> listadoCadetes)
    {
        this.listadoCadetes = listadoCadetes;
        this.nombre = nombre;
        this.telefono = telefono;
    }

    public string? Nombre { get => nombre; set => nombre = value; }
    public string? Telefono { get => telefono; set => telefono = value; }
    
    //metodos
    public void DarDeAltaPedido(int num, string observacion, string nombre, string direccion, int telefono, string datosReferenciadeDireccion, int idCadete)
    {
        Cliente clienteNuevo = new Cliente(nombre, direccion, telefono, datosReferenciadeDireccion);
        Pedido pedidoNuevo = new Pedido(num, observacion, clienteNuevo);

        AsignarPedido(pedidoNuevo, idCadete);
                                                                                                          
    }
    public void AsignarPedido(Pedido nuevoPedido, int idCadete)
    {
        foreach (var cadete in listadoCadetes)
        {
            if (idCadete == cadete.Id)
            {
                cadete.AgregarPedido(nuevoPedido);
            }
        }
    }

    public void ReasignarPedido( Pedido pedidoAReasignar, int id)
    {
        foreach (var  cadete in listadoCadetes)
        {
            if (id == cadete.Id)
            {
                cadete.AgregarPedido(pedidoAReasignar);
                cadete.EliminarPedido(pedidoAReasignar, pedidoAReasignar.Numero);
                break;
            }
        }
    }

    // public string Informe(float total, int cantidad)
    // {
    // }
}