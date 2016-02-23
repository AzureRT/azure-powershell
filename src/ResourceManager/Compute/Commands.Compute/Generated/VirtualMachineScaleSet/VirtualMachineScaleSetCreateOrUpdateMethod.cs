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

using Microsoft.Azure;
using Microsoft.Azure.Commands.Compute.Automation.Models;
using Microsoft.Azure.Management.Compute;
using Microsoft.Azure.Management.Compute.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;

namespace Microsoft.Azure.Commands.Compute.Automation
{
    public partial class InvokeAzureComputeMethodCmdlet : ComputeAutomationBaseCmdlet
    {
        protected object CreateVirtualMachineScaleSetCreateOrUpdateDynamicParameters()
        {
            dynamicParameters = new RuntimeDefinedParameterDictionary();
            var pResourceGroupName = new RuntimeDefinedParameter();
            pResourceGroupName.Name = "ResourceGroupName";
            pResourceGroupName.ParameterType = typeof(string);
            pResourceGroupName.Attributes.Add(new ParameterAttribute
            {
                ParameterSetName = "InvokeByDynamicParameters",
                Position = 1,
                Mandatory = false
            });
            pResourceGroupName.Attributes.Add(new AllowNullAttribute());
            dynamicParameters.Add("ResourceGroupName", pResourceGroupName);

            var pName = new RuntimeDefinedParameter();
            pName.Name = "Name";
            pName.ParameterType = typeof(string);
            pName.Attributes.Add(new ParameterAttribute
            {
                ParameterSetName = "InvokeByDynamicParameters",
                Position = 2,
                Mandatory = false
            });
            pName.Attributes.Add(new AllowNullAttribute());
            dynamicParameters.Add("Name", pName);

            var pParameters = new RuntimeDefinedParameter();
            pParameters.Name = "VirtualMachineScaleSetCreateOrUpdateParameter";
            pParameters.ParameterType = typeof(VirtualMachineScaleSet);
            pParameters.Attributes.Add(new ParameterAttribute
            {
                ParameterSetName = "InvokeByDynamicParameters",
                Position = 3,
                Mandatory = false
            });
            pParameters.Attributes.Add(new AllowNullAttribute());
            dynamicParameters.Add("VirtualMachineScaleSetCreateOrUpdateParameter", pParameters);

            var pArgumentList = new RuntimeDefinedParameter();
            pArgumentList.Name = "ArgumentList";
            pArgumentList.ParameterType = typeof(object[]);
            pArgumentList.Attributes.Add(new ParameterAttribute
            {
                ParameterSetName = "InvokeByStaticParameters",
                Position = 4,
                Mandatory = true
            });
            pArgumentList.Attributes.Add(new AllowNullAttribute());
            dynamicParameters.Add("ArgumentList", pArgumentList);

            return dynamicParameters;
        }

        protected void ExecuteVirtualMachineScaleSetCreateOrUpdateMethod(object[] invokeMethodInputParameters)
        {
            string resourceGroupName = (string)ParseParameter(invokeMethodInputParameters[0]);
            string name = (string)ParseParameter(invokeMethodInputParameters[1]);
            VirtualMachineScaleSet parameters = (VirtualMachineScaleSet)ParseParameter(invokeMethodInputParameters[2]);

            var result = VirtualMachineScaleSetsClient.CreateOrUpdate(resourceGroupName, name, parameters);
            WriteObject(result);
        }
    }

    public partial class NewAzureComputeArgumentListCmdlet : ComputeAutomationBaseCmdlet
    {
        protected PSArgument[] CreateVirtualMachineScaleSetCreateOrUpdateParameters()
        {
            string resourceGroupName = string.Empty;
            string name = string.Empty;
            VirtualMachineScaleSet parameters = new VirtualMachineScaleSet();

            return ConvertFromObjectsToArguments(
                 new string[] { "ResourceGroupName", "Name", "Parameters" },
                 new object[] { resourceGroupName, name, parameters });
        }
    }

    [Cmdlet("New", "AzureRmVmss", DefaultParameterSetName = "InvokeByDynamicParameters")]
    public partial class NewAzureRmVMSS : InvokeAzureComputeMethodCmdlet
    {
        public NewAzureRmVMSS()
        {
        }

        public override string MethodName { get; set; }

        protected override void ProcessRecord()
        {
            this.MethodName = "VirtualMachineScaleSetCreateOrUpdate";
            base.ProcessRecord();
        }

        public override object GetDynamicParameters()
        {
            dynamicParameters = new RuntimeDefinedParameterDictionary();
            var pResourceGroupName = new RuntimeDefinedParameter();
            pResourceGroupName.Name = "ResourceGroupName";
            pResourceGroupName.ParameterType = typeof(string);
            pResourceGroupName.Attributes.Add(new ParameterAttribute
            {
                ParameterSetName = "InvokeByDynamicParameters",
                Position = 1,
                Mandatory = false
            });
            pResourceGroupName.Attributes.Add(new AllowNullAttribute());
            dynamicParameters.Add("ResourceGroupName", pResourceGroupName);

            var pName = new RuntimeDefinedParameter();
            pName.Name = "Name";
            pName.ParameterType = typeof(string);
            pName.Attributes.Add(new ParameterAttribute
            {
                ParameterSetName = "InvokeByDynamicParameters",
                Position = 2,
                Mandatory = false
            });
            pName.Attributes.Add(new AllowNullAttribute());
            dynamicParameters.Add("Name", pName);

            var pParameters = new RuntimeDefinedParameter();
            pParameters.Name = "VirtualMachineScaleSetCreateOrUpdateParameter";
            pParameters.ParameterType = typeof(VirtualMachineScaleSet);
            pParameters.Attributes.Add(new ParameterAttribute
            {
                ParameterSetName = "InvokeByDynamicParameters",
                Position = 3,
                Mandatory = false
            });
            pParameters.Attributes.Add(new AllowNullAttribute());
            dynamicParameters.Add("VirtualMachineScaleSetCreateOrUpdateParameter", pParameters);

            var pArgumentList = new RuntimeDefinedParameter();
            pArgumentList.Name = "ArgumentList";
            pArgumentList.ParameterType = typeof(object[]);
            pArgumentList.Attributes.Add(new ParameterAttribute
            {
                ParameterSetName = "InvokeByStaticParameters",
                Position = 4,
                Mandatory = true
            });
            pArgumentList.Attributes.Add(new AllowNullAttribute());
            dynamicParameters.Add("ArgumentList", pArgumentList);

            return dynamicParameters;
        }
    }
}
