﻿// ==========================================================================
//  Squidex Headless CMS
// ==========================================================================
//  Copyright (c) Squidex UG (haftungsbeschränkt)
//  All rights reserved. Licensed under the MIT license.
// ==========================================================================

using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using Squidex.Infrastructure.Json.Newtonsoft;

namespace Squidex.Domain.Apps.Core.Apps.Json
{
    public sealed class AppPatternsConverter : JsonClassConverter<AppPatterns>
    {
        protected override void WriteValue(JsonWriter writer, AppPatterns value, JsonSerializer serializer)
        {
            var json = new Dictionary<Guid, AppPattern>(value.Count);

            foreach (var (key, pattern) in value)
            {
                json.Add(key, pattern);
            }

            serializer.Serialize(writer, json);
        }

        protected override AppPatterns ReadValue(JsonReader reader, Type objectType, JsonSerializer serializer)
        {
            var json = serializer.Deserialize<Dictionary<Guid, AppPattern>>(reader)!;

            return new AppPatterns(json);
        }
    }
}
