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
    public class AppsTest
    {

        [TestMethod]
        public void TestCreateDockerAppExperimentalRequest()
        {
            string json = @"{
  ""name"": ""docker_app"",
  ""space_guid"": ""92e72df6-6897-461e-b669-43ea67ce7a4d"",
  ""docker_image"": ""cloudfoundry/hello"",
  ""diego"": true
}";

            CreateDockerAppExperimentalRequest request = new CreateDockerAppExperimentalRequest();

            request.Name = "docker_app";
            request.SpaceGuid = new Guid("92e72df6-6897-461e-b669-43ea67ce7a4d");
            request.DockerImage = "cloudfoundry/hello";
            request.Diego = true;
            string result = JsonConvert.SerializeObject(request, Formatting.None);
            Assert.AreEqual(TestUtil.ToUnformatedJsonString(json), result);
        }
        [TestMethod]
        public void TestCopyAppBitsForAppRequest()
        {
            string json = @"{""source_app_guid"":""667d248a-2242-490b-bd67-dbfd27b178de""}";

            CopyAppBitsForAppRequest request = new CopyAppBitsForAppRequest();

            request.SourceAppGuid = new Guid("667d248a-2242-490b-bd67-dbfd27b178de");
            string result = JsonConvert.SerializeObject(request, Formatting.None);
            Assert.AreEqual(TestUtil.ToUnformatedJsonString(json), result);
        }
        [TestMethod]
        public void TestCreateAppRequest()
        {
            string json = @"{
  ""name"": ""my_super_app"",
  ""space_guid"": ""a06fbc43-81de-48aa-87c4-0a4f7d7175cf"",
  ""diego"": true,
  ""ports"": [
    1024,
    2000
  ]
}";

            CreateAppRequest request = new CreateAppRequest();

            request.Name = "my_super_app";
            request.SpaceGuid = new Guid("a06fbc43-81de-48aa-87c4-0a4f7d7175cf");
            request.Diego = true;
            request.Ports = Array.ConvertAll(TestUtil.GetJsonArray(@"[1024,2000]"), (p => (int?)Convert.ToInt32(p))); 

            string result = JsonConvert.SerializeObject(request, Formatting.None);
            Assert.AreEqual(TestUtil.ToUnformatedJsonString(json), result);
        }
        [TestMethod]
        public void TestUpdateAppRequest()
        {
            string json = @"{
  ""name"": ""new_name""
}";

            UpdateAppRequest request = new UpdateAppRequest();

            request.Name = "new_name";
            string result = JsonConvert.SerializeObject(request, Formatting.None);
            Assert.AreEqual(TestUtil.ToUnformatedJsonString(json), result);
        }
    }
}
