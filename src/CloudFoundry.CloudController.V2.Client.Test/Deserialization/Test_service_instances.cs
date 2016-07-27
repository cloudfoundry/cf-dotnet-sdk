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
using System.CodeDom.Compiler;

namespace CloudFoundry.CloudController.V2.Test.Deserialization
{
    [TestClass]
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public class ServiceInstancesTest
    {


        [TestMethod]
        public void TestBindingServiceInstanceToRouteResponse()
        {
            string json = @"{
  ""metadata"": {
    ""guid"": ""cb4e905d-d3eb-417c-adae-469318bbcc66"",
    ""url"": ""/v2/service_instances/d69f4ef2-4709-49c4-993f-d7ad1b9e5079"",
    ""created_at"": ""2016-07-27T14:02:56Z"",
    ""updated_at"": null
  },
  ""entity"": {
    ""name"": ""name-2251"",
    ""credentials"": {
      ""creds-key-65"": ""creds-val-65""
    },
    ""service_plan_guid"": ""cb4e905d-d3eb-417c-adae-469318bbcc66"",
    ""space_guid"": ""cb4e905d-d3eb-417c-adae-469318bbcc66"",
    ""gateway_data"": null,
    ""dashboard_url"": null,
    ""type"": ""managed_service_instance"",
    ""last_operation"": null,
    ""tags"": [

    ],
    ""space_url"": ""/v2/spaces/07b680b5-208d-48b0-bcaf-c8839db5d30e"",
    ""service_plan_url"": ""/v2/service_plans/f15859d0-8c2f-4526-b65b-2ba10dcf3261"",
    ""service_bindings_url"": ""/v2/service_instances/d69f4ef2-4709-49c4-993f-d7ad1b9e5079/service_bindings"",
    ""service_keys_url"": ""/v2/service_instances/d69f4ef2-4709-49c4-993f-d7ad1b9e5079/service_keys"",
    ""routes_url"": ""/v2/service_instances/d69f4ef2-4709-49c4-993f-d7ad1b9e5079/routes""
  }
}";

            BindingServiceInstanceToRouteResponse obj = Utilities.DeserializeJson<BindingServiceInstanceToRouteResponse>(json);

            Assert.AreEqual("cb4e905d-d3eb-417c-adae-469318bbcc66", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/service_instances/d69f4ef2-4709-49c4-993f-d7ad1b9e5079", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
            Assert.AreEqual("2016-07-27T14:02:56Z", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("name-2251", TestUtil.ToTestableString(obj.Name), true);
            Assert.AreEqual("cb4e905d-d3eb-417c-adae-469318bbcc66", TestUtil.ToTestableString(obj.ServicePlanGuid), true);
            Assert.AreEqual("cb4e905d-d3eb-417c-adae-469318bbcc66", TestUtil.ToTestableString(obj.SpaceGuid), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.GatewayData), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.DashboardUrl), true);
            Assert.AreEqual("managed_service_instance", TestUtil.ToTestableString(obj.Type), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.LastOperation), true);
            Assert.AreEqual("/v2/spaces/07b680b5-208d-48b0-bcaf-c8839db5d30e", TestUtil.ToTestableString(obj.SpaceUrl), true);
            Assert.AreEqual("/v2/service_plans/f15859d0-8c2f-4526-b65b-2ba10dcf3261", TestUtil.ToTestableString(obj.ServicePlanUrl), true);
            Assert.AreEqual("/v2/service_instances/d69f4ef2-4709-49c4-993f-d7ad1b9e5079/service_bindings", TestUtil.ToTestableString(obj.ServiceBindingsUrl), true);
            Assert.AreEqual("/v2/service_instances/d69f4ef2-4709-49c4-993f-d7ad1b9e5079/service_keys", TestUtil.ToTestableString(obj.ServiceKeysUrl), true);
            Assert.AreEqual("/v2/service_instances/d69f4ef2-4709-49c4-993f-d7ad1b9e5079/routes", TestUtil.ToTestableString(obj.RoutesUrl), true);
        }

        [TestMethod]
        public void TestRetrievingPermissionsOnServiceInstanceResponse()
        {
            string json = @"{
  ""manage"": true
}";

            RetrievingPermissionsOnServiceInstanceResponse obj = Utilities.DeserializeJson<RetrievingPermissionsOnServiceInstanceResponse>(json);

            Assert.AreEqual("true", TestUtil.ToTestableString(obj.Manage), true);
        }

        [TestMethod]
        public void TestListAllRoutesForServiceInstanceResponse()
        {
            string json = @"{
  ""total_results"": 1,
  ""total_pages"": 1,
  ""prev_url"": null,
  ""next_url"": null,
  ""resources"": [
    {
      ""metadata"": {
        ""guid"": ""c3d8b268-e31a-435e-81b9-c17c42c62527"",
        ""url"": ""/v2/routes/079afd56-f993-4e2d-873a-8cefaedcda8d"",
        ""created_at"": ""2016-07-27T14:02:56Z"",
        ""updated_at"": null
      },
      ""entity"": {
        ""host"": ""host-32"",
        ""path"": """",
        ""domain_guid"": ""c3d8b268-e31a-435e-81b9-c17c42c62527"",
        ""space_guid"": ""c3d8b268-e31a-435e-81b9-c17c42c62527"",
        ""service_instance_guid"": ""c3d8b268-e31a-435e-81b9-c17c42c62527"",
        ""port"": null,
        ""domain_url"": ""/v2/private_domains/9805d15f-c816-499a-ab41-9bf2de7ad167"",
        ""space_url"": ""/v2/spaces/c385e19f-2168-4304-b4c8-8ce2c4ba5956"",
        ""service_instance_url"": ""/v2/service_instances/b4c3fb52-0597-4070-83cd-446cb8a776b8"",
        ""apps_url"": ""/v2/routes/079afd56-f993-4e2d-873a-8cefaedcda8d/apps"",
        ""route_mappings_url"": ""/v2/routes/079afd56-f993-4e2d-873a-8cefaedcda8d/route_mappings""
      }
    }
  ]
}";

            PagedResponseCollection<ListAllRoutesForServiceInstanceResponse> page = Utilities.DeserializePage<ListAllRoutesForServiceInstanceResponse>(json, null);

            Assert.AreEqual("1", TestUtil.ToTestableString(page.Properties.TotalResults), true);
            Assert.AreEqual("1", TestUtil.ToTestableString(page.Properties.TotalPages), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page.Properties.PreviousUrl), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page.Properties.NextUrl), true);
            Assert.AreEqual("c3d8b268-e31a-435e-81b9-c17c42c62527", TestUtil.ToTestableString(page[0].EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/routes/079afd56-f993-4e2d-873a-8cefaedcda8d", TestUtil.ToTestableString(page[0].EntityMetadata.Url), true);
            Assert.AreEqual("2016-07-27T14:02:56Z", TestUtil.ToTestableString(page[0].EntityMetadata.CreatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[0].EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("host-32", TestUtil.ToTestableString(page[0].Host), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[0].Path), true);
            Assert.AreEqual("c3d8b268-e31a-435e-81b9-c17c42c62527", TestUtil.ToTestableString(page[0].DomainGuid), true);
            Assert.AreEqual("c3d8b268-e31a-435e-81b9-c17c42c62527", TestUtil.ToTestableString(page[0].SpaceGuid), true);
            Assert.AreEqual("c3d8b268-e31a-435e-81b9-c17c42c62527", TestUtil.ToTestableString(page[0].ServiceInstanceGuid), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[0].Port), true);
            Assert.AreEqual("/v2/private_domains/9805d15f-c816-499a-ab41-9bf2de7ad167", TestUtil.ToTestableString(page[0].DomainUrl), true);
            Assert.AreEqual("/v2/spaces/c385e19f-2168-4304-b4c8-8ce2c4ba5956", TestUtil.ToTestableString(page[0].SpaceUrl), true);
            Assert.AreEqual("/v2/service_instances/b4c3fb52-0597-4070-83cd-446cb8a776b8", TestUtil.ToTestableString(page[0].ServiceInstanceUrl), true);
            Assert.AreEqual("/v2/routes/079afd56-f993-4e2d-873a-8cefaedcda8d/apps", TestUtil.ToTestableString(page[0].AppsUrl), true);
            Assert.AreEqual("/v2/routes/079afd56-f993-4e2d-873a-8cefaedcda8d/route_mappings", TestUtil.ToTestableString(page[0].RouteMappingsUrl), true);
        }

        [TestMethod]
        public void TestListAllServiceInstancesResponse()
        {
            string json = @"{
  ""total_results"": 1,
  ""total_pages"": 1,
  ""prev_url"": null,
  ""next_url"": null,
  ""resources"": [
    {
      ""metadata"": {
        ""guid"": ""da00eaca-5e0c-41d4-9669-e52e9ed7767b"",
        ""url"": ""/v2/service_instances/c132b0e5-4d0b-48b8-92f4-fec9b6e90fb7"",
        ""created_at"": ""2016-07-27T14:02:57Z"",
        ""updated_at"": null
      },
      ""entity"": {
        ""name"": ""name-2290"",
        ""credentials"": {
          ""creds-key-72"": ""creds-val-72""
        },
        ""service_plan_guid"": ""da00eaca-5e0c-41d4-9669-e52e9ed7767b"",
        ""space_guid"": ""da00eaca-5e0c-41d4-9669-e52e9ed7767b"",
        ""gateway_data"": null,
        ""dashboard_url"": null,
        ""type"": ""managed_service_instance"",
        ""last_operation"": {
          ""type"": ""create"",
          ""state"": ""succeeded"",
          ""description"": ""service broker-provided description"",
          ""updated_at"": ""2016-07-27T14:02:57Z"",
          ""created_at"": ""2016-07-27T14:02:57Z""
        },
        ""tags"": [
          ""accounting"",
          ""mongodb""
        ],
        ""space_url"": ""/v2/spaces/e2a012a3-170f-463d-8c29-21965f537440"",
        ""service_plan_url"": ""/v2/service_plans/0d5fa512-c62d-4557-9319-ce010261f146"",
        ""service_bindings_url"": ""/v2/service_instances/c132b0e5-4d0b-48b8-92f4-fec9b6e90fb7/service_bindings"",
        ""service_keys_url"": ""/v2/service_instances/c132b0e5-4d0b-48b8-92f4-fec9b6e90fb7/service_keys"",
        ""routes_url"": ""/v2/service_instances/c132b0e5-4d0b-48b8-92f4-fec9b6e90fb7/routes""
      }
    }
  ]
}";

            PagedResponseCollection<ListAllServiceInstancesResponse> page = Utilities.DeserializePage<ListAllServiceInstancesResponse>(json, null);

            Assert.AreEqual("1", TestUtil.ToTestableString(page.Properties.TotalResults), true);
            Assert.AreEqual("1", TestUtil.ToTestableString(page.Properties.TotalPages), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page.Properties.PreviousUrl), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page.Properties.NextUrl), true);
            Assert.AreEqual("da00eaca-5e0c-41d4-9669-e52e9ed7767b", TestUtil.ToTestableString(page[0].EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/service_instances/c132b0e5-4d0b-48b8-92f4-fec9b6e90fb7", TestUtil.ToTestableString(page[0].EntityMetadata.Url), true);
            Assert.AreEqual("2016-07-27T14:02:57Z", TestUtil.ToTestableString(page[0].EntityMetadata.CreatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[0].EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("name-2290", TestUtil.ToTestableString(page[0].Name), true);
            Assert.AreEqual("da00eaca-5e0c-41d4-9669-e52e9ed7767b", TestUtil.ToTestableString(page[0].ServicePlanGuid), true);
            Assert.AreEqual("da00eaca-5e0c-41d4-9669-e52e9ed7767b", TestUtil.ToTestableString(page[0].SpaceGuid), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[0].GatewayData), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[0].DashboardUrl), true);
            Assert.AreEqual("managed_service_instance", TestUtil.ToTestableString(page[0].Type), true);
            Assert.AreEqual("/v2/spaces/e2a012a3-170f-463d-8c29-21965f537440", TestUtil.ToTestableString(page[0].SpaceUrl), true);
            Assert.AreEqual("/v2/service_plans/0d5fa512-c62d-4557-9319-ce010261f146", TestUtil.ToTestableString(page[0].ServicePlanUrl), true);
            Assert.AreEqual("/v2/service_instances/c132b0e5-4d0b-48b8-92f4-fec9b6e90fb7/service_bindings", TestUtil.ToTestableString(page[0].ServiceBindingsUrl), true);
            Assert.AreEqual("/v2/service_instances/c132b0e5-4d0b-48b8-92f4-fec9b6e90fb7/service_keys", TestUtil.ToTestableString(page[0].ServiceKeysUrl), true);
            Assert.AreEqual("/v2/service_instances/c132b0e5-4d0b-48b8-92f4-fec9b6e90fb7/routes", TestUtil.ToTestableString(page[0].RoutesUrl), true);
        }

        [TestMethod]
        public void TestRetrieveServiceInstanceResponse()
        {
            string json = @"{
  ""metadata"": {
    ""guid"": ""5e039e3f-2b6c-4fdd-bd4e-d3a8bb6390aa"",
    ""url"": ""/v2/service_instances/3ab8efaf-6524-41bb-a33a-c7a9454af936"",
    ""created_at"": ""2016-07-27T14:02:57Z"",
    ""updated_at"": null
  },
  ""entity"": {
    ""name"": ""name-2302"",
    ""credentials"": {
      ""creds-key-74"": ""creds-val-74""
    },
    ""service_plan_guid"": ""5e039e3f-2b6c-4fdd-bd4e-d3a8bb6390aa"",
    ""space_guid"": ""5e039e3f-2b6c-4fdd-bd4e-d3a8bb6390aa"",
    ""gateway_data"": null,
    ""dashboard_url"": null,
    ""type"": ""managed_service_instance"",
    ""last_operation"": {
      ""type"": ""create"",
      ""state"": ""succeeded"",
      ""description"": ""service broker-provided description"",
      ""updated_at"": ""2016-07-27T14:02:57Z"",
      ""created_at"": ""2016-07-27T14:02:57Z""
    },
    ""tags"": [
      ""accounting"",
      ""mongodb""
    ],
    ""space_url"": ""/v2/spaces/41131f1c-2bb4-4c09-a893-18d2e730d4e7"",
    ""service_plan_url"": ""/v2/service_plans/e25e779e-5f5a-4e71-a9cc-175f0d0051de"",
    ""service_bindings_url"": ""/v2/service_instances/3ab8efaf-6524-41bb-a33a-c7a9454af936/service_bindings"",
    ""service_keys_url"": ""/v2/service_instances/3ab8efaf-6524-41bb-a33a-c7a9454af936/service_keys"",
    ""routes_url"": ""/v2/service_instances/3ab8efaf-6524-41bb-a33a-c7a9454af936/routes""
  }
}";

            RetrieveServiceInstanceResponse obj = Utilities.DeserializeJson<RetrieveServiceInstanceResponse>(json);

            Assert.AreEqual("5e039e3f-2b6c-4fdd-bd4e-d3a8bb6390aa", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/service_instances/3ab8efaf-6524-41bb-a33a-c7a9454af936", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
            Assert.AreEqual("2016-07-27T14:02:57Z", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("name-2302", TestUtil.ToTestableString(obj.Name), true);
            Assert.AreEqual("5e039e3f-2b6c-4fdd-bd4e-d3a8bb6390aa", TestUtil.ToTestableString(obj.ServicePlanGuid), true);
            Assert.AreEqual("5e039e3f-2b6c-4fdd-bd4e-d3a8bb6390aa", TestUtil.ToTestableString(obj.SpaceGuid), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.GatewayData), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.DashboardUrl), true);
            Assert.AreEqual("managed_service_instance", TestUtil.ToTestableString(obj.Type), true);
            Assert.AreEqual("/v2/spaces/41131f1c-2bb4-4c09-a893-18d2e730d4e7", TestUtil.ToTestableString(obj.SpaceUrl), true);
            Assert.AreEqual("/v2/service_plans/e25e779e-5f5a-4e71-a9cc-175f0d0051de", TestUtil.ToTestableString(obj.ServicePlanUrl), true);
            Assert.AreEqual("/v2/service_instances/3ab8efaf-6524-41bb-a33a-c7a9454af936/service_bindings", TestUtil.ToTestableString(obj.ServiceBindingsUrl), true);
            Assert.AreEqual("/v2/service_instances/3ab8efaf-6524-41bb-a33a-c7a9454af936/service_keys", TestUtil.ToTestableString(obj.ServiceKeysUrl), true);
            Assert.AreEqual("/v2/service_instances/3ab8efaf-6524-41bb-a33a-c7a9454af936/routes", TestUtil.ToTestableString(obj.RoutesUrl), true);
        }

        [TestMethod]
        public void TestCreateServiceInstanceResponse()
        {
            string json = @"{
  ""metadata"": {
    ""guid"": ""4c13af41-ff67-4a2d-943d-7cbd97d8ef25"",
    ""url"": ""/v2/service_instances/0a601e1c-9937-4ea0-8c6b-789662fa8413"",
    ""created_at"": ""2016-07-27T14:02:57Z"",
    ""updated_at"": null
  },
  ""entity"": {
    ""name"": ""my-service-instance"",
    ""credentials"": {

    },
    ""service_plan_guid"": ""4c13af41-ff67-4a2d-943d-7cbd97d8ef25"",
    ""space_guid"": ""4c13af41-ff67-4a2d-943d-7cbd97d8ef25"",
    ""gateway_data"": null,
    ""dashboard_url"": null,
    ""type"": ""managed_service_instance"",
    ""last_operation"": {
      ""type"": ""create"",
      ""state"": ""in progress"",
      ""description"": """",
      ""updated_at"": null,
      ""created_at"": ""2016-07-27T14:02:57Z""
    },
    ""tags"": [
      ""accounting"",
      ""mongodb""
    ],
    ""space_url"": ""/v2/spaces/2c672d60-5d90-4e14-a9ef-6ac6ac817a5e"",
    ""service_plan_url"": ""/v2/service_plans/91581e5e-4450-4dd1-92e7-9d1cf99d6bea"",
    ""service_bindings_url"": ""/v2/service_instances/0a601e1c-9937-4ea0-8c6b-789662fa8413/service_bindings"",
    ""service_keys_url"": ""/v2/service_instances/0a601e1c-9937-4ea0-8c6b-789662fa8413/service_keys"",
    ""routes_url"": ""/v2/service_instances/0a601e1c-9937-4ea0-8c6b-789662fa8413/routes""
  }
}";

            CreateServiceInstanceResponse obj = Utilities.DeserializeJson<CreateServiceInstanceResponse>(json);

            Assert.AreEqual("4c13af41-ff67-4a2d-943d-7cbd97d8ef25", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/service_instances/0a601e1c-9937-4ea0-8c6b-789662fa8413", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
            Assert.AreEqual("2016-07-27T14:02:57Z", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("my-service-instance", TestUtil.ToTestableString(obj.Name), true);
            Assert.AreEqual("4c13af41-ff67-4a2d-943d-7cbd97d8ef25", TestUtil.ToTestableString(obj.ServicePlanGuid), true);
            Assert.AreEqual("4c13af41-ff67-4a2d-943d-7cbd97d8ef25", TestUtil.ToTestableString(obj.SpaceGuid), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.GatewayData), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.DashboardUrl), true);
            Assert.AreEqual("managed_service_instance", TestUtil.ToTestableString(obj.Type), true);
            Assert.AreEqual("/v2/spaces/2c672d60-5d90-4e14-a9ef-6ac6ac817a5e", TestUtil.ToTestableString(obj.SpaceUrl), true);
            Assert.AreEqual("/v2/service_plans/91581e5e-4450-4dd1-92e7-9d1cf99d6bea", TestUtil.ToTestableString(obj.ServicePlanUrl), true);
            Assert.AreEqual("/v2/service_instances/0a601e1c-9937-4ea0-8c6b-789662fa8413/service_bindings", TestUtil.ToTestableString(obj.ServiceBindingsUrl), true);
            Assert.AreEqual("/v2/service_instances/0a601e1c-9937-4ea0-8c6b-789662fa8413/service_keys", TestUtil.ToTestableString(obj.ServiceKeysUrl), true);
            Assert.AreEqual("/v2/service_instances/0a601e1c-9937-4ea0-8c6b-789662fa8413/routes", TestUtil.ToTestableString(obj.RoutesUrl), true);
        }

        [TestMethod]
        public void TestListAllServiceKeysForServiceInstanceResponse()
        {
            string json = @"{
  ""total_results"": 1,
  ""total_pages"": 1,
  ""prev_url"": null,
  ""next_url"": null,
  ""resources"": [
    {
      ""metadata"": {
        ""guid"": ""35e094e1-dfaa-4fff-8a23-cff43af9b9be"",
        ""url"": ""/v2/service_keys/452b4c2b-866f-4111-9bfa-47c3a16ac7ea"",
        ""created_at"": ""2016-07-27T14:02:57Z"",
        ""updated_at"": null
      },
      ""entity"": {
        ""name"": ""a-service-key"",
        ""service_instance_guid"": ""35e094e1-dfaa-4fff-8a23-cff43af9b9be"",
        ""credentials"": {
          ""creds-key-69"": ""creds-val-69""
        },
        ""service_instance_url"": ""/v2/service_instances/7190d64b-e7fc-44dd-891f-edeea3d34ae3""
      }
    }
  ]
}";

            PagedResponseCollection<ListAllServiceKeysForServiceInstanceResponse> page = Utilities.DeserializePage<ListAllServiceKeysForServiceInstanceResponse>(json, null);

            Assert.AreEqual("1", TestUtil.ToTestableString(page.Properties.TotalResults), true);
            Assert.AreEqual("1", TestUtil.ToTestableString(page.Properties.TotalPages), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page.Properties.PreviousUrl), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page.Properties.NextUrl), true);
            Assert.AreEqual("35e094e1-dfaa-4fff-8a23-cff43af9b9be", TestUtil.ToTestableString(page[0].EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/service_keys/452b4c2b-866f-4111-9bfa-47c3a16ac7ea", TestUtil.ToTestableString(page[0].EntityMetadata.Url), true);
            Assert.AreEqual("2016-07-27T14:02:57Z", TestUtil.ToTestableString(page[0].EntityMetadata.CreatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[0].EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("a-service-key", TestUtil.ToTestableString(page[0].Name), true);
            Assert.AreEqual("35e094e1-dfaa-4fff-8a23-cff43af9b9be", TestUtil.ToTestableString(page[0].ServiceInstanceGuid), true);
            Assert.AreEqual("/v2/service_instances/7190d64b-e7fc-44dd-891f-edeea3d34ae3", TestUtil.ToTestableString(page[0].ServiceInstanceUrl), true);
        }

        [TestMethod]
        public void TestDeleteServiceInstanceResponse()
        {
            string json = @"{
  ""metadata"": {
    ""guid"": ""c76a2683-7d36-43e0-8007-382925be6bfa"",
    ""url"": ""/v2/service_instances/ce196478-d618-401a-b9f7-358cb8cf20b3"",
    ""created_at"": ""2016-07-27T14:02:57Z"",
    ""updated_at"": null
  },
  ""entity"": {
    ""name"": ""name-2296"",
    ""credentials"": {
      ""creds-key-73"": ""creds-val-73""
    },
    ""service_plan_guid"": ""c76a2683-7d36-43e0-8007-382925be6bfa"",
    ""space_guid"": ""c76a2683-7d36-43e0-8007-382925be6bfa"",
    ""gateway_data"": null,
    ""dashboard_url"": null,
    ""type"": ""managed_service_instance"",
    ""last_operation"": {
      ""type"": ""delete"",
      ""state"": ""in progress"",
      ""description"": """",
      ""updated_at"": ""2016-07-27T14:02:57Z"",
      ""created_at"": ""2016-07-27T14:02:57Z""
    },
    ""tags"": [
      ""accounting"",
      ""mongodb""
    ],
    ""space_url"": ""/v2/spaces/0aa3e371-56d1-40d2-84c3-7e965d75aac4"",
    ""service_plan_url"": ""/v2/service_plans/00c7bb4b-838b-4140-b12e-5ec8bf984892"",
    ""service_bindings_url"": ""/v2/service_instances/ce196478-d618-401a-b9f7-358cb8cf20b3/service_bindings"",
    ""service_keys_url"": ""/v2/service_instances/ce196478-d618-401a-b9f7-358cb8cf20b3/service_keys"",
    ""routes_url"": ""/v2/service_instances/ce196478-d618-401a-b9f7-358cb8cf20b3/routes""
  }
}";

            DeleteServiceInstanceResponse obj = Utilities.DeserializeJson<DeleteServiceInstanceResponse>(json);

            Assert.AreEqual("c76a2683-7d36-43e0-8007-382925be6bfa", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/service_instances/ce196478-d618-401a-b9f7-358cb8cf20b3", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
            Assert.AreEqual("2016-07-27T14:02:57Z", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("name-2296", TestUtil.ToTestableString(obj.Name), true);
            Assert.AreEqual("c76a2683-7d36-43e0-8007-382925be6bfa", TestUtil.ToTestableString(obj.ServicePlanGuid), true);
            Assert.AreEqual("c76a2683-7d36-43e0-8007-382925be6bfa", TestUtil.ToTestableString(obj.SpaceGuid), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.GatewayData), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.DashboardUrl), true);
            Assert.AreEqual("managed_service_instance", TestUtil.ToTestableString(obj.Type), true);
            Assert.AreEqual("/v2/spaces/0aa3e371-56d1-40d2-84c3-7e965d75aac4", TestUtil.ToTestableString(obj.SpaceUrl), true);
            Assert.AreEqual("/v2/service_plans/00c7bb4b-838b-4140-b12e-5ec8bf984892", TestUtil.ToTestableString(obj.ServicePlanUrl), true);
            Assert.AreEqual("/v2/service_instances/ce196478-d618-401a-b9f7-358cb8cf20b3/service_bindings", TestUtil.ToTestableString(obj.ServiceBindingsUrl), true);
            Assert.AreEqual("/v2/service_instances/ce196478-d618-401a-b9f7-358cb8cf20b3/service_keys", TestUtil.ToTestableString(obj.ServiceKeysUrl), true);
            Assert.AreEqual("/v2/service_instances/ce196478-d618-401a-b9f7-358cb8cf20b3/routes", TestUtil.ToTestableString(obj.RoutesUrl), true);
        }

        [TestMethod]
        public void TestListAllServiceBindingsForServiceInstanceResponse()
        {
            string json = @"{
  ""total_results"": 1,
  ""total_pages"": 1,
  ""prev_url"": null,
  ""next_url"": null,
  ""resources"": [
    {
      ""metadata"": {
        ""guid"": ""8374d2b6-eb17-4382-a11c-4f4a99256e5b"",
        ""url"": ""/v2/service_bindings/0b31d460-939c-4d10-853f-40e95d87ef3c"",
        ""created_at"": ""2016-07-27T14:02:56Z"",
        ""updated_at"": null
      },
      ""entity"": {
        ""app_guid"": ""8374d2b6-eb17-4382-a11c-4f4a99256e5b"",
        ""service_instance_guid"": ""8374d2b6-eb17-4382-a11c-4f4a99256e5b"",
        ""credentials"": {
          ""creds-key-64"": ""creds-val-64""
        },
        ""binding_options"": {

        },
        ""gateway_data"": null,
        ""gateway_name"": """",
        ""syslog_drain_url"": null,
        ""volume_mounts"": [

        ],
        ""app_url"": ""/v2/apps/1f2a9c09-47ff-45ec-b876-229b119d51c5"",
        ""service_instance_url"": ""/v2/service_instances/129ee350-4855-4543-8ad0-543c92235781""
      }
    }
  ]
}";

            PagedResponseCollection<ListAllServiceBindingsForServiceInstanceResponse> page = Utilities.DeserializePage<ListAllServiceBindingsForServiceInstanceResponse>(json, null);

            Assert.AreEqual("1", TestUtil.ToTestableString(page.Properties.TotalResults), true);
            Assert.AreEqual("1", TestUtil.ToTestableString(page.Properties.TotalPages), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page.Properties.PreviousUrl), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page.Properties.NextUrl), true);
            Assert.AreEqual("8374d2b6-eb17-4382-a11c-4f4a99256e5b", TestUtil.ToTestableString(page[0].EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/service_bindings/0b31d460-939c-4d10-853f-40e95d87ef3c", TestUtil.ToTestableString(page[0].EntityMetadata.Url), true);
            Assert.AreEqual("2016-07-27T14:02:56Z", TestUtil.ToTestableString(page[0].EntityMetadata.CreatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[0].EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("8374d2b6-eb17-4382-a11c-4f4a99256e5b", TestUtil.ToTestableString(page[0].AppGuid), true);
            Assert.AreEqual("8374d2b6-eb17-4382-a11c-4f4a99256e5b", TestUtil.ToTestableString(page[0].ServiceInstanceGuid), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[0].GatewayData), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[0].GatewayName), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[0].SyslogDrainUrl), true);
            Assert.AreEqual("/v2/apps/1f2a9c09-47ff-45ec-b876-229b119d51c5", TestUtil.ToTestableString(page[0].AppUrl), true);
            Assert.AreEqual("/v2/service_instances/129ee350-4855-4543-8ad0-543c92235781", TestUtil.ToTestableString(page[0].ServiceInstanceUrl), true);
        }

        [TestMethod]
        public void TestUpdateServiceInstanceResponse()
        {
            string json = @"{
  ""metadata"": {
    ""guid"": ""0c7b8148-0c55-489d-87a8-fdfa0d7134ab"",
    ""url"": ""/v2/service_instances/f5fe1c43-0a12-4413-ac78-ea9042469053"",
    ""created_at"": ""2016-07-27T14:02:57Z"",
    ""updated_at"": null
  },
  ""entity"": {
    ""name"": ""name-2308"",
    ""credentials"": {
      ""creds-key-75"": ""creds-val-75""
    },
    ""service_plan_guid"": ""0c7b8148-0c55-489d-87a8-fdfa0d7134ab"",
    ""space_guid"": ""0c7b8148-0c55-489d-87a8-fdfa0d7134ab"",
    ""gateway_data"": null,
    ""dashboard_url"": null,
    ""type"": ""managed_service_instance"",
    ""last_operation"": {
      ""type"": ""update"",
      ""state"": ""in progress"",
      ""description"": """",
      ""updated_at"": ""2016-07-27T14:02:57Z"",
      ""created_at"": ""2016-07-27T14:02:57Z""
    },
    ""tags"": [

    ],
    ""space_url"": ""/v2/spaces/0c586af6-f555-4cb1-ac46-62b3606b129a"",
    ""service_plan_url"": ""/v2/service_plans/4b1ecc14-363e-4ee5-9184-0ee97f737103"",
    ""service_bindings_url"": ""/v2/service_instances/f5fe1c43-0a12-4413-ac78-ea9042469053/service_bindings"",
    ""service_keys_url"": ""/v2/service_instances/f5fe1c43-0a12-4413-ac78-ea9042469053/service_keys"",
    ""routes_url"": ""/v2/service_instances/f5fe1c43-0a12-4413-ac78-ea9042469053/routes""
  }
}";

            UpdateServiceInstanceResponse obj = Utilities.DeserializeJson<UpdateServiceInstanceResponse>(json);

            Assert.AreEqual("0c7b8148-0c55-489d-87a8-fdfa0d7134ab", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/service_instances/f5fe1c43-0a12-4413-ac78-ea9042469053", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
            Assert.AreEqual("2016-07-27T14:02:57Z", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("name-2308", TestUtil.ToTestableString(obj.Name), true);
            Assert.AreEqual("0c7b8148-0c55-489d-87a8-fdfa0d7134ab", TestUtil.ToTestableString(obj.ServicePlanGuid), true);
            Assert.AreEqual("0c7b8148-0c55-489d-87a8-fdfa0d7134ab", TestUtil.ToTestableString(obj.SpaceGuid), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.GatewayData), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.DashboardUrl), true);
            Assert.AreEqual("managed_service_instance", TestUtil.ToTestableString(obj.Type), true);
            Assert.AreEqual("/v2/spaces/0c586af6-f555-4cb1-ac46-62b3606b129a", TestUtil.ToTestableString(obj.SpaceUrl), true);
            Assert.AreEqual("/v2/service_plans/4b1ecc14-363e-4ee5-9184-0ee97f737103", TestUtil.ToTestableString(obj.ServicePlanUrl), true);
            Assert.AreEqual("/v2/service_instances/f5fe1c43-0a12-4413-ac78-ea9042469053/service_bindings", TestUtil.ToTestableString(obj.ServiceBindingsUrl), true);
            Assert.AreEqual("/v2/service_instances/f5fe1c43-0a12-4413-ac78-ea9042469053/service_keys", TestUtil.ToTestableString(obj.ServiceKeysUrl), true);
            Assert.AreEqual("/v2/service_instances/f5fe1c43-0a12-4413-ac78-ea9042469053/routes", TestUtil.ToTestableString(obj.RoutesUrl), true);
        }
    }
}
