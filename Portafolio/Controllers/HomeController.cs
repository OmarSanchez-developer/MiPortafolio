﻿using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Portafolio.Models;
using Portafolio.Servicios;

namespace Portafolio.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly IRepositorioProyectos repositorioProyectos;
    //private readonly ServicioDelimitado servicioDelimitado;
    //private readonly ServicioUnico servicioUnico;
    //private readonly ServicioTransitorio servicioTransitorio;
    //private readonly ServicioDelimitado servicioDelimitado2;
    //private readonly ServicioUnico servicioUnico2;
    //private readonly ServicioTransitorio servicioTransitorio2;

    public HomeController(ILogger<HomeController> logger,
        IRepositorioProyectos repositorioProyectos
        //ServicioDelimitado servicioDelimitado,
        //ServicioUnico servicioUnico,
        //ServicioTransitorio servicioTransitorio,

        // ServicioDelimitado servicioDelimitado2,
        //ServicioUnico servicioUnico2,
        //ServicioTransitorio servicioTransitorio2

        )

    {
        _logger = logger;
        this.repositorioProyectos = repositorioProyectos;
        //this.servicioDelimitado = servicioDelimitado;
        //this.servicioUnico = servicioUnico;
        //this.servicioTransitorio = servicioTransitorio;
        //this.servicioDelimitado2 = servicioDelimitado2;
        //this.servicioUnico2 = servicioUnico2;
        //this.servicioTransitorio2 = servicioTransitorio2;
    }

    public IActionResult Index()
    {
        var proyectos = repositorioProyectos.ObtenerProyectos().Take(3).ToList();
        //var guidViewModel = new EjemploGUIDViewModel()
        //{
        //    Delimitado = servicioDelimitado.ObtenerGuid,
        //    Transitorio = servicioTransitorio.ObtenerGuid,
        //    Unico = servicioUnico.ObtenerGuid
        //};

        //var guidViewModel2 = new EjemploGUIDViewModel()
        //{
        //    Delimitado = servicioDelimitado2.ObtenerGuid,
        //    Transitorio = servicioTransitorio2.ObtenerGuid,
        //    Unico = servicioUnico2.ObtenerGuid
        //};


        var modelo = new HomeIndexViewModel() {
            Proyectos = proyectos
            //EjemploGUID_1 = guidViewModel,
            //EjemploGUID_2 = guidViewModel2
        };
        return View(modelo);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

