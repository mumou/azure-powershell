﻿// ----------------------------------------------------------------------------------
//
// Copyright Microsoft Corporation
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// ----------------------------------------------------------------------------------

using System;
using System.Management.Automation;
using Microsoft.WindowsAzure.Management.HDInsight.Cmdlet.GetAzureHDInsightClusters;

namespace Microsoft.WindowsAzure.Management.HDInsight.Cmdlet.Commands.BaseCommandInterfaces
{
    interface IManageAzureHDInsightRdpAccessBase : IAzureHDInsightClusterCommandBase
    {
        /// <summary>
        /// Gets or sets RDP Access Credential to connect to the HDInsight cluster.
        /// </summary>
        PSCredential RdpCredential { get; set; }

        /// <summary>
        /// Gets or sets the RDP Access expiry to connect to the HDInsight cluster.
        /// </summary>
        DateTime RdpAccessExpiry { get; set; }

        /// <summary>
        ///     Gets or sets a value indicating whether to enable or disable RDP access on this Azure HDInsight cluster.
        /// </summary>
        bool Enable { get; set; }

        /// <summary>
        ///     Gets or sets the Location for the cluster to return.
        /// </summary>
        string Location { get; set; }
    }
}
