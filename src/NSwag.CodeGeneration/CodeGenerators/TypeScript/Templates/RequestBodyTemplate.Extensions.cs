﻿using NJsonSchema.CodeGeneration;
using NSwag.CodeGeneration.CodeGenerators.Models;

namespace NSwag.CodeGeneration.CodeGenerators.TypeScript.Templates
{
    internal partial class RequestBodyTemplate : ITemplate
    {
        public RequestBodyTemplate(ParameterModel model)
        {
            Model = model;
        }

        public ParameterModel Model { get; }
        
        public string Render()
        {
            return ConversionUtilities.TrimWhiteSpaces(TransformText());
        }
    }
}
