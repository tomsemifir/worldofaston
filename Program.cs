﻿using System;

namespace WorldOfAston
{
    class Program
    {
        static void Main(string[] args)
        {
            Monde.Combat(Monde.PersonnageFactory(), Monde.MonstreFactory());
        }
    }
}
