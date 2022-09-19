namespace ConsolePrueba.Biblioteca
{
    internal class Libro
    {
        private String _titulo;
        private String _autor;
        private String _estilo;
        private String _editorial;
        
        

        public Libro(string titulo, string autor, string estilo, string editorial)
        {
            this._titulo = titulo;
            this._autor = autor;
            this._estilo = estilo;
            this._editorial = editorial;
        }

        public string Titulo
        {
            get => _titulo;
            set => _titulo = value ?? throw new ArgumentNullException(nameof(value));
        }

        public string Autor
        {
            get => _autor;
            set => _autor = value ?? throw new ArgumentNullException(nameof(value));
        }

        public string Estilo
        {
            get => _estilo;
            set => _estilo = value ?? throw new ArgumentNullException(nameof(value));
        }

        public string Editorial
        {
            get => _editorial;
            set => _editorial = value ?? throw new ArgumentNullException(nameof(value));
        }

        public override string ToString()
        {
            return "------------------------------\n" +
                   "Titulo: " + _titulo + " Autor: " + _autor + " Estilo: " + _estilo + " Editorial: " + _editorial;
        }
    }
}