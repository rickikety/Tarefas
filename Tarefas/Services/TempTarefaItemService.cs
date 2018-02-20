using System.Collections.Generic;
using System.Threading.Tasks;
using Tarefas.Models;
using System;

namespace Tarefas.Services
{
    public class TempTarefaItemService : ITarefaItemService
    {
        public Task<IEnumerable<TarefaItem>> GetItemAsync()
        {
            IEnumerable<TarefaItem> items = new[]{ //criando uma lista com duas tarefas
                new TarefaItem{
                    Nome = "Curso asp.net 2.0",
                    EstaCompleta = false,
                    DataConclusao = DateTimeOffset.Now.AddDays(1)
                },
                new TarefaItem{
                    Nome = "Desenvolver WEB",
                    EstaCompleta = false,
                    DataConclusao = DateTimeOffset.Now.AddDays(2)
                },
            };
            return Task.FromResult(items);
         //   throw new NotImplementedException();
        }
    }
}