using ScaleStockTracker.Infrastructure.Enums;
using ScaleStockTracker.Models.ValueObjects;
using System;

namespace ScaleStockTracker.Models
{
    public class FilialModel
    {
        public FilialModel(NomePadrao filialModelNome, TipoDocumentoEnum filialModelDocumento, Email filialModelEmail, Endereco filialModelEndereco,
                          DateTime filialModelDataCriacao)
        {
            FilialModelNome.Nome = filialModelNome.Nome;
            FilialModelNome.NomeFantasia = filialModelNome.NomeFantasia;
            FilialModelDocumento = filialModelDocumento;
            FilialModelEmail = filialModelEmail;
            FilialModelEndereco = filialModelEndereco;
            FilialModelDataCriacao = filialModelDataCriacao;
        }

        public string FilialModelId { get; set; }
        public NomePadrao FilialModelNome { get; set; }
        public TipoDocumentoEnum FilialModelDocumento { get; set; }
        public Email FilialModelEmail { get; set; }
        public Endereco FilialModelEndereco { get; set; }

        public DateTime FilialModelDataCriacao { get; set; }
        public DateTime FilialModelDataAlteracao { get; set; }

        public string EmpresaModelId { get; set; }
        public virtual EmpresaModel Empresa { get; set; }

    }
}