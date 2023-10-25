using SistemaFinanceiro.Entidades.Notificacoes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaFinanceiro.Entidades.Entidades
{
    public class BaseEntity : Notify
    {
        [Display(Name = "Código")]
        public int Id { get; set; }

        [Display(Name = "Nome")]
        public string Name { get; set; } = string.Empty;
    }
}
