namespace EspacioCadete;

using System.ComponentModel;
using EspacioPedido;

public class Cadete
{
    private int id;
    private string? nombre;
    private string? direccion;
    private string? telefono;
    private List<Pedido>? listaPedidos;

    public Cadete()
    {
    }

    public Cadete(int id, string nombre, string direccion, string telefono)
    {
        this.id = id;
        this.nombre = nombre;
        this.direccion = direccion;
        this.telefono = telefono;
    }

    public int Id { get => id; set => id = value; }
    public string? Nombre { get => nombre; set => nombre = value; }
    public string? Direccion { get => direccion; set => direccion = value; }
    public string? Telefono { get => telefono; set => telefono = value; }

    //metodos

    public void AgregarPedido(Pedido pedidoNuevo)
    {
        listaPedidos.Add(pedidoNuevo);
    }

    public void EliminarPedido(Pedido pedidoEliminado, int numero)
    {
        foreach (var pedido in listaPedidos)
        {
            if (numero == pedido.Numero)
            {
                listaPedidos.Remove(pedido);
                break;
            }
        }
    }



    public float JornalACobrar()
    {
        float total = 0;

        foreach (var pedidito in listaPedidos)
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

        foreach (var pedido in listaPedidos)
        {
            if (pedido.Estado == Estado.Entregado)
            {
                cantidad++;
            }
        }

        return cantidad;
    }
}

//clase hijo puede tener el constructor de la clase padre
//si no redefino el cosntructor toma el de la clase padre