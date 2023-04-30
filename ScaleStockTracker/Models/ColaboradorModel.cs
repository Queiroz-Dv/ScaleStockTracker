using ScaleStockTracker.Infrastructure.Enums;
using ScaleStockTracker.Models.DefaultModels;
using ScaleStockTracker.Models.ValueObjects;
using System;

namespace ScaleStockTracker.Models
{
    public class ColaboradorModel : Pessoa // Essa model herda de uma classe padrão (um molde) que será utilizado
    {
        public ColaboradorModel(
            NomeCompleto nomeCompleto,
            Endereco endereco,
            DateTime dataNascimento,
            string telefone,
            TipoDocumentoEnum documento,
            Email email,
            decimal colaboradorModelSalario,
            DateTime dataCriacao)
        {
            NomeCompleto = nomeCompleto;
            Endereco = endereco;
            DataNascimento = dataNascimento;
            Telefone = telefone;
            Documento = documento;
            Email = email;
            ColaboradorModelSalario = colaboradorModelSalario;
            DataCriacao = dataCriacao;
        }

        // Propriedades da model de Colaborador
        public override int Id { get; set; }
        public override NomeCompleto NomeCompleto { get; set; }
        public override Endereco Endereco { get; set; }
        public override DateTime DataNascimento { get; set; }
        public override string Telefone { get; set; }
        public override TipoDocumentoEnum Documento { get; set; }
        public override Email Email { get; set; }

        // Propriedade que pertence a model Colaborador
        public decimal ColaboradorModelSalario { get; set; }


        public override DateTime DataCriacao { get; set; }
        public override DateTime DataAlteracao { get; set; }


        // Relacionamentos 
        public string EmpresaId { get; set; }
        public string DepartamentoId { get; set; }
        public string CargoId { get; set; }

        public virtual EmpresaModel Empresa { get; set; }
        public virtual DepartamentoModel Departamento { get; set; }
        public virtual CargoModel Cargo { get; set; }

    }
}