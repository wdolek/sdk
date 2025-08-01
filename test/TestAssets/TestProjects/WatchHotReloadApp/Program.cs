// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using System.Linq;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.Versioning;
using System.Threading;
using System.Threading.Tasks;

// <metadata update handler placeholder>

var assembly = typeof(C).Assembly;

Console.WriteLine("Started");

// Process ID is insufficient because PID's may be reused.
Console.WriteLine($"Process identifier = {Process.GetCurrentProcess().Id}, {Guid.NewGuid()}");
Console.WriteLine($"DOTNET_WATCH = {Environment.GetEnvironmentVariable("DOTNET_WATCH")}");
Console.WriteLine($"DOTNET_WATCH_ITERATION = {Environment.GetEnvironmentVariable("DOTNET_WATCH_ITERATION")}");
Console.WriteLine($"Arguments = {string.Join(",", args)}");
Console.WriteLine($"Version = {assembly.GetCustomAttributes<AssemblyVersionAttribute>().FirstOrDefault()?.Version ?? "<unspecified>"}");
Console.WriteLine($"TFM = {assembly.GetCustomAttributes<TargetFrameworkAttribute>().FirstOrDefault()?.FrameworkName ?? "<unspecified>"}");
Console.WriteLine($"Configuration = {assembly.GetCustomAttributes<AssemblyConfigurationAttribute>().FirstOrDefault()?.Configuration ?? "<unspecified>"}");

while (true)
{
    F();
    await Task.Delay(1000);
}

void F()
{
    Console.WriteLine(".");
}

class C { /* member placeholder */ }

