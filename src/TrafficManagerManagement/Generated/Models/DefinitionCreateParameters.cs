// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.WindowsAzure.Management.TrafficManager.Models;

namespace Microsoft.WindowsAzure.Management.TrafficManager.Models
{
    /// <summary>
    /// Parameters supplied to create a definition.
    /// </summary>
    public partial class DefinitionCreateParameters
    {
        private DefinitionDnsOptions _dnsOptions;
        
        /// <summary>
        /// Required.
        /// </summary>
        public DefinitionDnsOptions DnsOptions
        {
            get { return this._dnsOptions; }
            set { this._dnsOptions = value; }
        }
        
        private IList<DefinitionMonitor> _monitors;
        
        /// <summary>
        /// Required.
        /// </summary>
        public IList<DefinitionMonitor> Monitors
        {
            get { return this._monitors; }
            set { this._monitors = value; }
        }
        
        private DefinitionPolicyCreateParameters _policy;
        
        /// <summary>
        /// Required.
        /// </summary>
        public DefinitionPolicyCreateParameters Policy
        {
            get { return this._policy; }
            set { this._policy = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the DefinitionCreateParameters class.
        /// </summary>
        public DefinitionCreateParameters()
        {
            this._monitors = new List<DefinitionMonitor>();
        }
    }
}
