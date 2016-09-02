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
    public class SpaceQuotaDefinitionsEndpoint
{
        [TestMethod]
        public void RemoveSpaceFromSpaceQuotaDefinitionTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                clients.ExpectedStatusCode = (HttpStatusCode)204;
                var cfClient = clients.CreateCloudFoundryClient();

                Guid? guid = Guid.NewGuid();

                Guid? space_guid = Guid.NewGuid();


                cfClient.SpaceQuotaDefinitions.RemoveSpaceFromSpaceQuotaDefinition(guid, space_guid).Wait();

            }
        }

        [TestMethod]
        public void DeleteSpaceQuotaDefinitionTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                clients.ExpectedStatusCode = (HttpStatusCode)204;
                var cfClient = clients.CreateCloudFoundryClient();

                Guid? guid = Guid.NewGuid();


                cfClient.SpaceQuotaDefinitions.DeleteSpaceQuotaDefinition(guid).Wait();

            }
        }

        [TestMethod]
        public void RetrieveSpaceQuotaDefinitionTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                string json = @"{
  ""metadata"": {
    ""guid"": ""cf317aea-6e60-4350-a4e1-914f9366b273"",
    ""url"": ""/v2/space_quota_definitions/fe56af6e-f43d-4b9e-892d-fc3c8fb0b65b"",
    ""created_at"": ""2016-09-02T11:52:22Z"",
    ""updated_at"": null
  },
  ""entity"": {
    ""name"": ""name-2187"",
    ""organization_guid"": ""cf317aea-6e60-4350-a4e1-914f9366b273"",
    ""non_basic_services_allowed"": true,
    ""total_services"": 60,
    ""total_routes"": 1000,
    ""memory_limit"": 20480,
    ""instance_memory_limit"": -1,
    ""app_instance_limit"": -1,
    ""app_task_limit"": 5,
    ""total_service_keys"": 600,
    ""total_reserved_route_ports"": -1,
    ""organization_url"": ""/v2/organizations/fecb7543-8ce2-472e-a51d-4405bc10eadf"",
    ""spaces_url"": ""/v2/space_quota_definitions/fe56af6e-f43d-4b9e-892d-fc3c8fb0b65b/spaces""
  }
}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)200;
                var cfClient = clients.CreateCloudFoundryClient();

                Guid? guid = Guid.NewGuid();


                var obj = cfClient.SpaceQuotaDefinitions.RetrieveSpaceQuotaDefinition(guid).Result;


                Assert.AreEqual("cf317aea-6e60-4350-a4e1-914f9366b273", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/space_quota_definitions/fe56af6e-f43d-4b9e-892d-fc3c8fb0b65b", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
                Assert.AreEqual("2016-09-02T11:52:22Z", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("name-2187", TestUtil.ToTestableString(obj.Name), true);
                Assert.AreEqual("cf317aea-6e60-4350-a4e1-914f9366b273", TestUtil.ToTestableString(obj.OrganizationGuid), true);
                Assert.AreEqual("true", TestUtil.ToTestableString(obj.NonBasicServicesAllowed), true);
                Assert.AreEqual("60", TestUtil.ToTestableString(obj.TotalServices), true);
                Assert.AreEqual("1000", TestUtil.ToTestableString(obj.TotalRoutes), true);
                Assert.AreEqual("20480", TestUtil.ToTestableString(obj.MemoryLimit), true);
                Assert.AreEqual("-1", TestUtil.ToTestableString(obj.InstanceMemoryLimit), true);
                Assert.AreEqual("-1", TestUtil.ToTestableString(obj.AppInstanceLimit), true);
                Assert.AreEqual("5", TestUtil.ToTestableString(obj.AppTaskLimit), true);
                Assert.AreEqual("600", TestUtil.ToTestableString(obj.TotalServiceKeys), true);
                Assert.AreEqual("-1", TestUtil.ToTestableString(obj.TotalReservedRoutePorts), true);
                Assert.AreEqual("/v2/organizations/fecb7543-8ce2-472e-a51d-4405bc10eadf", TestUtil.ToTestableString(obj.OrganizationUrl), true);
                Assert.AreEqual("/v2/space_quota_definitions/fe56af6e-f43d-4b9e-892d-fc3c8fb0b65b/spaces", TestUtil.ToTestableString(obj.SpacesUrl), true);

            }
        }

        [TestMethod]
        public void UpdateSpaceQuotaDefinitionTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                string json = @"{
  ""metadata"": {
    ""guid"": ""82df32f5-a611-4eb5-9229-46b7967337fd"",
    ""url"": ""/v2/space_quota_definitions/3b444ac8-20ef-4b59-8932-dcfc077bc377"",
    ""created_at"": ""2016-09-02T11:52:22Z"",
    ""updated_at"": ""2016-09-02T11:52:22Z""
  },
  ""entity"": {
    ""name"": ""new_name"",
    ""organization_guid"": ""82df32f5-a611-4eb5-9229-46b7967337fd"",
    ""non_basic_services_allowed"": true,
    ""total_services"": 60,
    ""total_routes"": 1000,
    ""memory_limit"": 20480,
    ""instance_memory_limit"": -1,
    ""app_instance_limit"": -1,
    ""app_task_limit"": 5,
    ""total_service_keys"": 600,
    ""total_reserved_route_ports"": -1,
    ""organization_url"": ""/v2/organizations/cb9023d1-dba7-4020-8941-b49d472aa41b"",
    ""spaces_url"": ""/v2/space_quota_definitions/3b444ac8-20ef-4b59-8932-dcfc077bc377/spaces""
  }
}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)201;
                var cfClient = clients.CreateCloudFoundryClient();

                Guid? guid = Guid.NewGuid();

                UpdateSpaceQuotaDefinitionRequest value = new UpdateSpaceQuotaDefinitionRequest();


                var obj = cfClient.SpaceQuotaDefinitions.UpdateSpaceQuotaDefinition(guid, value).Result;


                Assert.AreEqual("82df32f5-a611-4eb5-9229-46b7967337fd", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/space_quota_definitions/3b444ac8-20ef-4b59-8932-dcfc077bc377", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
                Assert.AreEqual("2016-09-02T11:52:22Z", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
                Assert.AreEqual("2016-09-02T11:52:22Z", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("new_name", TestUtil.ToTestableString(obj.Name), true);
                Assert.AreEqual("82df32f5-a611-4eb5-9229-46b7967337fd", TestUtil.ToTestableString(obj.OrganizationGuid), true);
                Assert.AreEqual("true", TestUtil.ToTestableString(obj.NonBasicServicesAllowed), true);
                Assert.AreEqual("60", TestUtil.ToTestableString(obj.TotalServices), true);
                Assert.AreEqual("1000", TestUtil.ToTestableString(obj.TotalRoutes), true);
                Assert.AreEqual("20480", TestUtil.ToTestableString(obj.MemoryLimit), true);
                Assert.AreEqual("-1", TestUtil.ToTestableString(obj.InstanceMemoryLimit), true);
                Assert.AreEqual("-1", TestUtil.ToTestableString(obj.AppInstanceLimit), true);
                Assert.AreEqual("5", TestUtil.ToTestableString(obj.AppTaskLimit), true);
                Assert.AreEqual("600", TestUtil.ToTestableString(obj.TotalServiceKeys), true);
                Assert.AreEqual("-1", TestUtil.ToTestableString(obj.TotalReservedRoutePorts), true);
                Assert.AreEqual("/v2/organizations/cb9023d1-dba7-4020-8941-b49d472aa41b", TestUtil.ToTestableString(obj.OrganizationUrl), true);
                Assert.AreEqual("/v2/space_quota_definitions/3b444ac8-20ef-4b59-8932-dcfc077bc377/spaces", TestUtil.ToTestableString(obj.SpacesUrl), true);

            }
        }

        [TestMethod]
        public void ListAllSpacesForSpaceQuotaDefinitionTest()
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
        ""guid"": ""31b6d4cf-2899-48d1-b853-3ea305c71c16"",
        ""url"": ""/v2/spaces/4a3b6c7e-3704-4558-bf9e-f5d3b57420b3"",
        ""created_at"": ""2016-09-02T11:52:23Z"",
        ""updated_at"": ""2016-09-02T11:52:23Z""
      },
      ""entity"": {
        ""name"": ""name-2196"",
        ""organization_guid"": ""31b6d4cf-2899-48d1-b853-3ea305c71c16"",
        ""space_quota_definition_guid"": ""31b6d4cf-2899-48d1-b853-3ea305c71c16"",
        ""allow_ssh"": true,
        ""organization_url"": ""/v2/organizations/6f2a31b5-fcf7-471f-b584-beeca1e20f93"",
        ""space_quota_definition_url"": ""/v2/space_quota_definitions/eac16072-e2b4-422a-a680-7930fbecb654"",
        ""developers_url"": ""/v2/spaces/4a3b6c7e-3704-4558-bf9e-f5d3b57420b3/developers"",
        ""managers_url"": ""/v2/spaces/4a3b6c7e-3704-4558-bf9e-f5d3b57420b3/managers"",
        ""auditors_url"": ""/v2/spaces/4a3b6c7e-3704-4558-bf9e-f5d3b57420b3/auditors"",
        ""apps_url"": ""/v2/spaces/4a3b6c7e-3704-4558-bf9e-f5d3b57420b3/apps"",
        ""routes_url"": ""/v2/spaces/4a3b6c7e-3704-4558-bf9e-f5d3b57420b3/routes"",
        ""domains_url"": ""/v2/spaces/4a3b6c7e-3704-4558-bf9e-f5d3b57420b3/domains"",
        ""service_instances_url"": ""/v2/spaces/4a3b6c7e-3704-4558-bf9e-f5d3b57420b3/service_instances"",
        ""app_events_url"": ""/v2/spaces/4a3b6c7e-3704-4558-bf9e-f5d3b57420b3/app_events"",
        ""events_url"": ""/v2/spaces/4a3b6c7e-3704-4558-bf9e-f5d3b57420b3/events"",
        ""security_groups_url"": ""/v2/spaces/4a3b6c7e-3704-4558-bf9e-f5d3b57420b3/security_groups""
      }
    }
  ]
}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)200;
                var cfClient = clients.CreateCloudFoundryClient();

                Guid? guid = Guid.NewGuid();


                var obj = cfClient.SpaceQuotaDefinitions.ListAllSpacesForSpaceQuotaDefinition(guid).Result;

                Assert.AreEqual("1", TestUtil.ToTestableString(obj.Properties.TotalResults), true);
                Assert.AreEqual("1", TestUtil.ToTestableString(obj.Properties.TotalPages), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.Properties.PreviousUrl), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.Properties.NextUrl), true);
                Assert.AreEqual("31b6d4cf-2899-48d1-b853-3ea305c71c16", TestUtil.ToTestableString(obj[0].EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/spaces/4a3b6c7e-3704-4558-bf9e-f5d3b57420b3", TestUtil.ToTestableString(obj[0].EntityMetadata.Url), true);
                Assert.AreEqual("2016-09-02T11:52:23Z", TestUtil.ToTestableString(obj[0].EntityMetadata.CreatedAt), true);
                Assert.AreEqual("2016-09-02T11:52:23Z", TestUtil.ToTestableString(obj[0].EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("name-2196", TestUtil.ToTestableString(obj[0].Name), true);
                Assert.AreEqual("31b6d4cf-2899-48d1-b853-3ea305c71c16", TestUtil.ToTestableString(obj[0].OrganizationGuid), true);
                Assert.AreEqual("31b6d4cf-2899-48d1-b853-3ea305c71c16", TestUtil.ToTestableString(obj[0].SpaceQuotaDefinitionGuid), true);
                Assert.AreEqual("true", TestUtil.ToTestableString(obj[0].AllowSsh), true);
                Assert.AreEqual("/v2/organizations/6f2a31b5-fcf7-471f-b584-beeca1e20f93", TestUtil.ToTestableString(obj[0].OrganizationUrl), true);
                Assert.AreEqual("/v2/space_quota_definitions/eac16072-e2b4-422a-a680-7930fbecb654", TestUtil.ToTestableString(obj[0].SpaceQuotaDefinitionUrl), true);
                Assert.AreEqual("/v2/spaces/4a3b6c7e-3704-4558-bf9e-f5d3b57420b3/developers", TestUtil.ToTestableString(obj[0].DevelopersUrl), true);
                Assert.AreEqual("/v2/spaces/4a3b6c7e-3704-4558-bf9e-f5d3b57420b3/managers", TestUtil.ToTestableString(obj[0].ManagersUrl), true);
                Assert.AreEqual("/v2/spaces/4a3b6c7e-3704-4558-bf9e-f5d3b57420b3/auditors", TestUtil.ToTestableString(obj[0].AuditorsUrl), true);
                Assert.AreEqual("/v2/spaces/4a3b6c7e-3704-4558-bf9e-f5d3b57420b3/apps", TestUtil.ToTestableString(obj[0].AppsUrl), true);
                Assert.AreEqual("/v2/spaces/4a3b6c7e-3704-4558-bf9e-f5d3b57420b3/routes", TestUtil.ToTestableString(obj[0].RoutesUrl), true);
                Assert.AreEqual("/v2/spaces/4a3b6c7e-3704-4558-bf9e-f5d3b57420b3/domains", TestUtil.ToTestableString(obj[0].DomainsUrl), true);
                Assert.AreEqual("/v2/spaces/4a3b6c7e-3704-4558-bf9e-f5d3b57420b3/service_instances", TestUtil.ToTestableString(obj[0].ServiceInstancesUrl), true);
                Assert.AreEqual("/v2/spaces/4a3b6c7e-3704-4558-bf9e-f5d3b57420b3/app_events", TestUtil.ToTestableString(obj[0].AppEventsUrl), true);
                Assert.AreEqual("/v2/spaces/4a3b6c7e-3704-4558-bf9e-f5d3b57420b3/events", TestUtil.ToTestableString(obj[0].EventsUrl), true);
                Assert.AreEqual("/v2/spaces/4a3b6c7e-3704-4558-bf9e-f5d3b57420b3/security_groups", TestUtil.ToTestableString(obj[0].SecurityGroupsUrl), true);

            }
        }

        [TestMethod]
        public void AssociateSpaceWithSpaceQuotaDefinitionTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                string json = @"{
  ""metadata"": {
    ""guid"": ""3565344b-f2eb-4a58-a01f-6a318c81e37f"",
    ""url"": ""/v2/space_quota_definitions/9030b883-d604-4a21-be57-2e076d59041a"",
    ""created_at"": ""2016-09-02T11:52:23Z"",
    ""updated_at"": null
  },
  ""entity"": {
    ""name"": ""name-2203"",
    ""organization_guid"": ""3565344b-f2eb-4a58-a01f-6a318c81e37f"",
    ""non_basic_services_allowed"": true,
    ""total_services"": 60,
    ""total_routes"": 1000,
    ""memory_limit"": 20480,
    ""instance_memory_limit"": -1,
    ""app_instance_limit"": -1,
    ""app_task_limit"": 5,
    ""total_service_keys"": 600,
    ""total_reserved_route_ports"": -1,
    ""organization_url"": ""/v2/organizations/ea4cc3c9-7ac8-473d-a1ce-6517494da908"",
    ""spaces_url"": ""/v2/space_quota_definitions/9030b883-d604-4a21-be57-2e076d59041a/spaces""
  }
}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)201;
                var cfClient = clients.CreateCloudFoundryClient();

                Guid? guid = Guid.NewGuid();

                Guid? space_guid = Guid.NewGuid();


                var obj = cfClient.SpaceQuotaDefinitions.AssociateSpaceWithSpaceQuotaDefinition(guid, space_guid).Result;


                Assert.AreEqual("3565344b-f2eb-4a58-a01f-6a318c81e37f", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/space_quota_definitions/9030b883-d604-4a21-be57-2e076d59041a", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
                Assert.AreEqual("2016-09-02T11:52:23Z", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("name-2203", TestUtil.ToTestableString(obj.Name), true);
                Assert.AreEqual("3565344b-f2eb-4a58-a01f-6a318c81e37f", TestUtil.ToTestableString(obj.OrganizationGuid), true);
                Assert.AreEqual("true", TestUtil.ToTestableString(obj.NonBasicServicesAllowed), true);
                Assert.AreEqual("60", TestUtil.ToTestableString(obj.TotalServices), true);
                Assert.AreEqual("1000", TestUtil.ToTestableString(obj.TotalRoutes), true);
                Assert.AreEqual("20480", TestUtil.ToTestableString(obj.MemoryLimit), true);
                Assert.AreEqual("-1", TestUtil.ToTestableString(obj.InstanceMemoryLimit), true);
                Assert.AreEqual("-1", TestUtil.ToTestableString(obj.AppInstanceLimit), true);
                Assert.AreEqual("5", TestUtil.ToTestableString(obj.AppTaskLimit), true);
                Assert.AreEqual("600", TestUtil.ToTestableString(obj.TotalServiceKeys), true);
                Assert.AreEqual("-1", TestUtil.ToTestableString(obj.TotalReservedRoutePorts), true);
                Assert.AreEqual("/v2/organizations/ea4cc3c9-7ac8-473d-a1ce-6517494da908", TestUtil.ToTestableString(obj.OrganizationUrl), true);
                Assert.AreEqual("/v2/space_quota_definitions/9030b883-d604-4a21-be57-2e076d59041a/spaces", TestUtil.ToTestableString(obj.SpacesUrl), true);

            }
        }

        [TestMethod]
        public void CreateSpaceQuotaDefinitionTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                string json = @"{
  ""metadata"": {
    ""guid"": ""ef7438e3-cd27-47af-b813-34751c5163bb"",
    ""url"": ""/v2/space_quota_definitions/0dfc0813-e7ce-46cb-a64e-1789f6bb4815"",
    ""created_at"": ""2016-09-02T11:52:22Z"",
    ""updated_at"": null
  },
  ""entity"": {
    ""name"": ""gold_quota"",
    ""organization_guid"": ""ef7438e3-cd27-47af-b813-34751c5163bb"",
    ""non_basic_services_allowed"": true,
    ""total_services"": -1,
    ""total_routes"": 10,
    ""memory_limit"": 5120,
    ""instance_memory_limit"": -1,
    ""app_instance_limit"": -1,
    ""app_task_limit"": 5,
    ""total_service_keys"": -1,
    ""total_reserved_route_ports"": 5,
    ""organization_url"": ""/v2/organizations/5a0d8e5e-699c-4489-bf5f-8d58ac846605"",
    ""spaces_url"": ""/v2/space_quota_definitions/0dfc0813-e7ce-46cb-a64e-1789f6bb4815/spaces""
  }
}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)201;
                var cfClient = clients.CreateCloudFoundryClient();

                CreateSpaceQuotaDefinitionRequest value = new CreateSpaceQuotaDefinitionRequest();


                var obj = cfClient.SpaceQuotaDefinitions.CreateSpaceQuotaDefinition(value).Result;


                Assert.AreEqual("ef7438e3-cd27-47af-b813-34751c5163bb", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/space_quota_definitions/0dfc0813-e7ce-46cb-a64e-1789f6bb4815", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
                Assert.AreEqual("2016-09-02T11:52:22Z", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("gold_quota", TestUtil.ToTestableString(obj.Name), true);
                Assert.AreEqual("ef7438e3-cd27-47af-b813-34751c5163bb", TestUtil.ToTestableString(obj.OrganizationGuid), true);
                Assert.AreEqual("true", TestUtil.ToTestableString(obj.NonBasicServicesAllowed), true);
                Assert.AreEqual("-1", TestUtil.ToTestableString(obj.TotalServices), true);
                Assert.AreEqual("10", TestUtil.ToTestableString(obj.TotalRoutes), true);
                Assert.AreEqual("5120", TestUtil.ToTestableString(obj.MemoryLimit), true);
                Assert.AreEqual("-1", TestUtil.ToTestableString(obj.InstanceMemoryLimit), true);
                Assert.AreEqual("-1", TestUtil.ToTestableString(obj.AppInstanceLimit), true);
                Assert.AreEqual("5", TestUtil.ToTestableString(obj.AppTaskLimit), true);
                Assert.AreEqual("-1", TestUtil.ToTestableString(obj.TotalServiceKeys), true);
                Assert.AreEqual("5", TestUtil.ToTestableString(obj.TotalReservedRoutePorts), true);
                Assert.AreEqual("/v2/organizations/5a0d8e5e-699c-4489-bf5f-8d58ac846605", TestUtil.ToTestableString(obj.OrganizationUrl), true);
                Assert.AreEqual("/v2/space_quota_definitions/0dfc0813-e7ce-46cb-a64e-1789f6bb4815/spaces", TestUtil.ToTestableString(obj.SpacesUrl), true);

            }
        }

        [TestMethod]
        public void ListAllSpaceQuotaDefinitionsTest()
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
        ""guid"": ""b20fa900-92d7-4f69-9ee8-46137fc5cab8"",
        ""url"": ""/v2/space_quota_definitions/f6380d39-d4b0-4442-b955-3c400f8b15e1"",
        ""created_at"": ""2016-09-02T11:52:22Z"",
        ""updated_at"": null
      },
      ""entity"": {
        ""name"": ""name-2181"",
        ""organization_guid"": ""b20fa900-92d7-4f69-9ee8-46137fc5cab8"",
        ""non_basic_services_allowed"": true,
        ""total_services"": 60,
        ""total_routes"": 1000,
        ""memory_limit"": 20480,
        ""instance_memory_limit"": -1,
        ""app_instance_limit"": -1,
        ""app_task_limit"": 5,
        ""total_service_keys"": 600,
        ""total_reserved_route_ports"": -1,
        ""organization_url"": ""/v2/organizations/95242594-c8bb-4d4e-aa35-7a7d79363043"",
        ""spaces_url"": ""/v2/space_quota_definitions/f6380d39-d4b0-4442-b955-3c400f8b15e1/spaces""
      }
    }
  ]
}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)200;
                var cfClient = clients.CreateCloudFoundryClient();


                var obj = cfClient.SpaceQuotaDefinitions.ListAllSpaceQuotaDefinitions().Result;

                Assert.AreEqual("1", TestUtil.ToTestableString(obj.Properties.TotalResults), true);
                Assert.AreEqual("1", TestUtil.ToTestableString(obj.Properties.TotalPages), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.Properties.PreviousUrl), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.Properties.NextUrl), true);
                Assert.AreEqual("b20fa900-92d7-4f69-9ee8-46137fc5cab8", TestUtil.ToTestableString(obj[0].EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/space_quota_definitions/f6380d39-d4b0-4442-b955-3c400f8b15e1", TestUtil.ToTestableString(obj[0].EntityMetadata.Url), true);
                Assert.AreEqual("2016-09-02T11:52:22Z", TestUtil.ToTestableString(obj[0].EntityMetadata.CreatedAt), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[0].EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("name-2181", TestUtil.ToTestableString(obj[0].Name), true);
                Assert.AreEqual("b20fa900-92d7-4f69-9ee8-46137fc5cab8", TestUtil.ToTestableString(obj[0].OrganizationGuid), true);
                Assert.AreEqual("true", TestUtil.ToTestableString(obj[0].NonBasicServicesAllowed), true);
                Assert.AreEqual("60", TestUtil.ToTestableString(obj[0].TotalServices), true);
                Assert.AreEqual("1000", TestUtil.ToTestableString(obj[0].TotalRoutes), true);
                Assert.AreEqual("20480", TestUtil.ToTestableString(obj[0].MemoryLimit), true);
                Assert.AreEqual("-1", TestUtil.ToTestableString(obj[0].InstanceMemoryLimit), true);
                Assert.AreEqual("-1", TestUtil.ToTestableString(obj[0].AppInstanceLimit), true);
                Assert.AreEqual("5", TestUtil.ToTestableString(obj[0].AppTaskLimit), true);
                Assert.AreEqual("600", TestUtil.ToTestableString(obj[0].TotalServiceKeys), true);
                Assert.AreEqual("-1", TestUtil.ToTestableString(obj[0].TotalReservedRoutePorts), true);
                Assert.AreEqual("/v2/organizations/95242594-c8bb-4d4e-aa35-7a7d79363043", TestUtil.ToTestableString(obj[0].OrganizationUrl), true);
                Assert.AreEqual("/v2/space_quota_definitions/f6380d39-d4b0-4442-b955-3c400f8b15e1/spaces", TestUtil.ToTestableString(obj[0].SpacesUrl), true);

            }
        }

    }
}