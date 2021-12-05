﻿using System;
using System.Threading.Tasks;

using R5T.T0064;


namespace R5T.D0104
{
    [ServiceDefinitionMarker]
    public interface IServiceCollectionSerializationFilePathProvider : IServiceDefinition
    {
        Task<string> GetServiceCollectionSerializationFilePath();
    }
}
