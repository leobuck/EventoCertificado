using Cadastro.Core.Application.Organizadores;
using Emissao.Core.Application.Certificados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EventoCertificado.Controllers
{
    public class DefaultController : Controller
    {
        private readonly IServicoEvento _servicoEvento;
        private readonly IServicoCertificado _servicoCertificado;

        public DefaultController(IServicoEvento servicoEvento, IServicoCertificado servicoCertificado)
        {
            _servicoEvento = servicoEvento;
            _servicoCertificado = servicoCertificado;
        }

        // GET: Default
        public ActionResult Index(Guid guid, string cpf)
        {
            var evento = _servicoEvento.RecuperarEvento(new Cadastro.Core.Domain.Model.Eventos.EventoId(guid));
            var certificado = _servicoCertificado.EmitirCertificado(new Emissao.Core.Domain.Model.Certificados.EventoId(guid), cpf);

            return View();
        }
    }
}