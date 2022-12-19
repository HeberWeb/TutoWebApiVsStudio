using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;

namespace TutoWebApiVsStudio.Models
{
    public class TodoContext : DbContext
    {
        /// <summary>
        /// Contrutor para o contexto e suas opções padrão
        /// </summary>
        /// <param name="options"></param>
        public TodoContext(DbContextOptions<TodoContext> options)
            : base(options)
        {
        }

        /// <summary>
        /// Propriedade no qual representa a tabela TodoItems na base de dados
        /// </summary>
        public DbSet<TodoItem> TodoItems { get; set; }
    }
}
