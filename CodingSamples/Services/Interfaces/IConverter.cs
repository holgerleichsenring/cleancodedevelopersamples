﻿namespace CodingSamples.Services.Interfaces
{
    public interface IConverter<in TFrom, out TTo>
    {
        TTo Convert(TFrom source);
    }
}
