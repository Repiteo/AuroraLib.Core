﻿namespace AuroraLib.Core.Interfaces
{
    /// <summary>
    /// Interface for compressing and decompressing data.
    /// </summary>
    public interface ICompressionAlgorithm : ICompressionDecoder, ICompressionEncoder
    { }
}
