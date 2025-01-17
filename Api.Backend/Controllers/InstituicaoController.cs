﻿using Api.Backend.Data;
using Api.Backend.Data.Dtos.Instituicao;
using Api.Backend.Domain.Models;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace Api.Backend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class InstituicaoController : ControllerBase
    {
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;

        public InstituicaoController(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }


        [HttpPost]
        public IActionResult AdicionaInstituicao([FromBody] CreateInstituicaoDto instituicaoDto)
        {
            Instituicao instituicao = _mapper.Map<Instituicao>(instituicaoDto);
            _context.Instituicaos.Add(instituicao);
            _context.SaveChanges();
            return CreatedAtAction(nameof(RecuperaInstituicaosPorId), new { Id = instituicao.Id }, instituicao);
        }

        [HttpGet]
        public IEnumerable<Instituicao> RecuperaInstituicaos()
        {
            return _context.Instituicaos;
        }

        [HttpGet("{id}")]
        public IActionResult RecuperaInstituicaosPorId(int id)
        {
            Instituicao instituicao = _context.Instituicaos.FirstOrDefault(instituicao => instituicao.Id == id);
            if (instituicao != null)
            {
                ReadInstituicaoDto instituicaoDto = _mapper.Map<ReadInstituicaoDto>(instituicao);
                return Ok(instituicaoDto);
            }
            return NotFound();
        }

        [HttpPut("{id}")]
        public IActionResult AtualizaInstituicao(int id, [FromBody] UpdateInstituicaoDto instituicaoDto)
        {
            Instituicao instituicao = _context.Instituicaos.FirstOrDefault(instituicao => instituicao.Id == id);
            if (instituicao == null)
            {
                return NotFound();
            }
            _mapper.Map(instituicaoDto, instituicao);
            _context.SaveChanges();
            return NoContent();
        }


        [HttpDelete("{id}")]
        public IActionResult DeletaInstituicao(int id)
        {
            Instituicao instituicao = _context.Instituicaos.FirstOrDefault(instituicao => instituicao.Id == id);
            if (instituicao == null)
            {
                return NotFound();
            }
            instituicao.Ativo = false;
            _context.SaveChanges();
            return NoContent();
        }

    }
}
