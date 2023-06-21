using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Tarefas.Models;
using Tarefas.Models.Enuns;
using TarefasAPI.Data;

namespace TarefasAPI.Controllers

{
[ApiController]
[Route("[controller]")]
    public class AnotacaoController : ControllerBase
    {
        private readonly DataContext _context;

        public AnotacaoController(DataContext context)
        {
            _context = context;
        }


         [HttpGet("{id}")] //Buscar pelo id
        public async Task<IActionResult> GetSingle(int id)
        {
            try
            {
                Anotacao p = await _context.Anotacoes
                    .FirstOrDefaultAsync(pBusca => pBusca.Id == id);

                return Ok(p);
            }
            catch (System.Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


         [HttpGet("GetAll")]
        public async Task<IActionResult> Get()
        {
            try
            {
                List<Anotacao> lista = await _context.Anotacoes.ToListAsync();
                return Ok(lista);
            }
            catch (System.Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public async Task<IActionResult> Add(Anotacao novaAnotacao)
        {
            try
            {
                await _context.Anotacoes.AddAsync(novaAnotacao);
                await _context.SaveChangesAsync();

                return Ok(novaAnotacao.Id);
            }
            catch (System.Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        public async Task<IActionResult> Update(Anotacao novaAnotacao)
        {
            try
            {
               
                _context.Anotacoes.Update(novaAnotacao);
                int linhasAfetadas = await _context.SaveChangesAsync();

                return Ok(linhasAfetadas);
            }
            catch (System.Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

         [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                Anotacao pRemover = await _context.Anotacoes.FirstOrDefaultAsync(p => p.Id == id);

                _context.Anotacoes.Remove(pRemover);
                int linhaAfetadas = await _context.SaveChangesAsync();
                return Ok(linhaAfetadas);
            }
            catch (System.Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}