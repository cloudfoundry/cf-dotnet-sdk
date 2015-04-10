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
        public void CreateRouteTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                string json = @"{
  ""metadata"": {
    ""guid"": ""23516622-a0c1-4c72-ae72-9f79dcfbf53e"",
    ""url"": ""/v2/routes/23516622-a0c1-4c72-ae72-9f79dcfbf53e"",
    ""created_at"": ""2015-04-10T20:04:41+00:00"",
    ""updated_at"": null
  },
  ""entity"": {
    ""host"": """",
    ""domain_guid"": ""25bdf764-1b3c-4c8e-91c0-71650edd5e01"",
    ""space_guid"": ""ff6560d1-4cbb-408e-8461-c551628f58f0"",
    ""domain_url"": ""/v2/domains/25bdf764-1b3c-4c8e-91c0-71650edd5e01"",
    ""space_url"": ""/v2/spaces/ff6560d1-4cbb-408e-8461-c551628f58f0"",
    ""apps_url"": ""/v2/routes/23516622-a0c1-4c72-ae72-9f79dcfbf53e/apps""
  }
}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)201;
                var cfClient = clients.CreateCloudFoundryClient();

                CreateRouteRequest value = new CreateRouteRequest();


                var obj = cfClient.Routes.CreateRoute(value).Result;


                Assert.AreEqual("23516622-a0c1-4c72-ae72-9f79dcfbf53e", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/routes/23516622-a0c1-4c72-ae72-9f79dcfbf53e", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
                Assert.AreEqual("2015-04-10T20:04:41+00:00", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.Host), true);
                Assert.AreEqual("25bdf764-1b3c-4c8e-91c0-71650edd5e01", TestUtil.ToTestableString(obj.DomainGuid), true);
                Assert.AreEqual("ff6560d1-4cbb-408e-8461-c551628f58f0", TestUtil.ToTestableString(obj.SpaceGuid), true);
                Assert.AreEqual("/v2/domains/25bdf764-1b3c-4c8e-91c0-71650edd5e01", TestUtil.ToTestableString(obj.DomainUrl), true);
                Assert.AreEqual("/v2/spaces/ff6560d1-4cbb-408e-8461-c551628f58f0", TestUtil.ToTestableString(obj.SpaceUrl), true);
                Assert.AreEqual("/v2/routes/23516622-a0c1-4c72-ae72-9f79dcfbf53e/apps", TestUtil.ToTestableString(obj.AppsUrl), true);

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
        ""guid"": ""a7c2dc03-1a7d-4517-bd2a-d7928bff9e92"",
        ""url"": ""/v2/routes/a7c2dc03-1a7d-4517-bd2a-d7928bff9e92"",
        ""created_at"": ""2015-04-10T20:04:41+00:00"",
        ""updated_at"": null
      },
      ""entity"": {
        ""host"": ""host-9"",
        ""domain_guid"": ""714f1258-ac51-4a8d-ba7f-3b1e608752aa"",
        ""space_guid"": ""92fff293-ab5d-4b6f-bf82-803eb73b9cd0"",
        ""domain_url"": ""/v2/domains/714f1258-ac51-4a8d-ba7f-3b1e608752aa"",
        ""space_url"": ""/v2/spaces/92fff293-ab5d-4b6f-bf82-803eb73b9cd0"",
        ""apps_url"": ""/v2/routes/a7c2dc03-1a7d-4517-bd2a-d7928bff9e92/apps""
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
                Assert.AreEqual("a7c2dc03-1a7d-4517-bd2a-d7928bff9e92", TestUtil.ToTestableString(obj[0].EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/routes/a7c2dc03-1a7d-4517-bd2a-d7928bff9e92", TestUtil.ToTestableString(obj[0].EntityMetadata.Url), true);
                Assert.AreEqual("2015-04-10T20:04:41+00:00", TestUtil.ToTestableString(obj[0].EntityMetadata.CreatedAt), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[0].EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("host-9", TestUtil.ToTestableString(obj[0].Host), true);
                Assert.AreEqual("714f1258-ac51-4a8d-ba7f-3b1e608752aa", TestUtil.ToTestableString(obj[0].DomainGuid), true);
                Assert.AreEqual("92fff293-ab5d-4b6f-bf82-803eb73b9cd0", TestUtil.ToTestableString(obj[0].SpaceGuid), true);
                Assert.AreEqual("/v2/domains/714f1258-ac51-4a8d-ba7f-3b1e608752aa", TestUtil.ToTestableString(obj[0].DomainUrl), true);
                Assert.AreEqual("/v2/spaces/92fff293-ab5d-4b6f-bf82-803eb73b9cd0", TestUtil.ToTestableString(obj[0].SpaceUrl), true);
                Assert.AreEqual("/v2/routes/a7c2dc03-1a7d-4517-bd2a-d7928bff9e92/apps", TestUtil.ToTestableString(obj[0].AppsUrl), true);

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
    ""guid"": ""ddaea2c6-cfd4-4e84-b1ad-a4c0810ac9b7"",
    ""url"": ""/v2/routes/ddaea2c6-cfd4-4e84-b1ad-a4c0810ac9b7"",
    ""created_at"": ""2015-04-10T20:04:42+00:00"",
    ""updated_at"": null
  },
  ""entity"": {
    ""host"": ""host-15"",
    ""domain_guid"": ""745ecd0c-6ba3-4ceb-a861-5072b34f9201"",
    ""space_guid"": ""c5e4ff76-27e1-430d-b5d6-ed1bfd47cd7a"",
    ""domain_url"": ""/v2/domains/745ecd0c-6ba3-4ceb-a861-5072b34f9201"",
    ""space_url"": ""/v2/spaces/c5e4ff76-27e1-430d-b5d6-ed1bfd47cd7a"",
    ""apps_url"": ""/v2/routes/ddaea2c6-cfd4-4e84-b1ad-a4c0810ac9b7/apps""
  }
}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)201;
                var cfClient = clients.CreateCloudFoundryClient();

                Guid? guid = Guid.NewGuid();

                Guid? app_guid = Guid.NewGuid();


                var obj = cfClient.Routes.AssociateAppWithRoute(guid, app_guid).Result;


                Assert.AreEqual("ddaea2c6-cfd4-4e84-b1ad-a4c0810ac9b7", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/routes/ddaea2c6-cfd4-4e84-b1ad-a4c0810ac9b7", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
                Assert.AreEqual("2015-04-10T20:04:42+00:00", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("host-15", TestUtil.ToTestableString(obj.Host), true);
                Assert.AreEqual("745ecd0c-6ba3-4ceb-a861-5072b34f9201", TestUtil.ToTestableString(obj.DomainGuid), true);
                Assert.AreEqual("c5e4ff76-27e1-430d-b5d6-ed1bfd47cd7a", TestUtil.ToTestableString(obj.SpaceGuid), true);
                Assert.AreEqual("/v2/domains/745ecd0c-6ba3-4ceb-a861-5072b34f9201", TestUtil.ToTestableString(obj.DomainUrl), true);
                Assert.AreEqual("/v2/spaces/c5e4ff76-27e1-430d-b5d6-ed1bfd47cd7a", TestUtil.ToTestableString(obj.SpaceUrl), true);
                Assert.AreEqual("/v2/routes/ddaea2c6-cfd4-4e84-b1ad-a4c0810ac9b7/apps", TestUtil.ToTestableString(obj.AppsUrl), true);

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
        ""guid"": ""3e9f464d-e308-465c-a33c-e7ba43b2d924"",
        ""url"": ""/v2/apps/3e9f464d-e308-465c-a33c-e7ba43b2d924"",
        ""created_at"": ""2015-04-10T20:04:41+00:00"",
        ""updated_at"": ""2015-04-10T20:04:41+00:00""
      },
      ""entity"": {
        ""name"": ""name-1741"",
        ""production"": false,
        ""space_guid"": ""34f7ad16-788b-4d19-b1f5-1496b73ae942"",
        ""stack_guid"": ""f74a3fbc-9ea4-4e47-a852-75e86bb10d8d"",
        ""buildpack"": null,
        ""detected_buildpack"": null,
        ""environment_json"": null,
        ""memory"": 1024,
        ""instances"": 1,
        ""disk_quota"": 1024,
        ""state"": ""STOPPED"",
        ""version"": ""dfdda49b-027d-4fe3-936e-36a00f5530b6"",
        ""command"": null,
        ""console"": false,
        ""debug"": null,
        ""staging_task_id"": null,
        ""package_state"": ""PENDING"",
        ""health_check_type"": ""port"",
        ""health_check_timeout"": null,
        ""staging_failed_reason"": null,
        ""docker_image"": null,
        ""package_updated_at"": ""2015-04-10T20:04:41+00:00"",
        ""detected_start_command"": """",
        ""space_url"": ""/v2/spaces/34f7ad16-788b-4d19-b1f5-1496b73ae942"",
        ""stack_url"": ""/v2/stacks/f74a3fbc-9ea4-4e47-a852-75e86bb10d8d"",
        ""events_url"": ""/v2/apps/3e9f464d-e308-465c-a33c-e7ba43b2d924/events"",
        ""service_bindings_url"": ""/v2/apps/3e9f464d-e308-465c-a33c-e7ba43b2d924/service_bindings"",
        ""routes_url"": ""/v2/apps/3e9f464d-e308-465c-a33c-e7ba43b2d924/routes""
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
                Assert.AreEqual("3e9f464d-e308-465c-a33c-e7ba43b2d924", TestUtil.ToTestableString(obj[0].EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/apps/3e9f464d-e308-465c-a33c-e7ba43b2d924", TestUtil.ToTestableString(obj[0].EntityMetadata.Url), true);
                Assert.AreEqual("2015-04-10T20:04:41+00:00", TestUtil.ToTestableString(obj[0].EntityMetadata.CreatedAt), true);
                Assert.AreEqual("2015-04-10T20:04:41+00:00", TestUtil.ToTestableString(obj[0].EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("name-1741", TestUtil.ToTestableString(obj[0].Name), true);
                Assert.AreEqual("false", TestUtil.ToTestableString(obj[0].Production), true);
                Assert.AreEqual("34f7ad16-788b-4d19-b1f5-1496b73ae942", TestUtil.ToTestableString(obj[0].SpaceGuid), true);
                Assert.AreEqual("f74a3fbc-9ea4-4e47-a852-75e86bb10d8d", TestUtil.ToTestableString(obj[0].StackGuid), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[0].Buildpack), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[0].DetectedBuildpack), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[0].EnvironmentJson), true);
                Assert.AreEqual("1024", TestUtil.ToTestableString(obj[0].Memory), true);
                Assert.AreEqual("1", TestUtil.ToTestableString(obj[0].Instances), true);
                Assert.AreEqual("1024", TestUtil.ToTestableString(obj[0].DiskQuota), true);
                Assert.AreEqual("STOPPED", TestUtil.ToTestableString(obj[0].State), true);
                Assert.AreEqual("dfdda49b-027d-4fe3-936e-36a00f5530b6", TestUtil.ToTestableString(obj[0].Version), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[0].Command), true);
                Assert.AreEqual("false", TestUtil.ToTestableString(obj[0].Console), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[0].Debug), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[0].StagingTaskId), true);
                Assert.AreEqual("PENDING", TestUtil.ToTestableString(obj[0].PackageState), true);
                Assert.AreEqual("port", TestUtil.ToTestableString(obj[0].HealthCheckType), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[0].HealthCheckTimeout), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[0].StagingFailedReason), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[0].DockerImage), true);
                Assert.AreEqual("2015-04-10T20:04:41+00:00", TestUtil.ToTestableString(obj[0].PackageUpdatedAt), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[0].DetectedStartCommand), true);
                Assert.AreEqual("/v2/spaces/34f7ad16-788b-4d19-b1f5-1496b73ae942", TestUtil.ToTestableString(obj[0].SpaceUrl), true);
                Assert.AreEqual("/v2/stacks/f74a3fbc-9ea4-4e47-a852-75e86bb10d8d", TestUtil.ToTestableString(obj[0].StackUrl), true);
                Assert.AreEqual("/v2/apps/3e9f464d-e308-465c-a33c-e7ba43b2d924/events", TestUtil.ToTestableString(obj[0].EventsUrl), true);
                Assert.AreEqual("/v2/apps/3e9f464d-e308-465c-a33c-e7ba43b2d924/service_bindings", TestUtil.ToTestableString(obj[0].ServiceBindingsUrl), true);
                Assert.AreEqual("/v2/apps/3e9f464d-e308-465c-a33c-e7ba43b2d924/routes", TestUtil.ToTestableString(obj[0].RoutesUrl), true);

            }
        }

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


                cfClient.Routes.CheckRouteExists(domain_guid, host).Wait();

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


                cfClient.Routes.DeleteRoute(guid).Wait();

            }
        }

        [TestMethod]
        public void RemoveAppFromRouteTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                string json = @"{
  ""metadata"": {
    ""guid"": ""92ed1858-e023-4715-9afa-a41cec7d2c2d"",
    ""url"": ""/v2/routes/92ed1858-e023-4715-9afa-a41cec7d2c2d"",
    ""created_at"": ""2015-04-10T20:04:42+00:00"",
    ""updated_at"": null
  },
  ""entity"": {
    ""host"": ""host-16"",
    ""domain_guid"": ""2456da0b-9b56-43f1-a9f9-6f23d35beab1"",
    ""space_guid"": ""6bf42871-3d2e-434a-b842-730e11eb2ff4"",
    ""domain_url"": ""/v2/domains/2456da0b-9b56-43f1-a9f9-6f23d35beab1"",
    ""space_url"": ""/v2/spaces/6bf42871-3d2e-434a-b842-730e11eb2ff4"",
    ""apps_url"": ""/v2/routes/92ed1858-e023-4715-9afa-a41cec7d2c2d/apps""
  }
}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)201;
                var cfClient = clients.CreateCloudFoundryClient();

                Guid? guid = Guid.NewGuid();

                Guid? app_guid = Guid.NewGuid();


                var obj = cfClient.Routes.RemoveAppFromRoute(guid, app_guid).Result;


                Assert.AreEqual("92ed1858-e023-4715-9afa-a41cec7d2c2d", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/routes/92ed1858-e023-4715-9afa-a41cec7d2c2d", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
                Assert.AreEqual("2015-04-10T20:04:42+00:00", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("host-16", TestUtil.ToTestableString(obj.Host), true);
                Assert.AreEqual("2456da0b-9b56-43f1-a9f9-6f23d35beab1", TestUtil.ToTestableString(obj.DomainGuid), true);
                Assert.AreEqual("6bf42871-3d2e-434a-b842-730e11eb2ff4", TestUtil.ToTestableString(obj.SpaceGuid), true);
                Assert.AreEqual("/v2/domains/2456da0b-9b56-43f1-a9f9-6f23d35beab1", TestUtil.ToTestableString(obj.DomainUrl), true);
                Assert.AreEqual("/v2/spaces/6bf42871-3d2e-434a-b842-730e11eb2ff4", TestUtil.ToTestableString(obj.SpaceUrl), true);
                Assert.AreEqual("/v2/routes/92ed1858-e023-4715-9afa-a41cec7d2c2d/apps", TestUtil.ToTestableString(obj.AppsUrl), true);

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
    ""guid"": ""d2d6f154-17fa-49b2-a71d-f229547d968d"",
    ""url"": ""/v2/routes/d2d6f154-17fa-49b2-a71d-f229547d968d"",
    ""created_at"": ""2015-04-10T20:04:41+00:00"",
    ""updated_at"": null
  },
  ""entity"": {
    ""host"": ""host-10"",
    ""domain_guid"": ""0b6ece33-92e5-49a3-9faf-3e4b2af8e2f5"",
    ""space_guid"": ""6b0b6d7f-67fa-4d54-849e-b5058b3f368d"",
    ""domain_url"": ""/v2/domains/0b6ece33-92e5-49a3-9faf-3e4b2af8e2f5"",
    ""space_url"": ""/v2/spaces/6b0b6d7f-67fa-4d54-849e-b5058b3f368d"",
    ""apps_url"": ""/v2/routes/d2d6f154-17fa-49b2-a71d-f229547d968d/apps""
  }
}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)200;
                var cfClient = clients.CreateCloudFoundryClient();

                Guid? guid = Guid.NewGuid();


                var obj = cfClient.Routes.RetrieveRoute(guid).Result;


                Assert.AreEqual("d2d6f154-17fa-49b2-a71d-f229547d968d", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/routes/d2d6f154-17fa-49b2-a71d-f229547d968d", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
                Assert.AreEqual("2015-04-10T20:04:41+00:00", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("host-10", TestUtil.ToTestableString(obj.Host), true);
                Assert.AreEqual("0b6ece33-92e5-49a3-9faf-3e4b2af8e2f5", TestUtil.ToTestableString(obj.DomainGuid), true);
                Assert.AreEqual("6b0b6d7f-67fa-4d54-849e-b5058b3f368d", TestUtil.ToTestableString(obj.SpaceGuid), true);
                Assert.AreEqual("/v2/domains/0b6ece33-92e5-49a3-9faf-3e4b2af8e2f5", TestUtil.ToTestableString(obj.DomainUrl), true);
                Assert.AreEqual("/v2/spaces/6b0b6d7f-67fa-4d54-849e-b5058b3f368d", TestUtil.ToTestableString(obj.SpaceUrl), true);
                Assert.AreEqual("/v2/routes/d2d6f154-17fa-49b2-a71d-f229547d968d/apps", TestUtil.ToTestableString(obj.AppsUrl), true);

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
    ""guid"": ""acdc01b7-d50e-47af-abd8-d8e2d6e87cef"",
    ""url"": ""/v2/routes/acdc01b7-d50e-47af-abd8-d8e2d6e87cef"",
    ""created_at"": ""2015-04-10T20:04:41+00:00"",
    ""updated_at"": ""2015-04-10T20:04:41+00:00""
  },
  ""entity"": {
    ""host"": ""new_host"",
    ""domain_guid"": ""b1fd6144-035c-41aa-94ca-d085311b7084"",
    ""space_guid"": ""5994f3c1-e634-4f6a-959c-c8cd1d30095b"",
    ""domain_url"": ""/v2/domains/b1fd6144-035c-41aa-94ca-d085311b7084"",
    ""space_url"": ""/v2/spaces/5994f3c1-e634-4f6a-959c-c8cd1d30095b"",
    ""apps_url"": ""/v2/routes/acdc01b7-d50e-47af-abd8-d8e2d6e87cef/apps""
  }
}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)201;
                var cfClient = clients.CreateCloudFoundryClient();

                Guid? guid = Guid.NewGuid();

                UpdateRouteRequest value = new UpdateRouteRequest();


                var obj = cfClient.Routes.UpdateRoute(guid, value).Result;


                Assert.AreEqual("acdc01b7-d50e-47af-abd8-d8e2d6e87cef", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/routes/acdc01b7-d50e-47af-abd8-d8e2d6e87cef", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
                Assert.AreEqual("2015-04-10T20:04:41+00:00", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
                Assert.AreEqual("2015-04-10T20:04:41+00:00", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("new_host", TestUtil.ToTestableString(obj.Host), true);
                Assert.AreEqual("b1fd6144-035c-41aa-94ca-d085311b7084", TestUtil.ToTestableString(obj.DomainGuid), true);
                Assert.AreEqual("5994f3c1-e634-4f6a-959c-c8cd1d30095b", TestUtil.ToTestableString(obj.SpaceGuid), true);
                Assert.AreEqual("/v2/domains/b1fd6144-035c-41aa-94ca-d085311b7084", TestUtil.ToTestableString(obj.DomainUrl), true);
                Assert.AreEqual("/v2/spaces/5994f3c1-e634-4f6a-959c-c8cd1d30095b", TestUtil.ToTestableString(obj.SpaceUrl), true);
                Assert.AreEqual("/v2/routes/acdc01b7-d50e-47af-abd8-d8e2d6e87cef/apps", TestUtil.ToTestableString(obj.AppsUrl), true);

            }
        }

    }
}