using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro.Core.Domain.Model.Organizadores
{
    public class OrganizadorScope
    {
        public static Expression<Func<Organizador, bool>> TodosAtivos =>
            x => x.Ativo;

        public static Expression<Func<Organizador, bool>> TodosAtivosAnoCorrente(int ano) =>
            x => x.Ativo && x.DataCadastro.Year == ano;
    }
}
