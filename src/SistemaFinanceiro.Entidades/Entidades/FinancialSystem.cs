using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaFinanceiro.Entidades.Entidades
{
    [Table("FinancialSystem")]
    public class FinancialSystem : BaseEntity
    {
        public int Month { get; set; }

        public int Year { get; set; }
        
        public int ClosingDay { get; set; }
        
        public bool GenerateExpenseCopy { get; set; }
        
        public int MonthCopy { get; set; }
        
        public int YearCopy { get; set; }
    }
}
