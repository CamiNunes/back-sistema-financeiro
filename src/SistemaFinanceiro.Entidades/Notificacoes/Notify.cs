using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaFinanceiro.Entidades.Notificacoes
{
    public class Notify
    {
        public Notify()
        {
            notifications = new List<Notify>();   
        }

        [NotMapped]
        public string PropertyName { get; set; } = string.Empty;

        [NotMapped]
        public string Message { get; set; } = string.Empty;

        [NotMapped]
        public List<Notify> notifications;

        public bool ValidateProperyString(string value, string propertyName)
        {
            if(string.IsNullOrWhiteSpace(value) || string.IsNullOrWhiteSpace(propertyName))
            {
                notifications.Add(new Notify
                {
                    Message = "Campo Obrigatório",
                    PropertyName = propertyName,
                });

                return false;
            }

            return true;
        }

        public bool ValidateProperyInt(int value, string propertyName)
        {
            if (value < 1 || string.IsNullOrWhiteSpace(propertyName))
            {
                notifications.Add(new Notify
                {
                    Message = "Campo Obrigatório",
                    PropertyName = propertyName,
                });

                return false;
            }

            return true;
        }
    }
}
