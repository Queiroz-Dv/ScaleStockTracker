using ScaleStockTracker.Infrastructure.Enums;

namespace ScaleStockTracker.Models.ValueObjects
{
    public class Endereco
    {
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public EstadosBrasileirosEnum UF { get; set; }
    }
}
