﻿
// S - SRP: Esta clase tiene la responsabilidad de definir el barco abstracto.

// O -  OCP: Si se aplica, para agregar una abstraccion diferente basta con implementar una nueva clase.

// L -  LSP: Cualquier clase que herede esta debe ser y es un subtipo de esta clase.

// I -  ISP: No se aplica.

// D -  DIP: Esta clase solo depende de abstracciones.

//      Expert: No se aplica.

//      Polymorphism: No se aplica.

//      Creator: No se utiliza.

using System;

namespace Library
{
    public abstract class AbstractVesselAttacker : AbstractStateManager
    {
        protected AbstractVesselAttacker(int size, int health)
        : base(size, health)
        {
        }
        public virtual void LaunchMissile(AbstractTable table, int x, int y)
        {
            throw new NoOneMissileException();
        }

        public virtual void ThrowLoad(AbstractTable table, int x, int y)
        {
            throw new NoOneLoadException();
        }

        public virtual void LaunchMissile(AbstractTable table, int x1, int y1, int x2, int y2)
        {
            throw new NoTwoMissileException();
        }
        
    }
}