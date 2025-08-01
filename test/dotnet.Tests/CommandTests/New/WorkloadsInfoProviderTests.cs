﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Microsoft.DotNet.Cli.Commands.New;
using Microsoft.DotNet.Cli.Commands.Workload;
using Microsoft.DotNet.Cli.Commands.Workload.Install.WorkloadInstallRecords;
using Microsoft.DotNet.Cli.Commands.Workload.List;
using Microsoft.NET.Sdk.WorkloadManifestReader;
using Microsoft.TemplateEngine.Abstractions.Components;
using Moq;

namespace Microsoft.DotNet.Cli.New.Tests
{
    public class WorkloadsInfoProviderTests
    {
        [Fact]
        public async Task InstalledWorkloads_ShouldReturnExpectedWorkloads()
        {
            // Setup

            var resolverMock = new Mock<IWorkloadResolver>();
            var repoMock = new Mock<IWorkloadInstallationRecordRepository>();

            resolverMock
                .Setup(r => r.GetAvailableWorkloads())
                .Returns(Enumerable.Empty<WorkloadResolver.WorkloadInfo>());

            repoMock
                .Setup(r => r.GetInstalledWorkloads(It.IsAny<SdkFeatureBand>()))
                .Returns((IEnumerable<WorkloadId>)new List<WorkloadId>() { new WorkloadId("A"), new WorkloadId("B") });

            resolverMock
                .Setup(r => r.GetExtendedWorkloads(It.IsAny<IEnumerable<WorkloadId>>()))
                .Returns((IEnumerable<WorkloadId> workloadIds) => workloadIds.Select(w =>
                    new WorkloadResolver.WorkloadInfo(w, $"Description: {w.ToString()}")));

            var parseResult = Parser.Parse(["dotnet"]);
            IWorkloadsRepositoryEnumerator workloadsEnumerator = new WorkloadInfoHelper(
                isInteractive: false,
                currentSdkVersion: "1.2.3",
                workloadRecordRepo: repoMock.Object,
                workloadResolver: resolverMock.Object);
            IWorkloadsInfoProvider wp = new WorkloadsInfoProvider(new Lazy<IWorkloadsRepositoryEnumerator>(workloadsEnumerator));

            // Act
            var workloads = await wp.GetInstalledWorkloadsAsync(default);

            // Assert
            List<WorkloadInfo> expected = new()
            {
                new WorkloadInfo("A", "Description: A"), new WorkloadInfo("B", "Description: B")
            };
            workloads.Should().Equal(expected,
                (w1, w2) => w1.Id.Equals(w2.Id) && w1.Description.Equals(w2.Description),
                "WorkloadsInfoProvider should return expected workload infos based on workload resolver and installation repository");
        }
    }
}
