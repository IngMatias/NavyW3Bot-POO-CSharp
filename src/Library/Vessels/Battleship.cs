﻿using System;
using System.Collections.Generic;

    // S - SRP: Esta clase  se encarga de la responsabilidad de implementar el Acorazado.
    // Si se es estricto de puede detectar que hay dos razones de cambio, si se desea cambiar
    // el tamaño del barco, o la forma en la que ataca.
    // Sin embargo no creemos que sea necesario romper esta unión.

    // O - OCP: Se piensa la jerarquia AbstractVessels - Vessel para permitir la implementacion de nuevos
    // barcos sin la necesidad de alterar el codigo, sino mas bien agregandolo en una nueva clase.

    // L - LSP: Battleship no puede ser intercambiado por cualquier otro barco, no puede recibir 
    // el mensaje de ThrowLoad,además se comporta de distinta manera, naturalmente.
    // Se revisa cuidadosamente no generar efectos colaterales.

    // I - Battleship: GameLogic no respeta ISP, no hace uso de todas las operaciones de Table.

    // D - DIP: Battleship depende de Table, que no es una abstraccion, no se cumple DIP.

    // Expert : En esta clase no se conoce.

    // Polimorfismo : El metodo LaunchMissile es polimorfico en todos los barcos que lo tienen. Asi como ThrowLoad.

    // Creator : Se usa Creator cuando se crea MissileAttack porque se usa de manera cercana.

namespace Library
{
    public class Battleship : AbstractVessels
    {
        public Battleship()
        :base(6,1)
        {
        }
        public void LaunchMissile(ITable table, int x, int y)
        {
            AbstractAttacker missile1 = new MissileAttack();
            AbstractAttacker missile2 = new MissileAttack();
            AbstractAttacker missile3 = new MissileAttack();
            table.AttackAt(x, y, missile1);
            table.RandomAttack(missile2);
            table.RandomAttack(missile3);
        }
        public override void Attack0(ITable table, IPrinter clientP ,IReader clientR)
        {
            int x = Int32.Parse(clientR.Read()) - 1;
            int y = Int32.Parse(clientR.Read()) - 1;
            this.LaunchMissile(table,x,y);
        }
        public override List<string> AttackForms()
        {
            return new List<string> {"Acorazado:" ,"Lanzar misil"};
        }
        public override void Attack1(ITable table, IPrinter clientP, IReader clientR)
        {
            throw new NotImplementedException();
        }
    }
}