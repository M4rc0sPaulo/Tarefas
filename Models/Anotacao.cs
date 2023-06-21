using Tarefas.Models.Enuns;
namespace Tarefas.Models
{
    public class Anotacao
    {
         public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime Data { get; set; }
        public PrioridadeEnums IdPrioridade { get; set; }
        public string Tipo { get; set; }
        public object NovaAnotacao { get; internal set; }
    }
}