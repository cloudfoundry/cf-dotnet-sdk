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
    public class ServicesTest
    {


        [TestMethod]
        public void TestRetrieveServiceResponse()
        {
            string json = @"{
  ""metadata"": {
    ""guid"": ""ba67be21-d957-4033-89b4-ca392f34de82"",
    ""url"": ""/v2/services/7aa6156c-3d4a-4fab-a04f-401408c55380"",
    ""created_at"": ""2016-09-02T11:52:11Z"",
    ""updated_at"": null
  },
  ""entity"": {
    ""label"": ""label-44"",
    ""provider"": null,
    ""url"": null,
    ""description"": ""desc-133"",
    ""long_description"": null,
    ""version"": null,
    ""info_url"": null,
    ""active"": true,
    ""bindable"": true,
    ""unique_id"": ""3f5c60a0-7ee6-4b92-a005-379382c3b305"",
    ""extra"": null,
    ""tags"": [

    ],
    ""requires"": [

    ],
    ""documentation_url"": null,
    ""service_broker_guid"": ""ba67be21-d957-4033-89b4-ca392f34de82"",
    ""plan_updateable"": false,
    ""service_plans_url"": ""/v2/services/7aa6156c-3d4a-4fab-a04f-401408c55380/service_plans""
  }
}";

            RetrieveServiceResponse obj = Utilities.DeserializeJson<RetrieveServiceResponse>(json);

            Assert.AreEqual("ba67be21-d957-4033-89b4-ca392f34de82", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/services/7aa6156c-3d4a-4fab-a04f-401408c55380", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
            Assert.AreEqual("2016-09-02T11:52:11Z", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("label-44", TestUtil.ToTestableString(obj.Label), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.Provider), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.Url), true);
            Assert.AreEqual("desc-133", TestUtil.ToTestableString(obj.Description), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.LongDescription), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.Version), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.InfoUrl), true);
            Assert.AreEqual("true", TestUtil.ToTestableString(obj.Active), true);
            Assert.AreEqual("true", TestUtil.ToTestableString(obj.Bindable), true);
            Assert.AreEqual("3f5c60a0-7ee6-4b92-a005-379382c3b305", TestUtil.ToTestableString(obj.UniqueId), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.Extra), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.DocumentationUrl), true);
            Assert.AreEqual("ba67be21-d957-4033-89b4-ca392f34de82", TestUtil.ToTestableString(obj.ServiceBrokerGuid), true);
            Assert.AreEqual("false", TestUtil.ToTestableString(obj.PlanUpdateable), true);
            Assert.AreEqual("/v2/services/7aa6156c-3d4a-4fab-a04f-401408c55380/service_plans", TestUtil.ToTestableString(obj.ServicePlansUrl), true);
        }

        [TestMethod]
        public void TestListAllServicesResponse()
        {
            string json = @"{
  ""total_results"": 1,
  ""total_pages"": 1,
  ""prev_url"": null,
  ""next_url"": null,
  ""resources"": [
    {
      ""metadata"": {
        ""guid"": ""6fe07f36-ac66-4163-b3f7-f05cfc921f6b"",
        ""url"": ""/v2/services/e412f014-47d5-42f0-9140-323152320d05"",
        ""created_at"": ""2016-09-02T11:52:11Z"",
        ""updated_at"": null
      },
      ""entity"": {
        ""label"": ""label-45"",
        ""provider"": null,
        ""url"": null,
        ""description"": ""desc-134"",
        ""long_description"": null,
        ""version"": null,
        ""info_url"": null,
        ""active"": true,
        ""bindable"": true,
        ""unique_id"": ""06bdd9f9-29b0-4660-a9e8-018126cb652b"",
        ""extra"": null,
        ""tags"": [

        ],
        ""requires"": [

        ],
        ""documentation_url"": null,
        ""service_broker_guid"": ""6fe07f36-ac66-4163-b3f7-f05cfc921f6b"",
        ""plan_updateable"": false,
        ""service_plans_url"": ""/v2/services/e412f014-47d5-42f0-9140-323152320d05/service_plans""
      }
    }
  ]
}";

            PagedResponseCollection<ListAllServicesResponse> page = Utilities.DeserializePage<ListAllServicesResponse>(json, null);

            Assert.AreEqual("1", TestUtil.ToTestableString(page.Properties.TotalResults), true);
            Assert.AreEqual("1", TestUtil.ToTestableString(page.Properties.TotalPages), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page.Properties.PreviousUrl), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page.Properties.NextUrl), true);
            Assert.AreEqual("6fe07f36-ac66-4163-b3f7-f05cfc921f6b", TestUtil.ToTestableString(page[0].EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/services/e412f014-47d5-42f0-9140-323152320d05", TestUtil.ToTestableString(page[0].EntityMetadata.Url), true);
            Assert.AreEqual("2016-09-02T11:52:11Z", TestUtil.ToTestableString(page[0].EntityMetadata.CreatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[0].EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("label-45", TestUtil.ToTestableString(page[0].Label), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[0].Provider), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[0].Url), true);
            Assert.AreEqual("desc-134", TestUtil.ToTestableString(page[0].Description), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[0].LongDescription), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[0].Version), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[0].InfoUrl), true);
            Assert.AreEqual("true", TestUtil.ToTestableString(page[0].Active), true);
            Assert.AreEqual("true", TestUtil.ToTestableString(page[0].Bindable), true);
            Assert.AreEqual("06bdd9f9-29b0-4660-a9e8-018126cb652b", TestUtil.ToTestableString(page[0].UniqueId), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[0].Extra), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[0].DocumentationUrl), true);
            Assert.AreEqual("6fe07f36-ac66-4163-b3f7-f05cfc921f6b", TestUtil.ToTestableString(page[0].ServiceBrokerGuid), true);
            Assert.AreEqual("false", TestUtil.ToTestableString(page[0].PlanUpdateable), true);
            Assert.AreEqual("/v2/services/e412f014-47d5-42f0-9140-323152320d05/service_plans", TestUtil.ToTestableString(page[0].ServicePlansUrl), true);
        }

        [TestMethod]
        public void TestListAllServicePlansForServiceResponse()
        {
            string json = @"{
  ""total_results"": 1,
  ""total_pages"": 1,
  ""prev_url"": null,
  ""next_url"": null,
  ""resources"": [
    {
      ""metadata"": {
        ""guid"": ""dde52e55-d019-4a2d-b8ab-541f2115f995"",
        ""url"": ""/v2/service_plans/c02a3127-af54-4694-bf5b-a27462941ad8"",
        ""created_at"": ""2016-09-02T11:52:11Z"",
        ""updated_at"": null
      },
      ""entity"": {
        ""name"": ""name-844"",
        ""free"": false,
        ""description"": ""desc-132"",
        ""service_guid"": ""dde52e55-d019-4a2d-b8ab-541f2115f995"",
        ""extra"": null,
        ""unique_id"": ""027b34e8-d9c3-42d7-b95c-41d074b26bc8"",
        ""public"": true,
        ""active"": true,
        ""service_url"": ""/v2/services/b6af24b0-1112-415c-81e0-a2f41faf99d4"",
        ""service_instances_url"": ""/v2/service_plans/c02a3127-af54-4694-bf5b-a27462941ad8/service_instances""
      }
    }
  ]
}";

            PagedResponseCollection<ListAllServicePlansForServiceResponse> page = Utilities.DeserializePage<ListAllServicePlansForServiceResponse>(json, null);

            Assert.AreEqual("1", TestUtil.ToTestableString(page.Properties.TotalResults), true);
            Assert.AreEqual("1", TestUtil.ToTestableString(page.Properties.TotalPages), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page.Properties.PreviousUrl), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page.Properties.NextUrl), true);
            Assert.AreEqual("dde52e55-d019-4a2d-b8ab-541f2115f995", TestUtil.ToTestableString(page[0].EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/service_plans/c02a3127-af54-4694-bf5b-a27462941ad8", TestUtil.ToTestableString(page[0].EntityMetadata.Url), true);
            Assert.AreEqual("2016-09-02T11:52:11Z", TestUtil.ToTestableString(page[0].EntityMetadata.CreatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[0].EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("name-844", TestUtil.ToTestableString(page[0].Name), true);
            Assert.AreEqual("false", TestUtil.ToTestableString(page[0].Free), true);
            Assert.AreEqual("desc-132", TestUtil.ToTestableString(page[0].Description), true);
            Assert.AreEqual("dde52e55-d019-4a2d-b8ab-541f2115f995", TestUtil.ToTestableString(page[0].ServiceGuid), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[0].Extra), true);
            Assert.AreEqual("027b34e8-d9c3-42d7-b95c-41d074b26bc8", TestUtil.ToTestableString(page[0].UniqueId), true);
            Assert.AreEqual("true", TestUtil.ToTestableString(page[0].Public), true);
            Assert.AreEqual("true", TestUtil.ToTestableString(page[0].Active), true);
            Assert.AreEqual("/v2/services/b6af24b0-1112-415c-81e0-a2f41faf99d4", TestUtil.ToTestableString(page[0].ServiceUrl), true);
            Assert.AreEqual("/v2/service_plans/c02a3127-af54-4694-bf5b-a27462941ad8/service_instances", TestUtil.ToTestableString(page[0].ServiceInstancesUrl), true);
        }

        [TestMethod]
        public void TestDeleteServiceResponse()
        {
            string json = @"{
  ""metadata"": {
    ""guid"": ""da005992-5a54-4658-830d-fe6b3d4c707b"",
    ""created_at"": ""2016-09-02T11:52:11Z"",
    ""url"": ""/v2/jobs/ac108b04-21a9-482c-ad44-159dff6c031b""
  },
  ""entity"": {
    ""guid"": ""da005992-5a54-4658-830d-fe6b3d4c707b"",
    ""status"": ""queued""
  }
}";

            DeleteServiceResponse obj = Utilities.DeserializeJson<DeleteServiceResponse>(json);

            Assert.AreEqual("da005992-5a54-4658-830d-fe6b3d4c707b", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
            Assert.AreEqual("2016-09-02T11:52:11Z", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
            Assert.AreEqual("/v2/jobs/ac108b04-21a9-482c-ad44-159dff6c031b", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
            Assert.AreEqual("da005992-5a54-4658-830d-fe6b3d4c707b", TestUtil.ToTestableString(obj.Guid), true);
            Assert.AreEqual("queued", TestUtil.ToTestableString(obj.Status), true);
        }
    }
}
