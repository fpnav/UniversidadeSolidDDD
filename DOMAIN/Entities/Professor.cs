using DOMAIN.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOMAIN.Entities
{
    public class Professor
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Email { get; set; }

        public bool IsValid()
        {
            return CpfService.IsValid(Cpf) &&
                EmailService.IsValid(Email);
        }
    }
}
