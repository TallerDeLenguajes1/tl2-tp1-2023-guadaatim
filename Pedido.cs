namespace EspacioPedido;
using EspacioCliente;

public enum Estado
{
    Pendiente,
    Entregado,
    Cancelado
}

public class Pedido
{
    private int numero;
    private string? observacion;
    private Cliente? cliente;
    private Estado estado;

    public Pedido()
    {
    }

    public Pedido(int numero, string? observacion, Cliente? cliente)
    {
        this.numero = numero;
        this.observacion = observacion;
        this.cliente = cliente;
        estado = Estado.Pendiente;
    }

    public int Numero { get => numero;}
    public string? Observacion { get => observacion; }
    public Estado Estado { get => estado;}

    public void AgregarCliente(Cliente clienteNuevo)
    {
        cliente = clienteNuevo;
    }

    public void EliminarCliente()
    {
        cliente = null;
    }

    public string VerDireccionCliente()
    {
        return cliente.Direccion;
    }

    public string VerDatosDeCliente()
    {
        return cliente.DatosReferenciaDireccion;
    } 

    public void CambiarEstado()
    {
        if (estado == Estado.Pendiente )
        {
            estado = Estado.Entregado;

        } 
    }

   public void CancelarPedido()
    {
        this.estado = Estado.Cancelado;      
    }
} 
