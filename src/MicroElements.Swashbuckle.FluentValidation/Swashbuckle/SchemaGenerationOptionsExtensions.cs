﻿using MicroElements.OpenApi.FluentValidation;
using Microsoft.Extensions.Options;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace MicroElements.Swashbuckle.FluentValidation
{
    public static class SchemaGenerationOptionsExtensions
    {
        public static SchemaGenerationOptions FillFromSwashbuckleOptions(this SchemaGenerationOptions options, IOptions<SwaggerGenOptions>? swaggerGenOptions = null)
        {
            // Swashbuckle services
            if (options.SchemaIdSelector is null)
            {
                options.SchemaIdSelector =
                    swaggerGenOptions?.Value.SchemaGeneratorOptions.SchemaIdSelector ??
                    new SchemaGeneratorOptions().SchemaIdSelector;
            }

            return options;
        }
    }
}