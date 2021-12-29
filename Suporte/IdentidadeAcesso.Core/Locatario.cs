using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdentidadeAcesso.Core
{
    public class Locatario
    {
        public LocatarioId TenantId { get; private set; }
        public string Nome { get; set; }

        public Locatario(LocatarioId tenantId)
        {
            TenantId = tenantId;
        }

        public Usuario NovoUsuario()
        {
            return new Usuario(TenantId);
        }
    }
}
