﻿
// S -  SRP: Esta clase tiene como responsabilidad realizar un evento.

// O -  OCP: Esta clase es un ejemplo del uso de OCP, se implementa la interface IEvent pero no se
//      modifica el codigo existente para agregar un evento.

// L -  LSP: Esta clase es un subtipo de IEvent.

// I -  ISP: No se utiliza.

// D -  DIP: Hurricane depende de AbstractTable, una abstraccion, y HurricaneAttack que no es una.

//      Expert: No aplica.

//      Polymorphism: El metodo DoEvent es polimorfico a todos los IEvent.

//      Creator: Esta clase usa al patron para crear instancias de HurricaneAttack, ya que las usa de manera cercana.

using System.IO;

namespace Library
{
    public class HurricaneToString : AbstractIEventToString
    {
        public HurricaneToString()
        :base(new MeteorShowerToString())
        {
        }
        public override string ToString(IEvent catastrophe, string lang)
        {
            if (catastrophe is Hurricane)
            {
                return File.ReadAllLines(@"..\..\..\..\language"+lang+@"\Events.txt")[1];
            }   
            else
            {
                return this.SendNext(catastrophe, lang);
            }
        }
    }
}