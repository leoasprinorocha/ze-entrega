using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ze_EntregaWeb.Context;

namespace Ze_EntregaWeb.Controllers
{
    public class ClientesController : Controller
    {
        private readonly ZeEntregaContext _context;

        public ClientesController(ZeEntregaContext context)
        {
            _context = context;
        }

        public ActionResult Index()
        {
            var listaClientes = _context.Clientes.ToList();
            return View(listaClientes);
        }
    }
}
