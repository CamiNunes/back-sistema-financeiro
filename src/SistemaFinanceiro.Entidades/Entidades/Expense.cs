using SistemaFinanceiro.Entidades.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaFinanceiro.Entidades.Entidades
{
    [Table("Expense")]
    public class Expense : BaseEntity
    {
        public decimal Valor { get; set; }
        public int Mes { get; set; }
        public int Ano { get; set; }

        public EnumExpenseType ExpenseType { get; set; }

        public DateTime RegisterDate { get; set; }

        public DateTime ChangeDate { get; set; }

        public DateTime PaymentDate { get; set; }

        public DateTime ExpiryDate { get; set; }

        public bool PaidOut { get; set; }

        public bool OverdueExpense { get; set; }

        [ForeignKey("Category")]
        [Column(Order = 1)]
        public int IdCategory { get; set; }
        public virtual Category Category { get; set; }
    }
}
