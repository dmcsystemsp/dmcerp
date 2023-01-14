using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace DMCERP.br.com.erp.model
{
    public class Municipio
    {
        public int CdMunicipio { get; set; }
        public string NomeMunicipio { get; set; }
        public int CdUF { get; set; }
        public string NomeUF { get; set; }
        public string SiglaUF { get; set; }

    }
}
