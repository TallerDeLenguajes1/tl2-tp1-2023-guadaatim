namespace EspacioPedido;
using EspacioCliente;

public class Pedido{
    private int nro;
    private string? observacion;
    private Cliente? cliente;
    private string? estado;

    public int Nro { get => nro; set => nro = value; }
    public string? Observacion { get => observacion; set => observacion = value; }
    public Cliente? Cliente { get => cliente; set => cliente = value; }
    public string? Estado { get => estado; set => estado = value; }

    //cambiar estado
    //cargar cliente
    
}