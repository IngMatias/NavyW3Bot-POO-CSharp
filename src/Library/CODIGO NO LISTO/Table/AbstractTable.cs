﻿
// S -  SRP: Esta clase define los metodos para la representacion (en strings) del tablero.

// O -  OCP: Se cumple. Si se deseara añadir una representacion basta con crear una nueva clase.

// L -  LSP: Se cumple. Cualquier objeto que herede esta clase es y debe ser un subtipo de esta.

// I -  ISP: No se aplica.

// D -  DIP: Esta clase depende solamente de abstracciones.

//      Expert: Esta clase no conoce la representacion del tablero, aun asi se encarga de su representacion. 

//      Polymorphism: No se aplica.

//      Creator: No se aplica.

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace Library
{
    public abstract class AbstractTable : AbstractAttackable
    {
        protected AbstractTable(int x, int y)
        : base(x, y)
        {
        }
        public List<string> ListTable()
        {
            AbstractFieldInterfaceToInt fieldToInt = new HeadFieldInterfacesToInt();

            StringBuilder row = new StringBuilder();
            List<string> toReturn = new List<string>();
            for (int j = 0; j < this.YLength(); j++)
            {
                for (int i = 0; i < this.XLength(); i++)
                {
                    row.Append(fieldToInt.Convert(this.At(i, j)));
                }
                toReturn.Add(row.ToString());
                row.Clear();
            }
            return toReturn;
        }
        public string StringTable()
        {
            AbstractFieldInterfaceToInt fieldToInt = new HeadFieldInterfacesToInt();

            StringBuilder toReturn = new StringBuilder();
            for (int j = 0; j < this.YLength(); j++)
            {
                for (int i = 0; i < this.XLength(); i++)
                {
                    toReturn.Append(fieldToInt.Convert(this.At(i, j)));
                }
                toReturn.Append("\n");
            }
            return toReturn.ToString();
        }

        public string StringVessels()
        {
            ToString vesselsName = new VesselsToString();
            ToString itemName = new ItemsToString();

            StringBuilder toReturn = new StringBuilder();
            int vesselIndex = 1;
            int itemIndex = 1;

            foreach (AbstractVessel vessel in this.GetListOfVessels())
            {
                toReturn.Append(vesselIndex + " " + vesselsName.ToString(vessel) + "\n");
                foreach (IItem item in vessel.Items)
                {
                    if (item != null)
                    {
                        toReturn.Append("    " + itemIndex + itemName.ToString(item) + "\n");
                    }
                    else
                    {
                        toReturn.Append("    " + itemIndex + "Vacio" + "\n");
                    }
                    itemIndex++;
                }
                toReturn.Append("\n");
                itemIndex = 1;
                vesselIndex ++;
            }
            return toReturn.ToString();
        }
        public string EmojiTable()
        {
            AbstractFieldInterfaceToEmoji fieldToEmoji = new HeadFieldInterfacesToEmoji();
            StringBuilder toReturn = new StringBuilder();
            for (int j = 0; j < this.YLength(); j++)
            {
                for (int i = 0; i < this.XLength(); i++)
                {
                    toReturn.Append(fieldToEmoji.Convert(this.At(i,j)));
                }
                toReturn.Append("\n");
            }
            return toReturn.ToString();
        }
    }
}