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
    public class UserProvidedServiceInstancesEndpoint
{
        [TestMethod]
        public void RetrieveUserProvidedServiceInstanceTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                string json = @"{
  ""metadata"": {
    ""guid"": ""7572c274-6126-441c-ab42-347686a7d4bf"",
    ""url"": ""/v2/user_provided_service_instances/5bca2497-3fda-4a01-ae2c-abb8a6675795"",
    ""created_at"": ""2016-07-27T14:02:39Z"",
    ""updated_at"": null
  },
  ""entity"": {
    ""name"": ""name-643"",
    ""credentials"": {
      ""creds-key-39"": ""creds-val-39""
    },
    ""space_guid"": ""7572c274-6126-441c-ab42-347686a7d4bf"",
    ""type"": ""user_provided_service_instance"",
    ""syslog_drain_url"": ""https://foo.com/url-58"",
    ""route_service_url"": null,
    ""space_url"": ""/v2/spaces/486ece15-ceb4-428b-89f4-ebfe204ce835"",
    ""service_bindings_url"": ""/v2/user_provided_service_instances/5bca2497-3fda-4a01-ae2c-abb8a6675795/service_bindings"",
    ""routes_url"": ""/v2/user_provided_service_instances/5bca2497-3fda-4a01-ae2c-abb8a6675795/routes""
  }
}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)200;
                var cfClient = clients.CreateCloudFoundryClient();

                Guid? guid = Guid.NewGuid();


                var obj = cfClient.UserProvidedServiceInstances.RetrieveUserProvidedServiceInstance(guid).Result;


                Assert.AreEqual("7572c274-6126-441c-ab42-347686a7d4bf", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/user_provided_service_instances/5bca2497-3fda-4a01-ae2c-abb8a6675795", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
                Assert.AreEqual("2016-07-27T14:02:39Z", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("name-643", TestUtil.ToTestableString(obj.Name), true);
                Assert.AreEqual("7572c274-6126-441c-ab42-347686a7d4bf", TestUtil.ToTestableString(obj.SpaceGuid), true);
                Assert.AreEqual("user_provided_service_instance", TestUtil.ToTestableString(obj.Type), true);
                Assert.AreEqual("https://foo.com/url-58", TestUtil.ToTestableString(obj.SyslogDrainUrl), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.RouteServiceUrl), true);
                Assert.AreEqual("/v2/spaces/486ece15-ceb4-428b-89f4-ebfe204ce835", TestUtil.ToTestableString(obj.SpaceUrl), true);
                Assert.AreEqual("/v2/user_provided_service_instances/5bca2497-3fda-4a01-ae2c-abb8a6675795/service_bindings", TestUtil.ToTestableString(obj.ServiceBindingsUrl), true);
                Assert.AreEqual("/v2/user_provided_service_instances/5bca2497-3fda-4a01-ae2c-abb8a6675795/routes", TestUtil.ToTestableString(obj.RoutesUrl), true);

            }
        }

        [TestMethod]
        public void UpdateUserProvidedServiceInstanceTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                string json = @"{
  ""metadata"": {
    ""guid"": ""07bce33a-ed28-429e-b42c-36d46782a2eb"",
    ""url"": ""/v2/user_provided_service_instances/4f3ac831-fb49-49e6-a278-f4c457770c02"",
    ""created_at"": ""2016-07-27T14:02:39Z"",
    ""updated_at"": ""2016-07-27T14:02:39Z""
  },
  ""entity"": {
    ""name"": ""name-658"",
    ""credentials"": {
      ""somekey"": ""somenewvalue""
    },
    ""space_guid"": ""07bce33a-ed28-429e-b42c-36d46782a2eb"",
    ""type"": ""user_provided_service_instance"",
    ""syslog_drain_url"": ""https://foo.com/url-61"",
    ""route_service_url"": null,
    ""space_url"": ""/v2/spaces/b6b897ca-d7ec-48bd-9c95-89f4b744ca4e"",
    ""service_bindings_url"": ""/v2/user_provided_service_instances/4f3ac831-fb49-49e6-a278-f4c457770c02/service_bindings"",
    ""routes_url"": ""/v2/user_provided_service_instances/4f3ac831-fb49-49e6-a278-f4c457770c02/routes""
  }
}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)201;
                var cfClient = clients.CreateCloudFoundryClient();

                Guid? guid = Guid.NewGuid();

                UpdateUserProvidedServiceInstanceRequest value = new UpdateUserProvidedServiceInstanceRequest();


                var obj = cfClient.UserProvidedServiceInstances.UpdateUserProvidedServiceInstance(guid, value).Result;


                Assert.AreEqual("07bce33a-ed28-429e-b42c-36d46782a2eb", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/user_provided_service_instances/4f3ac831-fb49-49e6-a278-f4c457770c02", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
                Assert.AreEqual("2016-07-27T14:02:39Z", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
                Assert.AreEqual("2016-07-27T14:02:39Z", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("name-658", TestUtil.ToTestableString(obj.Name), true);
                Assert.AreEqual("07bce33a-ed28-429e-b42c-36d46782a2eb", TestUtil.ToTestableString(obj.SpaceGuid), true);
                Assert.AreEqual("user_provided_service_instance", TestUtil.ToTestableString(obj.Type), true);
                Assert.AreEqual("https://foo.com/url-61", TestUtil.ToTestableString(obj.SyslogDrainUrl), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.RouteServiceUrl), true);
                Assert.AreEqual("/v2/spaces/b6b897ca-d7ec-48bd-9c95-89f4b744ca4e", TestUtil.ToTestableString(obj.SpaceUrl), true);
                Assert.AreEqual("/v2/user_provided_service_instances/4f3ac831-fb49-49e6-a278-f4c457770c02/service_bindings", TestUtil.ToTestableString(obj.ServiceBindingsUrl), true);
                Assert.AreEqual("/v2/user_provided_service_instances/4f3ac831-fb49-49e6-a278-f4c457770c02/routes", TestUtil.ToTestableString(obj.RoutesUrl), true);

            }
        }

        [TestMethod]
        public void DeleteUserProvidedServiceInstanceTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                clients.ExpectedStatusCode = (HttpStatusCode)204;
                var cfClient = clients.CreateCloudFoundryClient();

                Guid? guid = Guid.NewGuid();


                cfClient.UserProvidedServiceInstances.DeleteUserProvidedServiceInstance(guid).Wait();

            }
        }

        [TestMethod]
        public void ListAllRoutesForUserProvidedServiceInstanceTest()
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
        ""guid"": ""6b6dfd45-e300-41bb-b70a-05ea9cf3cc5e"",
        ""url"": ""/v2/routes/c63e065a-7462-460a-bf55-7602da4a8de2"",
        ""created_at"": ""2016-07-27T14:02:39Z"",
        ""updated_at"": ""2016-07-27T14:02:39Z""
      },
      ""entity"": {
        ""host"": ""host-17"",
        ""path"": """",
        ""domain_guid"": ""6b6dfd45-e300-41bb-b70a-05ea9cf3cc5e"",
        ""space_guid"": ""6b6dfd45-e300-41bb-b70a-05ea9cf3cc5e"",
        ""service_instance_guid"": ""6b6dfd45-e300-41bb-b70a-05ea9cf3cc5e"",
        ""port"": null,
        ""domain_url"": ""/v2/private_domains/524dc480-0612-4e51-865e-8a9bffe45b82"",
        ""space_url"": ""/v2/spaces/5b148a64-79a4-4f87-9fe5-887bf63a1d83"",
        ""service_instance_url"": ""/v2/user_provided_service_instances/d457176e-af36-4f39-aa9c-998bfa7013af"",
        ""apps_url"": ""/v2/routes/c63e065a-7462-460a-bf55-7602da4a8de2/apps"",
        ""route_mappings_url"": ""/v2/routes/c63e065a-7462-460a-bf55-7602da4a8de2/route_mappings""
      }
    }
  ]
}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)200;
                var cfClient = clients.CreateCloudFoundryClient();

                Guid? guid = Guid.NewGuid();


                var obj = cfClient.UserProvidedServiceInstances.ListAllRoutesForUserProvidedServiceInstance(guid).Result;

                Assert.AreEqual("1", TestUtil.ToTestableString(obj.Properties.TotalResults), true);
                Assert.AreEqual("1", TestUtil.ToTestableString(obj.Properties.TotalPages), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.Properties.PreviousUrl), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.Properties.NextUrl), true);
                Assert.AreEqual("6b6dfd45-e300-41bb-b70a-05ea9cf3cc5e", TestUtil.ToTestableString(obj[0].EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/routes/c63e065a-7462-460a-bf55-7602da4a8de2", TestUtil.ToTestableString(obj[0].EntityMetadata.Url), true);
                Assert.AreEqual("2016-07-27T14:02:39Z", TestUtil.ToTestableString(obj[0].EntityMetadata.CreatedAt), true);
                Assert.AreEqual("2016-07-27T14:02:39Z", TestUtil.ToTestableString(obj[0].EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("host-17", TestUtil.ToTestableString(obj[0].Host), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[0].Path), true);
                Assert.AreEqual("6b6dfd45-e300-41bb-b70a-05ea9cf3cc5e", TestUtil.ToTestableString(obj[0].DomainGuid), true);
                Assert.AreEqual("6b6dfd45-e300-41bb-b70a-05ea9cf3cc5e", TestUtil.ToTestableString(obj[0].SpaceGuid), true);
                Assert.AreEqual("6b6dfd45-e300-41bb-b70a-05ea9cf3cc5e", TestUtil.ToTestableString(obj[0].ServiceInstanceGuid), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[0].Port), true);
                Assert.AreEqual("/v2/private_domains/524dc480-0612-4e51-865e-8a9bffe45b82", TestUtil.ToTestableString(obj[0].DomainUrl), true);
                Assert.AreEqual("/v2/spaces/5b148a64-79a4-4f87-9fe5-887bf63a1d83", TestUtil.ToTestableString(obj[0].SpaceUrl), true);
                Assert.AreEqual("/v2/user_provided_service_instances/d457176e-af36-4f39-aa9c-998bfa7013af", TestUtil.ToTestableString(obj[0].ServiceInstanceUrl), true);
                Assert.AreEqual("/v2/routes/c63e065a-7462-460a-bf55-7602da4a8de2/apps", TestUtil.ToTestableString(obj[0].AppsUrl), true);
                Assert.AreEqual("/v2/routes/c63e065a-7462-460a-bf55-7602da4a8de2/route_mappings", TestUtil.ToTestableString(obj[0].RouteMappingsUrl), true);

            }
        }

        [TestMethod]
        public void ListAllUserProvidedServiceInstancesTest()
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
        ""guid"": ""fc19032f-449a-46a6-9948-b1e258838360"",
        ""url"": ""/v2/user_provided_service_instances/fee78402-ea7e-46c1-bce3-8ec85279d229"",
        ""created_at"": ""2016-07-27T14:02:39Z"",
        ""updated_at"": null
      },
      ""entity"": {
        ""name"": ""name-654"",
        ""credentials"": {
          ""creds-key-41"": ""creds-val-41""
        },
        ""space_guid"": ""fc19032f-449a-46a6-9948-b1e258838360"",
        ""type"": ""user_provided_service_instance"",
        ""syslog_drain_url"": ""https://foo.com/url-60"",
        ""route_service_url"": null,
        ""space_url"": ""/v2/spaces/6ce58e28-0774-4ed2-a539-fa430636ccd6"",
        ""service_bindings_url"": ""/v2/user_provided_service_instances/fee78402-ea7e-46c1-bce3-8ec85279d229/service_bindings"",
        ""routes_url"": ""/v2/user_provided_service_instances/fee78402-ea7e-46c1-bce3-8ec85279d229/routes""
      }
    }
  ]
}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)200;
                var cfClient = clients.CreateCloudFoundryClient();


                var obj = cfClient.UserProvidedServiceInstances.ListAllUserProvidedServiceInstances().Result;

                Assert.AreEqual("1", TestUtil.ToTestableString(obj.Properties.TotalResults), true);
                Assert.AreEqual("1", TestUtil.ToTestableString(obj.Properties.TotalPages), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.Properties.PreviousUrl), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.Properties.NextUrl), true);
                Assert.AreEqual("fc19032f-449a-46a6-9948-b1e258838360", TestUtil.ToTestableString(obj[0].EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/user_provided_service_instances/fee78402-ea7e-46c1-bce3-8ec85279d229", TestUtil.ToTestableString(obj[0].EntityMetadata.Url), true);
                Assert.AreEqual("2016-07-27T14:02:39Z", TestUtil.ToTestableString(obj[0].EntityMetadata.CreatedAt), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[0].EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("name-654", TestUtil.ToTestableString(obj[0].Name), true);
                Assert.AreEqual("fc19032f-449a-46a6-9948-b1e258838360", TestUtil.ToTestableString(obj[0].SpaceGuid), true);
                Assert.AreEqual("user_provided_service_instance", TestUtil.ToTestableString(obj[0].Type), true);
                Assert.AreEqual("https://foo.com/url-60", TestUtil.ToTestableString(obj[0].SyslogDrainUrl), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[0].RouteServiceUrl), true);
                Assert.AreEqual("/v2/spaces/6ce58e28-0774-4ed2-a539-fa430636ccd6", TestUtil.ToTestableString(obj[0].SpaceUrl), true);
                Assert.AreEqual("/v2/user_provided_service_instances/fee78402-ea7e-46c1-bce3-8ec85279d229/service_bindings", TestUtil.ToTestableString(obj[0].ServiceBindingsUrl), true);
                Assert.AreEqual("/v2/user_provided_service_instances/fee78402-ea7e-46c1-bce3-8ec85279d229/routes", TestUtil.ToTestableString(obj[0].RoutesUrl), true);

            }
        }

        [TestMethod]
        public void RemoveRouteFromUserProvidedServiceInstanceTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                clients.ExpectedStatusCode = (HttpStatusCode)204;
                var cfClient = clients.CreateCloudFoundryClient();

                Guid? guid = Guid.NewGuid();

                Guid? route_guid = Guid.NewGuid();


                cfClient.UserProvidedServiceInstances.RemoveRouteFromUserProvidedServiceInstance(guid, route_guid).Wait();

            }
        }

        [TestMethod]
        public void ListAllServiceBindingsForUserProvidedServiceInstanceTest()
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
        ""guid"": ""0bd3f2af-70f3-4cde-8e46-fe85157e139b"",
        ""url"": ""/v2/service_bindings/7c02c7c7-1e70-4d3f-a7e3-40abb6c81910"",
        ""created_at"": ""2016-07-27T14:02:39Z"",
        ""updated_at"": null
      },
      ""entity"": {
        ""app_guid"": ""0bd3f2af-70f3-4cde-8e46-fe85157e139b"",
        ""service_instance_guid"": ""0bd3f2af-70f3-4cde-8e46-fe85157e139b"",
        ""credentials"": {
          ""creds-key-35"": ""creds-val-35""
        },
        ""binding_options"": {

        },
        ""gateway_data"": null,
        ""gateway_name"": """",
        ""syslog_drain_url"": null,
        ""volume_mounts"": [

        ],
        ""app_url"": ""/v2/apps/56231c10-7024-431c-8362-a7ea5adc50b9"",
        ""service_instance_url"": ""/v2/user_provided_service_instances/19e0b6e2-08af-43e2-8e2a-6bd007879457""
      }
    }
  ]
}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)200;
                var cfClient = clients.CreateCloudFoundryClient();

                Guid? guid = Guid.NewGuid();


                var obj = cfClient.UserProvidedServiceInstances.ListAllServiceBindingsForUserProvidedServiceInstance(guid).Result;

                Assert.AreEqual("1", TestUtil.ToTestableString(obj.Properties.TotalResults), true);
                Assert.AreEqual("1", TestUtil.ToTestableString(obj.Properties.TotalPages), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.Properties.PreviousUrl), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.Properties.NextUrl), true);
                Assert.AreEqual("0bd3f2af-70f3-4cde-8e46-fe85157e139b", TestUtil.ToTestableString(obj[0].EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/service_bindings/7c02c7c7-1e70-4d3f-a7e3-40abb6c81910", TestUtil.ToTestableString(obj[0].EntityMetadata.Url), true);
                Assert.AreEqual("2016-07-27T14:02:39Z", TestUtil.ToTestableString(obj[0].EntityMetadata.CreatedAt), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[0].EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("0bd3f2af-70f3-4cde-8e46-fe85157e139b", TestUtil.ToTestableString(obj[0].AppGuid), true);
                Assert.AreEqual("0bd3f2af-70f3-4cde-8e46-fe85157e139b", TestUtil.ToTestableString(obj[0].ServiceInstanceGuid), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[0].GatewayData), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[0].GatewayName), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[0].SyslogDrainUrl), true);
                Assert.AreEqual("/v2/apps/56231c10-7024-431c-8362-a7ea5adc50b9", TestUtil.ToTestableString(obj[0].AppUrl), true);
                Assert.AreEqual("/v2/user_provided_service_instances/19e0b6e2-08af-43e2-8e2a-6bd007879457", TestUtil.ToTestableString(obj[0].ServiceInstanceUrl), true);

            }
        }

        [TestMethod]
        public void AssociateRouteWithUserProvidedServiceInstanceTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                string json = @"{
  ""metadata"": {
    ""guid"": ""056cb569-96ff-4450-89a1-6a1e7a62fb47"",
    ""url"": ""/v2/user_provided_service_instances/7dbb1ac8-f1f9-46bb-bdb3-a7e2e17af7a1"",
    ""created_at"": ""2016-07-27T14:02:39Z"",
    ""updated_at"": null
  },
  ""entity"": {
    ""name"": ""name-635"",
    ""credentials"": {
      ""creds-key-37"": ""creds-val-37""
    },
    ""space_guid"": ""056cb569-96ff-4450-89a1-6a1e7a62fb47"",
    ""type"": ""user_provided_service_instance"",
    ""syslog_drain_url"": ""https://foo.com/url-53"",
    ""route_service_url"": ""https://foo.com/url-52"",
    ""space_url"": ""/v2/spaces/eb1f28f5-25b1-4f62-bfd0-fdd1554453bf"",
    ""service_bindings_url"": ""/v2/user_provided_service_instances/7dbb1ac8-f1f9-46bb-bdb3-a7e2e17af7a1/service_bindings"",
    ""routes_url"": ""/v2/user_provided_service_instances/7dbb1ac8-f1f9-46bb-bdb3-a7e2e17af7a1/routes""
  }
}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)201;
                var cfClient = clients.CreateCloudFoundryClient();

                Guid? guid = Guid.NewGuid();

                Guid? route_guid = Guid.NewGuid();


                var obj = cfClient.UserProvidedServiceInstances.AssociateRouteWithUserProvidedServiceInstance(guid, route_guid).Result;


                Assert.AreEqual("056cb569-96ff-4450-89a1-6a1e7a62fb47", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/user_provided_service_instances/7dbb1ac8-f1f9-46bb-bdb3-a7e2e17af7a1", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
                Assert.AreEqual("2016-07-27T14:02:39Z", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("name-635", TestUtil.ToTestableString(obj.Name), true);
                Assert.AreEqual("056cb569-96ff-4450-89a1-6a1e7a62fb47", TestUtil.ToTestableString(obj.SpaceGuid), true);
                Assert.AreEqual("user_provided_service_instance", TestUtil.ToTestableString(obj.Type), true);
                Assert.AreEqual("https://foo.com/url-53", TestUtil.ToTestableString(obj.SyslogDrainUrl), true);
                Assert.AreEqual("https://foo.com/url-52", TestUtil.ToTestableString(obj.RouteServiceUrl), true);
                Assert.AreEqual("/v2/spaces/eb1f28f5-25b1-4f62-bfd0-fdd1554453bf", TestUtil.ToTestableString(obj.SpaceUrl), true);
                Assert.AreEqual("/v2/user_provided_service_instances/7dbb1ac8-f1f9-46bb-bdb3-a7e2e17af7a1/service_bindings", TestUtil.ToTestableString(obj.ServiceBindingsUrl), true);
                Assert.AreEqual("/v2/user_provided_service_instances/7dbb1ac8-f1f9-46bb-bdb3-a7e2e17af7a1/routes", TestUtil.ToTestableString(obj.RoutesUrl), true);

            }
        }

        [TestMethod]
        public void CreateUserProvidedServiceInstanceTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                string json = @"{
  ""metadata"": {
    ""guid"": ""916be9b8-ed73-4516-a528-a414340fd94b"",
    ""url"": ""/v2/user_provided_service_instances/5644e1d8-f55c-4155-befb-16a31cf01103"",
    ""created_at"": ""2016-07-27T14:02:39Z"",
    ""updated_at"": null
  },
  ""entity"": {
    ""name"": ""my-user-provided-instance"",
    ""credentials"": {
      ""somekey"": ""somevalue""
    },
    ""space_guid"": ""916be9b8-ed73-4516-a528-a414340fd94b"",
    ""type"": ""user_provided_service_instance"",
    ""syslog_drain_url"": ""syslog://example.com"",
    ""route_service_url"": ""https://logger.example.com"",
    ""space_url"": ""/v2/spaces/e2f2c5a1-a6c2-4db4-9fa3-c3b8f2b5805e"",
    ""service_bindings_url"": ""/v2/user_provided_service_instances/5644e1d8-f55c-4155-befb-16a31cf01103/service_bindings"",
    ""routes_url"": ""/v2/user_provided_service_instances/5644e1d8-f55c-4155-befb-16a31cf01103/routes""
  }
}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)201;
                var cfClient = clients.CreateCloudFoundryClient();

                CreateUserProvidedServiceInstanceRequest value = new CreateUserProvidedServiceInstanceRequest();


                var obj = cfClient.UserProvidedServiceInstances.CreateUserProvidedServiceInstance(value).Result;


                Assert.AreEqual("916be9b8-ed73-4516-a528-a414340fd94b", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/user_provided_service_instances/5644e1d8-f55c-4155-befb-16a31cf01103", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
                Assert.AreEqual("2016-07-27T14:02:39Z", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("my-user-provided-instance", TestUtil.ToTestableString(obj.Name), true);
                Assert.AreEqual("916be9b8-ed73-4516-a528-a414340fd94b", TestUtil.ToTestableString(obj.SpaceGuid), true);
                Assert.AreEqual("user_provided_service_instance", TestUtil.ToTestableString(obj.Type), true);
                Assert.AreEqual("syslog://example.com", TestUtil.ToTestableString(obj.SyslogDrainUrl), true);
                Assert.AreEqual("https://logger.example.com", TestUtil.ToTestableString(obj.RouteServiceUrl), true);
                Assert.AreEqual("/v2/spaces/e2f2c5a1-a6c2-4db4-9fa3-c3b8f2b5805e", TestUtil.ToTestableString(obj.SpaceUrl), true);
                Assert.AreEqual("/v2/user_provided_service_instances/5644e1d8-f55c-4155-befb-16a31cf01103/service_bindings", TestUtil.ToTestableString(obj.ServiceBindingsUrl), true);
                Assert.AreEqual("/v2/user_provided_service_instances/5644e1d8-f55c-4155-befb-16a31cf01103/routes", TestUtil.ToTestableString(obj.RoutesUrl), true);

            }
        }

    }
}