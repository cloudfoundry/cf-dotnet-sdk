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
    public class ServiceBindingsTest
    {

        [TestMethod]
        public void TestCreateServiceBindingRequest()
        {
            string json = @"{
  ""service_instance_guid"": ""de35c413-a8da-4a5c-ac0c-2b1abd8d8f32"",
  ""app_guid"": ""c98b4c8c-8b81-48cf-9e33-713eb44a00d6""
}";

            CreateServiceBindingRequest request = new CreateServiceBindingRequest();

            request.ServiceInstanceGuid = new Guid("de35c413-a8da-4a5c-ac0c-2b1abd8d8f32");
            request.AppGuid = new Guid("c98b4c8c-8b81-48cf-9e33-713eb44a00d6");
            string result = JsonConvert.SerializeObject(request, Formatting.None);
            Assert.AreEqual(TestUtil.ToUnformatedJsonString(json), result);
        }
    }
}
