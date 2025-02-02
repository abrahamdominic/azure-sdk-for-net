// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    internal partial class ServiceAssociationLinksListResult
    {
        internal static ServiceAssociationLinksListResult DeserializeServiceAssociationLinksListResult(JsonElement element)
        {
            Optional<IReadOnlyList<ServiceAssociationLink>> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<ServiceAssociationLink> array = new List<ServiceAssociationLink>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ServiceAssociationLink.DeserializeServiceAssociationLink(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"u8))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
            }
            return new ServiceAssociationLinksListResult(Optional.ToList(value), nextLink.Value);
        }
    }
}
