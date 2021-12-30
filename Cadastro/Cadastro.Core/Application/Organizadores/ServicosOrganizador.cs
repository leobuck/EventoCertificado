using Cadastro.Core.Domain.Model.Organizadores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro.Core.Application.Organizadores
{
    public class ServicosOrganizador : IServicoOrganizador
    {
        private readonly IOrganizadorRepositorio _repositorio;

        public ServicosOrganizador(IOrganizadorRepositorio repositorio)
        {
            _repositorio = repositorio;
        }

        public void CadastrarNovoOrganizador(Organizador organizador)
        {
            if (organizador.IsValid())
            {
                _repositorio.Adicionar(organizador);
            }
        }
    }
}
