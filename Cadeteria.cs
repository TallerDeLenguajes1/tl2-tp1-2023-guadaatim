namespace EspacioCadeteria;
using EspacioCadete;
using EspacioPedido;
using EspacioCliente;

public class EspacioCadeteria
{
    private string? nombre;
    private string? telefono;
    private List<Cadete>? listadoCadetes;

    public string? Nombre { get => nombre; set => nombre = value; }
    public string? Telefono { get => telefono; set => telefono = value; }
    public List<Cadete> ListadoCadetes { get => listadoCadetes; set => listadoCadetes = value; }

    //asignar pedido

    public void AsignarPedido(Pedido nuevoPedido, List<Cadete> ListadoCadetes)
    {
        
    }

    //informe 
}