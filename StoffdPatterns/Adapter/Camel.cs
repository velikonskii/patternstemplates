﻿using System;

namespace StoffdPatterns.Adapter {
    public class Camel : IAnimal {
        public void Move() {
            Console.WriteLine("Верблюд идет по пескам");
        }
    }
}