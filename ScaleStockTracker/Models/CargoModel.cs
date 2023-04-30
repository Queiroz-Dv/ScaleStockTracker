using System;
using System.Collections.Generic;

namespace ScaleStockTracker.Models
{
    public class CargoModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int DepartamentoId { get; set; }
        public virtual DepartamentoModel Departamento { get; set; }
        public int EmpresaId { get; set; }
        public virtual EmpresaModel Empresa { get; set; }
        public DateTime DataCriacao { get; set; }
        public DateTime DataAlteracao { get; set; }
        public virtual ICollection<ColaboradorModel> Colaboradores { get; set; }
    }
}
