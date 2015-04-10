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
    public class OrganizationQuotaDefinitionsTest
    {


        [TestMethod]
        public void TestListAllOrganizationQuotaDefinitionsResponse()
        {
            string json = @"{
  ""total_results"": 1,
  ""total_pages"": 1,
  ""prev_url"": null,
  ""next_url"": null,
  ""resources"": [
    {
      ""metadata"": {
        ""guid"": ""24d7d23c-7c73-498c-8bc6-1021014dbb75"",
        ""url"": ""/v2/quota_definitions/24d7d23c-7c73-498c-8bc6-1021014dbb75"",
        ""created_at"": ""2015-04-10T20:04:27+00:00"",
        ""updated_at"": null
      },
      ""entity"": {
        ""name"": ""default"",
        ""non_basic_services_allowed"": true,
        ""total_services"": 100,
        ""total_routes"": 1000,
        ""memory_limit"": 10240,
        ""trial_db_allowed"": false,
        ""instance_memory_limit"": -1
      }
    }
  ]
}";

            PagedResponseCollection<ListAllOrganizationQuotaDefinitionsResponse> page = Utilities.DeserializePage<ListAllOrganizationQuotaDefinitionsResponse>(json, null);

            Assert.AreEqual("1", TestUtil.ToTestableString(page.Properties.TotalResults), true);
            Assert.AreEqual("1", TestUtil.ToTestableString(page.Properties.TotalPages), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page.Properties.PreviousUrl), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page.Properties.NextUrl), true);
            Assert.AreEqual("24d7d23c-7c73-498c-8bc6-1021014dbb75", TestUtil.ToTestableString(page[0].EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/quota_definitions/24d7d23c-7c73-498c-8bc6-1021014dbb75", TestUtil.ToTestableString(page[0].EntityMetadata.Url), true);
            Assert.AreEqual("2015-04-10T20:04:27+00:00", TestUtil.ToTestableString(page[0].EntityMetadata.CreatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[0].EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("default", TestUtil.ToTestableString(page[0].Name), true);
            Assert.AreEqual("true", TestUtil.ToTestableString(page[0].NonBasicServicesAllowed), true);
            Assert.AreEqual("100", TestUtil.ToTestableString(page[0].TotalServices), true);
            Assert.AreEqual("1000", TestUtil.ToTestableString(page[0].TotalRoutes), true);
            Assert.AreEqual("10240", TestUtil.ToTestableString(page[0].MemoryLimit), true);
            Assert.AreEqual("false", TestUtil.ToTestableString(page[0].TrialDbAllowed), true);
            Assert.AreEqual("-1", TestUtil.ToTestableString(page[0].InstanceMemoryLimit), true);
        }

        [TestMethod]
        public void TestUpdateOrganizationQuotaDefinitionResponse()
        {
            string json = @"{
  ""metadata"": {
    ""guid"": ""1ee4bd73-6920-4100-a251-375d18c15744"",
    ""url"": ""/v2/quota_definitions/1ee4bd73-6920-4100-a251-375d18c15744"",
    ""created_at"": ""2015-04-10T20:04:40+00:00"",
    ""updated_at"": ""2015-04-10T20:04:40+00:00""
  },
  ""entity"": {
    ""name"": ""name-1660"",
    ""non_basic_services_allowed"": true,
    ""total_services"": 60,
    ""total_routes"": 1000,
    ""memory_limit"": 20480,
    ""trial_db_allowed"": false,
    ""instance_memory_limit"": -1
  }
}";

            UpdateOrganizationQuotaDefinitionResponse obj = Utilities.DeserializeJson<UpdateOrganizationQuotaDefinitionResponse>(json);

            Assert.AreEqual("1ee4bd73-6920-4100-a251-375d18c15744", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/quota_definitions/1ee4bd73-6920-4100-a251-375d18c15744", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
            Assert.AreEqual("2015-04-10T20:04:40+00:00", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
            Assert.AreEqual("2015-04-10T20:04:40+00:00", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("name-1660", TestUtil.ToTestableString(obj.Name), true);
            Assert.AreEqual("true", TestUtil.ToTestableString(obj.NonBasicServicesAllowed), true);
            Assert.AreEqual("60", TestUtil.ToTestableString(obj.TotalServices), true);
            Assert.AreEqual("1000", TestUtil.ToTestableString(obj.TotalRoutes), true);
            Assert.AreEqual("20480", TestUtil.ToTestableString(obj.MemoryLimit), true);
            Assert.AreEqual("false", TestUtil.ToTestableString(obj.TrialDbAllowed), true);
            Assert.AreEqual("-1", TestUtil.ToTestableString(obj.InstanceMemoryLimit), true);
        }

        [TestMethod]
        public void TestCreateOrganizationQuotaDefinitionResponse()
        {
            string json = @"{
  ""metadata"": {
    ""guid"": ""27b0c484-4aa4-4b99-aeda-1f136f8eb09f"",
    ""url"": ""/v2/quota_definitions/27b0c484-4aa4-4b99-aeda-1f136f8eb09f"",
    ""created_at"": ""2015-04-10T20:04:40+00:00"",
    ""updated_at"": null
  },
  ""entity"": {
    ""name"": ""gold_quota"",
    ""non_basic_services_allowed"": true,
    ""total_services"": 5,
    ""total_routes"": 10,
    ""memory_limit"": 5120,
    ""trial_db_allowed"": false,
    ""instance_memory_limit"": 10240
  }
}";

            CreateOrganizationQuotaDefinitionResponse obj = Utilities.DeserializeJson<CreateOrganizationQuotaDefinitionResponse>(json);

            Assert.AreEqual("27b0c484-4aa4-4b99-aeda-1f136f8eb09f", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/quota_definitions/27b0c484-4aa4-4b99-aeda-1f136f8eb09f", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
            Assert.AreEqual("2015-04-10T20:04:40+00:00", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("gold_quota", TestUtil.ToTestableString(obj.Name), true);
            Assert.AreEqual("true", TestUtil.ToTestableString(obj.NonBasicServicesAllowed), true);
            Assert.AreEqual("5", TestUtil.ToTestableString(obj.TotalServices), true);
            Assert.AreEqual("10", TestUtil.ToTestableString(obj.TotalRoutes), true);
            Assert.AreEqual("5120", TestUtil.ToTestableString(obj.MemoryLimit), true);
            Assert.AreEqual("false", TestUtil.ToTestableString(obj.TrialDbAllowed), true);
            Assert.AreEqual("10240", TestUtil.ToTestableString(obj.InstanceMemoryLimit), true);
        }

        [TestMethod]
        public void TestRetrieveOrganizationQuotaDefinitionResponse()
        {
            string json = @"{
  ""metadata"": {
    ""guid"": ""97a76304-61c7-4125-8a29-ba934c259c29"",
    ""url"": ""/v2/quota_definitions/97a76304-61c7-4125-8a29-ba934c259c29"",
    ""created_at"": ""2015-04-10T20:04:40+00:00"",
    ""updated_at"": null
  },
  ""entity"": {
    ""name"": ""name-1659"",
    ""non_basic_services_allowed"": true,
    ""total_services"": 60,
    ""total_routes"": 1000,
    ""memory_limit"": 20480,
    ""trial_db_allowed"": false,
    ""instance_memory_limit"": -1
  }
}";

            RetrieveOrganizationQuotaDefinitionResponse obj = Utilities.DeserializeJson<RetrieveOrganizationQuotaDefinitionResponse>(json);

            Assert.AreEqual("97a76304-61c7-4125-8a29-ba934c259c29", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/quota_definitions/97a76304-61c7-4125-8a29-ba934c259c29", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
            Assert.AreEqual("2015-04-10T20:04:40+00:00", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("name-1659", TestUtil.ToTestableString(obj.Name), true);
            Assert.AreEqual("true", TestUtil.ToTestableString(obj.NonBasicServicesAllowed), true);
            Assert.AreEqual("60", TestUtil.ToTestableString(obj.TotalServices), true);
            Assert.AreEqual("1000", TestUtil.ToTestableString(obj.TotalRoutes), true);
            Assert.AreEqual("20480", TestUtil.ToTestableString(obj.MemoryLimit), true);
            Assert.AreEqual("false", TestUtil.ToTestableString(obj.TrialDbAllowed), true);
            Assert.AreEqual("-1", TestUtil.ToTestableString(obj.InstanceMemoryLimit), true);
        }
    }
}
