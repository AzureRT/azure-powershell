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
    [Cmdlet(VerbsCommon.New, "AzureComputeParameterObject", DefaultParameterSetName = "CreateParameterObjectByFullName")]
    [OutputType(typeof(object))]
    public partial class NewAzureComputeParameterObjectCmdlet : ComputeAutomationBaseCmdlet
    {
        [Parameter(ParameterSetName = "CreateParameterObjectByFriendlyName", Mandatory = true, Position = 0)]
        [ValidateSet(
            "VirtualMachineScaleSetAdditionalUnattendContent",
            "VirtualMachineScaleSetAdditionalUnattendContentList",
            "VirtualMachineScaleSetImageReference",
            "VirtualMachineScaleSetLinuxConfiguration",
            "VirtualMachineScaleSetListParameters",
            "VirtualMachineScaleSetNetworkConfiguration",
            "VirtualMachineScaleSetNetworkConfigurationList",
            "VirtualMachineScaleSetNetworkProfile",
            "VirtualMachineScaleSetOSDisk",
            "VirtualMachineScaleSetOSProfile",
            "VirtualMachineScaleSetSku",
            "VirtualMachineScaleSetSshConfiguration",
            "VirtualMachineScaleSetSshPublicKey",
            "VirtualMachineScaleSetSshPublicKeyList",
            "VirtualMachineScaleSetStorageProfile",
            "VirtualMachineScaleSetUpgradePolicy",
            "VirtualMachineScaleSetVaultSecretGroup",
            "VirtualMachineScaleSetVaultSecretGroupList",
            "VirtualMachineScaleSetVirtualHardDisk",
            "VirtualMachineScaleSetVirtualMachineExtension",
            "VirtualMachineScaleSetVirtualMachineExtensionList",
            "VirtualMachineScaleSetVirtualMachineScaleSet",
            "VirtualMachineScaleSetVMListParameters",
            "VirtualMachineScaleSetVMProfile",
            "VirtualMachineScaleSetWindowsConfiguration",
            "VirtualMachineScaleSetWinRMConfiguration",
            "VirtualMachineScaleSetWinRMListener",
            "VirtualMachineScaleSetWinRMListenerList"
        )]
        public string FriendlyName { get; set; }

        [Parameter(ParameterSetName = "CreateParameterObjectByFullName", Mandatory = true, Position = 0)]
        [ValidateSet(
            "Microsoft.Azure.Management.Compute.Models.AdditionalUnattendContent",
            "Microsoft.Azure.Management.Compute.Models.ImageReference",
            "Microsoft.Azure.Management.Compute.Models.LinuxConfiguration",
            "Microsoft.Azure.Management.Compute.Models.ListParameters",
            "Microsoft.Azure.Management.Compute.Models.Sku",
            "Microsoft.Azure.Management.Compute.Models.SshConfiguration",
            "Microsoft.Azure.Management.Compute.Models.SshPublicKey",
            "Microsoft.Azure.Management.Compute.Models.UpgradePolicy",
            "Microsoft.Azure.Management.Compute.Models.VaultSecretGroup",
            "Microsoft.Azure.Management.Compute.Models.VirtualHardDisk",
            "Microsoft.Azure.Management.Compute.Models.VirtualMachineExtension",
            "Microsoft.Azure.Management.Compute.Models.VirtualMachineScaleSet",
            "Microsoft.Azure.Management.Compute.Models.VirtualMachineScaleSetNetworkConfiguration",
            "Microsoft.Azure.Management.Compute.Models.VirtualMachineScaleSetNetworkProfile",
            "Microsoft.Azure.Management.Compute.Models.VirtualMachineScaleSetOSDisk",
            "Microsoft.Azure.Management.Compute.Models.VirtualMachineScaleSetOSProfile",
            "Microsoft.Azure.Management.Compute.Models.VirtualMachineScaleSetStorageProfile",
            "Microsoft.Azure.Management.Compute.Models.VirtualMachineScaleSetVMListParameters",
            "Microsoft.Azure.Management.Compute.Models.VirtualMachineScaleSetVMProfile",
            "Microsoft.Azure.Management.Compute.Models.WindowsConfiguration",
            "Microsoft.Azure.Management.Compute.Models.WinRMConfiguration",
            "Microsoft.Azure.Management.Compute.Models.WinRMListener",
            "System.Collections.Generic.List<AdditionalUnattendContent>",
            "System.Collections.Generic.List<SshPublicKey>",
            "System.Collections.Generic.List<VaultSecretGroup>",
            "System.Collections.Generic.List<VirtualMachineExtension>",
            "System.Collections.Generic.List<VirtualMachineScaleSetNetworkConfiguration>",
            "System.Collections.Generic.List<WinRMListener>"
        )]
        public string FullName { get; set; }

        public override void ExecuteCmdlet()
        {
            base.ExecuteCmdlet();
            ExecuteClientAction(() =>
            {
                if (ParameterSetName == "CreateParameterObjectByFriendlyName")
                {
                    switch (FriendlyName)
                    {
                        case "VirtualMachineScaleSetAdditionalUnattendContent" : WriteObject(new AdditionalUnattendContent()); break;
                        case "VirtualMachineScaleSetAdditionalUnattendContentList" : WriteObject(new List<AdditionalUnattendContent>()); break;
                        case "VirtualMachineScaleSetImageReference" : WriteObject(new ImageReference()); break;
                        case "VirtualMachineScaleSetLinuxConfiguration" : WriteObject(new LinuxConfiguration()); break;
                        case "VirtualMachineScaleSetListParameters" : WriteObject(new ListParameters()); break;
                        case "VirtualMachineScaleSetNetworkConfiguration" : WriteObject(new VirtualMachineScaleSetNetworkConfiguration()); break;
                        case "VirtualMachineScaleSetNetworkConfigurationList" : WriteObject(new List<VirtualMachineScaleSetNetworkConfiguration>()); break;
                        case "VirtualMachineScaleSetNetworkProfile" : WriteObject(new VirtualMachineScaleSetNetworkProfile()); break;
                        case "VirtualMachineScaleSetOSDisk" : WriteObject(new VirtualMachineScaleSetOSDisk()); break;
                        case "VirtualMachineScaleSetOSProfile" : WriteObject(new VirtualMachineScaleSetOSProfile()); break;
                        case "VirtualMachineScaleSetSku" : WriteObject(new Sku()); break;
                        case "VirtualMachineScaleSetSshConfiguration" : WriteObject(new SshConfiguration()); break;
                        case "VirtualMachineScaleSetSshPublicKey" : WriteObject(new SshPublicKey()); break;
                        case "VirtualMachineScaleSetSshPublicKeyList" : WriteObject(new List<SshPublicKey>()); break;
                        case "VirtualMachineScaleSetStorageProfile" : WriteObject(new VirtualMachineScaleSetStorageProfile()); break;
                        case "VirtualMachineScaleSetUpgradePolicy" : WriteObject(new UpgradePolicy()); break;
                        case "VirtualMachineScaleSetVaultSecretGroup" : WriteObject(new VaultSecretGroup()); break;
                        case "VirtualMachineScaleSetVaultSecretGroupList" : WriteObject(new List<VaultSecretGroup>()); break;
                        case "VirtualMachineScaleSetVirtualHardDisk" : WriteObject(new VirtualHardDisk()); break;
                        case "VirtualMachineScaleSetVirtualMachineExtension" : WriteObject(new VirtualMachineExtension()); break;
                        case "VirtualMachineScaleSetVirtualMachineExtensionList" : WriteObject(new List<VirtualMachineExtension>()); break;
                        case "VirtualMachineScaleSetVirtualMachineScaleSet" : WriteObject(new VirtualMachineScaleSet()); break;
                        case "VirtualMachineScaleSetVMListParameters" : WriteObject(new VirtualMachineScaleSetVMListParameters()); break;
                        case "VirtualMachineScaleSetVMProfile" : WriteObject(new VirtualMachineScaleSetVMProfile()); break;
                        case "VirtualMachineScaleSetWindowsConfiguration" : WriteObject(new WindowsConfiguration()); break;
                        case "VirtualMachineScaleSetWinRMConfiguration" : WriteObject(new WinRMConfiguration()); break;
                        case "VirtualMachineScaleSetWinRMListener" : WriteObject(new WinRMListener()); break;
                        case "VirtualMachineScaleSetWinRMListenerList" : WriteObject(new List<WinRMListener>()); break;
                        default : WriteWarning("Cannot find the type by FriendlyName = '" + FriendlyName + "'."); break;
                    }
                }
                else if (ParameterSetName == "CreateParameterObjectByFullName")
                {
                    switch (FullName)
                    {
                        case "Microsoft.Azure.Management.Compute.Models.AdditionalUnattendContent" : WriteObject(new AdditionalUnattendContent()); break;
                        case "Microsoft.Azure.Management.Compute.Models.ImageReference" : WriteObject(new ImageReference()); break;
                        case "Microsoft.Azure.Management.Compute.Models.LinuxConfiguration" : WriteObject(new LinuxConfiguration()); break;
                        case "Microsoft.Azure.Management.Compute.Models.ListParameters" : WriteObject(new ListParameters()); break;
                        case "Microsoft.Azure.Management.Compute.Models.Sku" : WriteObject(new Sku()); break;
                        case "Microsoft.Azure.Management.Compute.Models.SshConfiguration" : WriteObject(new SshConfiguration()); break;
                        case "Microsoft.Azure.Management.Compute.Models.SshPublicKey" : WriteObject(new SshPublicKey()); break;
                        case "Microsoft.Azure.Management.Compute.Models.UpgradePolicy" : WriteObject(new UpgradePolicy()); break;
                        case "Microsoft.Azure.Management.Compute.Models.VaultSecretGroup" : WriteObject(new VaultSecretGroup()); break;
                        case "Microsoft.Azure.Management.Compute.Models.VirtualHardDisk" : WriteObject(new VirtualHardDisk()); break;
                        case "Microsoft.Azure.Management.Compute.Models.VirtualMachineExtension" : WriteObject(new VirtualMachineExtension()); break;
                        case "Microsoft.Azure.Management.Compute.Models.VirtualMachineScaleSet" : WriteObject(new VirtualMachineScaleSet()); break;
                        case "Microsoft.Azure.Management.Compute.Models.VirtualMachineScaleSetNetworkConfiguration" : WriteObject(new VirtualMachineScaleSetNetworkConfiguration()); break;
                        case "Microsoft.Azure.Management.Compute.Models.VirtualMachineScaleSetNetworkProfile" : WriteObject(new VirtualMachineScaleSetNetworkProfile()); break;
                        case "Microsoft.Azure.Management.Compute.Models.VirtualMachineScaleSetOSDisk" : WriteObject(new VirtualMachineScaleSetOSDisk()); break;
                        case "Microsoft.Azure.Management.Compute.Models.VirtualMachineScaleSetOSProfile" : WriteObject(new VirtualMachineScaleSetOSProfile()); break;
                        case "Microsoft.Azure.Management.Compute.Models.VirtualMachineScaleSetStorageProfile" : WriteObject(new VirtualMachineScaleSetStorageProfile()); break;
                        case "Microsoft.Azure.Management.Compute.Models.VirtualMachineScaleSetVMListParameters" : WriteObject(new VirtualMachineScaleSetVMListParameters()); break;
                        case "Microsoft.Azure.Management.Compute.Models.VirtualMachineScaleSetVMProfile" : WriteObject(new VirtualMachineScaleSetVMProfile()); break;
                        case "Microsoft.Azure.Management.Compute.Models.WindowsConfiguration" : WriteObject(new WindowsConfiguration()); break;
                        case "Microsoft.Azure.Management.Compute.Models.WinRMConfiguration" : WriteObject(new WinRMConfiguration()); break;
                        case "Microsoft.Azure.Management.Compute.Models.WinRMListener" : WriteObject(new WinRMListener()); break;
                        case "System.Collections.Generic.List<AdditionalUnattendContent>" : WriteObject(new List<AdditionalUnattendContent>()); break;
                        case "System.Collections.Generic.List<SshPublicKey>" : WriteObject(new List<SshPublicKey>()); break;
                        case "System.Collections.Generic.List<VaultSecretGroup>" : WriteObject(new List<VaultSecretGroup>()); break;
                        case "System.Collections.Generic.List<VirtualMachineExtension>" : WriteObject(new List<VirtualMachineExtension>()); break;
                        case "System.Collections.Generic.List<VirtualMachineScaleSetNetworkConfiguration>" : WriteObject(new List<VirtualMachineScaleSetNetworkConfiguration>()); break;
                        case "System.Collections.Generic.List<WinRMListener>" : WriteObject(new List<WinRMListener>()); break;
                        default : WriteWarning("Cannot find the type by FullName = '" + FullName + "'."); break;
                    }
                }
            });
        }

    }
}
