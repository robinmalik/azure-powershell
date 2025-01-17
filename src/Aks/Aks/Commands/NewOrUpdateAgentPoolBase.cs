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

using Microsoft.Azure.Commands.ResourceManager.Common.ArgumentCompleters;
using Newtonsoft.Json;
using System.Collections;
using System.Collections.Generic;
using System.Management.Automation;

namespace Microsoft.Azure.Commands.Aks
{
    public class NewOrUpdateAgentPoolBase : KubeCmdletBase
    {

        [Parameter(Mandatory = false, HelpMessage = "The version of Kubernetes to use for creating the cluster.")]
        public string KubernetesVersion { get; set; }

        [Parameter(Mandatory = false, HelpMessage = "Minimum number of nodes for auto-scaling.")]
        public int MinCount { get; set; }

        [Parameter(Mandatory = false, HelpMessage = "Maximum number of nodes for auto-scaling")]
        public int MaxCount { get; set; }

        [Parameter(Mandatory = false, HelpMessage = "Whether to enable auto-scaler")]
        public SwitchParameter EnableAutoScaling { get; set; }

        /// <summary>
        /// Gets or sets possible values include: 'System', 'User'
        /// </summary>
        [Parameter(Mandatory = false, HelpMessage = "The pool mode")]
        [PSArgumentCompleter("System", "User")]
        public string Mode { get; set; }

        [Parameter(Mandatory = false, HelpMessage = "Node pool labels used for building Kubernetes network.")]
        public Hashtable NodeLabel { get; set; }

        [Parameter(Mandatory = false, HelpMessage = "The tags to be persisted on the agent pool virtual machine scale set.")]
        public Hashtable Tag { get; set; }
    }
}
