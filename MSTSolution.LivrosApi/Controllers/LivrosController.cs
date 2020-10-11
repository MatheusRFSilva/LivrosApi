using MSTSolution.Comum.Interfaces;
using MSTSolution.LivrosApi.AcessoDados.Entity.Context;
using MSTSolution.LivrosApi.Dominio;
using MSTSolution.LivrosApi.Repositorios.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace MSTSolution.LivrosApi.Controllers
{
    public class LivrosController : ApiController
    {
        private IRepositorioMSTSolution<Livro, int> _repositorioLivros
             = new RepositorioLivros(new LivrosApiDbContext());

        public IHttpActionResult Get()
        {
            return Ok(_repositorioLivros.Selecionar());
        }

        public IHttpActionResult  Get(int? id)
        {
            if (!id.HasValue)
            {
                return BadRequest();
            }
            Livro livro = _repositorioLivros.SelecionarPorId(id.Value);
            if(livro == null)
            {
                return NotFound();
            }
            return Content(HttpStatusCode.Found,livro);
        }

        public IHttpActionResult Post([FromBody]Livro livro)
        {
            try
            {
                _repositorioLivros.Inserir(livro);
                return Created($"{Request.RequestUri}/{livro.Id}",livro);
            }
            catch(Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        public IHttpActionResult Put(int? id,[FromBody]Livro livro)
        {
            try
            {
                if (!id.HasValue)
                {
                    return BadRequest();
                }
                livro.Id = id.Value;
                _repositorioLivros.Atualziar(livro);
                return Ok();
            }catch(Exception ex)
            {
                return InternalServerError(ex);
            }
        }
        public IHttpActionResult Delete (int? id)
        {
            try
            {
                if(!id.HasValue)
                {
                    return BadRequest();
                }

                Livro livro = _repositorioLivros.SelecionarPorId(id.Value);
                if(livro ==null)
                {
                    return NotFound();
                }
                _repositorioLivros.ExcluirPorId(id.Value);
                return Ok();
            }catch(Exception ex)
            {
                return InternalServerError(ex);
            }
        }
    }
}