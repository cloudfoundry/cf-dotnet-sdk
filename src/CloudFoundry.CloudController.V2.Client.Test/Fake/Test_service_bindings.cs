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
    public class ServiceBindingsEndpoint
{
        [TestMethod]
        public void DeleteServiceBindingTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                clients.ExpectedStatusCode = (HttpStatusCode)204;
                var cfClient = clients.CreateCloudFoundryClient();

                Guid? guid = Guid.NewGuid();


                cfClient.ServiceBindings.DeleteServiceBinding(guid).Wait();

            }
        }

        [TestMethod]
        public void ListAllServiceBindingsTest()
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
        ""guid"": ""4544868b-0f46-4a1b-a00b-cf3848ffda7c"",
        ""url"": ""/v2/service_bindings/ff1be68f-98d2-4933-bce6-37add339785b"",
        ""created_at"": ""2016-05-05T14:14:49Z"",
        ""updated_at"": null
      },
      ""entity"": {
        ""app_guid"": ""4544868b-0f46-4a1b-a00b-cf3848ffda7c"",
        ""service_instance_guid"": ""4544868b-0f46-4a1b-a00b-cf3848ffda7c"",
        ""credentials"": {
          ""creds-key-18"": ""creds-val-18""
        },
        ""binding_options"": {

        },
        ""gateway_data"": null,
        ""gateway_name"": """",
        ""syslog_drain_url"": null,
        ""app_url"": ""/v2/apps/25285210-5d11-4cbb-aeb9-36415925aeb1"",
        ""service_instance_url"": ""/v2/service_instances/f581f9f0-f35b-4f26-bb90-2543355622d6""
      }
    }
  ]
}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)200;
                var cfClient = clients.CreateCloudFoundryClient();


                var obj = cfClient.ServiceBindings.ListAllServiceBindings().Result;

                Assert.AreEqual("1", TestUtil.ToTestableString(obj.Properties.TotalResults), true);
                Assert.AreEqual("1", TestUtil.ToTestableString(obj.Properties.TotalPages), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.Properties.PreviousUrl), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.Properties.NextUrl), true);
                Assert.AreEqual("4544868b-0f46-4a1b-a00b-cf3848ffda7c", TestUtil.ToTestableString(obj[0].EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/service_bindings/ff1be68f-98d2-4933-bce6-37add339785b", TestUtil.ToTestableString(obj[0].EntityMetadata.Url), true);
                Assert.AreEqual("2016-05-05T14:14:49Z", TestUtil.ToTestableString(obj[0].EntityMetadata.CreatedAt), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[0].EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("4544868b-0f46-4a1b-a00b-cf3848ffda7c", TestUtil.ToTestableString(obj[0].AppGuid), true);
                Assert.AreEqual("4544868b-0f46-4a1b-a00b-cf3848ffda7c", TestUtil.ToTestableString(obj[0].ServiceInstanceGuid), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[0].GatewayData), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[0].GatewayName), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[0].SyslogDrainUrl), true);
                Assert.AreEqual("/v2/apps/25285210-5d11-4cbb-aeb9-36415925aeb1", TestUtil.ToTestableString(obj[0].AppUrl), true);
                Assert.AreEqual("/v2/service_instances/f581f9f0-f35b-4f26-bb90-2543355622d6", TestUtil.ToTestableString(obj[0].ServiceInstanceUrl), true);

            }
        }

        [TestMethod]
        public void RetrieveServiceBindingTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                string json = @"{
  ""metadata"": {
    ""guid"": ""e8f1cff0-1704-490b-b47b-a4b3581e382c"",
    ""url"": ""/v2/service_bindings/6e4b915d-e5f1-4a15-bb14-10fca5b66b38"",
    ""created_at"": ""2016-05-05T14:14:49Z"",
    ""updated_at"": null
  },
  ""entity"": {
    ""app_guid"": ""e8f1cff0-1704-490b-b47b-a4b3581e382c"",
    ""service_instance_guid"": ""e8f1cff0-1704-490b-b47b-a4b3581e382c"",
    ""credentials"": {
      ""creds-key-16"": ""creds-val-16""
    },
    ""binding_options"": {

    },
    ""gateway_data"": null,
    ""gateway_name"": """",
    ""syslog_drain_url"": null,
    ""app_url"": ""/v2/apps/03328622-1188-4b77-9202-cdc6448661e8"",
    ""service_instance_url"": ""/v2/service_instances/f1e7a49e-0f4c-4c5f-af5c-4ce8f16f8410""
  }
}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)200;
                var cfClient = clients.CreateCloudFoundryClient();

                Guid? guid = Guid.NewGuid();


                var obj = cfClient.ServiceBindings.RetrieveServiceBinding(guid).Result;


                Assert.AreEqual("e8f1cff0-1704-490b-b47b-a4b3581e382c", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/service_bindings/6e4b915d-e5f1-4a15-bb14-10fca5b66b38", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
                Assert.AreEqual("2016-05-05T14:14:49Z", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("e8f1cff0-1704-490b-b47b-a4b3581e382c", TestUtil.ToTestableString(obj.AppGuid), true);
                Assert.AreEqual("e8f1cff0-1704-490b-b47b-a4b3581e382c", TestUtil.ToTestableString(obj.ServiceInstanceGuid), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.GatewayData), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.GatewayName), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.SyslogDrainUrl), true);
                Assert.AreEqual("/v2/apps/03328622-1188-4b77-9202-cdc6448661e8", TestUtil.ToTestableString(obj.AppUrl), true);
                Assert.AreEqual("/v2/service_instances/f1e7a49e-0f4c-4c5f-af5c-4ce8f16f8410", TestUtil.ToTestableString(obj.ServiceInstanceUrl), true);

            }
        }

        [TestMethod]
        public void CreateServiceBindingTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                string json = @"{
  ""metadata"": {
    ""guid"": ""b3773d1e-4ae8-4cd7-85ea-89d4bf9eda5b"",
    ""url"": ""/v2/service_bindings/75721750-7bb4-40b5-a318-4ba4a7eee464"",
    ""created_at"": ""2016-05-05T14:14:48Z"",
    ""updated_at"": null
  },
  ""entity"": {
    ""app_guid"": ""b3773d1e-4ae8-4cd7-85ea-89d4bf9eda5b"",
    ""service_instance_guid"": ""b3773d1e-4ae8-4cd7-85ea-89d4bf9eda5b"",
    ""credentials"": {
      ""creds-key-15"": ""creds-val-15""
    },
    ""binding_options"": {

    },
    ""gateway_data"": null,
    ""gateway_name"": """",
    ""syslog_drain_url"": null,
    ""app_url"": ""/v2/apps/b8bba933-1648-48d3-b9dc-51d1ac7e258b"",
    ""service_instance_url"": ""/v2/user_provided_service_instances/62e73456-318d-4fd8-809f-c273b271f683""
  }
}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)201;
                var cfClient = clients.CreateCloudFoundryClient();

                CreateServiceBindingRequest value = new CreateServiceBindingRequest();


                var obj = cfClient.ServiceBindings.CreateServiceBinding(value).Result;


                Assert.AreEqual("b3773d1e-4ae8-4cd7-85ea-89d4bf9eda5b", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/service_bindings/75721750-7bb4-40b5-a318-4ba4a7eee464", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
                Assert.AreEqual("2016-05-05T14:14:48Z", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("b3773d1e-4ae8-4cd7-85ea-89d4bf9eda5b", TestUtil.ToTestableString(obj.AppGuid), true);
                Assert.AreEqual("b3773d1e-4ae8-4cd7-85ea-89d4bf9eda5b", TestUtil.ToTestableString(obj.ServiceInstanceGuid), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.GatewayData), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.GatewayName), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.SyslogDrainUrl), true);
                Assert.AreEqual("/v2/apps/b8bba933-1648-48d3-b9dc-51d1ac7e258b", TestUtil.ToTestableString(obj.AppUrl), true);
                Assert.AreEqual("/v2/user_provided_service_instances/62e73456-318d-4fd8-809f-c273b271f683", TestUtil.ToTestableString(obj.ServiceInstanceUrl), true);

            }
        }

    }
}