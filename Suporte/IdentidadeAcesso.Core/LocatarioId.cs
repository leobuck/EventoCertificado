using Nucleo.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdentidadeAcesso.Core
{
    public class LocatarioId : Identity
    {
        public LocatarioId() : base() { }
        public LocatarioId(Guid id) : base(id) { }
    }
}
