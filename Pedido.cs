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
        this.estado = estado;
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
       
        if (Estado == Estado.Pendiente )
        {
            Estado = Estado.Entregado;

        } else
        {
           
        }

         public void CancelarPedido()
    {
       
        this.Estado = Estado.Cancelado;

        
           
        }
    } //cancelar pedido metodo
}