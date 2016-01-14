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

using Xunit;

namespace Microsoft.Azure.Commands.Common.ScenarioTest
{
    [Collection("SampleCollection")]
    public class ComputeTests
    {
        ScenarioTestFixture _collectionState;
        public ComputeTests(ScenarioTestFixture fixture)
        {
            _collectionState = fixture;
        }

        [Fact (Skip = "TODO: Re-enable once fixed in Azure Storage CoreCLR package.")]
        public void VirtualHardDisksTest()
        {
            var helper = _collectionState.GetRunner("virtual-hard-disk");
            helper.RunScript("01-VirtualHardDisks");
        }

        [Fact]
        public void VirtualMachineSizeTest()
        {
            var helper = _collectionState.GetRunner("compute-management");
            helper.RunScript("01-VirtualMachineSizes");
        }

        [Fact]
        public void VirtualMachineCreationTest()
        {
            var helper = _collectionState.GetRunner("compute-management");
            helper.RunScript("02-VirtualMachineCreation");
        }
    }
}
