﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro.Core.Domain.Model.Organizadores
{
    public class Organizador
    {
        public OrganizadorId Id { get; private set; }
        public string Nome { get; set; }
        public NomeCompleto Responsavel { get; set; }

        public Organizador(OrganizadorId id)
        {
            Id = id;
        }
    }
}
