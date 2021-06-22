﻿using System;

namespace Library
{
    public class ClientReader : IReader
    {
        public string Read()
        {
            return Console.ReadLine();
        }
        public string Read(IPrinter printer, object msg)
        {
            printer.Print(msg);
            return this.Read();
        }
        public int ReadInt(int from, int until, IPrinter printer, object msg)
        {
            printer.Print(msg);
            int read;
            while (true)
            {
                try
                {
                    read = Int32.Parse(this.Read());
                    if (from <= read && read <= until)
                    {
                        break;
                    }
                }
                catch (FormatException)
                {
                    printer.Print("Debes ingresar un numero entero: ");
                }
                catch (OverflowException)
                {
                    printer.Print("El numero ingresado es demaciado grande: ");
                }
                catch (Exception)
                {

                }
                printer.Print("Debes ingresar un numero entre " + from + " y " + until + " :");
            }
            return read;
        }
    }
}