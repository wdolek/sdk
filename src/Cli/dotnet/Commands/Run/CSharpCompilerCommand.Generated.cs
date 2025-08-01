// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Microsoft.DotNet.Cli.Commands.Run;

// Generated by test `RunFileTests.CscArguments`.
partial class CSharpCompilerCommand
{
    private IEnumerable<string> GetCscArguments(
        string fileNameWithoutExtension,
        string objDir,
        string binDir)
    {
        return
        [
            "/unsafe-",
            "/checked-",
            "/nowarn:1701,1702,IL2121,1701,1702",
            "/fullpaths",
            "/nostdlib+",
            "/errorreport:prompt",
            "/warn:10",
            "/define:TRACE;DEBUG;NET;NET10_0;NETCOREAPP;NET5_0_OR_GREATER;NET6_0_OR_GREATER;NET7_0_OR_GREATER;NET8_0_OR_GREATER;NET9_0_OR_GREATER;NET10_0_OR_GREATER;NETCOREAPP1_0_OR_GREATER;NETCOREAPP1_1_OR_GREATER;NETCOREAPP2_0_OR_GREATER;NETCOREAPP2_1_OR_GREATER;NETCOREAPP2_2_OR_GREATER;NETCOREAPP3_0_OR_GREATER;NETCOREAPP3_1_OR_GREATER",
            "/highentropyva+",
            "/nullable:enable",
            $"/reference:{DotNetRootPath}/packs/Microsoft.NETCore.App.Ref/{RuntimeVersion}/ref/net10.0/Microsoft.CSharp.dll",
            $"/reference:{DotNetRootPath}/packs/Microsoft.NETCore.App.Ref/{RuntimeVersion}/ref/net10.0/Microsoft.VisualBasic.Core.dll",
            $"/reference:{DotNetRootPath}/packs/Microsoft.NETCore.App.Ref/{RuntimeVersion}/ref/net10.0/Microsoft.VisualBasic.dll",
            $"/reference:{DotNetRootPath}/packs/Microsoft.NETCore.App.Ref/{RuntimeVersion}/ref/net10.0/Microsoft.Win32.Primitives.dll",
            $"/reference:{DotNetRootPath}/packs/Microsoft.NETCore.App.Ref/{RuntimeVersion}/ref/net10.0/Microsoft.Win32.Registry.dll",
            $"/reference:{DotNetRootPath}/packs/Microsoft.NETCore.App.Ref/{RuntimeVersion}/ref/net10.0/mscorlib.dll",
            $"/reference:{DotNetRootPath}/packs/Microsoft.NETCore.App.Ref/{RuntimeVersion}/ref/net10.0/netstandard.dll",
            $"/reference:{DotNetRootPath}/packs/Microsoft.NETCore.App.Ref/{RuntimeVersion}/ref/net10.0/System.AppContext.dll",
            $"/reference:{DotNetRootPath}/packs/Microsoft.NETCore.App.Ref/{RuntimeVersion}/ref/net10.0/System.Buffers.dll",
            $"/reference:{DotNetRootPath}/packs/Microsoft.NETCore.App.Ref/{RuntimeVersion}/ref/net10.0/System.Collections.Concurrent.dll",
            $"/reference:{DotNetRootPath}/packs/Microsoft.NETCore.App.Ref/{RuntimeVersion}/ref/net10.0/System.Collections.dll",
            $"/reference:{DotNetRootPath}/packs/Microsoft.NETCore.App.Ref/{RuntimeVersion}/ref/net10.0/System.Collections.Immutable.dll",
            $"/reference:{DotNetRootPath}/packs/Microsoft.NETCore.App.Ref/{RuntimeVersion}/ref/net10.0/System.Collections.NonGeneric.dll",
            $"/reference:{DotNetRootPath}/packs/Microsoft.NETCore.App.Ref/{RuntimeVersion}/ref/net10.0/System.Collections.Specialized.dll",
            $"/reference:{DotNetRootPath}/packs/Microsoft.NETCore.App.Ref/{RuntimeVersion}/ref/net10.0/System.ComponentModel.Annotations.dll",
            $"/reference:{DotNetRootPath}/packs/Microsoft.NETCore.App.Ref/{RuntimeVersion}/ref/net10.0/System.ComponentModel.DataAnnotations.dll",
            $"/reference:{DotNetRootPath}/packs/Microsoft.NETCore.App.Ref/{RuntimeVersion}/ref/net10.0/System.ComponentModel.dll",
            $"/reference:{DotNetRootPath}/packs/Microsoft.NETCore.App.Ref/{RuntimeVersion}/ref/net10.0/System.ComponentModel.EventBasedAsync.dll",
            $"/reference:{DotNetRootPath}/packs/Microsoft.NETCore.App.Ref/{RuntimeVersion}/ref/net10.0/System.ComponentModel.Primitives.dll",
            $"/reference:{DotNetRootPath}/packs/Microsoft.NETCore.App.Ref/{RuntimeVersion}/ref/net10.0/System.ComponentModel.TypeConverter.dll",
            $"/reference:{DotNetRootPath}/packs/Microsoft.NETCore.App.Ref/{RuntimeVersion}/ref/net10.0/System.Configuration.dll",
            $"/reference:{DotNetRootPath}/packs/Microsoft.NETCore.App.Ref/{RuntimeVersion}/ref/net10.0/System.Console.dll",
            $"/reference:{DotNetRootPath}/packs/Microsoft.NETCore.App.Ref/{RuntimeVersion}/ref/net10.0/System.Core.dll",
            $"/reference:{DotNetRootPath}/packs/Microsoft.NETCore.App.Ref/{RuntimeVersion}/ref/net10.0/System.Data.Common.dll",
            $"/reference:{DotNetRootPath}/packs/Microsoft.NETCore.App.Ref/{RuntimeVersion}/ref/net10.0/System.Data.DataSetExtensions.dll",
            $"/reference:{DotNetRootPath}/packs/Microsoft.NETCore.App.Ref/{RuntimeVersion}/ref/net10.0/System.Data.dll",
            $"/reference:{DotNetRootPath}/packs/Microsoft.NETCore.App.Ref/{RuntimeVersion}/ref/net10.0/System.Diagnostics.Contracts.dll",
            $"/reference:{DotNetRootPath}/packs/Microsoft.NETCore.App.Ref/{RuntimeVersion}/ref/net10.0/System.Diagnostics.Debug.dll",
            $"/reference:{DotNetRootPath}/packs/Microsoft.NETCore.App.Ref/{RuntimeVersion}/ref/net10.0/System.Diagnostics.DiagnosticSource.dll",
            $"/reference:{DotNetRootPath}/packs/Microsoft.NETCore.App.Ref/{RuntimeVersion}/ref/net10.0/System.Diagnostics.FileVersionInfo.dll",
            $"/reference:{DotNetRootPath}/packs/Microsoft.NETCore.App.Ref/{RuntimeVersion}/ref/net10.0/System.Diagnostics.Process.dll",
            $"/reference:{DotNetRootPath}/packs/Microsoft.NETCore.App.Ref/{RuntimeVersion}/ref/net10.0/System.Diagnostics.StackTrace.dll",
            $"/reference:{DotNetRootPath}/packs/Microsoft.NETCore.App.Ref/{RuntimeVersion}/ref/net10.0/System.Diagnostics.TextWriterTraceListener.dll",
            $"/reference:{DotNetRootPath}/packs/Microsoft.NETCore.App.Ref/{RuntimeVersion}/ref/net10.0/System.Diagnostics.Tools.dll",
            $"/reference:{DotNetRootPath}/packs/Microsoft.NETCore.App.Ref/{RuntimeVersion}/ref/net10.0/System.Diagnostics.TraceSource.dll",
            $"/reference:{DotNetRootPath}/packs/Microsoft.NETCore.App.Ref/{RuntimeVersion}/ref/net10.0/System.Diagnostics.Tracing.dll",
            $"/reference:{DotNetRootPath}/packs/Microsoft.NETCore.App.Ref/{RuntimeVersion}/ref/net10.0/System.dll",
            $"/reference:{DotNetRootPath}/packs/Microsoft.NETCore.App.Ref/{RuntimeVersion}/ref/net10.0/System.Drawing.dll",
            $"/reference:{DotNetRootPath}/packs/Microsoft.NETCore.App.Ref/{RuntimeVersion}/ref/net10.0/System.Drawing.Primitives.dll",
            $"/reference:{DotNetRootPath}/packs/Microsoft.NETCore.App.Ref/{RuntimeVersion}/ref/net10.0/System.Dynamic.Runtime.dll",
            $"/reference:{DotNetRootPath}/packs/Microsoft.NETCore.App.Ref/{RuntimeVersion}/ref/net10.0/System.Formats.Asn1.dll",
            $"/reference:{DotNetRootPath}/packs/Microsoft.NETCore.App.Ref/{RuntimeVersion}/ref/net10.0/System.Formats.Tar.dll",
            $"/reference:{DotNetRootPath}/packs/Microsoft.NETCore.App.Ref/{RuntimeVersion}/ref/net10.0/System.Globalization.Calendars.dll",
            $"/reference:{DotNetRootPath}/packs/Microsoft.NETCore.App.Ref/{RuntimeVersion}/ref/net10.0/System.Globalization.dll",
            $"/reference:{DotNetRootPath}/packs/Microsoft.NETCore.App.Ref/{RuntimeVersion}/ref/net10.0/System.Globalization.Extensions.dll",
            $"/reference:{DotNetRootPath}/packs/Microsoft.NETCore.App.Ref/{RuntimeVersion}/ref/net10.0/System.IO.Compression.Brotli.dll",
            $"/reference:{DotNetRootPath}/packs/Microsoft.NETCore.App.Ref/{RuntimeVersion}/ref/net10.0/System.IO.Compression.dll",
            $"/reference:{DotNetRootPath}/packs/Microsoft.NETCore.App.Ref/{RuntimeVersion}/ref/net10.0/System.IO.Compression.FileSystem.dll",
            $"/reference:{DotNetRootPath}/packs/Microsoft.NETCore.App.Ref/{RuntimeVersion}/ref/net10.0/System.IO.Compression.ZipFile.dll",
            $"/reference:{DotNetRootPath}/packs/Microsoft.NETCore.App.Ref/{RuntimeVersion}/ref/net10.0/System.IO.dll",
            $"/reference:{DotNetRootPath}/packs/Microsoft.NETCore.App.Ref/{RuntimeVersion}/ref/net10.0/System.IO.FileSystem.AccessControl.dll",
            $"/reference:{DotNetRootPath}/packs/Microsoft.NETCore.App.Ref/{RuntimeVersion}/ref/net10.0/System.IO.FileSystem.dll",
            $"/reference:{DotNetRootPath}/packs/Microsoft.NETCore.App.Ref/{RuntimeVersion}/ref/net10.0/System.IO.FileSystem.DriveInfo.dll",
            $"/reference:{DotNetRootPath}/packs/Microsoft.NETCore.App.Ref/{RuntimeVersion}/ref/net10.0/System.IO.FileSystem.Primitives.dll",
            $"/reference:{DotNetRootPath}/packs/Microsoft.NETCore.App.Ref/{RuntimeVersion}/ref/net10.0/System.IO.FileSystem.Watcher.dll",
            $"/reference:{DotNetRootPath}/packs/Microsoft.NETCore.App.Ref/{RuntimeVersion}/ref/net10.0/System.IO.IsolatedStorage.dll",
            $"/reference:{DotNetRootPath}/packs/Microsoft.NETCore.App.Ref/{RuntimeVersion}/ref/net10.0/System.IO.MemoryMappedFiles.dll",
            $"/reference:{DotNetRootPath}/packs/Microsoft.NETCore.App.Ref/{RuntimeVersion}/ref/net10.0/System.IO.Pipelines.dll",
            $"/reference:{DotNetRootPath}/packs/Microsoft.NETCore.App.Ref/{RuntimeVersion}/ref/net10.0/System.IO.Pipes.AccessControl.dll",
            $"/reference:{DotNetRootPath}/packs/Microsoft.NETCore.App.Ref/{RuntimeVersion}/ref/net10.0/System.IO.Pipes.dll",
            $"/reference:{DotNetRootPath}/packs/Microsoft.NETCore.App.Ref/{RuntimeVersion}/ref/net10.0/System.IO.UnmanagedMemoryStream.dll",
            $"/reference:{DotNetRootPath}/packs/Microsoft.NETCore.App.Ref/{RuntimeVersion}/ref/net10.0/System.Linq.AsyncEnumerable.dll",
            $"/reference:{DotNetRootPath}/packs/Microsoft.NETCore.App.Ref/{RuntimeVersion}/ref/net10.0/System.Linq.dll",
            $"/reference:{DotNetRootPath}/packs/Microsoft.NETCore.App.Ref/{RuntimeVersion}/ref/net10.0/System.Linq.Expressions.dll",
            $"/reference:{DotNetRootPath}/packs/Microsoft.NETCore.App.Ref/{RuntimeVersion}/ref/net10.0/System.Linq.Parallel.dll",
            $"/reference:{DotNetRootPath}/packs/Microsoft.NETCore.App.Ref/{RuntimeVersion}/ref/net10.0/System.Linq.Queryable.dll",
            $"/reference:{DotNetRootPath}/packs/Microsoft.NETCore.App.Ref/{RuntimeVersion}/ref/net10.0/System.Memory.dll",
            $"/reference:{DotNetRootPath}/packs/Microsoft.NETCore.App.Ref/{RuntimeVersion}/ref/net10.0/System.Net.dll",
            $"/reference:{DotNetRootPath}/packs/Microsoft.NETCore.App.Ref/{RuntimeVersion}/ref/net10.0/System.Net.Http.dll",
            $"/reference:{DotNetRootPath}/packs/Microsoft.NETCore.App.Ref/{RuntimeVersion}/ref/net10.0/System.Net.Http.Json.dll",
            $"/reference:{DotNetRootPath}/packs/Microsoft.NETCore.App.Ref/{RuntimeVersion}/ref/net10.0/System.Net.HttpListener.dll",
            $"/reference:{DotNetRootPath}/packs/Microsoft.NETCore.App.Ref/{RuntimeVersion}/ref/net10.0/System.Net.Mail.dll",
            $"/reference:{DotNetRootPath}/packs/Microsoft.NETCore.App.Ref/{RuntimeVersion}/ref/net10.0/System.Net.NameResolution.dll",
            $"/reference:{DotNetRootPath}/packs/Microsoft.NETCore.App.Ref/{RuntimeVersion}/ref/net10.0/System.Net.NetworkInformation.dll",
            $"/reference:{DotNetRootPath}/packs/Microsoft.NETCore.App.Ref/{RuntimeVersion}/ref/net10.0/System.Net.Ping.dll",
            $"/reference:{DotNetRootPath}/packs/Microsoft.NETCore.App.Ref/{RuntimeVersion}/ref/net10.0/System.Net.Primitives.dll",
            $"/reference:{DotNetRootPath}/packs/Microsoft.NETCore.App.Ref/{RuntimeVersion}/ref/net10.0/System.Net.Quic.dll",
            $"/reference:{DotNetRootPath}/packs/Microsoft.NETCore.App.Ref/{RuntimeVersion}/ref/net10.0/System.Net.Requests.dll",
            $"/reference:{DotNetRootPath}/packs/Microsoft.NETCore.App.Ref/{RuntimeVersion}/ref/net10.0/System.Net.Security.dll",
            $"/reference:{DotNetRootPath}/packs/Microsoft.NETCore.App.Ref/{RuntimeVersion}/ref/net10.0/System.Net.ServerSentEvents.dll",
            $"/reference:{DotNetRootPath}/packs/Microsoft.NETCore.App.Ref/{RuntimeVersion}/ref/net10.0/System.Net.ServicePoint.dll",
            $"/reference:{DotNetRootPath}/packs/Microsoft.NETCore.App.Ref/{RuntimeVersion}/ref/net10.0/System.Net.Sockets.dll",
            $"/reference:{DotNetRootPath}/packs/Microsoft.NETCore.App.Ref/{RuntimeVersion}/ref/net10.0/System.Net.WebClient.dll",
            $"/reference:{DotNetRootPath}/packs/Microsoft.NETCore.App.Ref/{RuntimeVersion}/ref/net10.0/System.Net.WebHeaderCollection.dll",
            $"/reference:{DotNetRootPath}/packs/Microsoft.NETCore.App.Ref/{RuntimeVersion}/ref/net10.0/System.Net.WebProxy.dll",
            $"/reference:{DotNetRootPath}/packs/Microsoft.NETCore.App.Ref/{RuntimeVersion}/ref/net10.0/System.Net.WebSockets.Client.dll",
            $"/reference:{DotNetRootPath}/packs/Microsoft.NETCore.App.Ref/{RuntimeVersion}/ref/net10.0/System.Net.WebSockets.dll",
            $"/reference:{DotNetRootPath}/packs/Microsoft.NETCore.App.Ref/{RuntimeVersion}/ref/net10.0/System.Numerics.dll",
            $"/reference:{DotNetRootPath}/packs/Microsoft.NETCore.App.Ref/{RuntimeVersion}/ref/net10.0/System.Numerics.Vectors.dll",
            $"/reference:{DotNetRootPath}/packs/Microsoft.NETCore.App.Ref/{RuntimeVersion}/ref/net10.0/System.ObjectModel.dll",
            $"/reference:{DotNetRootPath}/packs/Microsoft.NETCore.App.Ref/{RuntimeVersion}/ref/net10.0/System.Reflection.DispatchProxy.dll",
            $"/reference:{DotNetRootPath}/packs/Microsoft.NETCore.App.Ref/{RuntimeVersion}/ref/net10.0/System.Reflection.dll",
            $"/reference:{DotNetRootPath}/packs/Microsoft.NETCore.App.Ref/{RuntimeVersion}/ref/net10.0/System.Reflection.Emit.dll",
            $"/reference:{DotNetRootPath}/packs/Microsoft.NETCore.App.Ref/{RuntimeVersion}/ref/net10.0/System.Reflection.Emit.ILGeneration.dll",
            $"/reference:{DotNetRootPath}/packs/Microsoft.NETCore.App.Ref/{RuntimeVersion}/ref/net10.0/System.Reflection.Emit.Lightweight.dll",
            $"/reference:{DotNetRootPath}/packs/Microsoft.NETCore.App.Ref/{RuntimeVersion}/ref/net10.0/System.Reflection.Extensions.dll",
            $"/reference:{DotNetRootPath}/packs/Microsoft.NETCore.App.Ref/{RuntimeVersion}/ref/net10.0/System.Reflection.Metadata.dll",
            $"/reference:{DotNetRootPath}/packs/Microsoft.NETCore.App.Ref/{RuntimeVersion}/ref/net10.0/System.Reflection.Primitives.dll",
            $"/reference:{DotNetRootPath}/packs/Microsoft.NETCore.App.Ref/{RuntimeVersion}/ref/net10.0/System.Reflection.TypeExtensions.dll",
            $"/reference:{DotNetRootPath}/packs/Microsoft.NETCore.App.Ref/{RuntimeVersion}/ref/net10.0/System.Resources.Reader.dll",
            $"/reference:{DotNetRootPath}/packs/Microsoft.NETCore.App.Ref/{RuntimeVersion}/ref/net10.0/System.Resources.ResourceManager.dll",
            $"/reference:{DotNetRootPath}/packs/Microsoft.NETCore.App.Ref/{RuntimeVersion}/ref/net10.0/System.Resources.Writer.dll",
            $"/reference:{DotNetRootPath}/packs/Microsoft.NETCore.App.Ref/{RuntimeVersion}/ref/net10.0/System.Runtime.CompilerServices.Unsafe.dll",
            $"/reference:{DotNetRootPath}/packs/Microsoft.NETCore.App.Ref/{RuntimeVersion}/ref/net10.0/System.Runtime.CompilerServices.VisualC.dll",
            $"/reference:{DotNetRootPath}/packs/Microsoft.NETCore.App.Ref/{RuntimeVersion}/ref/net10.0/System.Runtime.dll",
            $"/reference:{DotNetRootPath}/packs/Microsoft.NETCore.App.Ref/{RuntimeVersion}/ref/net10.0/System.Runtime.Extensions.dll",
            $"/reference:{DotNetRootPath}/packs/Microsoft.NETCore.App.Ref/{RuntimeVersion}/ref/net10.0/System.Runtime.Handles.dll",
            $"/reference:{DotNetRootPath}/packs/Microsoft.NETCore.App.Ref/{RuntimeVersion}/ref/net10.0/System.Runtime.InteropServices.dll",
            $"/reference:{DotNetRootPath}/packs/Microsoft.NETCore.App.Ref/{RuntimeVersion}/ref/net10.0/System.Runtime.InteropServices.JavaScript.dll",
            $"/reference:{DotNetRootPath}/packs/Microsoft.NETCore.App.Ref/{RuntimeVersion}/ref/net10.0/System.Runtime.InteropServices.RuntimeInformation.dll",
            $"/reference:{DotNetRootPath}/packs/Microsoft.NETCore.App.Ref/{RuntimeVersion}/ref/net10.0/System.Runtime.Intrinsics.dll",
            $"/reference:{DotNetRootPath}/packs/Microsoft.NETCore.App.Ref/{RuntimeVersion}/ref/net10.0/System.Runtime.Loader.dll",
            $"/reference:{DotNetRootPath}/packs/Microsoft.NETCore.App.Ref/{RuntimeVersion}/ref/net10.0/System.Runtime.Numerics.dll",
            $"/reference:{DotNetRootPath}/packs/Microsoft.NETCore.App.Ref/{RuntimeVersion}/ref/net10.0/System.Runtime.Serialization.dll",
            $"/reference:{DotNetRootPath}/packs/Microsoft.NETCore.App.Ref/{RuntimeVersion}/ref/net10.0/System.Runtime.Serialization.Formatters.dll",
            $"/reference:{DotNetRootPath}/packs/Microsoft.NETCore.App.Ref/{RuntimeVersion}/ref/net10.0/System.Runtime.Serialization.Json.dll",
            $"/reference:{DotNetRootPath}/packs/Microsoft.NETCore.App.Ref/{RuntimeVersion}/ref/net10.0/System.Runtime.Serialization.Primitives.dll",
            $"/reference:{DotNetRootPath}/packs/Microsoft.NETCore.App.Ref/{RuntimeVersion}/ref/net10.0/System.Runtime.Serialization.Xml.dll",
            $"/reference:{DotNetRootPath}/packs/Microsoft.NETCore.App.Ref/{RuntimeVersion}/ref/net10.0/System.Security.AccessControl.dll",
            $"/reference:{DotNetRootPath}/packs/Microsoft.NETCore.App.Ref/{RuntimeVersion}/ref/net10.0/System.Security.Claims.dll",
            $"/reference:{DotNetRootPath}/packs/Microsoft.NETCore.App.Ref/{RuntimeVersion}/ref/net10.0/System.Security.Cryptography.Algorithms.dll",
            $"/reference:{DotNetRootPath}/packs/Microsoft.NETCore.App.Ref/{RuntimeVersion}/ref/net10.0/System.Security.Cryptography.Cng.dll",
            $"/reference:{DotNetRootPath}/packs/Microsoft.NETCore.App.Ref/{RuntimeVersion}/ref/net10.0/System.Security.Cryptography.Csp.dll",
            $"/reference:{DotNetRootPath}/packs/Microsoft.NETCore.App.Ref/{RuntimeVersion}/ref/net10.0/System.Security.Cryptography.dll",
            $"/reference:{DotNetRootPath}/packs/Microsoft.NETCore.App.Ref/{RuntimeVersion}/ref/net10.0/System.Security.Cryptography.Encoding.dll",
            $"/reference:{DotNetRootPath}/packs/Microsoft.NETCore.App.Ref/{RuntimeVersion}/ref/net10.0/System.Security.Cryptography.OpenSsl.dll",
            $"/reference:{DotNetRootPath}/packs/Microsoft.NETCore.App.Ref/{RuntimeVersion}/ref/net10.0/System.Security.Cryptography.Primitives.dll",
            $"/reference:{DotNetRootPath}/packs/Microsoft.NETCore.App.Ref/{RuntimeVersion}/ref/net10.0/System.Security.Cryptography.X509Certificates.dll",
            $"/reference:{DotNetRootPath}/packs/Microsoft.NETCore.App.Ref/{RuntimeVersion}/ref/net10.0/System.Security.dll",
            $"/reference:{DotNetRootPath}/packs/Microsoft.NETCore.App.Ref/{RuntimeVersion}/ref/net10.0/System.Security.Principal.dll",
            $"/reference:{DotNetRootPath}/packs/Microsoft.NETCore.App.Ref/{RuntimeVersion}/ref/net10.0/System.Security.Principal.Windows.dll",
            $"/reference:{DotNetRootPath}/packs/Microsoft.NETCore.App.Ref/{RuntimeVersion}/ref/net10.0/System.Security.SecureString.dll",
            $"/reference:{DotNetRootPath}/packs/Microsoft.NETCore.App.Ref/{RuntimeVersion}/ref/net10.0/System.ServiceModel.Web.dll",
            $"/reference:{DotNetRootPath}/packs/Microsoft.NETCore.App.Ref/{RuntimeVersion}/ref/net10.0/System.ServiceProcess.dll",
            $"/reference:{DotNetRootPath}/packs/Microsoft.NETCore.App.Ref/{RuntimeVersion}/ref/net10.0/System.Text.Encoding.CodePages.dll",
            $"/reference:{DotNetRootPath}/packs/Microsoft.NETCore.App.Ref/{RuntimeVersion}/ref/net10.0/System.Text.Encoding.dll",
            $"/reference:{DotNetRootPath}/packs/Microsoft.NETCore.App.Ref/{RuntimeVersion}/ref/net10.0/System.Text.Encoding.Extensions.dll",
            $"/reference:{DotNetRootPath}/packs/Microsoft.NETCore.App.Ref/{RuntimeVersion}/ref/net10.0/System.Text.Encodings.Web.dll",
            $"/reference:{DotNetRootPath}/packs/Microsoft.NETCore.App.Ref/{RuntimeVersion}/ref/net10.0/System.Text.Json.dll",
            $"/reference:{DotNetRootPath}/packs/Microsoft.NETCore.App.Ref/{RuntimeVersion}/ref/net10.0/System.Text.RegularExpressions.dll",
            $"/reference:{DotNetRootPath}/packs/Microsoft.NETCore.App.Ref/{RuntimeVersion}/ref/net10.0/System.Threading.AccessControl.dll",
            $"/reference:{DotNetRootPath}/packs/Microsoft.NETCore.App.Ref/{RuntimeVersion}/ref/net10.0/System.Threading.Channels.dll",
            $"/reference:{DotNetRootPath}/packs/Microsoft.NETCore.App.Ref/{RuntimeVersion}/ref/net10.0/System.Threading.dll",
            $"/reference:{DotNetRootPath}/packs/Microsoft.NETCore.App.Ref/{RuntimeVersion}/ref/net10.0/System.Threading.Overlapped.dll",
            $"/reference:{DotNetRootPath}/packs/Microsoft.NETCore.App.Ref/{RuntimeVersion}/ref/net10.0/System.Threading.Tasks.Dataflow.dll",
            $"/reference:{DotNetRootPath}/packs/Microsoft.NETCore.App.Ref/{RuntimeVersion}/ref/net10.0/System.Threading.Tasks.dll",
            $"/reference:{DotNetRootPath}/packs/Microsoft.NETCore.App.Ref/{RuntimeVersion}/ref/net10.0/System.Threading.Tasks.Extensions.dll",
            $"/reference:{DotNetRootPath}/packs/Microsoft.NETCore.App.Ref/{RuntimeVersion}/ref/net10.0/System.Threading.Tasks.Parallel.dll",
            $"/reference:{DotNetRootPath}/packs/Microsoft.NETCore.App.Ref/{RuntimeVersion}/ref/net10.0/System.Threading.Thread.dll",
            $"/reference:{DotNetRootPath}/packs/Microsoft.NETCore.App.Ref/{RuntimeVersion}/ref/net10.0/System.Threading.ThreadPool.dll",
            $"/reference:{DotNetRootPath}/packs/Microsoft.NETCore.App.Ref/{RuntimeVersion}/ref/net10.0/System.Threading.Timer.dll",
            $"/reference:{DotNetRootPath}/packs/Microsoft.NETCore.App.Ref/{RuntimeVersion}/ref/net10.0/System.Transactions.dll",
            $"/reference:{DotNetRootPath}/packs/Microsoft.NETCore.App.Ref/{RuntimeVersion}/ref/net10.0/System.Transactions.Local.dll",
            $"/reference:{DotNetRootPath}/packs/Microsoft.NETCore.App.Ref/{RuntimeVersion}/ref/net10.0/System.ValueTuple.dll",
            $"/reference:{DotNetRootPath}/packs/Microsoft.NETCore.App.Ref/{RuntimeVersion}/ref/net10.0/System.Web.dll",
            $"/reference:{DotNetRootPath}/packs/Microsoft.NETCore.App.Ref/{RuntimeVersion}/ref/net10.0/System.Web.HttpUtility.dll",
            $"/reference:{DotNetRootPath}/packs/Microsoft.NETCore.App.Ref/{RuntimeVersion}/ref/net10.0/System.Windows.dll",
            $"/reference:{DotNetRootPath}/packs/Microsoft.NETCore.App.Ref/{RuntimeVersion}/ref/net10.0/System.Xml.dll",
            $"/reference:{DotNetRootPath}/packs/Microsoft.NETCore.App.Ref/{RuntimeVersion}/ref/net10.0/System.Xml.Linq.dll",
            $"/reference:{DotNetRootPath}/packs/Microsoft.NETCore.App.Ref/{RuntimeVersion}/ref/net10.0/System.Xml.ReaderWriter.dll",
            $"/reference:{DotNetRootPath}/packs/Microsoft.NETCore.App.Ref/{RuntimeVersion}/ref/net10.0/System.Xml.Serialization.dll",
            $"/reference:{DotNetRootPath}/packs/Microsoft.NETCore.App.Ref/{RuntimeVersion}/ref/net10.0/System.Xml.XDocument.dll",
            $"/reference:{DotNetRootPath}/packs/Microsoft.NETCore.App.Ref/{RuntimeVersion}/ref/net10.0/System.Xml.XmlDocument.dll",
            $"/reference:{DotNetRootPath}/packs/Microsoft.NETCore.App.Ref/{RuntimeVersion}/ref/net10.0/System.Xml.XmlSerializer.dll",
            $"/reference:{DotNetRootPath}/packs/Microsoft.NETCore.App.Ref/{RuntimeVersion}/ref/net10.0/System.Xml.XPath.dll",
            $"/reference:{DotNetRootPath}/packs/Microsoft.NETCore.App.Ref/{RuntimeVersion}/ref/net10.0/System.Xml.XPath.XDocument.dll",
            $"/reference:{DotNetRootPath}/packs/Microsoft.NETCore.App.Ref/{RuntimeVersion}/ref/net10.0/WindowsBase.dll",
            "/debug+",
            "/debug:portable",
            "/filealign:512",
            "/optimize-",
            $"/out:{binDir}/{fileNameWithoutExtension}.dll",
            "/target:exe",
            "/warnaserror-",
            "/utf8output",
            "/deterministic+",
            "/langversion:13.0",
            "/features:FileBasedProgram",
            $"/analyzerconfig:{SdkPath}/Sdks/Microsoft.NET.Sdk/codestyle/cs/build/config/analysislevelstyle_default.globalconfig",
            $"/analyzerconfig:{objDir}/{fileNameWithoutExtension}.GeneratedMSBuildEditorConfig.editorconfig",
            $"/analyzerconfig:{SdkPath}/Sdks/Microsoft.NET.Sdk/analyzers/build/config/analysislevel_10_default.globalconfig",
            $"/analyzer:{SdkPath}/Sdks/Microsoft.NET.Sdk/targets/../analyzers/Microsoft.CodeAnalysis.CSharp.NetAnalyzers.dll",
            $"/analyzer:{SdkPath}/Sdks/Microsoft.NET.Sdk/targets/../analyzers/Microsoft.CodeAnalysis.NetAnalyzers.dll",
            $"/analyzer:{NuGetCachePath}/microsoft.net.illink.tasks/{RuntimeVersion}/analyzers/dotnet/cs/ILLink.CodeFixProvider.dll",
            $"/analyzer:{NuGetCachePath}/microsoft.net.illink.tasks/{RuntimeVersion}/analyzers/dotnet/cs/ILLink.RoslynAnalyzer.dll",
            $"/analyzer:{DotNetRootPath}/packs/Microsoft.NETCore.App.Ref/{RuntimeVersion}/analyzers/dotnet/cs/Microsoft.Interop.ComInterfaceGenerator.dll",
            $"/analyzer:{DotNetRootPath}/packs/Microsoft.NETCore.App.Ref/{RuntimeVersion}/analyzers/dotnet/cs/Microsoft.Interop.JavaScript.JSImportGenerator.dll",
            $"/analyzer:{DotNetRootPath}/packs/Microsoft.NETCore.App.Ref/{RuntimeVersion}/analyzers/dotnet/cs/Microsoft.Interop.LibraryImportGenerator.dll",
            $"/analyzer:{DotNetRootPath}/packs/Microsoft.NETCore.App.Ref/{RuntimeVersion}/analyzers/dotnet/cs/Microsoft.Interop.SourceGeneration.dll",
            $"/analyzer:{DotNetRootPath}/packs/Microsoft.NETCore.App.Ref/{RuntimeVersion}/analyzers/dotnet/cs/System.Text.Json.SourceGeneration.dll",
            $"/analyzer:{DotNetRootPath}/packs/Microsoft.NETCore.App.Ref/{RuntimeVersion}/analyzers/dotnet/cs/System.Text.RegularExpressions.Generator.dll",
            $"{EntryPointFileFullPath}",
            $"{objDir}/{fileNameWithoutExtension}.GlobalUsings.g.cs",
            $"{objDir}/.NETCoreApp,Version=v10.0.AssemblyAttributes.cs",
            $"{objDir}/{fileNameWithoutExtension}.AssemblyInfo.cs",
            "/warnaserror+:NU1605,SYSLIB0011",
        ];
    }

    /// <summary>
    /// Files that come from referenced NuGet packages (e.g., analyzers for NativeAOT) need to be checked specially (if they don't exist, MSBuild needs to run).
    /// </summary>
    public static IEnumerable<string> GetPathsOfCscInputsFromNuGetCache()
    {
        return
        [
            $"{NuGetCachePath}/microsoft.net.illink.tasks/{RuntimeVersion}/analyzers/dotnet/cs/ILLink.CodeFixProvider.dll",
            $"{NuGetCachePath}/microsoft.net.illink.tasks/{RuntimeVersion}/analyzers/dotnet/cs/ILLink.RoslynAnalyzer.dll",
        ];
    }
}
