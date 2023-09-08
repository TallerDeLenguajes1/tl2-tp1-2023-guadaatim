namespace EspacioCadeteria;
using EspacioCadete;
using EspacioPedido;
using EspacioCliente;
using System.ComponentModel;

public class EspacioCadeteria
{
    private string? nombre;
    private string? telefono;
    private List<Cadete>? listadoCadetes;

    public EspacioCadeteria(string nombre, string telefono, List<Cadete> listadoCadetes)
    {
        this.listadoCadetes = listadoCadetes;
        this.nombre = nombre;
        this.telefono = telefono;
    }

    public string? Nombre { get => nombre; set => nombre = value; }
    public string? Telefono { get => telefono; set => telefono = value; }
    public List<Cadete>? ListadoCadetes { get => listadoCadetes; set => listadoCadetes = value; }

    
    //metodos
    public void DarDeAltaPedido(int num, string observacion, string nombre, string direccion, string telefono, string datosReferenciadeDireccion, int id)
    {
        Cliente clienteNuevo = new Cliente(nombre, direccion, telefono, datosReferenciadeDireccion);
        Pedido pedidoNuevo = new Pedido(num, observacion, clienteNuevo);

        AsignarPedido(pedidoNuevo, listadoCadetes, id);
                                                                                                          
    }
    public void AsignarPedido(Pedido nuevoPedido, List<Cadete> ListadoCadetes, int id)
    {
        foreach (var cadete in ListadoCadetes)
        {
            if (id == cadete.Id)
            {
                cadete.AgregarPedido(nuevoPedido);
            }
        }
    }

    public void ReasignarPedido(List<Cadete> ListadoCadetes, Pedido pedidoAReasignar, int id)
    {
        foreach (var  cadete in ListadoCadetes)
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