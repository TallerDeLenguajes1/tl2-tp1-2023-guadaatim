namespace EspacioPedido;
using EspacioCliente;

enum Estado
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

    public int Numero { get => numero; set => numero = value; }
    public string? Observacion { get => observacion; set => observacion = value; }
    public Cliente? Cliente { get => cliente; set => cliente = value; }
    internal Estado Estado { get => estado; set => estado = value; }

    public void CargarCliente(string nombre, string direccion, string telefono, string datosReferenciaDireccion)
    {
        cliente.Nombre = nombre;
        cliente.Direccion = direccion;
        cliente.Telefono = telefono;
        cliente.DatosReferenciaDireccion = datosReferenciaDireccion;
    }

    public string VerDireccionCliente(Cliente cliente)
    {
        return cliente.Direccion;
    }

    public string VerDatosDeCliente(Cliente cliente)
    {
        return cliente.DatosReferenciaDireccion;
    } 
      
}