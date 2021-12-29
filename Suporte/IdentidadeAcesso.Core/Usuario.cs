using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdentidadeAcesso.Core
{
    public class Usuario
    {
        public LocatarioId TenantId { get; private set; }
        public string UserName { get; private set; }
        public string Password { get; private set; }

        public Usuario(LocatarioId tenantId)
        {
            TenantId = tenantId;
        }
    }
}
