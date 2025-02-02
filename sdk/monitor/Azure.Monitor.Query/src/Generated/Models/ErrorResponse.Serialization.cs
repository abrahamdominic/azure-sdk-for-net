// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Monitor.Query.Models
{
    internal partial class ErrorResponse
    {
        internal static ErrorResponse DeserializeErrorResponse(JsonElement element)
        {
            ErrorInfo error = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("error"u8))
                {
                    error = ErrorInfo.DeserializeErrorInfo(property.Value);
                    continue;
                }
            }
            return new ErrorResponse(error);
        }
    }
}
