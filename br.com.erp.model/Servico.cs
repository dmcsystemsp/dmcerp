using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMCERP.br.com.erp.model
{
    public class Servico
    {
        public int Codigo { get; set; }
        public string Descricao { get; set; }
        public decimal ValorServico { get; set; }
    }
}
