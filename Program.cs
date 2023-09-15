// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using EspacioCadete;
using EspacioCadeteria;
using EspacioCliente;
using EspacioPedido;

//StreamReader str

string strCadeterias = File.ReadAllText("Cadeterias.csv");
string strCadetes = File.ReadAllText("Cadetes.csv");

string[] strCadeteriasSeparada = strCadeterias.Split(',', '\r');
string[] strCadetesSeparada = strCadetes.Split(',');

int i = 1;
int j = 3;

Console.WriteLine("Seleccione una cadeteria: ");

while (strCadeteriasSeparada.Length >= j)
{
    Console.WriteLine(i + strCadeteriasSeparada[j]);
    j+=2;
    i++;
}

Console.WriteLine(strCadetesSeparada[6]);

List<Cadete> listadoCadetes = new List<Cadete>();

int opcionC;
bool control = int.TryParse(Console.ReadLine(), out opcionC);

if (control)
{   
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

