// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppService.Models
{
    internal partial class AppServiceBlobStorageTokenStore : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(SasUrlSettingName))
            {
                writer.WritePropertyName("sasUrlSettingName"u8);
                writer.WriteStringValue(SasUrlSettingName);
            }
            writer.WriteEndObject();
        }

        internal static AppServiceBlobStorageTokenStore DeserializeAppServiceBlobStorageTokenStore(JsonElement element)
        {
            Optional<string> sasUrlSettingName = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sasUrlSettingName"u8))
                {
                    sasUrlSettingName = property.Value.GetString();
                    continue;
                }
            }
            return new AppServiceBlobStorageTokenStore(sasUrlSettingName.Value);
        }
    }
}
