using System;
using System.Collections.Generic;

namespace ScaleStockTracker.Models
{
    public class DepartamentoModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int EmpresaId { get; set; }
        public virtual EmpresaModel Empresa { get; set; }
        public DateTime DataCriacao { get; set; }
        public DateTime DataAlteracao { get; set; }
        public virtual ICollection<CargoModel> Cargos { get; set; }
    }
}
