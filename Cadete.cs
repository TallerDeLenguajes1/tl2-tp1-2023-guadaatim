namespace EspacioCadete;

using System.ComponentModel;
using EspacioPedido;

public class Cadete
{
    private int id;
    private string? nombre;
    private string? direccion;
    private string? telefono;
    private List<Pedido>? listapedidos;

    public Cadete()
    {
    }

    public Cadete(int id, string nombre, string direccion, string telefono)
    {
        this.id = id;
        this.nombre = nombre;
        this.direccion = direccion;
        this.telefono = telefono;
        listapedidos = new List<Pedido>();
    }

    public int Id { get => id; set => id = value; }
    public string? Nombre { get => nombre; set => nombre = value; }
    public string? Direccion { get => direccion; set => direccion = value; }
    public string? Telefono { get => telefono; set => telefono = value; }

    public void AgregarPedido(Pedido pedidoNuevo)
    {
        listapedidos.Add(pedidoNuevo);
    }

    public void EliminarPedido(int numero)
    {
        foreach (var pedido in listapedidos)
        {
            if (numero == pedido.Numero)
            {
                listapedidos.Remove(pedido);
                break;
            }
        }
    }

    public void CambiarEstado(int numeroPedido)
    {
        Pedido pedidoACambiar = new();

        foreach (var pedidoElegido in listapedidos)
        {
            if (numeroPedido == pedidoElegido.Numero)
            {
                pedidoElegido.CambiarEstado();
                break;
            }
        }
    } 

    public float JornalACobrar()
    {
        float total = 0;

        foreach (var pedidito in listapedidos)
        {
            if (pedidito.Estado == Estado.Entregado)
            {
                total += 500;
            }
        }

        return total;
    }

    public int cantidadEnvios()
    {
        int cantidad = 0;

        foreach (var pedido in listapedidos)
        {
            if (pedido.Estado == Estado.Entregado)
            {
                cantidad++;
            }
        }

        return cantidad;
    }

    public Pedido BuscarPedido(int idPedido)
    {
        Pedido pedidoBuscado = new Pedido();

        foreach (var p in listapedidos)
        {
            if (idPedido == p.Numero)
            {
                pedidoBuscado = p;
                break;
            }
        }

        return pedidoBuscado;
    }
}