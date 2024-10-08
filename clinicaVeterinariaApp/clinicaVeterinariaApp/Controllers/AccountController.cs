﻿using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using clinicaVeterinariaApp.Data;
using Microsoft.AspNetCore.Mvc.Rendering;
using clinicaVeterinariaApp.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

public class AccountController : Controller
{
    private readonly IAccountService _accountService;
    private readonly AppDbContext _context;

    public AccountController(IAccountService accountService, AppDbContext context)
    {
        _accountService = accountService;
        _context = context;
    }
    //Vista del Login
    [HttpGet]
    public IActionResult Login()
    {
        return View();
    }

    //Effettua il login, recuperando nome, ruolo,e UserId
    [HttpPost]
    public async Task<IActionResult> Login(string email, string password)
    {
        var user = await _accountService.AuthenticateAsync(email, password);
        if (user != null)
        {
            var claims = new List<Claim>
        {
            new Claim(ClaimTypes.Name, user.Email),
            new Claim(ClaimTypes.Role, user.Ruoli.NomeRuolo),
            new Claim(ClaimTypes.NameIdentifier, user.UsersID.ToString()) // Usa UsersID
        };

            var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme,
                new ClaimsPrincipal(claimsIdentity));

            return RedirectToAction("Index", "Home");
        }

        ViewBag.Error = "Invalid login attempt.";
        return View();
    }

    //Vista della registrazione
    [HttpGet]
    public IActionResult Register()
    {
        ViewBag.Ruoli = new SelectList(_context.Ruoli, "RuoloID", "NomeRuolo");
        return View();
    }

    // Effettua la registrazione di farmacista e Veterinario
    [HttpPost]
    public async Task<IActionResult> Register(string nomeUser, string cognomeUser, string email, string password, int ruoloID)
    {
        var userExists = await _context.Users.AnyAsync(u => u.Email == email);
        if (userExists)
        {
            ViewBag.Error = "User already exists.";
            ViewBag.Ruoli = new SelectList(_context.Ruoli, "RuoloID", "NomeRuolo");
            return View();
        }

        await _accountService.RegisterAsync(nomeUser, cognomeUser, email, password, ruoloID);

        return RedirectToAction("Login");
    }

    [HttpGet]
    public IActionResult RegisterUser()
    {
        return View();
    }
    //Effettua la registrazione dello user, con l'uso del token per assegnare userId a proprietarioId
    [HttpPost]
    public async Task<IActionResult> RegisterUser(string nomeUser, string cognomeUser, string email, string password, string prenotazioneToken)
    {
        try
        {
            await _accountService.RegisterUserAsync(nomeUser, cognomeUser, email, password, prenotazioneToken);
            return RedirectToAction("Login");
        }
        catch (Exception ex)
        {
            ViewBag.Error = ex.Message;
            return View();
        }
    }

    //Gestisce il Logout

    [HttpPost]
    public async Task<IActionResult> Logout()
    {
        await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
        return RedirectToAction("Index", "Home");
    }
}
