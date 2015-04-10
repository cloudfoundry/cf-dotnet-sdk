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
    public class PrivateDomainsEndpoint
{
        [TestMethod]
        public void FilterPrivateDomainsByNameTest()
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
        ""guid"": ""1273db92-4f27-4548-b227-a1892a6c6d17"",
        ""url"": ""/v2/private_domains/1273db92-4f27-4548-b227-a1892a6c6d17"",
        ""created_at"": ""2015-04-10T20:04:21+00:00"",
        ""updated_at"": null
      },
      ""entity"": {
        ""name"": ""my-domain.com"",
        ""owning_organization_guid"": ""752beb7d-5799-45d3-a4db-cbf2281ed22c"",
        ""owning_organization_url"": ""/v2/organizations/752beb7d-5799-45d3-a4db-cbf2281ed22c""
      }
    }
  ]
}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)200;
                var cfClient = clients.CreateCloudFoundryClient();


                var obj = cfClient.PrivateDomains.FilterPrivateDomainsByName().Result;

                Assert.AreEqual("1", TestUtil.ToTestableString(obj.Properties.TotalResults), true);
                Assert.AreEqual("1", TestUtil.ToTestableString(obj.Properties.TotalPages), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.Properties.PreviousUrl), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.Properties.NextUrl), true);
                Assert.AreEqual("1273db92-4f27-4548-b227-a1892a6c6d17", TestUtil.ToTestableString(obj[0].EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/private_domains/1273db92-4f27-4548-b227-a1892a6c6d17", TestUtil.ToTestableString(obj[0].EntityMetadata.Url), true);
                Assert.AreEqual("2015-04-10T20:04:21+00:00", TestUtil.ToTestableString(obj[0].EntityMetadata.CreatedAt), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[0].EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("my-domain.com", TestUtil.ToTestableString(obj[0].Name), true);
                Assert.AreEqual("752beb7d-5799-45d3-a4db-cbf2281ed22c", TestUtil.ToTestableString(obj[0].OwningOrganizationGuid), true);
                Assert.AreEqual("/v2/organizations/752beb7d-5799-45d3-a4db-cbf2281ed22c", TestUtil.ToTestableString(obj[0].OwningOrganizationUrl), true);

            }
        }

        [TestMethod]
        public void RetrievePrivateDomainTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                string json = @"{
  ""metadata"": {
    ""guid"": ""02aaae75-d8cb-444a-a655-82ebb145c3e1"",
    ""url"": ""/v2/private_domains/02aaae75-d8cb-444a-a655-82ebb145c3e1"",
    ""created_at"": ""2015-04-10T20:04:20+00:00"",
    ""updated_at"": null
  },
  ""entity"": {
    ""name"": ""vcap.me"",
    ""owning_organization_guid"": ""4c62f66d-6edd-44d4-ba3a-63a7b756095c"",
    ""owning_organization_url"": ""/v2/organizations/4c62f66d-6edd-44d4-ba3a-63a7b756095c""
  }
}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)200;
                var cfClient = clients.CreateCloudFoundryClient();

                Guid? guid = Guid.NewGuid();


                var obj = cfClient.PrivateDomains.RetrievePrivateDomain(guid).Result;


                Assert.AreEqual("02aaae75-d8cb-444a-a655-82ebb145c3e1", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/private_domains/02aaae75-d8cb-444a-a655-82ebb145c3e1", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
                Assert.AreEqual("2015-04-10T20:04:20+00:00", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("vcap.me", TestUtil.ToTestableString(obj.Name), true);
                Assert.AreEqual("4c62f66d-6edd-44d4-ba3a-63a7b756095c", TestUtil.ToTestableString(obj.OwningOrganizationGuid), true);
                Assert.AreEqual("/v2/organizations/4c62f66d-6edd-44d4-ba3a-63a7b756095c", TestUtil.ToTestableString(obj.OwningOrganizationUrl), true);

            }
        }

        [TestMethod]
        public void CreatePrivateDomainOwnedByGivenOrganizationTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                string json = @"{
  ""metadata"": {
    ""guid"": ""ced2a4e4-24fb-48cb-8aed-f436f5a41be6"",
    ""url"": ""/v2/private_domains/ced2a4e4-24fb-48cb-8aed-f436f5a41be6"",
    ""created_at"": ""2015-04-10T20:04:21+00:00"",
    ""updated_at"": null
  },
  ""entity"": {
    ""name"": ""exmaple.com"",
    ""owning_organization_guid"": ""219f77d2-2603-4336-ab8e-b618d30e5ed5"",
    ""owning_organization_url"": ""/v2/organizations/219f77d2-2603-4336-ab8e-b618d30e5ed5""
  }
}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)201;
                var cfClient = clients.CreateCloudFoundryClient();

                CreatePrivateDomainOwnedByGivenOrganizationRequest value = new CreatePrivateDomainOwnedByGivenOrganizationRequest();


                var obj = cfClient.PrivateDomains.CreatePrivateDomainOwnedByGivenOrganization(value).Result;


                Assert.AreEqual("ced2a4e4-24fb-48cb-8aed-f436f5a41be6", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/private_domains/ced2a4e4-24fb-48cb-8aed-f436f5a41be6", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
                Assert.AreEqual("2015-04-10T20:04:21+00:00", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("exmaple.com", TestUtil.ToTestableString(obj.Name), true);
                Assert.AreEqual("219f77d2-2603-4336-ab8e-b618d30e5ed5", TestUtil.ToTestableString(obj.OwningOrganizationGuid), true);
                Assert.AreEqual("/v2/organizations/219f77d2-2603-4336-ab8e-b618d30e5ed5", TestUtil.ToTestableString(obj.OwningOrganizationUrl), true);

            }
        }

        [TestMethod]
        public void DeletePrivateDomainTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                clients.ExpectedStatusCode = (HttpStatusCode)204;
                var cfClient = clients.CreateCloudFoundryClient();

                Guid? guid = Guid.NewGuid();


                cfClient.PrivateDomains.DeletePrivateDomain(guid).Wait();

            }
        }

        [TestMethod]
        public void ListAllPrivateDomainsTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                string json = @"{
  ""total_results"": 4,
  ""total_pages"": 1,
  ""prev_url"": null,
  ""next_url"": null,
  ""resources"": [
    {
      ""metadata"": {
        ""guid"": ""02aaae75-d8cb-444a-a655-82ebb145c3e1"",
        ""url"": ""/v2/private_domains/02aaae75-d8cb-444a-a655-82ebb145c3e1"",
        ""created_at"": ""2015-04-10T20:04:20+00:00"",
        ""updated_at"": null
      },
      ""entity"": {
        ""name"": ""vcap.me"",
        ""owning_organization_guid"": ""4c62f66d-6edd-44d4-ba3a-63a7b756095c"",
        ""owning_organization_url"": ""/v2/organizations/4c62f66d-6edd-44d4-ba3a-63a7b756095c""
      }
    },
    {
      ""metadata"": {
        ""guid"": ""da17f4b4-4254-4eef-884f-95308f949744"",
        ""url"": ""/v2/private_domains/da17f4b4-4254-4eef-884f-95308f949744"",
        ""created_at"": ""2015-04-10T20:04:21+00:00"",
        ""updated_at"": null
      },
      ""entity"": {
        ""name"": ""domain-7.example.com"",
        ""owning_organization_guid"": ""8275c342-1cee-4e6a-9a59-279fcee62883"",
        ""owning_organization_url"": ""/v2/organizations/8275c342-1cee-4e6a-9a59-279fcee62883""
      }
    },
    {
      ""metadata"": {
        ""guid"": ""b35822b0-355e-493a-8500-ed6d7f1d3025"",
        ""url"": ""/v2/private_domains/b35822b0-355e-493a-8500-ed6d7f1d3025"",
        ""created_at"": ""2015-04-10T20:04:21+00:00"",
        ""updated_at"": null
      },
      ""entity"": {
        ""name"": ""domain-8.example.com"",
        ""owning_organization_guid"": ""f43738c9-d856-4b81-9860-ef60c894ff95"",
        ""owning_organization_url"": ""/v2/organizations/f43738c9-d856-4b81-9860-ef60c894ff95""
      }
    },
    {
      ""metadata"": {
        ""guid"": ""53350af0-d79b-45bd-9452-22896477467c"",
        ""url"": ""/v2/private_domains/53350af0-d79b-45bd-9452-22896477467c"",
        ""created_at"": ""2015-04-10T20:04:21+00:00"",
        ""updated_at"": null
      },
      ""entity"": {
        ""name"": ""domain-9.example.com"",
        ""owning_organization_guid"": ""016c8ff4-f745-40e1-9b31-17eca00a9bc5"",
        ""owning_organization_url"": ""/v2/organizations/016c8ff4-f745-40e1-9b31-17eca00a9bc5""
      }
    }
  ]
}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)200;
                var cfClient = clients.CreateCloudFoundryClient();


                var obj = cfClient.PrivateDomains.ListAllPrivateDomains().Result;

                Assert.AreEqual("4", TestUtil.ToTestableString(obj.Properties.TotalResults), true);
                Assert.AreEqual("1", TestUtil.ToTestableString(obj.Properties.TotalPages), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.Properties.PreviousUrl), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.Properties.NextUrl), true);
                Assert.AreEqual("02aaae75-d8cb-444a-a655-82ebb145c3e1", TestUtil.ToTestableString(obj[0].EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/private_domains/02aaae75-d8cb-444a-a655-82ebb145c3e1", TestUtil.ToTestableString(obj[0].EntityMetadata.Url), true);
                Assert.AreEqual("2015-04-10T20:04:20+00:00", TestUtil.ToTestableString(obj[0].EntityMetadata.CreatedAt), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[0].EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("vcap.me", TestUtil.ToTestableString(obj[0].Name), true);
                Assert.AreEqual("4c62f66d-6edd-44d4-ba3a-63a7b756095c", TestUtil.ToTestableString(obj[0].OwningOrganizationGuid), true);
                Assert.AreEqual("/v2/organizations/4c62f66d-6edd-44d4-ba3a-63a7b756095c", TestUtil.ToTestableString(obj[0].OwningOrganizationUrl), true);
                Assert.AreEqual("da17f4b4-4254-4eef-884f-95308f949744", TestUtil.ToTestableString(obj[1].EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/private_domains/da17f4b4-4254-4eef-884f-95308f949744", TestUtil.ToTestableString(obj[1].EntityMetadata.Url), true);
                Assert.AreEqual("2015-04-10T20:04:21+00:00", TestUtil.ToTestableString(obj[1].EntityMetadata.CreatedAt), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[1].EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("domain-7.example.com", TestUtil.ToTestableString(obj[1].Name), true);
                Assert.AreEqual("8275c342-1cee-4e6a-9a59-279fcee62883", TestUtil.ToTestableString(obj[1].OwningOrganizationGuid), true);
                Assert.AreEqual("/v2/organizations/8275c342-1cee-4e6a-9a59-279fcee62883", TestUtil.ToTestableString(obj[1].OwningOrganizationUrl), true);
                Assert.AreEqual("b35822b0-355e-493a-8500-ed6d7f1d3025", TestUtil.ToTestableString(obj[2].EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/private_domains/b35822b0-355e-493a-8500-ed6d7f1d3025", TestUtil.ToTestableString(obj[2].EntityMetadata.Url), true);
                Assert.AreEqual("2015-04-10T20:04:21+00:00", TestUtil.ToTestableString(obj[2].EntityMetadata.CreatedAt), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[2].EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("domain-8.example.com", TestUtil.ToTestableString(obj[2].Name), true);
                Assert.AreEqual("f43738c9-d856-4b81-9860-ef60c894ff95", TestUtil.ToTestableString(obj[2].OwningOrganizationGuid), true);
                Assert.AreEqual("/v2/organizations/f43738c9-d856-4b81-9860-ef60c894ff95", TestUtil.ToTestableString(obj[2].OwningOrganizationUrl), true);
                Assert.AreEqual("53350af0-d79b-45bd-9452-22896477467c", TestUtil.ToTestableString(obj[3].EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/private_domains/53350af0-d79b-45bd-9452-22896477467c", TestUtil.ToTestableString(obj[3].EntityMetadata.Url), true);
                Assert.AreEqual("2015-04-10T20:04:21+00:00", TestUtil.ToTestableString(obj[3].EntityMetadata.CreatedAt), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[3].EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("domain-9.example.com", TestUtil.ToTestableString(obj[3].Name), true);
                Assert.AreEqual("016c8ff4-f745-40e1-9b31-17eca00a9bc5", TestUtil.ToTestableString(obj[3].OwningOrganizationGuid), true);
                Assert.AreEqual("/v2/organizations/016c8ff4-f745-40e1-9b31-17eca00a9bc5", TestUtil.ToTestableString(obj[3].OwningOrganizationUrl), true);

            }
        }

    }
}