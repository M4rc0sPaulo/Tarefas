using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Tarefas.Models;
using Tarefas.Models.Enuns;
using System.Data;


namespace TarefasAPI.Data
{
    public class DataContext :DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        
        public DbSet<Anotacao> Anotacoes { get; set;}


          protected override void OnModelCreating(ModelBuilder modelBuilder)
          {
             modelBuilder.Entity<Anotacao>().HasData
             (
                new Anotacao() { Id = 1, Nome = "Refazer Atividade", Data =DateTime.Parse("2023-06-25 1:00:00") , IdPrioridade =PrioridadeEnums.Media, Tipo = "Trabalho"},
                 new Anotacao() { Id = 2, Nome = "Mestrar RPG Ordem", Data =DateTime.Parse("2023-06-30 1:00:00") , IdPrioridade =PrioridadeEnums.Alta, Tipo = "Atividade"},
                new Anotacao() { Id = 3, Nome = "Continuar Banco", Data =DateTime.Parse("2023-07-10 1:00:00") , IdPrioridade =PrioridadeEnums.Alta, Tipo = "Escola"},
                new Anotacao() { Id = 4, Nome = "Dentista", Data = DateTime.Parse("2023-06-27 1:00:00") , IdPrioridade =PrioridadeEnums.Media, Tipo = "Saúde"}
             );

          }


    }
}