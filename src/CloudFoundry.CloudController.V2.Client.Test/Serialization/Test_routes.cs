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
    public class RoutesTest
    {

        [TestMethod]
        public void TestCreateRouteRequest()
        {
            string json = @"{
  ""domain_guid"": ""25bdf764-1b3c-4c8e-91c0-71650edd5e01"",
  ""space_guid"": ""ff6560d1-4cbb-408e-8461-c551628f58f0""
}";

            CreateRouteRequest request = new CreateRouteRequest();

            request.DomainGuid = new Guid("25bdf764-1b3c-4c8e-91c0-71650edd5e01");
            request.SpaceGuid = new Guid("ff6560d1-4cbb-408e-8461-c551628f58f0");
            string result = JsonConvert.SerializeObject(request, Formatting.None);
            Assert.AreEqual(TestUtil.ToUnformatedJsonString(json), result);
        }
        [TestMethod]
        public void TestUpdateRouteRequest()
        {
            string json = @"{
  ""host"": ""new_host""
}";

            UpdateRouteRequest request = new UpdateRouteRequest();

            request.Host = "new_host";
            string result = JsonConvert.SerializeObject(request, Formatting.None);
            Assert.AreEqual(TestUtil.ToUnformatedJsonString(json), result);
        }
    }
}
