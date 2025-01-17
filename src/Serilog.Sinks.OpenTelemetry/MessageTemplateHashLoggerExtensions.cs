﻿// Copyright 2022 Serilog Contributors
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using Serilog.Configuration;
using Serilog.Sinks.OpenTelemetry;

namespace Serilog;

/// <summary>
/// Class containing extension methods to <see cref="LoggerConfiguration"/>, configuring an
/// enricher that adds the MD5 hash of the message template to the payload. 
/// </summary>
public static class MessageTemplateHashLoggerConfigurationExtensions
{
    /// <summary>
    /// The MD5 hash of the message template is added as a property to 
    /// the payload.
    /// </summary>
    /// <returns>Logger configuration, allowing configuration to continue.</returns>
    public static LoggerConfiguration WithMessageTemplateHash(
        this LoggerEnrichmentConfiguration enrichConfiguration)
    {
        if (enrichConfiguration == null) throw new ArgumentNullException(nameof(enrichConfiguration));

        return enrichConfiguration.With<MessageTemplateHashEnricher>();
    }
}
