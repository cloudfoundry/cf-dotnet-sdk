//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

//
// This source code was auto-generated by cf-sdk-builder
//

using CloudFoundry.CloudController.V2.Client;
using CloudFoundry.CloudController.V2.Client.Data;
using Microsoft.CSharp;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace CloudFoundry.CloudController.V2.Test.Serialization
{
    [TestClass]
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public class SpaceQuotaDefinitionsTest
    {

        [TestMethod]
        public void TestUpdateSpaceQuotaDefinitionRequest()
        {
            string json = @"{
  ""name"": ""new_name""
}";

            UpdateSpaceQuotaDefinitionRequest request = new UpdateSpaceQuotaDefinitionRequest();

            request.Name = "new_name";
            string result = JsonConvert.SerializeObject(request, Formatting.None);
            Assert.AreEqual(TestUtil.ToUnformatedJsonString(json), result);
        }
        [TestMethod]
        public void TestCreateSpaceQuotaDefinitionRequest()
        {
            string json = @"{
  ""name"": ""gold_quota"",
  ""non_basic_services_allowed"": true,
  ""total_services"": -1,
  ""total_routes"": 10,
  ""memory_limit"": 5120,
  ""organization_guid"": ""a2104f80-b5e2-46a9-ae5d-708e496a413d"",
  ""total_reserved_route_ports"": 5
}";

            CreateSpaceQuotaDefinitionRequest request = new CreateSpaceQuotaDefinitionRequest();

            request.Name = "gold_quota";
            request.NonBasicServicesAllowed = true;
            request.TotalServices = -1;
            request.TotalRoutes = 10;
            request.MemoryLimit = 5120;
            request.OrganizationGuid = new Guid("a2104f80-b5e2-46a9-ae5d-708e496a413d");
            request.TotalReservedRoutePorts = 5;
            string result = JsonConvert.SerializeObject(request, Formatting.None);
            Assert.AreEqual(TestUtil.ToUnformatedJsonString(json), result);
        }
    }
}
