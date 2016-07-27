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
    public class JobsEndpoint
{
        [TestMethod]
        public void RetrieveJobThatWasSuccessfulTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                string json = @"{
  ""metadata"": {
    ""guid"": ""c03d1b41-1036-4345-9839-d65dbb5d62d5"",
    ""created_at"": ""1970-01-01T00:00:00Z"",
    ""url"": ""/v2/jobs/0""
  },
  ""entity"": {
    ""guid"": ""c03d1b41-1036-4345-9839-d65dbb5d62d5"",
    ""status"": ""finished""
  }
}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)200;
                var cfClient = clients.CreateCloudFoundryClient();

                Guid? guid = Guid.NewGuid();


                var obj = cfClient.Jobs.RetrieveJobThatWasSuccessful(guid).Result;


                Assert.AreEqual("c03d1b41-1036-4345-9839-d65dbb5d62d5", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
                Assert.AreEqual("1970-01-01T00:00:00Z", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
                Assert.AreEqual("/v2/jobs/0", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
                Assert.AreEqual("c03d1b41-1036-4345-9839-d65dbb5d62d5", TestUtil.ToTestableString(obj.Guid), true);
                Assert.AreEqual("finished", TestUtil.ToTestableString(obj.Status), true);

            }
        }

        [TestMethod]
        public void RetrieveJobWithKnownFailureTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                string json = @"{
  ""metadata"": {
    ""guid"": ""0bdd5d7f-e38b-4556-83f0-4fef0656ce15"",
    ""created_at"": ""2016-07-27T14:02:53Z"",
    ""url"": ""/v2/jobs/f630a213-3439-4608-9ff1-e516409b17ad""
  },
  ""entity"": {
    ""guid"": ""0bdd5d7f-e38b-4556-83f0-4fef0656ce15"",
    ""status"": ""failed"",
    ""error"": ""Use of entity>error is deprecated in favor of entity>error_details."",
    ""error_details"": {
      ""code"": 1001,
      ""description"": ""Request invalid due to parse error: arbitrary string"",
      ""error_code"": ""CF-MessageParseError""
    }
  }
}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)200;
                var cfClient = clients.CreateCloudFoundryClient();

                Guid? guid = Guid.NewGuid();


                var obj = cfClient.Jobs.RetrieveJobWithKnownFailure(guid).Result;


                Assert.AreEqual("0bdd5d7f-e38b-4556-83f0-4fef0656ce15", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
                Assert.AreEqual("2016-07-27T14:02:53Z", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
                Assert.AreEqual("/v2/jobs/f630a213-3439-4608-9ff1-e516409b17ad", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
                Assert.AreEqual("0bdd5d7f-e38b-4556-83f0-4fef0656ce15", TestUtil.ToTestableString(obj.Guid), true);
                Assert.AreEqual("failed", TestUtil.ToTestableString(obj.Status), true);
                Assert.AreEqual("Use of entity>error is deprecated in favor of entity>error_details.", TestUtil.ToTestableString(obj.Error), true);

            }
        }

        [TestMethod]
        public void RetrieveJobThatIsQueuedTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                string json = @"{
  ""metadata"": {
    ""guid"": ""43a41098-dd22-487e-9f59-06a000287a17"",
    ""created_at"": ""2016-07-27T14:02:54Z"",
    ""url"": ""/v2/jobs/7f263590-f1b0-4dd8-a0c0-558541a17580""
  },
  ""entity"": {
    ""guid"": ""43a41098-dd22-487e-9f59-06a000287a17"",
    ""status"": ""queued""
  }
}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)200;
                var cfClient = clients.CreateCloudFoundryClient();

                Guid? guid = Guid.NewGuid();


                var obj = cfClient.Jobs.RetrieveJobThatIsQueued(guid).Result;


                Assert.AreEqual("43a41098-dd22-487e-9f59-06a000287a17", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
                Assert.AreEqual("2016-07-27T14:02:54Z", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
                Assert.AreEqual("/v2/jobs/7f263590-f1b0-4dd8-a0c0-558541a17580", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
                Assert.AreEqual("43a41098-dd22-487e-9f59-06a000287a17", TestUtil.ToTestableString(obj.Guid), true);
                Assert.AreEqual("queued", TestUtil.ToTestableString(obj.Status), true);

            }
        }

        [TestMethod]
        public void RetrieveJobWithUnknownFailureTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                string json = @"{
  ""metadata"": {
    ""guid"": ""3be445fa-8da4-4c86-8e22-cd2338063cd2"",
    ""created_at"": ""2016-07-27T14:02:53Z"",
    ""url"": ""/v2/jobs/ae64c06f-785d-42a4-b7ad-4abe87a1c010""
  },
  ""entity"": {
    ""guid"": ""3be445fa-8da4-4c86-8e22-cd2338063cd2"",
    ""status"": ""failed"",
    ""error"": ""Use of entity>error is deprecated in favor of entity>error_details."",
    ""error_details"": {
      ""error_code"": ""UnknownError"",
      ""description"": ""An unknown error occurred."",
      ""code"": 10001
    }
  }
}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)200;
                var cfClient = clients.CreateCloudFoundryClient();

                Guid? guid = Guid.NewGuid();


                var obj = cfClient.Jobs.RetrieveJobWithUnknownFailure(guid).Result;


                Assert.AreEqual("3be445fa-8da4-4c86-8e22-cd2338063cd2", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
                Assert.AreEqual("2016-07-27T14:02:53Z", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
                Assert.AreEqual("/v2/jobs/ae64c06f-785d-42a4-b7ad-4abe87a1c010", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
                Assert.AreEqual("3be445fa-8da4-4c86-8e22-cd2338063cd2", TestUtil.ToTestableString(obj.Guid), true);
                Assert.AreEqual("failed", TestUtil.ToTestableString(obj.Status), true);
                Assert.AreEqual("Use of entity>error is deprecated in favor of entity>error_details.", TestUtil.ToTestableString(obj.Error), true);

            }
        }

    }
}