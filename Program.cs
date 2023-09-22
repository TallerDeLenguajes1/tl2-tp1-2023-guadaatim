// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System.Linq.Expressions;
using EspacioCadete;
using EspacioCadeteria;
using EspacioCliente;
using EspacioPedido;

//StreamReader str

string strCadeterias = File.ReadAllText("Cadeterias.csv");

string[] strCadeteriasSeparada = strCadeterias.Split(',', '\r');
string[] strCadetesSeparados = null;

List<Cadete> listadoCadetes = new List<Cadete>();

int i = 0;

StreamReader strCadetes = new StreamReader("Cadetes.csv");
string? linea;

while ((linea = strCadetes.ReadLine()) != null)
{
    string[] fila = linea.Split(",").ToArray();
    
    if (i > 0)
    {   
        Cadete cadeteAgregar = new Cadete(Convert.ToInt32(fila[0]), fila[1], fila[2], fila[3]);
        listadoCadetes.Add(cadeteAgregar);
    }

    i++;
}


i = 1;
int j = 3;

Console.WriteLine("Seleccione una cadeteria: ");

while (strCadeteriasSeparada.Length >= j)
{
    Console.WriteLine(i + strCadeteriasSeparada[j]);
    j+=2;
    i++;
}

int opcionC;
bool control = int.TryParse(Console.ReadLine(), out opcionC);

if (control)
{   
    switch (opcionC)
    {
        case 1:
        opcionC = 3;
        break;
        case 2:
        opcionC = 5;
        break;
        case 3:
        opcionC = 7;
        break;
        case 4:
        opcionC = 9;
        break;
        case 5:
        opcionC = 11;
        break;
        default:
        break;
    }

    Cadeteria cadeteriaElegida = new Cadeteria(strCadeteriasSeparada[opcionC], "11111", listadoCadetes);
    Console.WriteLine("Cadeteria elegida: " + strCadeteriasSeparada[opcionC]);
    
    Console.WriteLine("Bienvenido!!!");
    Console.WriteLine("-------MENU-------");
    Console.WriteLine("1 - Dar de alta un pedido");
    Console.WriteLine("2 - Asignar cadete");
    Console.WriteLine("3 - Cambiar de estado un pedido");
    Console.WriteLine("4 - Reasignar pedido");

    int opcion;
    bool control2 = int.TryParse(Console.ReadLine(), out opcion);

    if (control2)
    {
        switch (opcion)
        {
            case 1:
            Cliente cliente = new Cliente("juan", "junin", 33444, "junin");
            Pedido nuevoPedido = new Pedido(1, "observacion", cliente);
            break;
            case 2:
            
            break;
            case 3:
            
            break;
            case 4:
            
            break;
            default:
            break;
        }
    }
}


