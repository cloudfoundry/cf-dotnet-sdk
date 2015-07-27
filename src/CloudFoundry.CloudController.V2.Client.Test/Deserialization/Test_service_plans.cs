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
    public class ServicePlansTest
    {


        [TestMethod]
        public void TestUpdateServicePlanDeprecatedResponse()
        {
            string json = @"{
  ""metadata"": {
    ""guid"": ""bc1b4fad-abb1-4e77-828f-5873dcf61964"",
    ""url"": ""/v2/service_plans/bc1b4fad-abb1-4e77-828f-5873dcf61964"",
    ""created_at"": ""2015-07-28T12:59:07Z"",
    ""updated_at"": ""2015-07-28T12:59:07Z""
  },
  ""entity"": {
    ""name"": ""100mb"",
    ""free"": true,
    ""description"": ""Let's you put data in your database!"",
    ""service_guid"": ""33dd3a4b-125a-4f5d-af4e-851fc3184722"",
    ""extra"": null,
    ""unique_id"": ""cb093083-9f99-4d1f-85fb-0e884933f439"",
    ""public"": true,
    ""active"": true,
    ""service_url"": ""/v2/services/33dd3a4b-125a-4f5d-af4e-851fc3184722"",
    ""service_instances_url"": ""/v2/service_plans/bc1b4fad-abb1-4e77-828f-5873dcf61964/service_instances""
  }
}";

            UpdateServicePlanDeprecatedResponse obj = Utilities.DeserializeJson<UpdateServicePlanDeprecatedResponse>(json);

            Assert.AreEqual("bc1b4fad-abb1-4e77-828f-5873dcf61964", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/service_plans/bc1b4fad-abb1-4e77-828f-5873dcf61964", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
            Assert.AreEqual("2015-07-28T12:59:07Z", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
            Assert.AreEqual("2015-07-28T12:59:07Z", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("100mb", TestUtil.ToTestableString(obj.Name), true);
            Assert.AreEqual("true", TestUtil.ToTestableString(obj.Free), true);
            Assert.AreEqual("Let's you put data in your database!", TestUtil.ToTestableString(obj.Description), true);
            Assert.AreEqual("33dd3a4b-125a-4f5d-af4e-851fc3184722", TestUtil.ToTestableString(obj.ServiceGuid), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.Extra), true);
            Assert.AreEqual("cb093083-9f99-4d1f-85fb-0e884933f439", TestUtil.ToTestableString(obj.UniqueId), true);
            Assert.AreEqual("true", TestUtil.ToTestableString(obj.Public), true);
            Assert.AreEqual("true", TestUtil.ToTestableString(obj.Active), true);
            Assert.AreEqual("/v2/services/33dd3a4b-125a-4f5d-af4e-851fc3184722", TestUtil.ToTestableString(obj.ServiceUrl), true);
            Assert.AreEqual("/v2/service_plans/bc1b4fad-abb1-4e77-828f-5873dcf61964/service_instances", TestUtil.ToTestableString(obj.ServiceInstancesUrl), true);
        }

        [TestMethod]
        public void TestCreateServicePlanDeprecatedResponse()
        {
            string json = @"{
  ""metadata"": {
    ""guid"": ""777594b7-91f0-42ba-a03a-c52ff3625398"",
    ""url"": ""/v2/service_plans/777594b7-91f0-42ba-a03a-c52ff3625398"",
    ""created_at"": ""2015-07-28T12:59:07Z"",
    ""updated_at"": null
  },
  ""entity"": {
    ""name"": ""100mb"",
    ""free"": true,
    ""description"": ""Let's you put data in your database!"",
    ""service_guid"": ""11bb76a2-b480-443a-b081-75213ad4f692"",
    ""extra"": null,
    ""unique_id"": ""d1b1e34d-29b2-4205-bb79-97105b0dfaa0"",
    ""public"": true,
    ""active"": true,
    ""service_url"": ""/v2/services/11bb76a2-b480-443a-b081-75213ad4f692"",
    ""service_instances_url"": ""/v2/service_plans/777594b7-91f0-42ba-a03a-c52ff3625398/service_instances""
  }
}";

            CreateServicePlanDeprecatedResponse obj = Utilities.DeserializeJson<CreateServicePlanDeprecatedResponse>(json);

            Assert.AreEqual("777594b7-91f0-42ba-a03a-c52ff3625398", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/service_plans/777594b7-91f0-42ba-a03a-c52ff3625398", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
            Assert.AreEqual("2015-07-28T12:59:07Z", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("100mb", TestUtil.ToTestableString(obj.Name), true);
            Assert.AreEqual("true", TestUtil.ToTestableString(obj.Free), true);
            Assert.AreEqual("Let's you put data in your database!", TestUtil.ToTestableString(obj.Description), true);
            Assert.AreEqual("11bb76a2-b480-443a-b081-75213ad4f692", TestUtil.ToTestableString(obj.ServiceGuid), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.Extra), true);
            Assert.AreEqual("d1b1e34d-29b2-4205-bb79-97105b0dfaa0", TestUtil.ToTestableString(obj.UniqueId), true);
            Assert.AreEqual("true", TestUtil.ToTestableString(obj.Public), true);
            Assert.AreEqual("true", TestUtil.ToTestableString(obj.Active), true);
            Assert.AreEqual("/v2/services/11bb76a2-b480-443a-b081-75213ad4f692", TestUtil.ToTestableString(obj.ServiceUrl), true);
            Assert.AreEqual("/v2/service_plans/777594b7-91f0-42ba-a03a-c52ff3625398/service_instances", TestUtil.ToTestableString(obj.ServiceInstancesUrl), true);
        }

        [TestMethod]
        public void TestListAllServiceInstancesForServicePlanResponse()
        {
            string json = @"{
  ""total_results"": 1,
  ""total_pages"": 1,
  ""prev_url"": null,
  ""next_url"": null,
  ""resources"": [
    {
      ""metadata"": {
        ""guid"": ""f28c0c09-ac40-4f1b-b412-d89ab47900b8"",
        ""url"": ""/v2/service_instances/f28c0c09-ac40-4f1b-b412-d89ab47900b8"",
        ""created_at"": ""2015-07-28T12:59:07Z"",
        ""updated_at"": null
      },
      ""entity"": {
        ""name"": ""name-1339"",
        ""credentials"": {
          ""creds-key-363"": ""creds-val-363""
        },
        ""service_plan_guid"": ""63f706cc-87f8-49d2-bb5a-6ad3d9f0dacf"",
        ""space_guid"": ""61bb8485-f1c0-4e10-be4c-de8e9283188a"",
        ""gateway_data"": null,
        ""dashboard_url"": null,
        ""type"": ""managed_service_instance"",
        ""last_operation"": null,
        ""space_url"": ""/v2/spaces/61bb8485-f1c0-4e10-be4c-de8e9283188a"",
        ""service_plan_url"": ""/v2/service_plans/63f706cc-87f8-49d2-bb5a-6ad3d9f0dacf"",
        ""service_bindings_url"": ""/v2/service_instances/f28c0c09-ac40-4f1b-b412-d89ab47900b8/service_bindings""
      }
    }
  ]
}";

            PagedResponseCollection<ListAllServiceInstancesForServicePlanResponse> page = Utilities.DeserializePage<ListAllServiceInstancesForServicePlanResponse>(json, null);

            Assert.AreEqual("1", TestUtil.ToTestableString(page.Properties.TotalResults), true);
            Assert.AreEqual("1", TestUtil.ToTestableString(page.Properties.TotalPages), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page.Properties.PreviousUrl), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page.Properties.NextUrl), true);
            Assert.AreEqual("f28c0c09-ac40-4f1b-b412-d89ab47900b8", TestUtil.ToTestableString(page[0].EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/service_instances/f28c0c09-ac40-4f1b-b412-d89ab47900b8", TestUtil.ToTestableString(page[0].EntityMetadata.Url), true);
            Assert.AreEqual("2015-07-28T12:59:07Z", TestUtil.ToTestableString(page[0].EntityMetadata.CreatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[0].EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("name-1339", TestUtil.ToTestableString(page[0].Name), true);
            Assert.AreEqual("63f706cc-87f8-49d2-bb5a-6ad3d9f0dacf", TestUtil.ToTestableString(page[0].ServicePlanGuid), true);
            Assert.AreEqual("61bb8485-f1c0-4e10-be4c-de8e9283188a", TestUtil.ToTestableString(page[0].SpaceGuid), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[0].GatewayData), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[0].DashboardUrl), true);
            Assert.AreEqual("managed_service_instance", TestUtil.ToTestableString(page[0].Type), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[0].LastOperation), true);
            Assert.AreEqual("/v2/spaces/61bb8485-f1c0-4e10-be4c-de8e9283188a", TestUtil.ToTestableString(page[0].SpaceUrl), true);
            Assert.AreEqual("/v2/service_plans/63f706cc-87f8-49d2-bb5a-6ad3d9f0dacf", TestUtil.ToTestableString(page[0].ServicePlanUrl), true);
            Assert.AreEqual("/v2/service_instances/f28c0c09-ac40-4f1b-b412-d89ab47900b8/service_bindings", TestUtil.ToTestableString(page[0].ServiceBindingsUrl), true);
        }

        [TestMethod]
        public void TestRetrieveServicePlanResponse()
        {
            string json = @"{
  ""metadata"": {
    ""guid"": ""93378fe8-6ec5-4cf9-a990-06c1feecff0f"",
    ""url"": ""/v2/service_plans/93378fe8-6ec5-4cf9-a990-06c1feecff0f"",
    ""created_at"": ""2015-07-28T12:59:07Z"",
    ""updated_at"": null
  },
  ""entity"": {
    ""name"": ""name-1343"",
    ""free"": false,
    ""description"": ""desc-107"",
    ""service_guid"": ""d432dc26-04f1-42ce-88af-076b67d6f395"",
    ""extra"": null,
    ""unique_id"": ""0b3aa890-bdc1-4e7f-9fad-a6ed34a36eae"",
    ""public"": true,
    ""active"": true,
    ""service_url"": ""/v2/services/d432dc26-04f1-42ce-88af-076b67d6f395"",
    ""service_instances_url"": ""/v2/service_plans/93378fe8-6ec5-4cf9-a990-06c1feecff0f/service_instances""
  }
}";

            RetrieveServicePlanResponse obj = Utilities.DeserializeJson<RetrieveServicePlanResponse>(json);

            Assert.AreEqual("93378fe8-6ec5-4cf9-a990-06c1feecff0f", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/service_plans/93378fe8-6ec5-4cf9-a990-06c1feecff0f", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
            Assert.AreEqual("2015-07-28T12:59:07Z", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("name-1343", TestUtil.ToTestableString(obj.Name), true);
            Assert.AreEqual("false", TestUtil.ToTestableString(obj.Free), true);
            Assert.AreEqual("desc-107", TestUtil.ToTestableString(obj.Description), true);
            Assert.AreEqual("d432dc26-04f1-42ce-88af-076b67d6f395", TestUtil.ToTestableString(obj.ServiceGuid), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.Extra), true);
            Assert.AreEqual("0b3aa890-bdc1-4e7f-9fad-a6ed34a36eae", TestUtil.ToTestableString(obj.UniqueId), true);
            Assert.AreEqual("true", TestUtil.ToTestableString(obj.Public), true);
            Assert.AreEqual("true", TestUtil.ToTestableString(obj.Active), true);
            Assert.AreEqual("/v2/services/d432dc26-04f1-42ce-88af-076b67d6f395", TestUtil.ToTestableString(obj.ServiceUrl), true);
            Assert.AreEqual("/v2/service_plans/93378fe8-6ec5-4cf9-a990-06c1feecff0f/service_instances", TestUtil.ToTestableString(obj.ServiceInstancesUrl), true);
        }

        [TestMethod]
        public void TestListAllServicePlansResponse()
        {
            string json = @"{
  ""total_results"": 1,
  ""total_pages"": 1,
  ""prev_url"": null,
  ""next_url"": null,
  ""resources"": [
    {
      ""metadata"": {
        ""guid"": ""f3f9898d-9df5-45f5-b274-5d541de023b6"",
        ""url"": ""/v2/service_plans/f3f9898d-9df5-45f5-b274-5d541de023b6"",
        ""created_at"": ""2015-07-28T12:59:07Z"",
        ""updated_at"": null
      },
      ""entity"": {
        ""name"": ""name-1345"",
        ""free"": false,
        ""description"": ""desc-111"",
        ""service_guid"": ""31caae45-a6ca-40f6-9ffd-ba5a48350ff7"",
        ""extra"": null,
        ""unique_id"": ""0e287792-e47b-4de5-b81c-0a8fc2f73493"",
        ""public"": true,
        ""active"": true,
        ""service_url"": ""/v2/services/31caae45-a6ca-40f6-9ffd-ba5a48350ff7"",
        ""service_instances_url"": ""/v2/service_plans/f3f9898d-9df5-45f5-b274-5d541de023b6/service_instances""
      }
    }
  ]
}";

            PagedResponseCollection<ListAllServicePlansResponse> page = Utilities.DeserializePage<ListAllServicePlansResponse>(json, null);

            Assert.AreEqual("1", TestUtil.ToTestableString(page.Properties.TotalResults), true);
            Assert.AreEqual("1", TestUtil.ToTestableString(page.Properties.TotalPages), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page.Properties.PreviousUrl), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page.Properties.NextUrl), true);
            Assert.AreEqual("f3f9898d-9df5-45f5-b274-5d541de023b6", TestUtil.ToTestableString(page[0].EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/service_plans/f3f9898d-9df5-45f5-b274-5d541de023b6", TestUtil.ToTestableString(page[0].EntityMetadata.Url), true);
            Assert.AreEqual("2015-07-28T12:59:07Z", TestUtil.ToTestableString(page[0].EntityMetadata.CreatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[0].EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("name-1345", TestUtil.ToTestableString(page[0].Name), true);
            Assert.AreEqual("false", TestUtil.ToTestableString(page[0].Free), true);
            Assert.AreEqual("desc-111", TestUtil.ToTestableString(page[0].Description), true);
            Assert.AreEqual("31caae45-a6ca-40f6-9ffd-ba5a48350ff7", TestUtil.ToTestableString(page[0].ServiceGuid), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[0].Extra), true);
            Assert.AreEqual("0e287792-e47b-4de5-b81c-0a8fc2f73493", TestUtil.ToTestableString(page[0].UniqueId), true);
            Assert.AreEqual("true", TestUtil.ToTestableString(page[0].Public), true);
            Assert.AreEqual("true", TestUtil.ToTestableString(page[0].Active), true);
            Assert.AreEqual("/v2/services/31caae45-a6ca-40f6-9ffd-ba5a48350ff7", TestUtil.ToTestableString(page[0].ServiceUrl), true);
            Assert.AreEqual("/v2/service_plans/f3f9898d-9df5-45f5-b274-5d541de023b6/service_instances", TestUtil.ToTestableString(page[0].ServiceInstancesUrl), true);
        }
    }
}
