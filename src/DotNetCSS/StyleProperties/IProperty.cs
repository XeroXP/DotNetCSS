﻿namespace DotNetCSS
{
    public interface IProperty : IStylesheetNode
    {
        string Name { get; }
        string Value { get; }
        bool IsImportant { get; }
    }
}