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

namespace Microsoft.Azure.Management.Internal.Resources.Models
{
    /// <summary>
    /// Entity representing the reference to the deployment paramaters.
    /// </summary>
    public partial class ParametersLink
    {
        private string _contentVersion;
        
        /// <summary>
        /// Optional. If included it must match the ContentVersion in the
        /// template.
        /// </summary>
        public string ContentVersion
        {
            get { return this._contentVersion; }
            set { this._contentVersion = value; }
        }
        
        private Uri _uri;
        
        /// <summary>
        /// Required. URI referencing the template.
        /// </summary>
        public Uri Uri
        {
            get { return this._uri; }
            set { this._uri = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the ParametersLink class.
        /// </summary>
        public ParametersLink()
        {
        }
        
        /// <summary>
        /// Initializes a new instance of the ParametersLink class with
        /// required arguments.
        /// </summary>
        public ParametersLink(Uri uri)
            : this()
        {
            if (uri == null)
            {
                throw new ArgumentNullException("uri");
            }
            this.Uri = uri;
        }
    }
}
