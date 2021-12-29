﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro.Core.Domain.Model.Organizadores
{
    public class OrganizadorId
    {
        public Guid Id { get; protected set; }

        public OrganizadorId()
        {
            Id = Guid.NewGuid();
        }

        public OrganizadorId(Guid id)
        {
            Id = id;
        }
    }
}
