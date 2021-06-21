﻿using System;
using System.Collections.Generic;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 class1 = new Class1();
            class1.SayHi();

            // FirstPhase pha = new FirstPhase();
            // AbstractTable tab = new Table();
            // IPrinter p = new ClientPrinter();
            // IReader r = new ClientReader();
            // pha.Execute(tab,null,p,r);

            Table tab = new Table();
            Console.WriteLine(tab.AddVessel(1,1,new Battleship(),true));
            Console.WriteLine(tab.StringTable());

            /*
            Diccionario con tipos
            IItem it1 = new AntiaircraftMissile();
            IItem it2 = new AntiaircraftMissile();
            Dictionary<System.Type,IItemValidator> dic = new Dictionary<System.Type, IItemValidator> ();
            dic.Add(it1.GetType(), new AntiaircraftMissileValidator());
            Console.WriteLine(dic[it2.GetType()]);
            */

            
        }
    }
}