using Cadastro.Core.Domain.Model.Organizadores;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Cadastro.Testes
{
    [TestClass]
    public class NomeCompletoTeste
    {
        [TestMethod]
        public void TesteNomeCompleto()
        {
            NomeCompleto nome = new NomeCompleto("Leo", "Buck");
            Assert.AreEqual("Leo Buck", nome.EscreverNome());
        }
    }
}
