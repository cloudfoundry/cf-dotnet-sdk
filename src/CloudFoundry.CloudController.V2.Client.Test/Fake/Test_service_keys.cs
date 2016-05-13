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
        public void CreateServiceKeyTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                string json = @"{
  ""metadata"": {
    ""guid"": ""41f8dd8d-69cc-4d00-a1cf-aec4ea19f12e"",
    ""url"": ""/v2/service_keys/502d9c2b-d798-4056-977f-45e44d742397"",
    ""created_at"": ""2016-05-05T14:15:14Z"",
    ""updated_at"": null
  },
  ""entity"": {
    ""name"": ""name-1615"",
    ""service_instance_guid"": ""41f8dd8d-69cc-4d00-a1cf-aec4ea19f12e"",
    ""credentials"": {
      ""creds-key-40"": ""creds-val-40""
    },
    ""service_instance_url"": ""/v2/service_instances/b908b86c-0481-4444-a004-40459f83d1a6""
  }
}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)201;
                var cfClient = clients.CreateCloudFoundryClient();

                CreateServiceKeyRequest value = new CreateServiceKeyRequest();


                var obj = cfClient.ServiceKeys.CreateServiceKey(value).Result;


                Assert.AreEqual("41f8dd8d-69cc-4d00-a1cf-aec4ea19f12e", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/service_keys/502d9c2b-d798-4056-977f-45e44d742397", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
                Assert.AreEqual("2016-05-05T14:15:14Z", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("name-1615", TestUtil.ToTestableString(obj.Name), true);
                Assert.AreEqual("41f8dd8d-69cc-4d00-a1cf-aec4ea19f12e", TestUtil.ToTestableString(obj.ServiceInstanceGuid), true);
                Assert.AreEqual("/v2/service_instances/b908b86c-0481-4444-a004-40459f83d1a6", TestUtil.ToTestableString(obj.ServiceInstanceUrl), true);

            }
        }

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
        ""guid"": ""41b393ad-4637-4353-b038-97864977ac08"",
        ""url"": ""/v2/service_keys/08207c7f-7f13-487a-9cb3-890f6de73332"",
        ""created_at"": ""2016-05-05T14:15:15Z"",
        ""updated_at"": null
      },
      ""entity"": {
        ""name"": ""name-1641"",
        ""service_instance_guid"": ""41b393ad-4637-4353-b038-97864977ac08"",
        ""credentials"": {
          ""creds-key-47"": ""creds-val-47""
        },
        ""service_instance_url"": ""/v2/service_instances/47571e61-6200-4b67-8015-813ea61c7f64""
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
                Assert.AreEqual("41b393ad-4637-4353-b038-97864977ac08", TestUtil.ToTestableString(obj[0].EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/service_keys/08207c7f-7f13-487a-9cb3-890f6de73332", TestUtil.ToTestableString(obj[0].EntityMetadata.Url), true);
                Assert.AreEqual("2016-05-05T14:15:15Z", TestUtil.ToTestableString(obj[0].EntityMetadata.CreatedAt), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[0].EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("name-1641", TestUtil.ToTestableString(obj[0].Name), true);
                Assert.AreEqual("41b393ad-4637-4353-b038-97864977ac08", TestUtil.ToTestableString(obj[0].ServiceInstanceGuid), true);
                Assert.AreEqual("/v2/service_instances/47571e61-6200-4b67-8015-813ea61c7f64", TestUtil.ToTestableString(obj[0].ServiceInstanceUrl), true);

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

        [TestMethod]
        public void RetrieveServiceKeyTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                string json = @"{
  ""metadata"": {
    ""guid"": ""04634821-4cfd-42d3-beaa-119ab3d80039"",
    ""url"": ""/v2/service_keys/6c7392e3-1061-4a2f-9b67-be338c1efe33"",
    ""created_at"": ""2016-05-05T14:15:15Z"",
    ""updated_at"": null
  },
  ""entity"": {
    ""name"": ""name-1654"",
    ""service_instance_guid"": ""04634821-4cfd-42d3-beaa-119ab3d80039"",
    ""credentials"": {
      ""creds-key-50"": ""creds-val-50""
    },
    ""service_instance_url"": ""/v2/service_instances/a2713b04-035d-4cb9-b8aa-56f740d2b002""
  }
}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)200;
                var cfClient = clients.CreateCloudFoundryClient();

                Guid? guid = Guid.NewGuid();


                var obj = cfClient.ServiceKeys.RetrieveServiceKey(guid).Result;


                Assert.AreEqual("04634821-4cfd-42d3-beaa-119ab3d80039", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/service_keys/6c7392e3-1061-4a2f-9b67-be338c1efe33", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
                Assert.AreEqual("2016-05-05T14:15:15Z", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("name-1654", TestUtil.ToTestableString(obj.Name), true);
                Assert.AreEqual("04634821-4cfd-42d3-beaa-119ab3d80039", TestUtil.ToTestableString(obj.ServiceInstanceGuid), true);
                Assert.AreEqual("/v2/service_instances/a2713b04-035d-4cb9-b8aa-56f740d2b002", TestUtil.ToTestableString(obj.ServiceInstanceUrl), true);

            }
        }

    }
}