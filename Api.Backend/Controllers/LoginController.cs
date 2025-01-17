﻿using Api.Backend.Data;
using Api.Backend.Data.Dtos.Usuario;
using Api.Backend.Domain.Models;
using Api.Backend.Services;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Api.Backend.Controllers
{
    public class LoginController: ControllerBase
    {
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;
        private LoginUsuarioDto user;

        public LoginController(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }


        [HttpPost]
        [Route("login")]
        [AllowAnonymous]
        public ActionResult<dynamic> Authenticate([FromBody] LoginUsuarioDto model)
        {
 
            Usuario usuario =  _context.Usuarios.FirstOrDefault(x =>
                               x.Email.ToLower() == model.Email.ToLower()
                               && x.Senha == model.Senha);
            if (usuario != null)
            {
                LoginUsuarioDto usuarioDto = _mapper.Map<LoginUsuarioDto>(usuario);
                 user = usuarioDto;
            }
            // Recupera o usuário
            

            // Verifica se o usuário existe
            if (user == null)
                return NotFound(new { message = "Usuário ou senha inválidos" });

            // Gera o Token
            var token = TokenService.GenerateToken(user);

            // Oculta a senha
            user.Senha = "";

            // Retorna os dados
            return new
            {
                user = user,
                token = token
            };
        }
    }
}
