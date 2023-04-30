using ScaleStockTracker.Infrastructure.Enums;
using ScaleStockTracker.Models.ValueObjects;
using System;

namespace ScaleStockTracker.Models.DefaultModels
{
    public  class Pessoa
    {
        public virtual int Id { get; set; }
        public virtual NomeCompleto NomeCompleto { get; set; }
        public virtual Endereco Endereco { get; set; }
        public virtual DateTime DataNascimento { get; set; }
        public virtual string Telefone { get; set; }
        public virtual TipoDocumentoEnum Documento { get; set; }
        public virtual Email Email { get; set; }
        public virtual DateTime DataCriacao { get; set; }
        public virtual DateTime DataAlteracao { get; set; }

        public virtual bool Administrador { get; set; }
        public virtual bool Gerente { get; set; }
        public virtual bool Usuario { get; set; }
        public virtual bool Cliente { get; set; }
    }
}