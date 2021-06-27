﻿
// S - SRP: Esta clase tiene la responsabilidad de definir los metodos necesarios para que un barco pueda guardar items.

// O -  OCP: Si se aplica, para agregar una forma diferente de guardar items basta con implementar una nueva clase.

// L -  LSP: Cualquier clase que herede esta debe ser y es un subtipo de esta clase.

// I -  ISP: No se aplica.

// D -  DIP: Esta clase solo depende de abstracciones.

//      Expert: Esta clase conoce los items, por lo tanto se encarga de su manejo.

//      Polymorphism: No se aplica.

//      Creator: No se utiliza.

using System.Collections.ObjectModel;
using System;

namespace Library
{
    public abstract class AbstractItemSaver
    {
        protected IItem[] _items;
        private bool _blocked = false;
        public ReadOnlyCollection<IItem> Items
        {
            get
            {
                return Array.AsReadOnly<IItem>(this._items);
            }
        }
        public AbstractItemSaver(int size)
        {
            this._items = new IItem[size];
        }
        public int CountItem()
        {
            int i = 0;
            foreach (IItem item in this._items)
            {
                if (item != null)
                {
                    i++;
                }
            }
            return i;
        }
        public int Length()
        {
            return this._items.Length;
        }
        public void Block()
        {
            this._blocked = false;
        }
        public void Unblock()
        {
            this._blocked = true;
        }
        public bool AddItem(int position, IItem toAdd, AbstractTable table, IItemValidator validator)
        {
            if (this._blocked)
            {
                throw new BlockedVesselException();
            }
            if (validator.IsAddable(position, this, table))
            {
                this._items[position] = toAdd;
                return true;
            }
            return false;
        }
        public void RemoveItem(IItem toRemove)
        {
            int index = Array.IndexOf(this._items, toRemove);
            if (index != -1)
            {
                this._items[index] = null;
            }
        }
    }
}