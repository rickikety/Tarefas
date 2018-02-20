


using System.Collections.Generic;

namespace Tarefas.Models
{
    public class TarefaViewModel
    {
        public IEnumerable<TarefaItem> TarefaItems { get; set; }
        // IEnumerable é semelhante á List<Tipo> do Java
    }
}