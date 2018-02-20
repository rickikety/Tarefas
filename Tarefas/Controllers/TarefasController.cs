
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Tarefas.Models;

namespace Tarefas.Controllers
{
    public class TarefasController : Controller
    {
        //injecao de dependecia -> só é possivel pois está registrada na startup.cs
        Services.ITarefaItemService _tarefaService;
        public TarefasController(Services.ITarefaItemService service){
            _tarefaService = service;
        }

        // lista de tarefas
        public async Task<IActionResult> Index(){

            // obter os dados, e retornar
            var tarefas = await _tarefaService.GetItemAsync();
            var model = new TarefaViewModel();
            {
                model.TarefaItems = tarefas;
            };
            return View(model);
        }
    }
}