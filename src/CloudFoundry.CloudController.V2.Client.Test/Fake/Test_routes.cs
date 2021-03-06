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
    public class RoutesEndpoint
{
        [TestMethod]
        public void CheckRouteExistsTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                clients.ExpectedStatusCode = (HttpStatusCode)204;
                var cfClient = clients.CreateCloudFoundryClient();

                Guid? domain_guid = Guid.NewGuid();

                dynamic host = null;

                dynamic path = null;

                dynamic port = null;


                cfClient.Routes.CheckRouteExists(domain_guid, host, path, port).Wait();

            }
        }

        [TestMethod]
        public void UpdateRouteTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                string json = @"{
  ""metadata"": {
    ""guid"": ""4be83a59-3faa-479f-84fc-6097aba4ffd5"",
    ""url"": ""/v2/routes/ab642f0e-bccd-4326-bc7a-fda268522dfd"",
    ""created_at"": ""2017-01-04T15:58:55Z"",
    ""updated_at"": ""2017-01-04T15:58:55Z""
  },
  ""entity"": {
    ""host"": ""host-21"",
    ""path"": """",
    ""domain_guid"": ""4be83a59-3faa-479f-84fc-6097aba4ffd5"",
    ""space_guid"": ""4be83a59-3faa-479f-84fc-6097aba4ffd5"",
    ""service_instance_guid"": null,
    ""port"": 10000,
    ""domain_url"": ""/v2/shared_domains/f7cd9f8c-7f74-44ac-acfe-5bc81824b8e5"",
    ""space_url"": ""/v2/spaces/2e3b04ed-099d-4a07-a1d5-a87fc93473f4"",
    ""apps_url"": ""/v2/routes/ab642f0e-bccd-4326-bc7a-fda268522dfd/apps"",
    ""route_mappings_url"": ""/v2/routes/ab642f0e-bccd-4326-bc7a-fda268522dfd/route_mappings""
  }
}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)201;
                var cfClient = clients.CreateCloudFoundryClient();

                Guid? guid = Guid.NewGuid();

                UpdateRouteRequest value = new UpdateRouteRequest();


                var obj = cfClient.Routes.UpdateRoute(guid, value).Result;


                Assert.AreEqual("4be83a59-3faa-479f-84fc-6097aba4ffd5", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/routes/ab642f0e-bccd-4326-bc7a-fda268522dfd", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
                Assert.AreEqual("2017-01-04T15:58:55Z", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
                Assert.AreEqual("2017-01-04T15:58:55Z", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("host-21", TestUtil.ToTestableString(obj.Host), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.Path), true);
                Assert.AreEqual("4be83a59-3faa-479f-84fc-6097aba4ffd5", TestUtil.ToTestableString(obj.DomainGuid), true);
                Assert.AreEqual("4be83a59-3faa-479f-84fc-6097aba4ffd5", TestUtil.ToTestableString(obj.SpaceGuid), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.ServiceInstanceGuid), true);
                Assert.AreEqual("10000", TestUtil.ToTestableString(obj.Port), true);
                Assert.AreEqual("/v2/shared_domains/f7cd9f8c-7f74-44ac-acfe-5bc81824b8e5", TestUtil.ToTestableString(obj.DomainUrl), true);
                Assert.AreEqual("/v2/spaces/2e3b04ed-099d-4a07-a1d5-a87fc93473f4", TestUtil.ToTestableString(obj.SpaceUrl), true);
                Assert.AreEqual("/v2/routes/ab642f0e-bccd-4326-bc7a-fda268522dfd/apps", TestUtil.ToTestableString(obj.AppsUrl), true);
                Assert.AreEqual("/v2/routes/ab642f0e-bccd-4326-bc7a-fda268522dfd/route_mappings", TestUtil.ToTestableString(obj.RouteMappingsUrl), true);

            }
        }

        [TestMethod]
        public void RemoveAppFromRouteTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                clients.ExpectedStatusCode = (HttpStatusCode)204;
                var cfClient = clients.CreateCloudFoundryClient();

                Guid? guid = Guid.NewGuid();

                Guid? app_guid = Guid.NewGuid();


                cfClient.Routes.RemoveAppFromRoute(guid, app_guid).Wait();

            }
        }

        [TestMethod]
        public void CreateRouteTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                string json = @"{
  ""metadata"": {
    ""guid"": ""74324be7-c811-4452-8cbd-09a0353a0e13"",
    ""url"": ""/v2/routes/6268b22c-7e01-4c87-9afd-94e0db64ffca"",
    ""created_at"": ""2017-01-04T15:58:56Z"",
    ""updated_at"": ""2017-01-04T15:58:56Z""
  },
  ""entity"": {
    ""host"": """",
    ""path"": """",
    ""domain_guid"": ""74324be7-c811-4452-8cbd-09a0353a0e13"",
    ""space_guid"": ""74324be7-c811-4452-8cbd-09a0353a0e13"",
    ""service_instance_guid"": null,
    ""port"": 10000,
    ""domain_url"": ""/v2/shared_domains/f6dc5692-0313-4477-b548-0d22d0aadb63"",
    ""space_url"": ""/v2/spaces/a7f61e23-57e7-4741-864e-844fe0f239d3"",
    ""apps_url"": ""/v2/routes/6268b22c-7e01-4c87-9afd-94e0db64ffca/apps"",
    ""route_mappings_url"": ""/v2/routes/6268b22c-7e01-4c87-9afd-94e0db64ffca/route_mappings""
  }
}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)201;
                var cfClient = clients.CreateCloudFoundryClient();

                CreateRouteRequest value = new CreateRouteRequest();


                var obj = cfClient.Routes.CreateRoute(value).Result;


                Assert.AreEqual("74324be7-c811-4452-8cbd-09a0353a0e13", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/routes/6268b22c-7e01-4c87-9afd-94e0db64ffca", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
                Assert.AreEqual("2017-01-04T15:58:56Z", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
                Assert.AreEqual("2017-01-04T15:58:56Z", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.Host), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.Path), true);
                Assert.AreEqual("74324be7-c811-4452-8cbd-09a0353a0e13", TestUtil.ToTestableString(obj.DomainGuid), true);
                Assert.AreEqual("74324be7-c811-4452-8cbd-09a0353a0e13", TestUtil.ToTestableString(obj.SpaceGuid), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.ServiceInstanceGuid), true);
                Assert.AreEqual("10000", TestUtil.ToTestableString(obj.Port), true);
                Assert.AreEqual("/v2/shared_domains/f6dc5692-0313-4477-b548-0d22d0aadb63", TestUtil.ToTestableString(obj.DomainUrl), true);
                Assert.AreEqual("/v2/spaces/a7f61e23-57e7-4741-864e-844fe0f239d3", TestUtil.ToTestableString(obj.SpaceUrl), true);
                Assert.AreEqual("/v2/routes/6268b22c-7e01-4c87-9afd-94e0db64ffca/apps", TestUtil.ToTestableString(obj.AppsUrl), true);
                Assert.AreEqual("/v2/routes/6268b22c-7e01-4c87-9afd-94e0db64ffca/route_mappings", TestUtil.ToTestableString(obj.RouteMappingsUrl), true);

            }
        }

        [TestMethod]
        public void AssociateAppWithRouteTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                string json = @"{
  ""metadata"": {
    ""guid"": ""c536cfbc-31b2-4095-a05e-0c9475162df4"",
    ""url"": ""/v2/routes/4b31be73-eb87-407a-b026-45f24dad9b20"",
    ""created_at"": ""2017-01-04T15:58:55Z"",
    ""updated_at"": ""2017-01-04T15:58:55Z""
  },
  ""entity"": {
    ""host"": ""host-19"",
    ""path"": """",
    ""domain_guid"": ""c536cfbc-31b2-4095-a05e-0c9475162df4"",
    ""space_guid"": ""c536cfbc-31b2-4095-a05e-0c9475162df4"",
    ""service_instance_guid"": null,
    ""port"": null,
    ""domain_url"": ""/v2/shared_domains/1870ea51-95e1-4f55-a23c-0328587c5167"",
    ""space_url"": ""/v2/spaces/38bda9f0-fe31-439d-a420-f6365c9485c3"",
    ""apps_url"": ""/v2/routes/4b31be73-eb87-407a-b026-45f24dad9b20/apps"",
    ""route_mappings_url"": ""/v2/routes/4b31be73-eb87-407a-b026-45f24dad9b20/route_mappings""
  }
}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)201;
                var cfClient = clients.CreateCloudFoundryClient();

                Guid? guid = Guid.NewGuid();

                Guid? app_guid = Guid.NewGuid();


                var obj = cfClient.Routes.AssociateAppWithRoute(guid, app_guid).Result;


                Assert.AreEqual("c536cfbc-31b2-4095-a05e-0c9475162df4", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/routes/4b31be73-eb87-407a-b026-45f24dad9b20", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
                Assert.AreEqual("2017-01-04T15:58:55Z", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
                Assert.AreEqual("2017-01-04T15:58:55Z", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("host-19", TestUtil.ToTestableString(obj.Host), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.Path), true);
                Assert.AreEqual("c536cfbc-31b2-4095-a05e-0c9475162df4", TestUtil.ToTestableString(obj.DomainGuid), true);
                Assert.AreEqual("c536cfbc-31b2-4095-a05e-0c9475162df4", TestUtil.ToTestableString(obj.SpaceGuid), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.ServiceInstanceGuid), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.Port), true);
                Assert.AreEqual("/v2/shared_domains/1870ea51-95e1-4f55-a23c-0328587c5167", TestUtil.ToTestableString(obj.DomainUrl), true);
                Assert.AreEqual("/v2/spaces/38bda9f0-fe31-439d-a420-f6365c9485c3", TestUtil.ToTestableString(obj.SpaceUrl), true);
                Assert.AreEqual("/v2/routes/4b31be73-eb87-407a-b026-45f24dad9b20/apps", TestUtil.ToTestableString(obj.AppsUrl), true);
                Assert.AreEqual("/v2/routes/4b31be73-eb87-407a-b026-45f24dad9b20/route_mappings", TestUtil.ToTestableString(obj.RouteMappingsUrl), true);

            }
        }

        [TestMethod]
        public void ListAllAppsForRouteTest()
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
        ""guid"": ""6bda6d68-21b9-4486-89cf-da35f1f2eb2c"",
        ""url"": ""/v2/apps/bdd71c69-8c2e-4a67-b443-016d5de04288"",
        ""created_at"": ""2017-01-04T15:58:55Z"",
        ""updated_at"": ""2017-01-04T15:58:55Z""
      },
      ""entity"": {
        ""name"": ""name-1906"",
        ""production"": false,
        ""space_guid"": ""6bda6d68-21b9-4486-89cf-da35f1f2eb2c"",
        ""stack_guid"": ""6bda6d68-21b9-4486-89cf-da35f1f2eb2c"",
        ""buildpack"": null,
        ""detected_buildpack"": null,
        ""detected_buildpack_guid"": null,
        ""environment_json"": null,
        ""memory"": 1024,
        ""instances"": 1,
        ""disk_quota"": 1024,
        ""state"": ""STOPPED"",
        ""version"": ""4d8c76d4-439d-45f7-9ccb-c884b7153a2c"",
        ""command"": null,
        ""console"": false,
        ""debug"": null,
        ""staging_task_id"": ""2a965df8-0c0e-476d-af95-e3c94ae262f0"",
        ""package_state"": ""STAGED"",
        ""health_check_type"": ""port"",
        ""health_check_timeout"": null,
        ""health_check_http_endpoint"": null,
        ""staging_failed_reason"": null,
        ""staging_failed_description"": null,
        ""diego"": false,
        ""docker_image"": null,
        ""package_updated_at"": ""2017-01-04T15:58:54Z"",
        ""detected_start_command"": """",
        ""enable_ssh"": true,
        ""docker_credentials_json"": {
          ""redacted_message"": ""[PRIVATE DATA HIDDEN]""
        },
        ""ports"": null,
        ""space_url"": ""/v2/spaces/8b3c9652-7d26-40bf-92f8-222ddbda1de3"",
        ""stack_url"": ""/v2/stacks/0fc9cb17-6b5c-441d-a89c-271745f3ec71"",
        ""routes_url"": ""/v2/apps/bdd71c69-8c2e-4a67-b443-016d5de04288/routes"",
        ""events_url"": ""/v2/apps/bdd71c69-8c2e-4a67-b443-016d5de04288/events"",
        ""service_bindings_url"": ""/v2/apps/bdd71c69-8c2e-4a67-b443-016d5de04288/service_bindings"",
        ""route_mappings_url"": ""/v2/apps/bdd71c69-8c2e-4a67-b443-016d5de04288/route_mappings""
      }
    }
  ]
}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)200;
                var cfClient = clients.CreateCloudFoundryClient();

                Guid? guid = Guid.NewGuid();


                var obj = cfClient.Routes.ListAllAppsForRoute(guid).Result;

                Assert.AreEqual("1", TestUtil.ToTestableString(obj.Properties.TotalResults), true);
                Assert.AreEqual("1", TestUtil.ToTestableString(obj.Properties.TotalPages), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.Properties.PreviousUrl), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.Properties.NextUrl), true);
                Assert.AreEqual("6bda6d68-21b9-4486-89cf-da35f1f2eb2c", TestUtil.ToTestableString(obj[0].EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/apps/bdd71c69-8c2e-4a67-b443-016d5de04288", TestUtil.ToTestableString(obj[0].EntityMetadata.Url), true);
                Assert.AreEqual("2017-01-04T15:58:55Z", TestUtil.ToTestableString(obj[0].EntityMetadata.CreatedAt), true);
                Assert.AreEqual("2017-01-04T15:58:55Z", TestUtil.ToTestableString(obj[0].EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("name-1906", TestUtil.ToTestableString(obj[0].Name), true);
                Assert.AreEqual("false", TestUtil.ToTestableString(obj[0].Production), true);
                Assert.AreEqual("6bda6d68-21b9-4486-89cf-da35f1f2eb2c", TestUtil.ToTestableString(obj[0].SpaceGuid), true);
                Assert.AreEqual("6bda6d68-21b9-4486-89cf-da35f1f2eb2c", TestUtil.ToTestableString(obj[0].StackGuid), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[0].Buildpack), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[0].DetectedBuildpack), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[0].DetectedBuildpackGuid), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[0].EnvironmentJson), true);
                Assert.AreEqual("1024", TestUtil.ToTestableString(obj[0].Memory), true);
                Assert.AreEqual("1", TestUtil.ToTestableString(obj[0].Instances), true);
                Assert.AreEqual("1024", TestUtil.ToTestableString(obj[0].DiskQuota), true);
                Assert.AreEqual("STOPPED", TestUtil.ToTestableString(obj[0].State), true);
                Assert.AreEqual("4d8c76d4-439d-45f7-9ccb-c884b7153a2c", TestUtil.ToTestableString(obj[0].Version), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[0].Command), true);
                Assert.AreEqual("false", TestUtil.ToTestableString(obj[0].Console), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[0].Debug), true);
                Assert.AreEqual("2a965df8-0c0e-476d-af95-e3c94ae262f0", TestUtil.ToTestableString(obj[0].StagingTaskId), true);
                Assert.AreEqual("STAGED", TestUtil.ToTestableString(obj[0].PackageState), true);
                Assert.AreEqual("port", TestUtil.ToTestableString(obj[0].HealthCheckType), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[0].HealthCheckTimeout), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[0].HealthCheckHttpEndpoint), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[0].StagingFailedReason), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[0].StagingFailedDescription), true);
                Assert.AreEqual("false", TestUtil.ToTestableString(obj[0].Diego), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[0].DockerImage), true);
                Assert.AreEqual("2017-01-04T15:58:54Z", TestUtil.ToTestableString(obj[0].PackageUpdatedAt), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[0].DetectedStartCommand), true);
                Assert.AreEqual("true", TestUtil.ToTestableString(obj[0].EnableSsh), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[0].Ports), true);
                Assert.AreEqual("/v2/spaces/8b3c9652-7d26-40bf-92f8-222ddbda1de3", TestUtil.ToTestableString(obj[0].SpaceUrl), true);
                Assert.AreEqual("/v2/stacks/0fc9cb17-6b5c-441d-a89c-271745f3ec71", TestUtil.ToTestableString(obj[0].StackUrl), true);
                Assert.AreEqual("/v2/apps/bdd71c69-8c2e-4a67-b443-016d5de04288/routes", TestUtil.ToTestableString(obj[0].RoutesUrl), true);
                Assert.AreEqual("/v2/apps/bdd71c69-8c2e-4a67-b443-016d5de04288/events", TestUtil.ToTestableString(obj[0].EventsUrl), true);
                Assert.AreEqual("/v2/apps/bdd71c69-8c2e-4a67-b443-016d5de04288/service_bindings", TestUtil.ToTestableString(obj[0].ServiceBindingsUrl), true);
                Assert.AreEqual("/v2/apps/bdd71c69-8c2e-4a67-b443-016d5de04288/route_mappings", TestUtil.ToTestableString(obj[0].RouteMappingsUrl), true);

            }
        }

        [TestMethod]
        public void ListAllRoutesTest()
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
        ""guid"": ""96cdbe58-58e3-467e-b5ed-ea6de012f026"",
        ""url"": ""/v2/routes/ab0c543e-1e4d-4a5c-b120-13f992a8eb77"",
        ""created_at"": ""2017-01-04T15:58:56Z"",
        ""updated_at"": ""2017-01-04T15:58:56Z""
      },
      ""entity"": {
        ""host"": ""host-23"",
        ""path"": """",
        ""domain_guid"": ""96cdbe58-58e3-467e-b5ed-ea6de012f026"",
        ""space_guid"": ""96cdbe58-58e3-467e-b5ed-ea6de012f026"",
        ""service_instance_guid"": ""96cdbe58-58e3-467e-b5ed-ea6de012f026"",
        ""port"": null,
        ""domain_url"": ""/v2/shared_domains/0b94469d-8f91-4a26-9ac7-d528b30f1b37"",
        ""space_url"": ""/v2/spaces/b68f3a65-60d0-42d0-b1de-bc5083324048"",
        ""service_instance_url"": ""/v2/service_instances/349eb01c-45eb-4f33-b614-9a8d392a54ae"",
        ""apps_url"": ""/v2/routes/ab0c543e-1e4d-4a5c-b120-13f992a8eb77/apps"",
        ""route_mappings_url"": ""/v2/routes/ab0c543e-1e4d-4a5c-b120-13f992a8eb77/route_mappings""
      }
    }
  ]
}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)200;
                var cfClient = clients.CreateCloudFoundryClient();


                var obj = cfClient.Routes.ListAllRoutes().Result;

                Assert.AreEqual("1", TestUtil.ToTestableString(obj.Properties.TotalResults), true);
                Assert.AreEqual("1", TestUtil.ToTestableString(obj.Properties.TotalPages), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.Properties.PreviousUrl), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.Properties.NextUrl), true);
                Assert.AreEqual("96cdbe58-58e3-467e-b5ed-ea6de012f026", TestUtil.ToTestableString(obj[0].EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/routes/ab0c543e-1e4d-4a5c-b120-13f992a8eb77", TestUtil.ToTestableString(obj[0].EntityMetadata.Url), true);
                Assert.AreEqual("2017-01-04T15:58:56Z", TestUtil.ToTestableString(obj[0].EntityMetadata.CreatedAt), true);
                Assert.AreEqual("2017-01-04T15:58:56Z", TestUtil.ToTestableString(obj[0].EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("host-23", TestUtil.ToTestableString(obj[0].Host), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[0].Path), true);
                Assert.AreEqual("96cdbe58-58e3-467e-b5ed-ea6de012f026", TestUtil.ToTestableString(obj[0].DomainGuid), true);
                Assert.AreEqual("96cdbe58-58e3-467e-b5ed-ea6de012f026", TestUtil.ToTestableString(obj[0].SpaceGuid), true);
                Assert.AreEqual("96cdbe58-58e3-467e-b5ed-ea6de012f026", TestUtil.ToTestableString(obj[0].ServiceInstanceGuid), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[0].Port), true);
                Assert.AreEqual("/v2/shared_domains/0b94469d-8f91-4a26-9ac7-d528b30f1b37", TestUtil.ToTestableString(obj[0].DomainUrl), true);
                Assert.AreEqual("/v2/spaces/b68f3a65-60d0-42d0-b1de-bc5083324048", TestUtil.ToTestableString(obj[0].SpaceUrl), true);
                Assert.AreEqual("/v2/service_instances/349eb01c-45eb-4f33-b614-9a8d392a54ae", TestUtil.ToTestableString(obj[0].ServiceInstanceUrl), true);
                Assert.AreEqual("/v2/routes/ab0c543e-1e4d-4a5c-b120-13f992a8eb77/apps", TestUtil.ToTestableString(obj[0].AppsUrl), true);
                Assert.AreEqual("/v2/routes/ab0c543e-1e4d-4a5c-b120-13f992a8eb77/route_mappings", TestUtil.ToTestableString(obj[0].RouteMappingsUrl), true);

            }
        }

        [TestMethod]
        public void CheckHttpRouteExistsTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                clients.ExpectedStatusCode = (HttpStatusCode)204;
                var cfClient = clients.CreateCloudFoundryClient();

                Guid? domain_guid = Guid.NewGuid();

                dynamic host = null;

                dynamic path = null;


                cfClient.Routes.CheckHttpRouteExists(domain_guid, host, path).Wait();

            }
        }

        [TestMethod]
        public void DeleteRouteTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                clients.ExpectedStatusCode = (HttpStatusCode)204;
                var cfClient = clients.CreateCloudFoundryClient();

                Guid? guid = Guid.NewGuid();

                dynamic recursive = null;


                cfClient.Routes.DeleteRoute(guid, recursive).Wait();

            }
        }

        [TestMethod]
        public void RetrieveRouteTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                string json = @"{
  ""metadata"": {
    ""guid"": ""cb61061b-1941-47f3-831b-2261d30503e0"",
    ""url"": ""/v2/routes/7e3b38d6-9c8f-496b-9d9d-3c19ec036ccf"",
    ""created_at"": ""2017-01-04T15:58:56Z"",
    ""updated_at"": ""2017-01-04T15:58:56Z""
  },
  ""entity"": {
    ""host"": ""host-24"",
    ""path"": """",
    ""domain_guid"": ""cb61061b-1941-47f3-831b-2261d30503e0"",
    ""space_guid"": ""cb61061b-1941-47f3-831b-2261d30503e0"",
    ""service_instance_guid"": ""cb61061b-1941-47f3-831b-2261d30503e0"",
    ""port"": null,
    ""domain_url"": ""/v2/shared_domains/68302234-5cea-4851-be07-157ee582272d"",
    ""space_url"": ""/v2/spaces/c5dc1200-5407-4a0f-aec3-f4078a486e4d"",
    ""service_instance_url"": ""/v2/service_instances/63fb3b9d-9851-407f-8271-8c2bb5535756"",
    ""apps_url"": ""/v2/routes/7e3b38d6-9c8f-496b-9d9d-3c19ec036ccf/apps"",
    ""route_mappings_url"": ""/v2/routes/7e3b38d6-9c8f-496b-9d9d-3c19ec036ccf/route_mappings""
  }
}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)200;
                var cfClient = clients.CreateCloudFoundryClient();

                Guid? guid = Guid.NewGuid();


                var obj = cfClient.Routes.RetrieveRoute(guid).Result;


                Assert.AreEqual("cb61061b-1941-47f3-831b-2261d30503e0", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/routes/7e3b38d6-9c8f-496b-9d9d-3c19ec036ccf", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
                Assert.AreEqual("2017-01-04T15:58:56Z", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
                Assert.AreEqual("2017-01-04T15:58:56Z", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("host-24", TestUtil.ToTestableString(obj.Host), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.Path), true);
                Assert.AreEqual("cb61061b-1941-47f3-831b-2261d30503e0", TestUtil.ToTestableString(obj.DomainGuid), true);
                Assert.AreEqual("cb61061b-1941-47f3-831b-2261d30503e0", TestUtil.ToTestableString(obj.SpaceGuid), true);
                Assert.AreEqual("cb61061b-1941-47f3-831b-2261d30503e0", TestUtil.ToTestableString(obj.ServiceInstanceGuid), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.Port), true);
                Assert.AreEqual("/v2/shared_domains/68302234-5cea-4851-be07-157ee582272d", TestUtil.ToTestableString(obj.DomainUrl), true);
                Assert.AreEqual("/v2/spaces/c5dc1200-5407-4a0f-aec3-f4078a486e4d", TestUtil.ToTestableString(obj.SpaceUrl), true);
                Assert.AreEqual("/v2/service_instances/63fb3b9d-9851-407f-8271-8c2bb5535756", TestUtil.ToTestableString(obj.ServiceInstanceUrl), true);
                Assert.AreEqual("/v2/routes/7e3b38d6-9c8f-496b-9d9d-3c19ec036ccf/apps", TestUtil.ToTestableString(obj.AppsUrl), true);
                Assert.AreEqual("/v2/routes/7e3b38d6-9c8f-496b-9d9d-3c19ec036ccf/route_mappings", TestUtil.ToTestableString(obj.RouteMappingsUrl), true);

            }
        }

    }
}