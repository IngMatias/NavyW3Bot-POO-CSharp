﻿using System;

    // S - SRP: Esta clase se encarga de la responsabilidad de manejar las impresiones del
    // bot, en primera instancia se utiliza la consola pero luego podria ser Telegram, WhatsApp, etc.

    // O - OCP: Se piensa la jerarquia IPrinter - ClientPrinter para permitir el agregado de nuevos
    // metodos de impresion sin la necesidad de alterar el codigo, sino mas bien agregandolo en una nueva clase.
    
    // L - LSP: ClientPrinter puede ser intercambiado por cualquier otro metodo de impresion y puede recibir 
    // los mismos mensajes, sin embargo se comporta de distinta manera, naturalmente.
    // Se revisa cuidadosamente no generar efectos colaterales.

    // I - ISP: No se encuentra una aplicacion del principio ISP.
    
    // D - DIP: ClientPrinter tiene dependencias desconocidas.

    // Expert : En esta clase no se conoce.

    // Polimorfismo : El metodo Print es polimorfico en todos los IPrinter.

    // Creator : No se usa Creator.

namespace Library
{
    public class ClientPrinter : IPrinter
    {
        public void Print(object ToPrint)
        {
            Console.WriteLine(ToPrint);
        }
    }
}