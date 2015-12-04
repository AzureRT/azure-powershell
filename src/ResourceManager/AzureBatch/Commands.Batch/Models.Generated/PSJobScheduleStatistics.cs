﻿// -----------------------------------------------------------------------------
﻿//
﻿// Copyright Microsoft Corporation
﻿// Licensed under the Apache License, Version 2.0 (the "License");
﻿// you may not use this file except in compliance with the License.
﻿// You may obtain a copy of the License at
﻿// http://www.apache.org/licenses/LICENSE-2.0
﻿// Unless required by applicable law or agreed to in writing, software
﻿// distributed under the License is distributed on an "AS IS" BASIS,
﻿// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
﻿// See the License for the specific language governing permissions and
﻿// limitations under the License.
﻿// -----------------------------------------------------------------------------
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.Azure.Commands.Batch.Models
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using Microsoft.Azure.Batch;
    
    
    public class PSJobScheduleStatistics
    {
        
        internal Microsoft.Azure.Batch.JobScheduleStatistics omObject;
        
        internal PSJobScheduleStatistics(Microsoft.Azure.Batch.JobScheduleStatistics omObject)
        {
            if ((omObject == null))
            {
                throw new System.ArgumentNullException("omObject");
            }
            this.omObject = omObject;
        }
        
        public string Url
        {
            get
            {
                return this.omObject.Url;
            }
        }
        
        public System.DateTime StartTime
        {
            get
            {
                return this.omObject.StartTime;
            }
        }
        
        public System.DateTime LastUpdateTime
        {
            get
            {
                return this.omObject.LastUpdateTime;
            }
        }
        
        public System.TimeSpan UserCpuTime
        {
            get
            {
                return this.omObject.UserCpuTime;
            }
        }
        
        public System.TimeSpan KernelCpuTime
        {
            get
            {
                return this.omObject.KernelCpuTime;
            }
        }
        
        public System.TimeSpan WallClockTime
        {
            get
            {
                return this.omObject.WallClockTime;
            }
        }
        
        public long ReadIOps
        {
            get
            {
                return this.omObject.ReadIOps;
            }
        }
        
        public long WriteIOps
        {
            get
            {
                return this.omObject.WriteIOps;
            }
        }
        
        public double ReadIOGiB
        {
            get
            {
                return this.omObject.ReadIOGiB;
            }
        }
        
        public double WriteIOGiB
        {
            get
            {
                return this.omObject.WriteIOGiB;
            }
        }
        
        public long SucceededTaskCount
        {
            get
            {
                return this.omObject.SucceededTaskCount;
            }
        }
        
        public long FailedTaskCount
        {
            get
            {
                return this.omObject.FailedTaskCount;
            }
        }
        
        public long TaskRetryCount
        {
            get
            {
                return this.omObject.TaskRetryCount;
            }
        }
        
        public System.TimeSpan WaitTime
        {
            get
            {
                return this.omObject.WaitTime;
            }
        }
    }
}
