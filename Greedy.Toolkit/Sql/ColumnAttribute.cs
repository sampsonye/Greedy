﻿using System;

namespace Greedy.Toolkit.Sql
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false, Inherited = true)]
    public class ColumnAttribute : Attribute
    {
        public string Name { get; set; }

        public ColumnAttribute(string name)
        {
            this.Name = name;
        }
    }
}
