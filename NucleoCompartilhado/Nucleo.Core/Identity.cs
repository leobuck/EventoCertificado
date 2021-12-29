using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nucleo.Core
{
    public class Identity
    {
        public Guid Id { get; protected set; }

        public Identity()
        {
            Id = Guid.NewGuid();
        }

        public Identity(Guid id)
        {
            Id = id;
        }
    }
}
