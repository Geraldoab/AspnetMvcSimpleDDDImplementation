using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisaoApp.Domain.Entities
{
    public class Usuario
    {
        public long Codigo { get; set; }
        public string Nome { get; set; }
    }
}