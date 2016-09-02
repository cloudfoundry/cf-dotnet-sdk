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

using CloudFoundry.CloudController.V2.Client.Data;
using Microsoft.QualityTools.Testing.Fakes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.CodeDom.Compiler;
using System.Net;
using System.Threading.Tasks;

namespace CloudFoundry.CloudController.V2.Client.Test.Fake
{
    [TestClass]
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public class ServiceKeysEndpoint
{
        [TestMethod]
        public void ListAllServiceKeysTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                string json = @"{
  ""total_results"": 1,
  ""total_pages"": 1,
  ""prev_url"": null,
  ""next_url"": null,
  ""resources"": [
    {
      ""metadata"": {
        ""guid"": ""b993d210-7878-40ab-a96b-cc1c1e0111fe"",
        ""url"": ""/v2/service_keys/cc3d0586-062b-4b2c-8b4a-c5185aa1f3c5"",
        ""created_at"": ""2016-09-02T11:52:25Z"",
        ""updated_at"": null
      },
      ""entity"": {
        ""name"": ""name-2262"",
        ""service_instance_guid"": ""b993d210-7878-40ab-a96b-cc1c1e0111fe"",
        ""credentials"": {
          ""creds-key-62"": ""creds-val-62""
        },
        ""service_instance_url"": ""/v2/service_instances/ea977d17-d843-420b-997a-c9f909c699d4""
      }
    }
  ]
}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)200;
                var cfClient = clients.CreateCloudFoundryClient();


                var obj = cfClient.ServiceKeys.ListAllServiceKeys().Result;

                Assert.AreEqual("1", TestUtil.ToTestableString(obj.Properties.TotalResults), true);
                Assert.AreEqual("1", TestUtil.ToTestableString(obj.Properties.TotalPages), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.Properties.PreviousUrl), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.Properties.NextUrl), true);
                Assert.AreEqual("b993d210-7878-40ab-a96b-cc1c1e0111fe", TestUtil.ToTestableString(obj[0].EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/service_keys/cc3d0586-062b-4b2c-8b4a-c5185aa1f3c5", TestUtil.ToTestableString(obj[0].EntityMetadata.Url), true);
                Assert.AreEqual("2016-09-02T11:52:25Z", TestUtil.ToTestableString(obj[0].EntityMetadata.CreatedAt), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[0].EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("name-2262", TestUtil.ToTestableString(obj[0].Name), true);
                Assert.AreEqual("b993d210-7878-40ab-a96b-cc1c1e0111fe", TestUtil.ToTestableString(obj[0].ServiceInstanceGuid), true);
                Assert.AreEqual("/v2/service_instances/ea977d17-d843-420b-997a-c9f909c699d4", TestUtil.ToTestableString(obj[0].ServiceInstanceUrl), true);

            }
        }

        [TestMethod]
        public void RetrieveServiceKeyTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                string json = @"{
  ""metadata"": {
    ""guid"": ""e5f5f18d-6c40-4915-82bb-fdd95a7f95cc"",
    ""url"": ""/v2/service_keys/9a650ebc-93c8-4657-8f05-12dd8bd33b12"",
    ""created_at"": ""2016-09-02T11:52:25Z"",
    ""updated_at"": null
  },
  ""entity"": {
    ""name"": ""name-2288"",
    ""service_instance_guid"": ""e5f5f18d-6c40-4915-82bb-fdd95a7f95cc"",
    ""credentials"": {
      ""creds-key-68"": ""creds-val-68""
    },
    ""service_instance_url"": ""/v2/service_instances/d7a54f8a-b1c0-4a14-914c-b2f3af45cd68""
  }
}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)200;
                var cfClient = clients.CreateCloudFoundryClient();

                Guid? guid = Guid.NewGuid();


                var obj = cfClient.ServiceKeys.RetrieveServiceKey(guid).Result;


                Assert.AreEqual("e5f5f18d-6c40-4915-82bb-fdd95a7f95cc", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/service_keys/9a650ebc-93c8-4657-8f05-12dd8bd33b12", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
                Assert.AreEqual("2016-09-02T11:52:25Z", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("name-2288", TestUtil.ToTestableString(obj.Name), true);
                Assert.AreEqual("e5f5f18d-6c40-4915-82bb-fdd95a7f95cc", TestUtil.ToTestableString(obj.ServiceInstanceGuid), true);
                Assert.AreEqual("/v2/service_instances/d7a54f8a-b1c0-4a14-914c-b2f3af45cd68", TestUtil.ToTestableString(obj.ServiceInstanceUrl), true);

            }
        }

        [TestMethod]
        public void CreateServiceKeyTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                string json = @"{
  ""metadata"": {
    ""guid"": ""b03972e4-83b6-4ef0-8dd6-5c9bd79a5bf3"",
    ""url"": ""/v2/service_keys/5fdf844d-d4c7-4afa-928f-e60a79bab6a2"",
    ""created_at"": ""2016-09-02T11:52:25Z"",
    ""updated_at"": null
  },
  ""entity"": {
    ""name"": ""name-2275"",
    ""service_instance_guid"": ""b03972e4-83b6-4ef0-8dd6-5c9bd79a5bf3"",
    ""credentials"": {
      ""creds-key-64"": ""creds-val-64""
    },
    ""service_instance_url"": ""/v2/service_instances/891d1dc7-e1f9-4c86-aca4-f869b8c6bb8e""
  }
}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)201;
                var cfClient = clients.CreateCloudFoundryClient();

                CreateServiceKeyRequest value = new CreateServiceKeyRequest();


                var obj = cfClient.ServiceKeys.CreateServiceKey(value).Result;


                Assert.AreEqual("b03972e4-83b6-4ef0-8dd6-5c9bd79a5bf3", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/service_keys/5fdf844d-d4c7-4afa-928f-e60a79bab6a2", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
                Assert.AreEqual("2016-09-02T11:52:25Z", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("name-2275", TestUtil.ToTestableString(obj.Name), true);
                Assert.AreEqual("b03972e4-83b6-4ef0-8dd6-5c9bd79a5bf3", TestUtil.ToTestableString(obj.ServiceInstanceGuid), true);
                Assert.AreEqual("/v2/service_instances/891d1dc7-e1f9-4c86-aca4-f869b8c6bb8e", TestUtil.ToTestableString(obj.ServiceInstanceUrl), true);

            }
        }

        [TestMethod]
        public void DeleteServiceKeyTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                clients.ExpectedStatusCode = (HttpStatusCode)204;
                var cfClient = clients.CreateCloudFoundryClient();

                Guid? guid = Guid.NewGuid();


                cfClient.ServiceKeys.DeleteServiceKey(guid).Wait();

            }
        }

    }
}