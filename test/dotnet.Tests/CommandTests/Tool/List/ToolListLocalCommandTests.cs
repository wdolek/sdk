// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

#nullable disable

using System.CommandLine;
using System.Text.Json;
using Microsoft.DotNet.Cli.ToolManifest;
using Microsoft.DotNet.Cli.Utils;
using Microsoft.DotNet.Cli.ToolPackage;
using Microsoft.Extensions.EnvironmentAbstractions;
using NuGet.Versioning;
using Parser = Microsoft.DotNet.Cli.Parser;
using Microsoft.DotNet.Cli.Commands.Tool.List;

namespace Microsoft.DotNet.Tests.Commands.Tool
{
    public class ToolListLocalCommandTests
    {
        private readonly ParseResult _parseResult;
        private readonly BufferedReporter _reporter;
        private readonly string _temporaryDirectory;
        private readonly FakeManifestInspector _toolManifestInspector;
        private readonly ToolListLocalCommand _defaultToolListLocalCommand;
        private readonly string _testManifestPath;

        public ToolListLocalCommandTests()
        {
            _reporter = new BufferedReporter();
            _temporaryDirectory = Path.GetTempPath();
            _testManifestPath = Path.Combine(Path.GetTempPath(), "filename");

            _toolManifestInspector = new FakeManifestInspector(
                new List<(ToolManifestPackage toolManifestPackage, FilePath SourceManifest)>()
                {
                    (new ToolManifestPackage(
                        new PackageId("package.id"),
                        NuGetVersion.Parse("2.1.4"),
                        new[] {new ToolCommandName("package-name")},
                        new DirectoryPath(_temporaryDirectory),
                        false), new FilePath(_testManifestPath)),
                    (new ToolManifestPackage(
                        new PackageId("foo.bar"),
                        NuGetVersion.Parse("1.0.8"),
                        new[] {new ToolCommandName("foo-bar")},
                        new DirectoryPath(_temporaryDirectory),
                        false), new FilePath(_testManifestPath))
                }
            );
            _parseResult = Parser.Parse("dotnet tool list");
            _defaultToolListLocalCommand = new ToolListLocalCommand(
                _parseResult,
                _toolManifestInspector,
                _reporter);
        }

        [Fact]
        public void GivenManifestInspectorItPrintsTheTable()
        {
            _defaultToolListLocalCommand.Execute();
            _reporter.Lines.Count.Should().Be(4);
            _reporter.Lines.Should().Contain(l => l.Contains("package.id"));
            _reporter.Lines.Should().Contain(l => l.Contains("2.1.4"));
            _reporter.Lines.Should().Contain(l => l.Contains(_testManifestPath));
            _reporter.Lines.Should().Contain(l => l.Contains("package-name"));
            _reporter.Lines.Should().Contain(l => l.Contains("foo.bar"));
            _reporter.Lines.Should().Contain(l => l.Contains("1.0.8"));
            _reporter.Lines.Should().Contain(l => l.Contains(_testManifestPath));
            _reporter.Lines.Should().Contain(l => l.Contains("foo-bar"));
        }

        [Fact]
        public void GivenManifestInspectorItPrintsJson()
        {
            new ToolListLocalCommand(
                Parser.Parse("dotnet tool list --format json"),
                _toolManifestInspector,
                _reporter).Execute();
            _reporter.Lines.Count.Should().Be(1);

            var versionedData = JsonSerializer.Deserialize<VersionedDataContract<LocalToolListJsonContract[]>>(_reporter.Lines[0]);
            versionedData.Should().NotBeNull();
            versionedData.Version.Should().Be(1);
            versionedData.Data.Length.Should().Be(2);

            versionedData.Data[0].PackageId.Should().Be("package.id");
            versionedData.Data[0].Version.Should().Be("2.1.4");
            versionedData.Data[0].Commands[0].Should().Be("package-name");
            versionedData.Data[0].Manifest.Should().Be(_testManifestPath);

            versionedData.Data[1].PackageId.Should().Be("foo.bar");
            versionedData.Data[1].Version.Should().Be("1.0.8");
            versionedData.Data[1].Commands[0].Should().Be("foo-bar");
            versionedData.Data[1].Manifest.Should().Be(_testManifestPath);
        }

        [Fact]
        public void GivenManifestInspectorWhenCalledFromRedirectCommandItPrintsTheTable()
        {
            var command = new ToolListCommand(result: _parseResult,
                toolListLocalCommand: _defaultToolListLocalCommand);
            _defaultToolListLocalCommand.Execute();
            _reporter.Lines.Count.Should().Be(4);
            _reporter.Lines.Should().Contain(l => l.Contains("package.id"));
            _reporter.Lines.Should().Contain(l => l.Contains("2.1.4"));
            _reporter.Lines.Should().Contain(l => l.Contains(_testManifestPath));
            _reporter.Lines.Should().Contain(l => l.Contains("package-name"));
            _reporter.Lines.Should().Contain(l => l.Contains("foo.bar"));
            _reporter.Lines.Should().Contain(l => l.Contains("1.0.8"));
            _reporter.Lines.Should().Contain(l => l.Contains(_testManifestPath));
            _reporter.Lines.Should().Contain(l => l.Contains("foo-bar"));
        }

        [Fact]
        public void GivenPackageIdArgumentItPrintsTheCorrectPackageInfo()
        {
            CreateCommandWithArg("package.id").Execute().Should().Be(0);
            _reporter.Lines.Count.Should().Be(3);
            _reporter.Lines.Should().Contain(l => l.Contains("package.id"));
            _reporter.Lines.Should().Contain(l => l.Contains("2.1.4"));
            _reporter.Lines.Should().Contain(l => l.Contains(_testManifestPath));
            _reporter.Lines.Should().Contain(l => l.Contains("package-name"));
        }

        [Fact]
        public void GivenNotInstalledPackageItPrintsEmpty()
        {
            CreateCommandWithArg("not-installed-package").Execute().Should().Be(1);
            _reporter.Lines.Count.Should().Be(2);
        }

        private ToolListLocalCommand CreateCommandWithArg(string arg)
        {
            var parseResult = Parser.Parse("dotnet tool list " + arg);
            var command = new ToolListLocalCommand(
                parseResult,
                _toolManifestInspector,
                _reporter);
            return command;
        }

        private sealed class FakeManifestInspector : IToolManifestInspector
        {
            private readonly IReadOnlyCollection<(ToolManifestPackage toolManifestPackage, FilePath SourceManifest)>
                ToToReturn;

            public FakeManifestInspector(
                IReadOnlyCollection<(ToolManifestPackage toolManifestPackage, FilePath SourceManifest)> toReturn)
            {
                ToToReturn = toReturn;
            }

            public IReadOnlyCollection<(ToolManifestPackage toolManifestPackage, FilePath SourceManifest)> Inspect(
                FilePath? filePath = null)
            {
                return ToToReturn;
            }
        }
    }
}
