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
        public DbSet<TodoItem> TodoItems { get; set; } = null!;

        //Usando .ToTable() para reconhecer ou criar tabela igual ao nome da classe e não da propriedade
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TodoItem>().ToTable(nameof(TodoItem));
        }
    }
}
