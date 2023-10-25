using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaFinanceiro.Entidades.Entidades
{
    [Table("UserFinancialSystem")]
    public class UserFinancialSystem
    {
        public int Id { get; set; }
        public string EmailUser { get; set; } = string.Empty;
        public bool Administrador { get; set; }
        public bool CurrentSystem { get; set; }


        [ForeignKey("FinancialSystem")]
        [Column(Order = 1)]
        public int IdSystem { get; set; }

        public virtual FinancialSystem FinancialSystem { get; set; }
    }
}
