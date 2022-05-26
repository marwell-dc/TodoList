using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ToDoList.Models
{
    public class Todo
    {
        public int Id { get; set; }
        [DisplayName("Titulo")]
        [Required(ErrorMessage = "Campo Obrigatório")]
        public string? Title { get; set; }
        [DisplayName("Concluído")]
        public bool Done { get; set; }
        [DisplayName("Criado em")]
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        [DisplayName("Ultima atualização em")]
        public DateTime LastUpdateDate { get; set; }
        [DisplayName("Usuário")]
        public string? User { get; set; }
    }
}