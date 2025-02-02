// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    [JsonConverter(typeof(ExposureControlResponseConverter))]
    public partial class ExposureControlResponse : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WriteEndObject();
        }

        internal static ExposureControlResponse DeserializeExposureControlResponse(JsonElement element)
        {
            Optional<string> featureName = default;
            Optional<string> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("featureName"u8))
                {
                    featureName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("value"u8))
                {
                    value = property.Value.GetString();
                    continue;
                }
            }
            return new ExposureControlResponse(featureName.Value, value.Value);
        }

        internal partial class ExposureControlResponseConverter : JsonConverter<ExposureControlResponse>
        {
            public override void Write(Utf8JsonWriter writer, ExposureControlResponse model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override ExposureControlResponse Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeExposureControlResponse(document.RootElement);
            }
        }
    }
}
