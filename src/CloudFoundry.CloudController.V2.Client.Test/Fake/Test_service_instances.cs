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
    public class ServiceInstancesEndpoint
{
        [TestMethod]
        public void UpdateServiceInstanceTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                string json = @"{
  ""metadata"": {
    ""guid"": ""a9211fe3-e249-41f5-a34c-7e63dd7edda9"",
    ""url"": ""/v2/service_instances/a9211fe3-e249-41f5-a34c-7e63dd7edda9"",
    ""created_at"": ""2015-04-10T20:04:28+00:00"",
    ""updated_at"": ""2015-04-10T20:04:28+00:00""
  },
  ""entity"": {
    ""name"": ""name-452"",
    ""credentials"": {
      ""creds-key-155"": ""creds-val-155""
    },
    ""service_plan_guid"": ""7666acc6-65c4-41de-8b3d-fc001ead2888"",
    ""space_guid"": ""deadbd5f-256f-4b16-9ab1-db80d9b8e02c"",
    ""gateway_data"": null,
    ""dashboard_url"": null,
    ""type"": ""managed_service_instance"",
    ""space_url"": ""/v2/spaces/deadbd5f-256f-4b16-9ab1-db80d9b8e02c"",
    ""service_plan_url"": ""/v2/service_plans/7666acc6-65c4-41de-8b3d-fc001ead2888"",
    ""service_bindings_url"": ""/v2/service_instances/a9211fe3-e249-41f5-a34c-7e63dd7edda9/service_bindings""
  }
}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)201;
                var cfClient = clients.CreateCloudFoundryClient();

                Guid? guid = Guid.NewGuid();

                UpdateServiceInstanceRequest value = new UpdateServiceInstanceRequest();


                var obj = cfClient.ServiceInstances.UpdateServiceInstance(guid, value).Result;


                Assert.AreEqual("a9211fe3-e249-41f5-a34c-7e63dd7edda9", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/service_instances/a9211fe3-e249-41f5-a34c-7e63dd7edda9", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
                Assert.AreEqual("2015-04-10T20:04:28+00:00", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
                Assert.AreEqual("2015-04-10T20:04:28+00:00", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("name-452", TestUtil.ToTestableString(obj.Name), true);
                Assert.AreEqual("7666acc6-65c4-41de-8b3d-fc001ead2888", TestUtil.ToTestableString(obj.ServicePlanGuid), true);
                Assert.AreEqual("deadbd5f-256f-4b16-9ab1-db80d9b8e02c", TestUtil.ToTestableString(obj.SpaceGuid), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.GatewayData), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.DashboardUrl), true);
                Assert.AreEqual("managed_service_instance", TestUtil.ToTestableString(obj.Type), true);
                Assert.AreEqual("/v2/spaces/deadbd5f-256f-4b16-9ab1-db80d9b8e02c", TestUtil.ToTestableString(obj.SpaceUrl), true);
                Assert.AreEqual("/v2/service_plans/7666acc6-65c4-41de-8b3d-fc001ead2888", TestUtil.ToTestableString(obj.ServicePlanUrl), true);
                Assert.AreEqual("/v2/service_instances/a9211fe3-e249-41f5-a34c-7e63dd7edda9/service_bindings", TestUtil.ToTestableString(obj.ServiceBindingsUrl), true);

            }
        }

        [TestMethod]
        public void ListAllServiceInstancesTest()
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
        ""guid"": ""2d7cd48f-13f5-4498-864d-94bd72c98058"",
        ""url"": ""/v2/service_instances/2d7cd48f-13f5-4498-864d-94bd72c98058"",
        ""created_at"": ""2015-04-10T20:04:28+00:00"",
        ""updated_at"": null
      },
      ""entity"": {
        ""name"": ""name-440"",
        ""credentials"": {
          ""creds-key-149"": ""creds-val-149""
        },
        ""service_plan_guid"": ""266ca2ca-0d56-402b-8aaa-fbdd242c3fea"",
        ""space_guid"": ""b96a55d6-1b68-4261-af22-78ba9a67b357"",
        ""gateway_data"": null,
        ""dashboard_url"": null,
        ""type"": ""managed_service_instance"",
        ""space_url"": ""/v2/spaces/b96a55d6-1b68-4261-af22-78ba9a67b357"",
        ""service_plan_url"": ""/v2/service_plans/266ca2ca-0d56-402b-8aaa-fbdd242c3fea"",
        ""service_bindings_url"": ""/v2/service_instances/2d7cd48f-13f5-4498-864d-94bd72c98058/service_bindings""
      }
    }
  ]
}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)200;
                var cfClient = clients.CreateCloudFoundryClient();


                var obj = cfClient.ServiceInstances.ListAllServiceInstances().Result;

                Assert.AreEqual("1", TestUtil.ToTestableString(obj.Properties.TotalResults), true);
                Assert.AreEqual("1", TestUtil.ToTestableString(obj.Properties.TotalPages), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.Properties.PreviousUrl), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.Properties.NextUrl), true);
                Assert.AreEqual("2d7cd48f-13f5-4498-864d-94bd72c98058", TestUtil.ToTestableString(obj[0].EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/service_instances/2d7cd48f-13f5-4498-864d-94bd72c98058", TestUtil.ToTestableString(obj[0].EntityMetadata.Url), true);
                Assert.AreEqual("2015-04-10T20:04:28+00:00", TestUtil.ToTestableString(obj[0].EntityMetadata.CreatedAt), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[0].EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("name-440", TestUtil.ToTestableString(obj[0].Name), true);
                Assert.AreEqual("266ca2ca-0d56-402b-8aaa-fbdd242c3fea", TestUtil.ToTestableString(obj[0].ServicePlanGuid), true);
                Assert.AreEqual("b96a55d6-1b68-4261-af22-78ba9a67b357", TestUtil.ToTestableString(obj[0].SpaceGuid), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[0].GatewayData), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[0].DashboardUrl), true);
                Assert.AreEqual("managed_service_instance", TestUtil.ToTestableString(obj[0].Type), true);
                Assert.AreEqual("/v2/spaces/b96a55d6-1b68-4261-af22-78ba9a67b357", TestUtil.ToTestableString(obj[0].SpaceUrl), true);
                Assert.AreEqual("/v2/service_plans/266ca2ca-0d56-402b-8aaa-fbdd242c3fea", TestUtil.ToTestableString(obj[0].ServicePlanUrl), true);
                Assert.AreEqual("/v2/service_instances/2d7cd48f-13f5-4498-864d-94bd72c98058/service_bindings", TestUtil.ToTestableString(obj[0].ServiceBindingsUrl), true);

            }
        }

        [TestMethod]
        public void CreateServiceInstanceTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                string json = @"{
  ""metadata"": {
    ""guid"": ""7e33786a-fbb8-4854-922d-6b22cf1d1b1a"",
    ""url"": ""/v2/service_instances/7e33786a-fbb8-4854-922d-6b22cf1d1b1a"",
    ""created_at"": ""2015-04-10T20:04:28+00:00"",
    ""updated_at"": null
  },
  ""entity"": {
    ""name"": ""my-service-instance"",
    ""credentials"": {
      ""creds-key-156"": ""creds-val-156""
    },
    ""service_plan_guid"": ""1eabc10f-7282-48f6-8338-e3b8e6394fc6"",
    ""space_guid"": ""ee553132-2dce-4623-a76e-4d389c8f3f88"",
    ""gateway_data"": ""CONFIGURATION"",
    ""dashboard_url"": ""http://dashboard.example.com"",
    ""type"": ""managed_service_instance"",
    ""space_url"": ""/v2/spaces/ee553132-2dce-4623-a76e-4d389c8f3f88"",
    ""service_plan_url"": ""/v2/service_plans/1eabc10f-7282-48f6-8338-e3b8e6394fc6"",
    ""service_bindings_url"": ""/v2/service_instances/7e33786a-fbb8-4854-922d-6b22cf1d1b1a/service_bindings""
  }
}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)201;
                var cfClient = clients.CreateCloudFoundryClient();

                CreateServiceInstanceRequest value = new CreateServiceInstanceRequest();


                var obj = cfClient.ServiceInstances.CreateServiceInstance(value).Result;


                Assert.AreEqual("7e33786a-fbb8-4854-922d-6b22cf1d1b1a", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/service_instances/7e33786a-fbb8-4854-922d-6b22cf1d1b1a", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
                Assert.AreEqual("2015-04-10T20:04:28+00:00", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("my-service-instance", TestUtil.ToTestableString(obj.Name), true);
                Assert.AreEqual("1eabc10f-7282-48f6-8338-e3b8e6394fc6", TestUtil.ToTestableString(obj.ServicePlanGuid), true);
                Assert.AreEqual("ee553132-2dce-4623-a76e-4d389c8f3f88", TestUtil.ToTestableString(obj.SpaceGuid), true);
                Assert.AreEqual("CONFIGURATION", TestUtil.ToTestableString(obj.GatewayData), true);
                Assert.AreEqual("http://dashboard.example.com", TestUtil.ToTestableString(obj.DashboardUrl), true);
                Assert.AreEqual("managed_service_instance", TestUtil.ToTestableString(obj.Type), true);
                Assert.AreEqual("/v2/spaces/ee553132-2dce-4623-a76e-4d389c8f3f88", TestUtil.ToTestableString(obj.SpaceUrl), true);
                Assert.AreEqual("/v2/service_plans/1eabc10f-7282-48f6-8338-e3b8e6394fc6", TestUtil.ToTestableString(obj.ServicePlanUrl), true);
                Assert.AreEqual("/v2/service_instances/7e33786a-fbb8-4854-922d-6b22cf1d1b1a/service_bindings", TestUtil.ToTestableString(obj.ServiceBindingsUrl), true);

            }
        }

        [TestMethod]
        public void DeleteServiceInstanceTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                clients.ExpectedStatusCode = (HttpStatusCode)204;
                var cfClient = clients.CreateCloudFoundryClient();

                Guid? guid = Guid.NewGuid();


                cfClient.ServiceInstances.DeleteServiceInstance(guid).Wait();

            }
        }

        [TestMethod]
        public void ListAllServiceBindingsForServiceInstanceTest()
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
        ""guid"": ""e7ecabf2-4041-492e-b620-7a483e2ebd93"",
        ""url"": ""/v2/service_bindings/e7ecabf2-4041-492e-b620-7a483e2ebd93"",
        ""created_at"": ""2015-04-10T20:04:29+00:00"",
        ""updated_at"": null
      },
      ""entity"": {
        ""app_guid"": ""e28aee4c-d295-4c9a-a85b-c456215cd8ad"",
        ""service_instance_guid"": ""137a53ed-05fa-4903-9f23-068ce9d5a3a2"",
        ""credentials"": {
          ""creds-key-165"": ""creds-val-165""
        },
        ""binding_options"": {

        },
        ""gateway_data"": null,
        ""gateway_name"": """",
        ""syslog_drain_url"": null,
        ""app_url"": ""/v2/apps/e28aee4c-d295-4c9a-a85b-c456215cd8ad"",
        ""service_instance_url"": ""/v2/service_instances/137a53ed-05fa-4903-9f23-068ce9d5a3a2""
      }
    }
  ]
}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)200;
                var cfClient = clients.CreateCloudFoundryClient();

                Guid? guid = Guid.NewGuid();


                var obj = cfClient.ServiceInstances.ListAllServiceBindingsForServiceInstance(guid).Result;

                Assert.AreEqual("1", TestUtil.ToTestableString(obj.Properties.TotalResults), true);
                Assert.AreEqual("1", TestUtil.ToTestableString(obj.Properties.TotalPages), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.Properties.PreviousUrl), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.Properties.NextUrl), true);
                Assert.AreEqual("e7ecabf2-4041-492e-b620-7a483e2ebd93", TestUtil.ToTestableString(obj[0].EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/service_bindings/e7ecabf2-4041-492e-b620-7a483e2ebd93", TestUtil.ToTestableString(obj[0].EntityMetadata.Url), true);
                Assert.AreEqual("2015-04-10T20:04:29+00:00", TestUtil.ToTestableString(obj[0].EntityMetadata.CreatedAt), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[0].EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("e28aee4c-d295-4c9a-a85b-c456215cd8ad", TestUtil.ToTestableString(obj[0].AppGuid), true);
                Assert.AreEqual("137a53ed-05fa-4903-9f23-068ce9d5a3a2", TestUtil.ToTestableString(obj[0].ServiceInstanceGuid), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[0].GatewayData), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[0].GatewayName), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[0].SyslogDrainUrl), true);
                Assert.AreEqual("/v2/apps/e28aee4c-d295-4c9a-a85b-c456215cd8ad", TestUtil.ToTestableString(obj[0].AppUrl), true);
                Assert.AreEqual("/v2/service_instances/137a53ed-05fa-4903-9f23-068ce9d5a3a2", TestUtil.ToTestableString(obj[0].ServiceInstanceUrl), true);

            }
        }

        [TestMethod]
        public void MigrateServiceInstancesFromOneServicePlanToAnotherServicePlanExperimentalTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                string json = @"{""changed_count"":1}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)200;
                var cfClient = clients.CreateCloudFoundryClient();

                Guid? service_plan_guid = Guid.NewGuid();

                MigrateServiceInstancesFromOneServicePlanToAnotherServicePlanExperimentalRequest value = new MigrateServiceInstancesFromOneServicePlanToAnotherServicePlanExperimentalRequest();


                var obj = cfClient.ServiceInstances.MigrateServiceInstancesFromOneServicePlanToAnotherServicePlanExperimental(service_plan_guid, value).Result;


                Assert.AreEqual("1", TestUtil.ToTestableString(obj.ChangedCount), true);

            }
        }

        [TestMethod]
        public void RetrieveServiceInstanceTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                string json = @"{
  ""metadata"": {
    ""guid"": ""9e59ec01-6526-462b-8a45-205893489605"",
    ""url"": ""/v2/service_instances/9e59ec01-6526-462b-8a45-205893489605"",
    ""created_at"": ""2015-04-10T20:04:28+00:00"",
    ""updated_at"": null
  },
  ""entity"": {
    ""name"": ""name-445"",
    ""credentials"": {
      ""creds-key-152"": ""creds-val-152""
    },
    ""service_plan_guid"": ""1b677577-f0d3-46ce-8b9f-fa2afbc77a30"",
    ""space_guid"": ""58cba8d4-1894-492f-a66a-e6df7c8e87ff"",
    ""gateway_data"": null,
    ""dashboard_url"": null,
    ""type"": ""managed_service_instance"",
    ""space_url"": ""/v2/spaces/58cba8d4-1894-492f-a66a-e6df7c8e87ff"",
    ""service_plan_url"": ""/v2/service_plans/1b677577-f0d3-46ce-8b9f-fa2afbc77a30"",
    ""service_bindings_url"": ""/v2/service_instances/9e59ec01-6526-462b-8a45-205893489605/service_bindings""
  }
}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)200;
                var cfClient = clients.CreateCloudFoundryClient();

                Guid? guid = Guid.NewGuid();


                var obj = cfClient.ServiceInstances.RetrieveServiceInstance(guid).Result;


                Assert.AreEqual("9e59ec01-6526-462b-8a45-205893489605", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/service_instances/9e59ec01-6526-462b-8a45-205893489605", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
                Assert.AreEqual("2015-04-10T20:04:28+00:00", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("name-445", TestUtil.ToTestableString(obj.Name), true);
                Assert.AreEqual("1b677577-f0d3-46ce-8b9f-fa2afbc77a30", TestUtil.ToTestableString(obj.ServicePlanGuid), true);
                Assert.AreEqual("58cba8d4-1894-492f-a66a-e6df7c8e87ff", TestUtil.ToTestableString(obj.SpaceGuid), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.GatewayData), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.DashboardUrl), true);
                Assert.AreEqual("managed_service_instance", TestUtil.ToTestableString(obj.Type), true);
                Assert.AreEqual("/v2/spaces/58cba8d4-1894-492f-a66a-e6df7c8e87ff", TestUtil.ToTestableString(obj.SpaceUrl), true);
                Assert.AreEqual("/v2/service_plans/1b677577-f0d3-46ce-8b9f-fa2afbc77a30", TestUtil.ToTestableString(obj.ServicePlanUrl), true);
                Assert.AreEqual("/v2/service_instances/9e59ec01-6526-462b-8a45-205893489605/service_bindings", TestUtil.ToTestableString(obj.ServiceBindingsUrl), true);

            }
        }

        [TestMethod]
        public void RetrievingPermissionsOnServiceInstanceTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                string json = @"{""manage"":true}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)200;
                var cfClient = clients.CreateCloudFoundryClient();

                Guid? guid = Guid.NewGuid();


                var obj = cfClient.ServiceInstances.RetrievingPermissionsOnServiceInstance(guid).Result;


                Assert.AreEqual("true", TestUtil.ToTestableString(obj.Manage), true);

            }
        }

    }
}