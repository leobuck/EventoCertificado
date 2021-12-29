using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro.Core.Domain.Model.Organizadores
{
    public class Organizador
    {
        public Guid Id { get; private set; }
        public string Nome { get; set; }

        public Organizador()
        {
            Id = Guid.NewGuid();
        }
    }
}
