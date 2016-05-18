/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the discovery-2015-11-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ApplicationDiscoveryService.Model
{
    /// <summary>
    /// Container for the parameters to the GetConfigurationAttributes operation.
    /// Retrieve a list of attributes for a specific configuration ID. For example, the output
    /// for a <i>server</i> configuration item includes a list of attributes about the server,
    /// including host name, operating system, number of network cards, etc.
    /// </summary>
    public partial class GetConfigurationAttributesRequest : AmazonApplicationDiscoveryServiceRequest
    {
        private List<string> _configurationIds = new List<string>();

        /// <summary>
        /// Gets and sets the property ConfigurationIds. 
        /// <para>
        /// One or more configuration IDs.
        /// </para>
        /// </summary>
        public List<string> ConfigurationIds
        {
            get { return this._configurationIds; }
            set { this._configurationIds = value; }
        }

        // Check to see if ConfigurationIds property is set
        internal bool IsSetConfigurationIds()
        {
            return this._configurationIds != null && this._configurationIds.Count > 0; 
        }

    }
}