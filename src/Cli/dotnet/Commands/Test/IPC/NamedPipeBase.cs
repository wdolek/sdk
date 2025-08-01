﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

#nullable disable

#pragma warning disable IDE0240 // Remove redundant nullable directive
#nullable disable
#pragma warning restore IDE0240 // Remove redundant nullable directive

using System.Globalization;
using Microsoft.DotNet.Cli.Commands.Test.IPC.Serializers;

namespace Microsoft.DotNet.Cli.Commands.Test.IPC;

internal abstract class NamedPipeBase
{
    private readonly Dictionary<Type, INamedPipeSerializer> _typeSerializer = [];
    private readonly Dictionary<int, INamedPipeSerializer> _idSerializer = [];

    public void RegisterSerializer(INamedPipeSerializer namedPipeSerializer, Type type)
    {
        _typeSerializer.Add(type, namedPipeSerializer);
        _idSerializer.Add(namedPipeSerializer.Id, namedPipeSerializer);
    }

    protected INamedPipeSerializer GetSerializer(int id, bool skipUnknownMessages = false)
    {
        if (_idSerializer.TryGetValue(id, out INamedPipeSerializer serializer))
        {
            return serializer;
        }
        else
        {
            return skipUnknownMessages
                ? new UnknownMessageSerializer(id)
                : throw new ArgumentException((string.Format(
                CultureInfo.InvariantCulture,
#if dotnet
                 LocalizableStrings.NoSerializerRegisteredWithIdErrorMessage,
#else
                "No serializer registered with ID '{0}'",
#endif
                id)));
        }
    }


    protected INamedPipeSerializer GetSerializer(Type type)
        => _typeSerializer.TryGetValue(type, out INamedPipeSerializer serializer)
            ? serializer
            : throw new ArgumentException(string.Format(
                CultureInfo.InvariantCulture,
#if dotnet
                 LocalizableStrings.NoSerializerRegisteredWithTypeErrorMessage,
#else
                "No serializer registered with type '{0}'",
#endif
                type));
}
