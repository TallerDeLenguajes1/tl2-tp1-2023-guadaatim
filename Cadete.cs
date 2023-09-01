namespace EspacioCadete;
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

    public void CambiarEstado(int numeroPedido, int opcion)
    {
        Pedido pedidoACambiar = new Pedido();

        foreach (var pedidoelegido in listaPedidos)
        {
            if (numeroPedido == pedidoelegido.Numero)
            {
                pedidoACambiar = pedidoelegido;
                break;
            }
        }

        if (pedidoACambiar.Estado == Estado.Pendiente && opcion == 1)
        {
            pedidoACambiar.Estado = Estado.Entregado;

        } else
        {
            if (pedidoACambiar.Estado == Estado.Pendiente && opcion == 2)
            {
                pedidoACambiar.Estado = Estado.Cancelado;
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

//clase hijo puedes tener el constructor de la clase padre
//si no redefino el cosntructor toma el de la clase padre