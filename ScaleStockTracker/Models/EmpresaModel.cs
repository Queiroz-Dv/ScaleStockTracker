using ScaleStockTracker.Infrastructure.Enums;
using ScaleStockTracker.Models.ValueObjects;
using System;
using System.Collections.Generic;

namespace ScaleStockTracker.Models
{
    public class EmpresaModel
    {
        Guid guid = Guid.NewGuid();

        public EmpresaModel(NomePadrao empresaModelNome, TipoDocumentoEnum empresaModelCNPJ, Email empresaModelEmail, 
                            Endereco endereco, DateTime empresaModelDataCriacao)
        {
            EmpresaModelId = guid.ToString().Substring(0, 9);
            EmpresaModelNome = empresaModelNome;
            EmpresaModelCNPJ = empresaModelCNPJ;
            EmpresaModelEmail = empresaModelEmail;
            Endereco = endereco;
            EmpresaModelDataCriacao = empresaModelDataCriacao;
            Filiais = new List<FilialModel>();
        }

        public string EmpresaModelId { get; set; }
        public NomePadrao EmpresaModelNome { get; set; }
        public TipoDocumentoEnum EmpresaModelCNPJ { get; set; } = TipoDocumentoEnum.CNPJ;
        public Email EmpresaModelEmail { get; set; }
        public string EmpresaModelTelefone { get; set; }
        public Endereco Endereco { get; set; }
        public DateTime EmpresaModelDataCriacao { get; set; }
        public DateTime EmpresaModelDataAlteracao { get; set; }

        public IEnumerable<FilialModel> Filiais { get; set; }
    }
}
