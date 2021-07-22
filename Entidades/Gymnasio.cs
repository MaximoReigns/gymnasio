namespace prueba.Entidades
{
    class Gymnasio
    {
        string nombreGym;
        string ubicacion;

        string ceo;

        string cliente;
        public string Nombre
        {
            get { return nombreGym; }
            set { nombreGym = value.ToUpper(); }
        }
        public string Ubicacion
        {
            get { return ubicacion; }
            set { ubicacion = value.ToLower(); }
        }

        public string Ceo
        {
            get { return ceo; }
            set { ceo = value; }
        }

        public string Cliente
        {
            get { return cliente; }
            set { cliente = value; }
        }
        public int NumeroDeMaquinas { get; set; }

        public TipoMaquina TipoMaquinas { get; set; }

        public TipoCliente TipoClientes { get; set; }

        public TipoRutina TipoRutinas { get; set; }

        public Gymnasio(string nombre, int numeroMaquinas) => (Nombre, NumeroDeMaquinas) = (nombre, numeroMaquinas);

        public Gymnasio(string nombre, int numeroMaquinas,
                        TipoCliente tipo,
                        string ubicacion = "")
        {
            (Nombre, NumeroDeMaquinas) = (nombre, numeroMaquinas);
            Ubicacion = ubicacion;
        }

        public override string ToString()
        {
            string newLine = System.Environment.NewLine;
            return $"Nombre del Gymnasio: \"{Nombre}\" {newLine}Número de Maquinas: {NumeroDeMaquinas} {newLine}Tipo de Cliente: {TipoClientes} {newLine}Ubicación: {Ubicacion}";
        }
    }
}

/*public Gymnasio(string nombre, string ubicacion, int numeroMaquinas,
                        TipoCliente tipoCliente, TipoRutina tipoRutina, TipoMaquina tiposMaquina,
                        string cliente = "")
        {
            (Nombre, Ubicacion, NumeroDeMaquinas) = (nombre, ubicacion, numeroMaquinas);
            Cliente = cliente;
        }*/