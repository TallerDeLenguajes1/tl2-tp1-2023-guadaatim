using EspacioCadete;
using EspacioCadeteria;

namespace EspacioAccesoADatos;

public class AccesoADatos
{
    public List<Cadete> LeerArchivoCadetes(string nombre)
    {
        List<Cadete> listadoCadetes = new List<Cadete>();

        StreamReader strCadetes = new StreamReader(nombre);
        string? linea;
        int i = 0;

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

        return listadoCadetes;
    }

    public List<Cadeteria> LeerArchivoCadeteria(string nombre, List<Cadete> listadoCadetes)
    {
        List<Cadeteria> listadoCadeterias = new List<Cadeteria>();

        StreamReader strCadeterias = new StreamReader(nombre);
        string? linea;
        int i = 0;

        while ((linea = strCadeterias.ReadLine()) != null)
        {
            string[] fila = linea.Split(",").ToArray();

            if (i > 0)
            {
                Cadeteria cadeteriaAgregar = new Cadeteria(fila[1], "111", listadoCadetes);
                listadoCadeterias.Add(cadeteriaAgregar);
            }

            i++;
        }
        
        return listadoCadeterias;
    }
}
