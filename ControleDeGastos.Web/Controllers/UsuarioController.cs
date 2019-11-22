﻿using ControleDeGastos.Domain;
using ControleDeGastos.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace ControleDeGastos.Web.Controllers
{
    public class UsuarioController : Controller
    {
        #region Atributos
        private readonly UsuarioService _usuarioService;
        private readonly UserManager<UsuarioLogado> _userManager;
        private readonly SignInManager<UsuarioLogado> _signInManager;
        #endregion

        #region Construtor
        public UsuarioController(UsuarioService usuarioService, UserManager<UsuarioLogado> userManager,
            SignInManager<UsuarioLogado> signInManager)
        {
            _usuarioService = usuarioService;
            _userManager = userManager;
            _signInManager = signInManager;
        }
        #endregion

        #region Index
        public IActionResult Index()
        {
            return View();
        }
        #endregion

        #region Cadastro
        public IActionResult Cadastro()
        {
            return View();
        }
        #endregion

        #region Cadastrar
        [HttpPost]
        public async Task<IActionResult> Cadastrar(Usuario u)
        {
            if (ModelState.IsValid)
            {
                UsuarioLogado usuarioLogado = new UsuarioLogado
                {
                    Email = u.Email,
                    UserName = u.Email
                };
                IdentityResult result = await _userManager.CreateAsync(usuarioLogado, u.Senha);
                if (result.Succeeded)
                {
                    await _signInManager.SignInAsync(usuarioLogado, isPersistent: false);
                    if (_usuarioService.Cadastrar(u))
                    {
                        return RedirectToAction("Index");
                    }
                    ModelState.AddModelError("", "Este e-mail já está sendo utilizado!");
                }
                AdicionarErros(result);
            }
            return View(u);
        }
        #endregion

        #region Logar
        [HttpPost]
        public IActionResult Logar()
        {
            return View();
        }

        [HttpPost]
        public async Task <IActionResult> Logar (Usuario u)
        {
            var result = await _signInManager.PasswordSignInAsync(u.Email, u.Senha, true, lockoutOnFailure: false);

            if (result.Succeeded)
            {
                return RedirectToAction("Dashboard", "Usuario");
            }
            ModelState.AddModelError("", "Falha no Login");
            return View();
            
        }


        #endregion

        #region Dashboard
        public IActionResult Dashboard()
        {
            return View();
        }
        #endregion

        #region Perfil
        public IActionResult Perfil()
        {
            return View();
        }
        #endregion

        private void AdicionarErros(IdentityResult result)
        {
            foreach (var erro in result.Errors)
            {
                ModelState.AddModelError("", erro.Description);
            }
        }


        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Usuario");
        }


    }
}