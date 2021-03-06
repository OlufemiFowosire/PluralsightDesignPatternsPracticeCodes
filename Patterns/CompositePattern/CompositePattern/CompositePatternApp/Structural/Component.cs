﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePatternApp.Structural
{
    public abstract class Component
    {
        public Component(string name)
        {
            Name = name;
        }

        public string Name { get; }

        public abstract void PrimaryOperation(int depth);
        public abstract void Add(Component c);
        public abstract void Remove(Component c);
    }
}
