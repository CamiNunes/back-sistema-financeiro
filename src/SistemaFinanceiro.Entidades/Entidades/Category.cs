using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaFinanceiro.Entidades.Entidades
{
    [Table("Category")]
    public class Category : BaseEntity
    {
        [ForeignKey("FinancialSystem")]
        [Column(Order = 1)]
        public int IdSystem { get; set; }

        public virtual FinancialSystem FinancialSystem { get; set; }
    }
}
