using System;
using prueba.Entidades;

namespace prueba
{
    class Program
    {
        static void Main(string[] args)
        {
            var gymnasio = new Gymnasio("Gym uno mas", 17,
                                        TipoCliente.Griton,
                                        ubicacion: "SM 63, AV. TULUM"
                                        );
            //gymnasio.TipoClientes = TipoCliente.Griton;
            //gymnasio.numeroDeMaquinas = 15;
            /*gymnasio.numeroDeMaquinas = 27;
            gymnasio.Cliente = "Máximo Sánchez";
            gymnasio.TipoRutinas = TipoRutina.Brazo;
            gymnasio.TipoMaquinas = TiposMaquina.Arnold;*/
            Console.WriteLine(gymnasio);
        }
    }
}
