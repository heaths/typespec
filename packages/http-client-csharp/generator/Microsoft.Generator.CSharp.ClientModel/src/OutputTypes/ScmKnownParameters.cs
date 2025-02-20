// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Text.Json;
using System.Xml;
using System.Xml.Linq;
using Microsoft.Generator.CSharp.Providers;
using static Microsoft.Generator.CSharp.Snippets.Snippet;

namespace Microsoft.Generator.CSharp.ClientModel
{
    internal static class ScmKnownParameters
    {
        private static readonly CSharpType modelReaderWriterOptionsType = typeof(ModelReaderWriterOptions);
        private static readonly CSharpType nullableModelReaderWriterOptionsType = new CSharpType(typeof(ModelReaderWriterOptions), isNullable: true);

        public static readonly ParameterProvider XmlWriter = new("writer", FormattableStringHelpers.Empty, typeof(XmlWriter));
        public static readonly ParameterProvider NameHint = new("nameHint", FormattableStringHelpers.Empty, typeof(string));
        public static readonly ParameterProvider XElement = new("element", FormattableStringHelpers.Empty, typeof(XElement));
        public static readonly ParameterProvider Utf8JsonWriter = new("writer", FormattableStringHelpers.Empty, typeof(Utf8JsonWriter));
        public static readonly ParameterProvider Utf8JsonReader = new("reader", FormattableStringHelpers.Empty, typeof(Utf8JsonReader), isRef: true);
        public static readonly ParameterProvider JsonOptions = new("options", FormattableStringHelpers.Empty, typeof(JsonSerializerOptions));
        public static readonly ParameterProvider Options = new("options", FormattableStringHelpers.Empty, modelReaderWriterOptionsType);
        public static readonly ParameterProvider OptionalOptions = new("options", FormattableStringHelpers.Empty, nullableModelReaderWriterOptionsType, DefaultOf(nullableModelReaderWriterOptionsType));
        public static readonly ParameterProvider JsonElement = new("element", FormattableStringHelpers.Empty, typeof(JsonElement));
        public static readonly ParameterProvider Data = new("data", FormattableStringHelpers.Empty, typeof(BinaryData));
        public static readonly ParameterProvider TokenAuth = new("tokenCredential", $"The token credential to copy", ClientModelPlugin.Instance.TypeFactory.TokenCredentialType());
        public static readonly ParameterProvider MatchConditionsParameter = new("matchConditions", $"The content to send as the request conditions of the request.", ClientModelPlugin.Instance.TypeFactory.MatchConditionsType(), DefaultOf(ClientModelPlugin.Instance.TypeFactory.MatchConditionsType()));
        public static readonly ParameterProvider RequestOptions = new("options", $"The request options, which can override default behaviors of the client pipeline on a per-call basis.", typeof(RequestOptions));
        public static readonly ParameterProvider BinaryContent = new("content", $"The content to send as the body of the request.", typeof(BinaryContent));
    }
}
