namespace PIMVIII.Models
{
    public class Telefone
    {
        public int Id { get; set; }
        public int Numero { get; set; }
        public int Ddd { get; set; }

        public List<TipoTelefone> Tipo { get; set; }
    }
}