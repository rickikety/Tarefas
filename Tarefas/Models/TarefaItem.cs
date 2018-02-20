using System;

namespace Tarefas.Models
{
    public class TarefaItem
    {
        public Guid ID { get; set; } // identificador unico sem banco de dados inicial
        public bool EstaCompleta { get; set; }
        public string Nome { get; set; }
        public DateTimeOffset? DataConclusao { get; set; } // tipo data, mas precisoque o DateTime ?* opcional
    }
}